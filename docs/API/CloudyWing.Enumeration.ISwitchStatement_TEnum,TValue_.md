#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration](CloudyWing.Enumeration.md 'CloudyWing.Enumeration')

## ISwitchStatement<TEnum,TValue> Interface

The switch statement interface

```csharp
public interface ISwitchStatement<TEnum,TValue>
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable
```
#### Type parameters

<a name='CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.TValue'></a>

`TValue`

The type of the value.

Derived  
&#8627; [IThenStatement&lt;TEnum,TValue&gt;](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')  
&#8627; [IWhenStatement&lt;TEnum,TValue&gt;](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>')
### Properties

<a name='CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.Enumeration'></a>

## ISwitchStatement<TEnum,TValue>.Enumeration Property

Gets the enumeration.

```csharp
CloudyWing.Enumeration.IEnumeration<TEnum,TValue> Enumeration { get; }
```

#### Property Value
[CloudyWing.Enumeration.IEnumeration&lt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md#CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.TEnum 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>.TEnum')[,](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')[TValue](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md#CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.TValue 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>.TValue')[&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')  
The enumeration.

<a name='CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.InnerStatement'></a>

## ISwitchStatement<TEnum,TValue>.InnerStatement Property

Gets the inner statement.

```csharp
CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue> InnerStatement { get; }
```

#### Property Value
[CloudyWing.Enumeration.ISwitchStatement&lt;](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md#CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.TEnum 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>.TEnum')[,](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md#CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.TValue 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>.TValue')[&gt;](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>')  
The inner statement.