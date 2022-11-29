#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration.Abstractions](CloudyWing.Enumeration.Abstractions.md 'CloudyWing.Enumeration.Abstractions')

## LongEnumeration<T> Class

The long enumeration base.

```csharp
public abstract class LongEnumeration<T> : CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<T, long>
    where T : CloudyWing.Enumeration.Abstractions.LongEnumeration<T>
```
#### Type parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T'></a>

`T`

The long enumeration.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.Enumeration.Abstractions.EnumerationBase&lt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>') &#129106; [CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')[&gt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>') &#129106; LongEnumeration<T>
### Constructors

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.LongEnumeration(long)'></a>

## LongEnumeration(long) Constructor

Initializes a new instance of the [LongEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>') class.

```csharp
protected LongEnumeration(long value);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.LongEnumeration(long).value'></a>

`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The value.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.LongEnumeration(long,string)'></a>

## LongEnumeration(long, string) Constructor

Initializes a new instance of the [LongEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>') class.

```csharp
protected LongEnumeration(long value, string name);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.LongEnumeration(long,string).value'></a>

`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The value.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.LongEnumeration(long,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name.
### Methods

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.Equals(object)'></a>

## LongEnumeration<T>.Equals(object) Method

Determines whether the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'), is equal to this instance.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.Equals(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') to compare with this instance.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is equal to this instance; otherwise, `false`.
### Operators

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.LongEnumeration_T_,decimal)'></a>

## LongEnumeration<T>.operator ==(LongEnumeration<T>, decimal) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.LongEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.LongEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.LongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.LongEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_)'></a>

## LongEnumeration<T>.operator ==(decimal, LongEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(decimal left, CloudyWing.Enumeration.Abstractions.LongEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.LongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_)'></a>

## LongEnumeration<T>.operator >(decimal, LongEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(decimal left, CloudyWing.Enumeration.Abstractions.LongEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.LongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_)'></a>

## LongEnumeration<T>.operator >=(decimal, LongEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(decimal left, CloudyWing.Enumeration.Abstractions.LongEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.LongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Implicitdecimal(CloudyWing.Enumeration.Abstractions.LongEnumeration_T_)'></a>

## LongEnumeration<T>.implicit operator decimal(LongEnumeration<T>) Operator

Performs an implicit conversion from [LongEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>') to [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal').

```csharp
public static decimal implicit operator decimal(CloudyWing.Enumeration.Abstractions.LongEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Implicitdecimal(CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.LongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')

The enumeration.

#### Returns
[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.LongEnumeration_T_)'></a>

## LongEnumeration<T>.implicit operator double(LongEnumeration<T>) Operator

Performs an implicit conversion from [LongEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>') to [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').

```csharp
public static double implicit operator double(CloudyWing.Enumeration.Abstractions.LongEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.LongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')

The enumeration.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Implicitfloat(CloudyWing.Enumeration.Abstractions.LongEnumeration_T_)'></a>

## LongEnumeration<T>.implicit operator float(LongEnumeration<T>) Operator

Performs an implicit conversion from [LongEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>') to [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').

```csharp
public static float implicit operator float(CloudyWing.Enumeration.Abstractions.LongEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Implicitfloat(CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.LongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')

The enumeration.

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.LongEnumeration_T_,decimal)'></a>

## LongEnumeration<T>.operator !=(LongEnumeration<T>, decimal) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.LongEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.LongEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.LongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.LongEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_)'></a>

## LongEnumeration<T>.operator !=(decimal, LongEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(decimal left, CloudyWing.Enumeration.Abstractions.LongEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.LongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_)'></a>

## LongEnumeration<T>.operator <(decimal, LongEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(decimal left, CloudyWing.Enumeration.Abstractions.LongEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.LongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_)'></a>

## LongEnumeration<T>.operator <=(decimal, LongEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(decimal left, CloudyWing.Enumeration.Abstractions.LongEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.LongEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.LongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.LongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.LongEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.