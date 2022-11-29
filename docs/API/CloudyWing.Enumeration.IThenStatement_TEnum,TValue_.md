#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration](CloudyWing.Enumeration.md 'CloudyWing.Enumeration')

## IThenStatement<TEnum,TValue> Interface

The then statement.

```csharp
public interface IThenStatement<TEnum,TValue> :
CloudyWing.Enumeration.ISwitchStatement<TEnum, TValue>
    where TEnum : CloudyWing.Enumeration.IEnumeration<TEnum, TValue>
    where TValue : System.IComparable
```
#### Type parameters

<a name='CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.TEnum'></a>

`TEnum`

The type of the enum.

<a name='CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.TValue'></a>

`TValue`

The type of the value.

Implements [CloudyWing.Enumeration.ISwitchStatement&lt;](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>')[TEnum](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md#CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.TEnum 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>.TEnum')[,](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>')[TValue](CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.md#CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.TValue 'CloudyWing.Enumeration.IThenStatement<TEnum,TValue>.TValue')[&gt;](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>')

### See Also
- [IEnumeration&lt;TEnum, TValue&gt;](CloudyWing.Enumeration.ISwitchStatement_TEnum,TValue_.md 'CloudyWing.Enumeration.ISwitchStatement<TEnum,TValue>')
- [IEnumeration&lt;TEnum, TValue&gt;](CloudyWing.Enumeration.IEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.IEnumeration<TEnum,TValue>')
### Properties

<a name='CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.IsExecuted'></a>

## IThenStatement<TEnum,TValue>.IsExecuted Property

Gets a value indicating whether this action is executed.

```csharp
bool IsExecuted { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if this action is executed; otherwise, `false`.
### Methods

<a name='CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.Default(System.Action)'></a>

## IThenStatement<TEnum,TValue>.Default(Action) Method

Defaults the specified action.

```csharp
void Default(System.Action action);
```
#### Parameters

<a name='CloudyWing.Enumeration.IThenStatement_TEnum,TValue_.Default(System.Action).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action.