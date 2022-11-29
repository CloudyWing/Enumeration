#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration.Abstractions](CloudyWing.Enumeration.Abstractions.md 'CloudyWing.Enumeration.Abstractions')

## ConvertibleEnumeration<TEnum,TValue> Class

The convertible enumeration base.

```csharp
public abstract class ConvertibleEnumeration<TEnum,TValue> : CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum, TValue>,
System.IConvertible
    where TEnum : CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum, TValue>
    where TValue : System.IComparable, System.IConvertible
```
#### Type parameters

<a name='CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.TValue'></a>

`TValue`

The type of the value.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.Enumeration.Abstractions.EnumerationBase&lt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md#CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.TEnum 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>.TEnum')[,](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[TValue](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md#CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.TValue 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>.TValue')[&gt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>') &#129106; ConvertibleEnumeration<TEnum,TValue>

Derived  
&#8627; [ByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')  
&#8627; [CharEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.CharEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.CharEnumeration<T>')  
&#8627; [DecimalEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.DecimalEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.DecimalEnumeration<T>')  
&#8627; [DoubleEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.DoubleEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.DoubleEnumeration<T>')  
&#8627; [FloatEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')  
&#8627; [IntEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')  
&#8627; [LongEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')  
&#8627; [SByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')  
&#8627; [ShortEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ShortEnumeration<T>')  
&#8627; [UIntEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.UIntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UIntEnumeration<T>')  
&#8627; [ULongEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')  
&#8627; [UShortEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

Implements [System.IConvertible](https://docs.microsoft.com/en-us/dotnet/api/System.IConvertible 'System.IConvertible')

### See Also
- [EnumerationBase&lt;TEnum,TValue&gt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')
- [System.IConvertible](https://docs.microsoft.com/en-us/dotnet/api/System.IConvertible 'System.IConvertible')
### Constructors

<a name='CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.ConvertibleEnumeration(TValue)'></a>

## ConvertibleEnumeration(TValue) Constructor

Initializes a new instance of the [ConvertibleEnumeration&lt;TEnum,TValue&gt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>') class.

```csharp
protected ConvertibleEnumeration(TValue value);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.ConvertibleEnumeration(TValue).value'></a>

`value` [TValue](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md#CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.TValue 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>.TValue')

The value.

<a name='CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.ConvertibleEnumeration(TValue,string)'></a>

## ConvertibleEnumeration(TValue, string) Constructor

Initializes a new instance of the [ConvertibleEnumeration&lt;TEnum,TValue&gt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>') class.

```csharp
protected ConvertibleEnumeration(TValue value, string name);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.ConvertibleEnumeration(TValue,string).value'></a>

`value` [TValue](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md#CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.TValue 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>.TValue')

The value.

<a name='CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.ConvertibleEnumeration(TValue,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name.