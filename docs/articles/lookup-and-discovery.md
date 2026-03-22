# Lookup and Discovery APIs

`Enumeration` includes additive APIs that make it easier to inspect declared members, perform safe lookups, and prepare data for UI or serialization scenarios.

## Static Lookup Helpers

`EnumerationBase<TEnum, TValue>` exposes APIs for discovering declared members and resolving them by value or name.

```csharp
IEnumerable<WeekDay> allDays = WeekDay.GetAll();
IEnumerable<int> values = WeekDay.GetValues();
IEnumerable<string> names = WeekDay.GetNames();

bool hasMondayValue = WeekDay.IsDefined(1);
bool hasMondayName = WeekDay.IsDefinedName("monday", ignoreCase: true);

WeekDay monday = WeekDay.Parse(1);
WeekDay fallbackByValue = WeekDay.ParseOrDefault(9, WeekDay.Sunday);
WeekDay fallbackByName = WeekDay.ParseNameOrDefault("Holiday", WeekDay.Sunday);
```

Use `Parse` and `ParseName` when a missing match should fail fast. Use the `TryParse*` and `*OrDefault` APIs when the input may be unknown at runtime.

## Collection Lookup Helpers

When you already have a sequence of enumerations, `EnumerationExtensions` can perform lookups without changing the public API of your enumeration type.

```csharp
IEnumerable<IEnumeration<WeekDay, int>> days = WeekDay.GetAll();

bool hasFriday = days.ContainsName("Friday");
bool hasZero = days.ContainsValue(0);

bool foundValue = days.TryGetValue("Monday", out int mondayValue);
bool foundName = days.TryGetName(0, out string firstDayName);
```

These helpers return `false` when no match is found. They expect the sequence to contain a single match for each lookup key.

## Projection Helpers

The collection extensions also provide convenient projections for building option lists and lookup tables.

```csharp
string[] nameArray = days.ToNameArray();
IList<int> valueList = days.ToValueList();

IDictionary<int, string> valueNameMap = days.ToDictionary();
IDictionary<string, int> nameValueMap = days.ToNameValueDictionary();
```

`ToDictionary()` uses the enumeration value as the key, while `ToNameValueDictionary()` uses the enumeration name as the key.
