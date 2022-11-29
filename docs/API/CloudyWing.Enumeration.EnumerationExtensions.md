#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration](CloudyWing.Enumeration.md 'CloudyWing.Enumeration')

## EnumerationExtensions Class

The extension methods of enumeration.

```csharp
public static class EnumerationExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EnumerationExtensions
### Methods

<a name='CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool)'></a>

## EnumerationExtensions.AndWhen<TEnum,TValue>(this IWhenStatement<TEnum,TValue>, bool) Method

Ands the when.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> AndWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> enumeration, bool isMatch)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.AndWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, bool).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).TValue 'CloudyWing.Enumeration.EnumerationExtensions.AndWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, bool).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')

The enumeration.

<a name='CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).isMatch'></a>

`isMatch` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is match].

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.AndWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, bool).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).TValue 'CloudyWing.Enumeration.EnumerationExtensions.AndWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, bool).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_)'></a>

## EnumerationExtensions.AndWhen<TEnum,TValue>(this IWhenStatement<TEnum,TValue>, Func<bool>) Method

Ands the when.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> AndWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> enumeration, System.Func<bool> predicate)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.AndWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Func<bool>).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).TValue 'CloudyWing.Enumeration.EnumerationExtensions.AndWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Func<bool>).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')

The enumeration.

<a name='CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The predicate.

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.AndWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Func<bool>).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.AndWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).TValue 'CloudyWing.Enumeration.EnumerationExtensions.AndWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Func<bool>).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.ContainsValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__,TValue)'></a>

## EnumerationExtensions.ContainsValue<TEnum,TValue>(this IEnumerable<IEnumeration<TEnum,TValue>>, TValue) Method

Determines whether the specified value contains value.

```csharp
public static bool ContainsValue<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>> enumerations, TValue value)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.ContainsValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__,TValue).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.ContainsValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__,TValue).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.ContainsValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__,TValue).enumerations'></a>

`enumerations` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ContainsValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__,TValue).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.ContainsValue<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>, TValue).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ContainsValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__,TValue).TValue 'CloudyWing.Enumeration.EnumerationExtensions.ContainsValue<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>, TValue).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The enumerations.

<a name='CloudyWing.Enumeration.EnumerationExtensions.ContainsValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__,TValue).value'></a>

`value` [TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ContainsValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__,TValue).TValue 'CloudyWing.Enumeration.EnumerationExtensions.ContainsValue<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>, TValue).TValue')

The value.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified value contains value; otherwise, `false`.

<a name='CloudyWing.Enumeration.EnumerationExtensions.GetEnumerationTypes(thisSystem.Type)'></a>

## EnumerationExtensions.GetEnumerationTypes(this Type) Method

Gets the enumeration types.

```csharp
public static System.Collections.Generic.IEnumerable<System.Type> GetEnumerationTypes(this System.Type type);
```
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.GetEnumerationTypes(thisSystem.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The enumeration types.

<a name='CloudyWing.Enumeration.EnumerationExtensions.GetEnumerationValueTypes(thisSystem.Type)'></a>

## EnumerationExtensions.GetEnumerationValueTypes(this Type) Method

Gets the enumeration value types.

```csharp
public static System.Collections.Generic.IEnumerable<System.Type> GetEnumerationValueTypes(this System.Type type);
```
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.GetEnumerationValueTypes(thisSystem.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The enumeration value types.

<a name='CloudyWing.Enumeration.EnumerationExtensions.IsEnumeration(thisSystem.Type)'></a>

## EnumerationExtensions.IsEnumeration(this Type) Method

Determines whether this instance is enumeration.

```csharp
public static bool IsEnumeration(this System.Type type);
```
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.IsEnumeration(thisSystem.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified type is enumeration; otherwise, `false`.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OfName_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__)'></a>

## EnumerationExtensions.OfName<TEnum,TValue>(this IEnumerable<IEnumeration<TEnum,TValue>>) Method

Filters the elements of an System.Collections.IEnumerable based on a name.

```csharp
public static System.Collections.Generic.IEnumerable<string> OfName<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>> enumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.OfName_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OfName_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.OfName_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).enumerations'></a>

`enumerations` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OfName_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.OfName<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OfName_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OfName<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The enumerations.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The `IEnumeration` based on a name.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OfValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__)'></a>

## EnumerationExtensions.OfValue<TEnum,TValue>(this IEnumerable<IEnumeration<TEnum,TValue>>) Method

Filters the elements of an System.Collections.IEnumerable based on a value.

```csharp
public static System.Collections.Generic.IEnumerable<TValue> OfValue<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>> enumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.OfValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OfValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.OfValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).enumerations'></a>

`enumerations` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OfValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.OfValue<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OfValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OfValue<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The enumerations.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OfValue_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OfValue<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The `IEnumeration` based on a value.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool)'></a>

