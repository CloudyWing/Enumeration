# 進階用法

本文說明條件判斷的 Fluent Interface、JSON 序列化、`TypeConverter`、`IParsable<TSelf>`、Analyzer、trimming 與 Calendars 位移運算的使用方式。

## 範例使用的列舉

本文的範例沿用下列 `Status` 定義：

```csharp
using CloudyWing.Enumeration.Abstractions;

public sealed class Status : EnumerationBase<Status, int> {
    private Status(int value, string name) : base(value, name) { }

    public static Status Active { get; } = new Status(1, "Active");

    public static Status Inactive { get; } = new Status(2, "Inactive");

    public static Status Pending { get; } = new Status(3, "Pending");

    public static Status Suspended { get; } = new Status(4, "Suspended");

    public static Status Archived { get; } = new Status(5, "Archived");
}
```

## 套件與目標框架

| 套件 | 目標框架 | 安裝 |
| --- | --- | --- |
| `CloudyWing.Enumeration` | .NET Standard 2.0、.NET Framework 4.5、.NET 10 | `dotnet add package CloudyWing.Enumeration` |
| `CloudyWing.Enumeration.Calendars` | .NET Standard 2.0、.NET Framework 4.5、.NET 10 | `dotnet add package CloudyWing.Enumeration.Calendars` |
| `CloudyWing.Enumeration.Json` | .NET Standard 2.0、.NET 10 | `dotnet add package CloudyWing.Enumeration.Json` |
| `CloudyWing.Enumeration.Analyzers` | .NET Standard 2.0（Roslyn Analyzer，不影響專案本身的目標框架） | `dotnet add package CloudyWing.Enumeration.Analyzers` |

