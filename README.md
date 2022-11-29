# Enumeration

**Enumeration** 為 [Constants](https://github.com/CloudyWing/Constants) 重新優化的版本，起因是看到 MSDN「[使用列舉類別，而非列舉類型](https://learn.microsoft.com/zh-tw/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types)」這篇文章，覺得原本的命名有些不適當，所以重建一個 Repository，後面不知不覺就幾乎整個重寫了...。

**Enumeration**，為將列舉類別重複的程式碼整理成 `EnumerationBase<T>` 的抽象類別，繼承實作的方法請參考 Examples。

## Supported Frameworks
* .NET Standard 2.1
* .NET Standard 2.0
* .NET Framework 4.5

## Abstract Enumerations
目前提供以下 Abstract Enumerations 提供繼承：
* EnumerationBase：最底層的 Abstract Enumeration，如 `Guid` 之類未實作 `IConvertible`，可繼承此 Enumeration。
* ConvertibleEnumeration：有實作 `IConvertible` 的 Enumeration，可用在需要 `IConvertible` 轉型的地方，如 `SqlParameter` 之類的 `DbParameter` 有設定 `DbType` 時，會使用 `IConvertible` 將 Value 轉換成對應型別。
* Numeric Enumerations：此類 Enumeration 皆有繼承 `ConvertibleEnumeration` 與有指定 Value Type，並且在使用 `==`、`!=`、`>`、`<`、`>=`、`<=`和`Equals` 等 Operator 和 Method 時，Enumeration 與數值型別的執行結果，大致等同於 Value 與數值型別的執行結果，目前有定義以下 Numeric Enumerations：
    * CharEnumeration。
    * ByteEnumeration。
    * SByteEnumeration。
    * ShortEnumeration。
    * UShortEnumeration。
    * IntEnumeration。
    * UIntEnumeration。
    * LongEnumeration。
    * ULongEnumeration。
    * FloatEnumeration。
    * DoubleEnumeration。
    * DecimalEnumeration。

## Examples 與簡單的 API 說明
以下範例的 `TEnum` 表示實際的 Enumeration 型別，`TValue` 表示 Value 型別。
### 實作 Enumeration
#### 簡單寫法
```csharp
/// int 可替換任何 implement  IConvertible 的 type
[Serializable]
public sealed class WeekDay : ConvertibleEnumeration<WeekDay, int> {
    // Constructor 設定成 private
    private WeekDay(int value, string name, string englishName) : base(value, name) {
        EnglishName = englishName;
    }

    public static WeekDay Sunday { get; } = new WeekDay(0, "星期日", nameof(Sunday));
    public static WeekDay Monday { get; } = new WeekDay(1, "星期一", nameof(Monday));
    public static WeekDay Tuesday { get; } = new WeekDay(2, "星期二", nameof(Tuesday));
    public static WeekDay Wednesday { get; } = new WeekDay(3, "星期三", nameof(Wednesday));
    public static WeekDay Thursday { get; } = new WeekDay(4, "星期四", nameof(Thursday));
    public static WeekDay Friday { get; } = new WeekDay(5, "星期五", nameof(Friday));
    public static WeekDay Saturday { get; } = new WeekDay(6, "星期六", nameof(Saturday));

    // 額外擴充的 Property
    public string EnglishName { get; }
}
```
#### 使用 Lazy Initialization
```csharp
/// int 可替換任何 implement  IConvertible 的 type
[Serializable]
public sealed class WeekDay : ConvertibleEnumeration<WeekDay, int> {
    public static readonly Lazy<WeekDay> sunday = new Lazy<WeekDay>(() => new WeekDay(0, "星期日", nameof(Sunday)));
    public static readonly Lazy<WeekDay> monday = new Lazy<WeekDay>(() => new WeekDay(1, "星期一", nameof(Monday)));
    public static readonly Lazy<WeekDay> tuesday = new Lazy<WeekDay>(() => new WeekDay(2, "星期二", nameof(Tuesday)));
    public static readonly Lazy<WeekDay> wednesday = new Lazy<WeekDay>(() => new WeekDay(3, "星期三", nameof(Wednesday)));
    public static readonly Lazy<WeekDay> thursday = new Lazy<WeekDay>(() => new WeekDay(4, "星期四", nameof(Thursday)));
    public static readonly Lazy<WeekDay> friday = new Lazy<WeekDay>(() => new WeekDay(5, "星期五", nameof(Friday)));
    public static readonly Lazy<WeekDay> saturday = new Lazy<WeekDay>(() => new WeekDay(6, "星期六", nameof(Saturday)));

    // Constructor 設定成 private
    private WeekDay(int value, string name, string englishName) : base(value, name) {
        EnglishName = englishName;
    }

    public static WeekDay Sunday => sunday.Value;
    public static WeekDay Monday => monday.Value;
    public static WeekDay Tuesday => tuesday.Value;
    public static WeekDay Wednesday => wednesday.Value;
    public static WeekDay Thursday => thursday.Value;
    public static WeekDay Friday => friday.Value;
    public static WeekDay Saturday => saturday.Value;

    // 額外擴充的 Property
    public string EnglishName { get; }
}
```

#### 繼承 Numeric Enumeration
```csharp
[Serializable]
public sealed class WeekDay : IntEnumeration<WeekDay> {
    public static readonly Lazy<WeekDay> sunday = new Lazy<WeekDay>(() => new WeekDay(0, "星期日", nameof(Sunday)));
    public static readonly Lazy<WeekDay> monday = new Lazy<WeekDay>(() => new WeekDay(1, "星期一", nameof(Monday)));
    public static readonly Lazy<WeekDay> tuesday = new Lazy<WeekDay>(() => new WeekDay(2, "星期二", nameof(Tuesday)));
    public static readonly Lazy<WeekDay> wednesday = new Lazy<WeekDay>(() => new WeekDay(3, "星期三", nameof(Wednesday)));
    public static readonly Lazy<WeekDay> thursday = new Lazy<WeekDay>(() => new WeekDay(4, "星期四", nameof(Thursday)));
    public static readonly Lazy<WeekDay> friday = new Lazy<WeekDay>(() => new WeekDay(5, "星期五", nameof(Friday)));
    public static readonly Lazy<WeekDay> saturday = new Lazy<WeekDay>(() => new WeekDay(6, "星期六", nameof(Saturday)));

    // Constructor 設定成 private
    private WeekDay(int value, string name, string englishName) : base(value, name) {
        EnglishName = englishName;
    }

    public static WeekDay Sunday => sunday.Value;
    public static WeekDay Monday => monday.Value;
    public static WeekDay Tuesday => tuesday.Value;
    public static WeekDay Wednesday => wednesday.Value;
    public static WeekDay Thursday => thursday.Value;
    public static WeekDay Friday => friday.Value;
    public static WeekDay Saturday => saturday.Value;

    // 額外擴充的 Property
    public string EnglishName { get; }
}
```

### 條件判斷
由於 Enumeration 無法像 `enum` 一樣用於 Switch Case，所以提供 Fluent Interface 來簡化寫法。
```csharp
public void Test(WeekDay week) {
    List<WeekDay> list = new List<WeekDay>();

    week.When(WeekDay.Sunday).then(() => list.Add(week))
        .When(WeekDay.Sunday, WeekDay.Monday).then(() => list.Add(week))
        .When(true).then(() => list.Add(week))
        .When(WeekDay.Sunday)
        .AndWhen(true).then(() => list.Add(week)).then(() => list.Add(week))
        .When(WeekDay.Sunday).then(() => list.Add(week))
        .OrWhen(WeekDay.Sunday, WeekDay.Monday)).then(() => list.Add(week))
        .Default(() => list.Add(week));
    
    /*
    以上寫法約等同如下
    List<WeekDay> list = new List<WeekDay>();

    if (week == WeekDay.Sunday) {
        list.Add(week);
    } eles if (week == WeekDay.Sunday || week == WeekDay.Monday) {
        list.Add(week);
    } else if (true) {
        list.Add(week);
    } else if (week == WeekDay.Sunday && true) {
        list.Add(week);
    } else if (week == WeekDay.Sunday || (week == WeekDay.Monday || week == WeekDay.Tuesday)) {
        list.Add(week);
    } else {
        list.Add(week);
    }
    */
}
```

### Operators
`EnumerationBase<TEnum, TValue>` 有定義 `EnumerationBase<TEnum, TValue>` 與 `TEnum` 還有 `EnumerationBase<TEnum, TValue>` 與 `TValue` 之間的 Operators ，Operators 包含了 `Implicit Conversion`、`Explicit Conversion`、`==`、`!=`、`>`、`<`、`>=`、`<=`，需注意 `Explicit Conversion` 失敗會 Throw `InvalidCastException`。
```csharp
// i is 1
int i = WeekDay.Monday;

// 因為有可能會失敗或資訊遺失，所以要使用 `Explicit Conversion`，weekDay is Monday
WeekDay weekDay = (WeekDay)1;

// result is true
bool result = WeekDay.Monday == 1;

// 反過來寫結果相同，result is true
bool result = 1 == WeekDay.Monday;
```

### Static Methods
`EnumerationBase<TEnum, TValue>` 有定義以下 Static Methods，這邊直接用範例說明，在使用 `Parse()` 時需注意，若找不到對應的 Enumeration，會 Throw `EnumerationNotFoundException`，所以非確定 Enumeration 存在時，請使用 `TryParse()`。
```csharp
// 取得全部的 `WeekDay` Instance
IEnumeration<WeekDay> weekDays = WeekDay.GetAll();

// weekDay is Monday
WeekDay weekDay = WeekDay.Parse(1);

// result is true，weekDay is Monday
bool result = WeekDay.TryParse(1, out WeekDay weekDay);

// weekDay is Monday
WeekDay weekDay = WeekDay.ParseName("Monday");

// 可傳入參數來忽略大小寫，weekDay is Monday
WeekDay weekDay = WeekDay.ParseName("monday", true);

// result is true，weekDay is Monday
WeekDay weekDay = WeekDay.TryParseName("Monday", out WeekDay weekDay);

// 可傳入參數來忽略大小寫，result is true，weekDay is Monday
WeekDay weekDay = WeekDay.TryParseName("monday", true, out WeekDay weekDay);
```

### 型別判斷
目前提供以下 `Type` 的 Extension Methods 來取得 Enumeration 的型別資訊：
* `IsEnumeration()`：判斷是否有實作 `IEnumeration<TEnum, TValue>`。
* `GetEnumerationTypes()`：取得 `IEnumerable<IEnumeration<TEnum, TValue>>`。
* `GetEnumerationValueTypes()`：取得 `IEnumerable<TValue>`。

### 集合相關的擴充方法
目前 `IEnumerable<IEnumeration<TEnum, TValue>>` 提供以下 Extension Methods：
* `ContainsValue(TValue value)`：判斷集合裡是否有 `Value` 和參數 `value` 相同的 Enumeration。
* `OfValue()`：取得 `IEnumerable<TValue>`。
* `OfName()`：取得 `IEnumerable<string>` based on Enumeration `Name`。
* `ToValueArray()`：取得 `TValue[]`。
* `ToNameArray()`：取得 `string[]` based on Enumeration `Name`。
* `ToValueList()`：取得 `IList<TValue>`。
* `ToNameList()`：取得 `IList<string>` based on Enumeration `Name`。
* `ToDictionary()`：取得 Key 為 Enumeration Value、Value` 為 Enumeration `Name` 的 `IDictionary`。

## 參考文件
* [API 文件](./docs/API/index.md)。

## License
This project is MIT [licensed](./LICENSE.md).