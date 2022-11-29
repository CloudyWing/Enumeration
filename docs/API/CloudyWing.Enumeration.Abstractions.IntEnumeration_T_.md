#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration.Abstractions](CloudyWing.Enumeration.Abstractions.md 'CloudyWing.Enumeration.Abstractions')

## IntEnumeration<T> Class

The int enumeration base.

```csharp
public abstract class IntEnumeration<T> : CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<T, int>
    where T : CloudyWing.Enumeration.Abstractions.IntEnumeration<T>
```
#### Type parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T'></a>

`T`

The int enumeration.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.Enumeration.Abstractions.EnumerationBase&lt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>') &#129106; [CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>') &#129106; IntEnumeration<T>
### Constructors

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.IntEnumeration(int)'></a>

## IntEnumeration(int) Constructor

Initializes a new instance of the [IntEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>') class.

```csharp
protected IntEnumeration(int value);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.IntEnumeration(int).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.IntEnumeration(int,string)'></a>

## IntEnumeration(int, string) Constructor

Initializes a new instance of the [IntEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>') class.

```csharp
protected IntEnumeration(int value, string name);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.IntEnumeration(int,string).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.IntEnumeration(int,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name.
### Methods

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.Equals(object)'></a>

## IntEnumeration<T>.Equals(object) Method

Determines whether the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'), is equal to this instance.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.Equals(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') to compare with this instance.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is equal to this instance; otherwise, `false`.
### Operators

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator ==(byte, IntEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(byte left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator ==(char, IntEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(char left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte)'></a>

## IntEnumeration<T>.operator ==(IntEnumeration<T>, byte) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char)'></a>

## IntEnumeration<T>.operator ==(IntEnumeration<T>, char) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal)'></a>

## IntEnumeration<T>.operator ==(IntEnumeration<T>, decimal) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double)'></a>

## IntEnumeration<T>.operator ==(IntEnumeration<T>, double) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float)'></a>

## IntEnumeration<T>.operator ==(IntEnumeration<T>, float) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long)'></a>

## IntEnumeration<T>.operator ==(IntEnumeration<T>, long) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte)'></a>

## IntEnumeration<T>.operator ==(IntEnumeration<T>, sbyte) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short)'></a>

## IntEnumeration<T>.operator ==(IntEnumeration<T>, short) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint)'></a>

## IntEnumeration<T>.operator ==(IntEnumeration<T>, uint) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort)'></a>

## IntEnumeration<T>.operator ==(IntEnumeration<T>, ushort) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator ==(decimal, IntEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(decimal left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator ==(double, IntEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(double left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator ==(float, IntEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(float left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator ==(long, IntEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(long left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator ==(sbyte, IntEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(sbyte left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator ==(short, IntEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(short left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator ==(uint, IntEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(uint left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator ==(ushort, IntEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(ushort left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >(byte, IntEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(byte left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >(char, IntEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(char left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte)'></a>

## IntEnumeration<T>.operator >(IntEnumeration<T>, byte) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char)'></a>

## IntEnumeration<T>.operator >(IntEnumeration<T>, char) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal)'></a>

## IntEnumeration<T>.operator >(IntEnumeration<T>, decimal) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double)'></a>

## IntEnumeration<T>.operator >(IntEnumeration<T>, double) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float)'></a>

## IntEnumeration<T>.operator >(IntEnumeration<T>, float) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long)'></a>

## IntEnumeration<T>.operator >(IntEnumeration<T>, long) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte)'></a>

## IntEnumeration<T>.operator >(IntEnumeration<T>, sbyte) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short)'></a>

## IntEnumeration<T>.operator >(IntEnumeration<T>, short) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint)'></a>

## IntEnumeration<T>.operator >(IntEnumeration<T>, uint) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort)'></a>

## IntEnumeration<T>.operator >(IntEnumeration<T>, ushort) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >(decimal, IntEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(decimal left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >(double, IntEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(double left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >(float, IntEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(float left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >(long, IntEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(long left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >(sbyte, IntEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(sbyte left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >(short, IntEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(short left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >(uint, IntEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(uint left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >(ushort, IntEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(ushort left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >=(byte, IntEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(byte left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >=(char, IntEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(char left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte)'></a>

## IntEnumeration<T>.operator >=(IntEnumeration<T>, byte) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char)'></a>

## IntEnumeration<T>.operator >=(IntEnumeration<T>, char) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal)'></a>

## IntEnumeration<T>.operator >=(IntEnumeration<T>, decimal) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double)'></a>

## IntEnumeration<T>.operator >=(IntEnumeration<T>, double) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float)'></a>

## IntEnumeration<T>.operator >=(IntEnumeration<T>, float) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long)'></a>

## IntEnumeration<T>.operator >=(IntEnumeration<T>, long) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte)'></a>

## IntEnumeration<T>.operator >=(IntEnumeration<T>, sbyte) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short)'></a>

## IntEnumeration<T>.operator >=(IntEnumeration<T>, short) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint)'></a>

## IntEnumeration<T>.operator >=(IntEnumeration<T>, uint) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort)'></a>

## IntEnumeration<T>.operator >=(IntEnumeration<T>, ushort) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >=(decimal, IntEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(decimal left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >=(double, IntEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(double left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >=(float, IntEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(float left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >=(long, IntEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(long left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >=(sbyte, IntEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(sbyte left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >=(short, IntEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(short left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >=(uint, IntEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(uint left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator >=(ushort, IntEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(ushort left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Implicitdecimal(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.implicit operator decimal(IntEnumeration<T>) Operator

Performs an implicit conversion from [IntEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>') to [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal').

```csharp
public static decimal implicit operator decimal(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Implicitdecimal(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The enumeration.

#### Returns
[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.implicit operator double(IntEnumeration<T>) Operator

Performs an implicit conversion from [IntEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>') to [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').

```csharp
public static double implicit operator double(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The enumeration.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Implicitfloat(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.implicit operator float(IntEnumeration<T>) Operator

Performs an implicit conversion from [IntEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>') to [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').

```csharp
public static float implicit operator float(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Implicitfloat(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The enumeration.

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Implicitlong(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.implicit operator long(IntEnumeration<T>) Operator

Performs an implicit conversion from [IntEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>') to [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').

```csharp
public static long implicit operator long(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Implicitlong(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The enumeration.

#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator !=(byte, IntEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(byte left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator !=(char, IntEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(char left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte)'></a>

## IntEnumeration<T>.operator !=(IntEnumeration<T>, byte) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char)'></a>

## IntEnumeration<T>.operator !=(IntEnumeration<T>, char) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal)'></a>

## IntEnumeration<T>.operator !=(IntEnumeration<T>, decimal) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double)'></a>

## IntEnumeration<T>.operator !=(IntEnumeration<T>, double) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float)'></a>

## IntEnumeration<T>.operator !=(IntEnumeration<T>, float) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long)'></a>

## IntEnumeration<T>.operator !=(IntEnumeration<T>, long) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte)'></a>

## IntEnumeration<T>.operator !=(IntEnumeration<T>, sbyte) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short)'></a>

## IntEnumeration<T>.operator !=(IntEnumeration<T>, short) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint)'></a>

## IntEnumeration<T>.operator !=(IntEnumeration<T>, uint) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort)'></a>

## IntEnumeration<T>.operator !=(IntEnumeration<T>, ushort) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator !=(decimal, IntEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(decimal left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator !=(double, IntEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(double left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator !=(float, IntEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(float left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator !=(long, IntEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(long left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator !=(sbyte, IntEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(sbyte left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator !=(short, IntEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(short left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator !=(uint, IntEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(uint left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator !=(ushort, IntEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(ushort left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <(byte, IntEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(byte left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <(char, IntEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(char left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte)'></a>

## IntEnumeration<T>.operator <(IntEnumeration<T>, byte) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char)'></a>

## IntEnumeration<T>.operator <(IntEnumeration<T>, char) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal)'></a>

## IntEnumeration<T>.operator <(IntEnumeration<T>, decimal) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double)'></a>

## IntEnumeration<T>.operator <(IntEnumeration<T>, double) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float)'></a>

## IntEnumeration<T>.operator <(IntEnumeration<T>, float) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long)'></a>

## IntEnumeration<T>.operator <(IntEnumeration<T>, long) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte)'></a>

## IntEnumeration<T>.operator <(IntEnumeration<T>, sbyte) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short)'></a>

## IntEnumeration<T>.operator <(IntEnumeration<T>, short) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint)'></a>

## IntEnumeration<T>.operator <(IntEnumeration<T>, uint) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort)'></a>

## IntEnumeration<T>.operator <(IntEnumeration<T>, ushort) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <(decimal, IntEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(decimal left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <(double, IntEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(double left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <(float, IntEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(float left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <(long, IntEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(long left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <(sbyte, IntEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(sbyte left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <(short, IntEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(short left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <(uint, IntEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(uint left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <(ushort, IntEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(ushort left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <=(byte, IntEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(byte left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <=(char, IntEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(char left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte)'></a>

## IntEnumeration<T>.operator <=(IntEnumeration<T>, byte) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char)'></a>

## IntEnumeration<T>.operator <=(IntEnumeration<T>, char) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal)'></a>

## IntEnumeration<T>.operator <=(IntEnumeration<T>, decimal) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double)'></a>

## IntEnumeration<T>.operator <=(IntEnumeration<T>, double) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float)'></a>

## IntEnumeration<T>.operator <=(IntEnumeration<T>, float) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long)'></a>

## IntEnumeration<T>.operator <=(IntEnumeration<T>, long) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte)'></a>

## IntEnumeration<T>.operator <=(IntEnumeration<T>, sbyte) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short)'></a>

## IntEnumeration<T>.operator <=(IntEnumeration<T>, short) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint)'></a>

## IntEnumeration<T>.operator <=(IntEnumeration<T>, uint) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort)'></a>

## IntEnumeration<T>.operator <=(IntEnumeration<T>, ushort) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.IntEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.IntEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <=(decimal, IntEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(decimal left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <=(double, IntEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(double left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <=(float, IntEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(float left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(float,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <=(long, IntEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(long left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <=(sbyte, IntEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(sbyte left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <=(short, IntEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(short left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <=(uint, IntEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(uint left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_)'></a>

## IntEnumeration<T>.operator <=(ushort, IntEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(ushort left, CloudyWing.Enumeration.Abstractions.IntEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.IntEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.IntEnumeration&lt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.IntEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.IntEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.