# 進階用法

本文說明條件判斷的 Fluent Interface、JSON 序列化、`TypeConverter`、`IParsable<TSelf>`、Analyzer 與 trimming 的使用方式。

## Fluent 條件判斷

列舉類別無法用於 `switch` 的 `case`，可改用 `When()`、`Then()` 與 `Default()` 串接條件。只會執行第一個成立的分支；已有分支執行後，後續的條件不會再評估。

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

.NET 10 目標的基底類別以明確介面實作 `IParsable<TEnum>` 與 `ISpanParsable<TEnum>`，可用於以泛型限制條件解析的程式碼。解析規則與 `TypeConverter` 相同，先比對 Name，再將文字轉換為 Value 比對；找不到成員時 `Parse()` 拋出 `FormatException`。

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

| 規則 | 說明 |
| --- | --- |
| `ENUM001` | 兩個成員宣告相同的 Value。 |
| `ENUM002` | 兩個成員宣告相同的 Name。 |
| `ENUM003` | 非抽象列舉宣告 public 建構子。 |

`ENUM001` 與 `ENUM002` 檢查以屬性初始設定式或運算式主體建立、且引數為常數的成員，並會追蹤同一個檔案中的 `this(...)` 與 `base(...)` 建構子鏈；透過 `Lazy<T>` 欄位等方式建立的成員不在檢查範圍。標註 `[EnumerationIgnore]` 的屬性不會檢查。

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