## EnumerationExtensions.OrWhen<TEnum,TValue>(this IWhenStatement<TEnum,TValue>, bool) Method

Ors the when.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> enumeration, bool isMatch)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, bool).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, bool).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')

The enumeration.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).isMatch'></a>

`isMatch` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is match].

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, bool).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,bool).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, bool).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[])'></a>

## EnumerationExtensions.OrWhen<TEnum,TValue>(this IWhenStatement<TEnum,TValue>, IEnumeration<TEnum,TValue>[]) Method

Ors the when.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> enumeration, params CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[] matchEnumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')

The enumeration.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).matchEnumerations'></a>

`matchEnumerations` [CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The match enumerations.

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__)'></a>

## EnumerationExtensions.OrWhen<TEnum,TValue>(this IWhenStatement<TEnum,TValue>, IEnumerable<IEnumeration<TEnum,TValue>>) Method

Ors the when.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> enumeration, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>> matchEnumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')

The enumeration.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).matchEnumerations'></a>

`matchEnumerations` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The match enumerations.

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_)'></a>

## EnumerationExtensions.OrWhen<TEnum,TValue>(this IWhenStatement<TEnum,TValue>, Func<bool>) Method

Ors the when.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> enumeration, System.Func<bool> predicate)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Func<bool>).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Func<bool>).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')

The enumeration.

<a name='CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The predicate.

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Func<bool>).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.OrWhen_TEnum,TValue_(thisCloudyWing.Enumeration.IWhenStatement_TEnum,TValue_,System.Func_bool_).TValue 'CloudyWing.Enumeration.EnumerationExtensions.OrWhen<TEnum,TValue>(this CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>, System.Func<bool>).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToDictionary_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__)'></a>

## EnumerationExtensions.ToDictionary<TEnum,TValue>(this IEnumerable<IEnumeration<TEnum,TValue>>) Method

Converts to dictionary.

```csharp
public static System.Collections.Generic.IDictionary<TValue,string> ToDictionary<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>> enumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToDictionary_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum'></a>

`TEnum`

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToDictionary_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToDictionary_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).enumerations'></a>

`enumerations` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToDictionary_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.ToDictionary<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToDictionary_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.ToDictionary<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The enumerations.

#### Returns
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToDictionary_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.ToDictionary<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The pairs of value and name.

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToNameArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__)'></a>

## EnumerationExtensions.ToNameArray<TEnum,TValue>(this IEnumerable<IEnumeration<TEnum,TValue>>) Method

Converts to name array.

```csharp
public static string[] ToNameArray<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>> enumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToNameArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToNameArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToNameArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).enumerations'></a>

`enumerations` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToNameArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.ToNameArray<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToNameArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.ToNameArray<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The enumerations.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The value array.

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToNameList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__)'></a>

## EnumerationExtensions.ToNameList<TEnum,TValue>(this IEnumerable<IEnumeration<TEnum,TValue>>) Method

Converts to name list.

```csharp
public static System.Collections.Generic.IList<string> ToNameList<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>> enumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToNameList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum'></a>

`TEnum`

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToNameList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToNameList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).enumerations'></a>

`enumerations` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToNameList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.ToNameList<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToNameList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.ToNameList<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The enumerations.

#### Returns
[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The value list.

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToValueArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__)'></a>

## EnumerationExtensions.ToValueArray<TEnum,TValue>(this IEnumerable<IEnumeration<TEnum,TValue>>) Method

Converts to value array.

```csharp
public static TValue[] ToValueArray<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>> enumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToValueArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToValueArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToValueArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).enumerations'></a>

`enumerations` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToValueArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.ToValueArray<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToValueArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.ToValueArray<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The enumerations.

#### Returns
[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToValueArray_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.ToValueArray<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The value array.

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToValueList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__)'></a>

## EnumerationExtensions.ToValueList<TEnum,TValue>(this IEnumerable<IEnumeration<TEnum,TValue>>) Method

Converts to value list.

