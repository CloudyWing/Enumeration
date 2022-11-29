#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration](CloudyWing.Enumeration.md 'CloudyWing.Enumeration')

## IEnumeration<TEnum,TValue> Interface

The enumeration interface.

```csharp
public interface IEnumeration<in TEnum,TValue> :
System.IComparable
    where TValue : System.IComparable
```
#### Type parameters

<a name='CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.TValue'></a>

`TValue`

The type of the value.

Derived  
&#8627; [EnumerationBase&lt;TEnum,TValue&gt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')

Implements [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable')

### See Also
- [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable')
### Properties

<a name='CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.Name'></a>

## IEnumeration<TEnum,TValue>.Name Property

Gets the name.

```csharp
string Name { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name.

<a name='CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.Value'></a>

## IEnumeration<TEnum,TValue>.Value Property

Gets the value.

```csharp
TValue Value { get; }
```

#### Property Value
[TValue](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md#CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.TValue 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>.TValue')  
The value.