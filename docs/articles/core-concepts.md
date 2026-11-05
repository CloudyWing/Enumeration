# 核心概念

本文說明 Enumeration 如何定義成員、如何探索與查找成員，以及相等、比較與轉換的規則。

## 選擇基底類別

| 基底類別 | 適用情境 |
| --- | --- |
| `EnumerationBase<TEnum, TValue>` | Value 型別只需實作 `IComparable`，例如 `Guid`。 |
| `ConvertibleEnumeration<TEnum, TValue>` | Value 型別實作 `IConvertible`，列舉本身也需要 `IConvertible`，例如設定 `DbType` 的 `DbParameter`。 |
| `IntEnumeration<T>` 等數值基底類別 | Value 為數值型別，並需要與其他數值型別直接比較。 |

`TEnum` 必須是衍生類別本身，例如 `class Status : EnumerationBase<Status, int>`。基底類別都位於 `CloudyWing.Enumeration.Abstractions` 命名空間。

## 定義成員

成員以 `TEnum` 型別的 public static 屬性宣告，建構子宣告為 `private`，讓已宣告的成員成為封閉集合。

```csharp
using CloudyWing.Enumeration.Abstractions;

public sealed class Status : EnumerationBase<Status, int> {
    private Status(int value, string name) : base(value, name) { }

    public static Status Active { get; } = new Status(1, "Active");

    public static Status Inactive { get; } = new Status(2, "Inactive");
}
```

只傳入 Value 的建構子會以 `value.ToString()` 作為 Name。

## 成員探索規則

第一次呼叫 `GetAll()`、`Parse()`、`TryParse()` 等查找方法時，函式庫以反射讀取直接宣告在 `TEnum` 上、可讀取的 public static 屬性，並依宣告順序建立成員清單，之後的呼叫都使用快取。

- 回傳既有實例的別名屬性（例如 `public static Status Default => Active;`）不會產生新成員，該實例保留第一次宣告的位置。
- 標註 `[EnumerationIgnore]` 的屬性不參與探索，也不會呼叫其 getter，適合輔助屬性或依設定切換的屬性。
- 屬性型別宣告為可為 null（`Status?`）且回傳 `null` 時會略過。
- 不可讀取的屬性與具索引參數的屬性會略過。

查找使用初始化時建立的字典，Value 以 `EqualityComparer<TValue>.Default` 比對，Name 依 `ignoreCase` 參數以 `StringComparison.Ordinal` 或 `StringComparison.OrdinalIgnoreCase` 比對。

> [!WARNING]
> 不要在 `TEnum` 的 static 初始化過程中呼叫 `GetAll()`、`Parse()` 等查找方法。此時尚未初始化的成員仍為 `null`，函式庫會拋出說明初始化順序問題的 `InvalidOperationException`，且不會快取不完整的結果。需要在 static 成員中使用成員清單時，改以延遲初始化的方式取得。

## 重複的 Value 或 Name

兩個不同實例宣告相同的 Value 時，`GetAll()` 仍會回傳兩者，但以該 Value 呼叫 `Parse()`、`TryParse()` 或明確轉換時會拋出 `InvalidOperationException`。Name 重複時，`ParseName()` 與 `TryParseName()` 的行為相同；只在忽略大小寫時才重複的 Name，只有 `ignoreCase` 為 `true` 的查找會拋出例外。

可安裝 `CloudyWing.Enumeration.Analyzers` 在編譯時偵測這類宣告，詳見 [進階用法](advanced-usage.md#analyzer)。

## 查找 API

```csharp
IEnumerable<Status> all = Status.GetAll();
IReadOnlyList<Status> list = Status.GetAllAsReadOnly();
int count = Status.GetCount();

Status active = Status.Parse(1);
bool isFound = Status.TryParse(2, out Status? inactive);
Status fallback = Status.ParseOrDefault(9, Status.Active);

Status byName = Status.ParseName("active", ignoreCase: true);
bool isDefined = Status.IsDefinedName("Inactive");
```

- `GetAll()` 每次回傳同一個唯讀集合，成員在第一次讀取集合時才探索。
- `GetAllAsReadOnly()` 回傳同一個 `IReadOnlyList<TEnum>`，呼叫時即完成探索。
- 找不到成員時，`Parse()` 與 `ParseName()` 拋出 `EnumerationNotFoundException`，`TryParse()` 與 `TryParseName()` 回傳 `false`。
- .NET 10 目標另提供接受 `ReadOnlySpan<char>` 的 `TryParseName()` 多載，查找時不需要配置字串。

## 相等、雜湊與比較

- `Equals(TEnum)` 與 `==` 依 Value 比較，`Equals(object)` 也接受 `TValue`，例如 `Status.Active.Equals(1)` 為 `true`。
- `GetHashCode()` 回傳 Value 的雜湊值，因此列舉與其 Value 在雜湊集合中視為相同的鍵。
- `CompareTo()` 與 `>`、`<`、`>=`、`<=` 依 Value 排序。
- 運算子的任一側為 `null` 時，`==` 回傳 `false`、`!=` 回傳 `true`，比較運算子回傳 `false`，數值基底類別與其他數值型別比較時也套用相同規則。

數值基底類別的 `Equals(object)` 接受其他數值型別（例如 `LongEnumeration` 與 `int`），這類跨型別相等的雜湊值不一定相同，作為雜湊集合的鍵時應使用相同的 Value 型別。

## 轉換

```csharp
// 隱含轉換為 Value
int value = Status.Active;

// 明確轉換為列舉，找不到時拋出 InvalidCastException，Value 重複時拋出 InvalidOperationException
Status status = (Status)1;
```

`ConvertibleEnumeration<TEnum, TValue>` 實作的 `IConvertible.ToType()` 會將 `IFormatProvider` 傳給 Value 的轉換；目標型別為列舉本身或其列舉基底類別時回傳實例本身。

## 序列化

基底類別標註 `[Serializable]` 並實作 `IObjectReference`。支援 `IObjectReference` 的序列化器（例如 .NET Framework 的 `BinaryFormatter` 與 `DataContractSerializer`）反序列化時會回傳已宣告的實例，維持參考相等。衍生類別本身也需要標註 `[Serializable]`。

JSON 序列化請使用 `CloudyWing.Enumeration.Json` 套件，詳見 [進階用法](advanced-usage.md#systemtextjson)。