```csharp
public static System.Collections.Generic.IList<TValue> ToValueList<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>> enumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToValueList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToValueList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.ToValueList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).enumerations'></a>

`enumerations` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToValueList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.ToValueList<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToValueList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.ToValueList<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The enumerations.

#### Returns
[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.ToValueList_TEnum,TValue_(thisSystem.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.ToValueList<TEnum,TValue>(this System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The value list.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,bool)'></a>

## EnumerationExtensions.When<TEnum,TValue>(this IEnumeration<TEnum,TValue>, bool) Method

Whens the specified is match.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue> enumeration, bool isMatch)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,bool).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,bool).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,bool).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,bool).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, bool).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,bool).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, bool).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')

The enumeration.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,bool).isMatch'></a>

`isMatch` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is match].

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,bool).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, bool).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,bool).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, bool).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[])'></a>

## EnumerationExtensions.When<TEnum,TValue>(this IEnumeration<TEnum,TValue>, IEnumeration<TEnum,TValue>[]) Method

Whens the specified is match.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue> enumeration, params CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[] matchEnumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')

The enumeration.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).matchEnumerations'></a>

`matchEnumerations` [CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The match enumerations.

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__)'></a>

## EnumerationExtensions.When<TEnum,TValue>(this IEnumeration<TEnum,TValue>, IEnumerable<IEnumeration<TEnum,TValue>>) Method

Whens the specified is match.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue> enumeration, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>> matchEnumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')

The enumeration.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).matchEnumerations'></a>

`matchEnumerations` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The match enumerations.

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Func_bool_)'></a>

## EnumerationExtensions.When<TEnum,TValue>(this IEnumeration<TEnum,TValue>, Func<bool>) Method

Whens the specified is match.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue> enumeration, System.Func<bool> predicate)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Func_bool_).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Func_bool_).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Func_bool_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Func_bool_).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, System.Func<bool>).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Func_bool_).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, System.Func<bool>).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')

The enumeration.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Func_bool_).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The predicate.

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Func_bool_).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, System.Func<bool>).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IEnumeration_TEnum,TValue_,System.Func_bool_).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IEnumeration<TEnum,TValue>, System.Func<bool>).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,bool)'></a>

## EnumerationExtensions.When<TEnum,TValue>(this IThenStatement<TEnum,TValue>, bool) Method

Whens the specified is match.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue> statement, bool isMatch)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,bool).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,bool).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,bool).statement'></a>

`statement` [CloudyWing.Enumeration.IThenStatement&lt;](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,bool).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, bool).TEnum')[,](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,bool).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, bool).TValue')[&gt;](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')

The then statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,bool).isMatch'></a>

`isMatch` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

if set to `true` [is match].

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,bool).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, bool).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,bool).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, bool).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[])'></a>

## EnumerationExtensions.When<TEnum,TValue>(this IThenStatement<TEnum,TValue>, IEnumeration<TEnum,TValue>[]) Method

Whens the specified is match.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue> statement, params CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[] matchEnumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).statement'></a>

`statement` [CloudyWing.Enumeration.IThenStatement&lt;](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TEnum')[,](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TValue')[&gt;](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')

The then statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).matchEnumerations'></a>

`matchEnumerations` [CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The match enumerations.

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,CloudyWing.Enumeration.IEnumeration_TEnum,TValue_[]).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, CloudyWing.Enumeration.IEnumeration<TEnum,TValue>[]).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__)'></a>

## EnumerationExtensions.When<TEnum,TValue>(this IThenStatement<TEnum,TValue>, IEnumerable<IEnumeration<TEnum,TValue>>) Method

Whens the specified is match.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue> statement, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>> matchEnumerations)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).statement'></a>

`statement` [CloudyWing.Enumeration.IThenStatement&lt;](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')

The then statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).matchEnumerations'></a>

`matchEnumerations` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The match enumerations.

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Collections.Generic.IEnumerable_CloudyWing.Enumeration.IEnumeration_TEnum,TValue__).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, System.Collections.Generic.IEnumerable<CloudyWing.Enumeration.IEnumeration<TEnum,TValue>>).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Func_bool_)'></a>

## EnumerationExtensions.When<TEnum,TValue>(this IThenStatement<TEnum,TValue>, Func<bool>) Method

Whens the specified is match.

```csharp
public static CloudyWing.Enumeration.IWhenStatement<TEnum,TValue> When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue> statement, System.Func<bool> predicate)
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable;
```
#### Type parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Func_bool_).TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Func_bool_).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Func_bool_).statement'></a>

`statement` [CloudyWing.Enumeration.IThenStatement&lt;](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Func_bool_).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, System.Func<bool>).TEnum')[,](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Func_bool_).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, System.Func<bool>).TValue')[&gt;](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')

The then statement.

<a name='CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Func_bool_).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The predicate.

#### Returns
[CloudyWing.Enumeration.IWhenStatement&lt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Func_bool_).TEnum 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, System.Func<bool>).TEnum')[,](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.EnumerationExtensions.md#CloudyWing.Enumeration.EnumerationExtensions.When_TEnum,TValue_(thisCloudyWing.Enumeration.IThenStatement_TEnum,TValue_,System.Func_bool_).TValue 'CloudyWing.Enumeration.EnumerationExtensions.When<TEnum,TValue>(this CloudyWing.Enumeration.IThenStatement<TEnum,TValue>, System.Func<bool>).TValue')[&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')  
The when statement.