#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration.Abstractions](CloudyWing.Enumeration.Abstractions.md 'CloudyWing.Enumeration.Abstractions')

## ULongEnumeration<T> Class

The ulong enumeration base.

```csharp
public abstract class ULongEnumeration<T> : CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<T, ulong>
    where T : CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>
```
#### Type parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T'></a>

`T`

The ulong enumeration.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.Enumeration.Abstractions.EnumerationBase&lt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')[&gt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>') &#129106; [CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')[&gt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>') &#129106; ULongEnumeration<T>
### Constructors

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.ULongEnumeration(ulong)'></a>

## ULongEnumeration(ulong) Constructor

Initializes a new instance of the [ULongEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>') class.

```csharp
protected ULongEnumeration(ulong value);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.ULongEnumeration(ulong).value'></a>

`value` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.ULongEnumeration(ulong,string)'></a>

## ULongEnumeration(ulong, string) Constructor

Initializes a new instance of the [ULongEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>') class.

```csharp
protected ULongEnumeration(ulong value, string name);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.ULongEnumeration(ulong,string).value'></a>

`value` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.ULongEnumeration(ulong,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name.
### Methods

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.Equals(object)'></a>

## ULongEnumeration<T>.Equals(object) Method

Determines whether the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'), is equal to this instance.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.Equals(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') to compare with this instance.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is equal to this instance; otherwise, `false`.
### Operators

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_,decimal)'></a>

## ULongEnumeration<T>.operator ==(ULongEnumeration<T>, decimal) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.ULongEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ULongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_)'></a>

## ULongEnumeration<T>.operator ==(decimal, ULongEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(decimal left, CloudyWing.Enumeration.Abstractions.ULongEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ULongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_)'></a>

## ULongEnumeration<T>.operator >(decimal, ULongEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(decimal left, CloudyWing.Enumeration.Abstractions.ULongEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ULongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_)'></a>

## ULongEnumeration<T>.operator >=(decimal, ULongEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(decimal left, CloudyWing.Enumeration.Abstractions.ULongEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ULongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Implicitdecimal(CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_)'></a>

## ULongEnumeration<T>.implicit operator decimal(ULongEnumeration<T>) Operator

Performs an implicit conversion from [ULongEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>') to [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal').

```csharp
public static decimal implicit operator decimal(CloudyWing.Enumeration.Abstractions.ULongEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Implicitdecimal(CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.ULongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')

The enumeration.

#### Returns
[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_)'></a>

## ULongEnumeration<T>.implicit operator double(ULongEnumeration<T>) Operator

Performs an implicit conversion from [ULongEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>') to [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').

```csharp
public static double implicit operator double(CloudyWing.Enumeration.Abstractions.ULongEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.ULongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')

The enumeration.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Implicitfloat(CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_)'></a>

## ULongEnumeration<T>.implicit operator float(ULongEnumeration<T>) Operator

Performs an implicit conversion from [ULongEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>') to [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').

```csharp
public static float implicit operator float(CloudyWing.Enumeration.Abstractions.ULongEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Implicitfloat(CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.ULongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')

The enumeration.

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_,decimal)'></a>

## ULongEnumeration<T>.operator !=(ULongEnumeration<T>, decimal) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.ULongEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ULongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_)'></a>

## ULongEnumeration<T>.operator !=(decimal, ULongEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(decimal left, CloudyWing.Enumeration.Abstractions.ULongEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ULongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_)'></a>

## ULongEnumeration<T>.operator <(decimal, ULongEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(decimal left, CloudyWing.Enumeration.Abstractions.ULongEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ULongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_)'></a>

## ULongEnumeration<T>.operator <=(decimal, ULongEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(decimal left, CloudyWing.Enumeration.Abstractions.ULongEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ULongEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ULongEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ULongEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.