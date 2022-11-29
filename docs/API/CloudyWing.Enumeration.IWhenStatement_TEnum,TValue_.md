#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration](CloudyWing.Enumeration.md 'CloudyWing.Enumeration')

## IWhenStatement<TEnum,TValue> Interface

The when statement.

```csharp
public interface IWhenStatement<TEnum,TValue> :
CloudyWing.Enumeration.ISwitchStatement<TEnum, TValue>
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable
```
#### Type parameters

<a name='CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.TValue'></a>

`TValue`

The type of the value.

Implements [CloudyWing.Enumeration.ISwitchStatement&lt;](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md#CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.TEnum 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>.TEnum')[,](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md#CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.TValue 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>.TValue')[&gt;](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>')

### See Also
- [IEnumeration&lt;TEnum, TValue&gt;](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>')
- [IEnumeration&lt;TEnum, TValue&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')
### Properties

<a name='CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.MatchPredicate'></a>

## IWhenStatement<TEnum,TValue>.MatchPredicate Property

Gets the match predicate.

```csharp
System.Func<bool> MatchPredicate { get; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
The match predicate.
### Methods

<a name='CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.Then(System.Action)'></a>

## IWhenStatement<TEnum,TValue>.Then(Action) Method

Thens the specified action.

```csharp
CloudyWing.Enumeration.IThenStatement<TEnum,TValue> Then(System.Action action);
```
#### Parameters

<a name='CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.Then(System.Action).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action.

#### Returns
[CloudyWing.Enumeration.IThenStatement&lt;](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md#CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.TEnum 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>.TEnum')[,](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.md#CloudyWing.Enumeration.IWhenStatement_TEnum,TValue_.TValue 'CloudyWing.Enumeration.IWhenStatement<TEnum,TValue>.TValue')[&gt;](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>')  
The `IThenEnumeration`.