`CloudyWing.Enumeration.Json` 沒有 .NET Framework 4.5 目標。其 .NET Standard 2.0 目標相依 `System.Text.Json` 10.0.8 以上，.NET 10 目標使用框架內建的 System.Text.Json。`CloudyWing.Enumeration.Analyzers` 的編譯器需求見 [Analyzer](#analyzer)。

## Fluent 條件判斷

列舉類別無法用於 `switch` 的 `case`，可改用 `When()`、`Then()` 與 `Default()` 串接條件。只會執行第一個成立的分支；已有分支執行後，後續以 `Func<bool>` 傳入的條件委派不會再執行。直接傳入的 `bool` 運算式由呼叫端先行求值，列舉清單多載（例如 `When(Status.Inactive, Status.Suspended)`）也會在呼叫 `When()` 時就比對，這兩種寫法不受短路影響。

```csharp
using CloudyWing.Enumeration;

status.When(Status.Active).Then(() => Activate())
    .When(Status.Inactive, Status.Suspended).Then(() => Deactivate())
    .When(Status.Pending).AndWhen(() => isReviewRequired).Then(() => Review())
    .When(Status.Archived).OrWhen(() => isExpired).Then(() => Archive())
    .Default(() => Log());
```

- `When()` 接受列舉清單、`bool` 或 `Func<bool>`。
- `AndWhen()` 與 `OrWhen()` 以 AND 或 OR 合併前一個條件。

## System.Text.Json

安裝 `CloudyWing.Enumeration.Json` 套件：

```bash
dotnet add package CloudyWing.Enumeration.Json
```

`CloudyWing.Enumeration.Json` 的 .NET Standard 2.0 目標相依 `System.Text.Json` 10.0.8 以上，.NET 10 目標使用框架內建的 System.Text.Json。

`EnumerationJsonConverter<TEnum, TValue>` 處理單一列舉型別，`EnumerationJsonConverterFactory` 處理所有列舉型別。兩者都可以 `EnumerationJsonFormat` 選擇以 Value 或 Name 序列化，預設為 Value。

```csharp
using System.Text.Json;
using CloudyWing.Enumeration.Json;

JsonSerializerOptions options = new() {
    Converters = { new EnumerationJsonConverterFactory(EnumerationJsonFormat.Name) }
};

// {"Status":"Active"}
string json = JsonSerializer.Serialize(new { Status = Status.Active }, options);
```

- 讀取不對應任何成員的 JSON 時拋出 `JsonException`。
- 支援字典鍵，Name 格式以名稱作為屬性名稱，Value 格式沿用 Value 型別的屬性名稱格式。
- Value 格式透過序列化選項取得 `TValue` 的中繼資料，搭配 source generator 時需要讓 `TValue` 包含在 `JsonSerializerContext` 中。
- `EnumerationJsonConverterFactory` 在執行期間建立泛型轉換器，trimming 或 Native AOT 應用程式請改為逐一註冊 `EnumerationJsonConverter<TEnum, TValue>`。

## TypeConverter

`EnumerationTypeConverter<TEnum, TValue>` 讓透過 `TypeDescriptor` 取得轉換器的元件（例如 ASP.NET Core model binding 與 `Microsoft.Extensions.Configuration` 繫結）可以將字串轉換為列舉。在應用程式啟動時註冊，不需要修改列舉型別：

```csharp
using CloudyWing.Enumeration;

EnumerationTypeConverter.Register<Status, int>();
```

也可以直接在列舉型別上標註：

```csharp
[TypeConverter(typeof(EnumerationTypeConverter<Status, int>))]
public sealed class Status : EnumerationBase<Status, int> {
    // ...
}
```

轉換規則如下：

- 字串先以 Ordinal 比對 Name，再依文化特性轉換為 Value 比對。
- 空字串或只有空白的字串轉換為 `null`。
- 找不到成員時拋出 `FormatException`。
- 轉換為字串時回傳 Name，轉換為 `TValue` 時回傳 Value。

## IParsable 與 ISpanParsable

.NET 10 目標的基底類別以明確介面實作 `IParsable<TEnum>` 與 `ISpanParsable<TEnum>`，可用於以泛型限制條件解析的程式碼。解析規則與 `TypeConverter` 共用，先以 Ordinal 比對 Name，再將文字轉換為 Value 比對。兩者在下列情況的結果不同：

- 空字串或只有空白的字串，`TypeConverter` 轉換為 `null`；`Parse()` 沒有這項特例，視為找不到成員而拋出 `FormatException`，`TryParse()` 回傳 `false`。
- `Parse()` 的 `s` 為 `null` 時拋出 `ArgumentNullException`，`TryParse()` 回傳 `false`。

找不到成員時 `Parse()` 與 `TypeConverter` 都拋出 `FormatException`；多個成員符合時兩者都拋出 `InvalidOperationException`。

```csharp
static T ParseText<T>(string text) where T : IParsable<T> {
    return T.Parse(text, CultureInfo.InvariantCulture);
}

Status byName = ParseText<Status>("Active");
Status byValue = ParseText<Status>("1");
```

## Analyzer

安裝 `CloudyWing.Enumeration.Analyzers` 套件後，編譯時會檢查列舉宣告：

```bash
dotnet add package CloudyWing.Enumeration.Analyzers
```

此套件是只含 Roslyn Analyzer 的開發期相依性，不會傳遞給參考你專案的其他專案，只分析 C# 程式碼，且專案需參考 `CloudyWing.Enumeration`。Analyzer 以 `Microsoft.CodeAnalysis.CSharp` 4.8.0 建置，需要 Roslyn 4.8 以上的編譯器，也就是 Visual Studio 2022 17.8 以上，或 .NET SDK 8.0.100 以上。編譯器版本較舊時，Analyzer 可能無法載入。

三條規則的類別皆為 `Design`，預設啟用，嚴重度為 Warning。

| 規則 | 觸發條件 | 修正方式 |
| --- | --- | --- |
| `ENUM001` | 同一個列舉型別的兩個成員宣告相同的 Value。診斷位置在後宣告的成員，訊息會指出先宣告的成員。 | 改成唯一的 Value；兩者應為同一成員時，保留一個宣告，另一個改為回傳既有實例的別名屬性。 |
| `ENUM002` | 同一個列舉型別的兩個成員宣告相同的 Name，以區分大小寫的 Ordinal 方式比對。只傳入 Value 的建構子會以 Value 的字串作為 Name，同樣納入比對。 | 改成唯一的 Name。 |
| `ENUM003` | 非抽象列舉宣告 public 建構子。診斷位置在該建構子，static 建構子不在檢查範圍。 | 將建構子改成 `private`，讓已宣告的成員成為封閉集合。 |

規則的嚴重度可用 `.editorconfig` 調整，例如將重複 Value 視為錯誤：

```ini
[*.cs]
dotnet_diagnostic.ENUM001.severity = error
```

`ENUM001` 與 `ENUM002` 檢查以屬性初始設定式或運算式主體建立、且引數為常數的成員，並會追蹤同一個檔案中的 `this(...)` 與 `base(...)` 建構子鏈；透過 `Lazy<T>` 欄位等方式建立的成員不在檢查範圍。標註 `[EnumerationIgnore]` 的屬性不會檢查。`ENUM002` 以區分大小寫的方式比對，僅大小寫不同的 Name 不會回報，但以 `ignoreCase: true` 查找時仍會拋出 `InvalidOperationException`。

## Trimming 與 Native AOT

.NET 10 目標的套件標示為 AOT 相容。`TEnum` 型別參數標註 `DynamicallyAccessedMembers(PublicProperties)`，trimming 會保留列舉型別的 public 屬性，讓成員探索在 trimming 後仍可運作。

自行定義泛型的中繼基底類別（例如 `class StatusBase<T> : IntEnumeration<T>`）時，`T` 也需要加上相同的標註，否則啟用 trimming 分析時會出現 `IL2091` 警告。

```csharp
public abstract class StatusBase<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] T>
    : IntEnumeration<T>
    where T : StatusBase<T> {
    protected StatusBase(int value, string name) : base(value, name) { }
}
```


## Calendars 位移運算

`CloudyWing.Enumeration.Calendars` 的 `Month`（Value 為 1 至 12）與 `WeekDay`（Value 為 0 至 6，星期日為 0）支援 `+`、`-`、`++`、`--` 與整數位移，結果會在範圍內循環：

```csharp
using CloudyWing.Enumeration.Calendars;

Month january = Month.December + 1;      // Month.January
WeekDay saturday = WeekDay.Sunday - 1;   // WeekDay.Saturday
Month august = Month.January + int.MaxValue;
```

位移量先對 12（`Month`）或 7（`WeekDay`）取模再運算，因此位移量接近 `int.MaxValue` 或 `int.MinValue` 時不會發生整數溢位。

## 偵錯資訊與符號套件

`CloudyWing.Enumeration`、`CloudyWing.Enumeration.Calendars` 與 `CloudyWing.Enumeration.Json` 打包時會同時產生 `.snupkg` 符號套件，並在 PDB 記錄儲存庫網址與未追蹤來源檔案的資訊。`CloudyWing.Enumeration.Analyzers` 只包含 Analyzer 組件，不產生符號套件。
