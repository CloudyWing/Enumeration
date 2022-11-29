#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration.Abstractions](CloudyWing.Enumeration.Abstractions.md 'CloudyWing.Enumeration.Abstractions')

## ByteEnumeration<T> Class

The byte enumeration base.

```csharp
public abstract class ByteEnumeration<T> : CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<T, byte>
    where T : CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>
```
#### Type parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T'></a>

`T`

The byte enumeration.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.Enumeration.Abstractions.EnumerationBase&lt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>') &#129106; [CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>') &#129106; ByteEnumeration<T>
### Constructors

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.ByteEnumeration(byte)'></a>

## ByteEnumeration(byte) Constructor

Initializes a new instance of the [ByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>') class.

```csharp
protected ByteEnumeration(byte value);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.ByteEnumeration(byte).value'></a>

`value` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The value.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.ByteEnumeration(byte,string)'></a>

## ByteEnumeration(byte, string) Constructor

Initializes a new instance of the [ByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>') class.

```csharp
protected ByteEnumeration(byte value, string name);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.ByteEnumeration(byte,string).value'></a>

`value` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The value.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.ByteEnumeration(byte,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name.
### Methods

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.Equals(object)'></a>

## ByteEnumeration<T>.Equals(object) Method

Determines whether the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'), is equal to this instance.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.Equals(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') to compare with this instance.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is equal to this instance; otherwise, `false`.
### Operators

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator ==(char, ByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(char left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char)'></a>

## ByteEnumeration<T>.operator ==(ByteEnumeration<T>, char) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal)'></a>

## ByteEnumeration<T>.operator ==(ByteEnumeration<T>, decimal) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double)'></a>

## ByteEnumeration<T>.operator ==(ByteEnumeration<T>, double) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float)'></a>

## ByteEnumeration<T>.operator ==(ByteEnumeration<T>, float) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int)'></a>

## ByteEnumeration<T>.operator ==(ByteEnumeration<T>, int) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long)'></a>

## ByteEnumeration<T>.operator ==(ByteEnumeration<T>, long) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte)'></a>

## ByteEnumeration<T>.operator ==(ByteEnumeration<T>, sbyte) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short)'></a>

## ByteEnumeration<T>.operator ==(ByteEnumeration<T>, short) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint)'></a>

## ByteEnumeration<T>.operator ==(ByteEnumeration<T>, uint) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong)'></a>

## ByteEnumeration<T>.operator ==(ByteEnumeration<T>, ulong) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort)'></a>

## ByteEnumeration<T>.operator ==(ByteEnumeration<T>, ushort) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator ==(decimal, ByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(decimal left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator ==(double, ByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(double left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator ==(float, ByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(float left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator ==(int, ByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(int left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator ==(long, ByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(long left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator ==(sbyte, ByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(sbyte left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator ==(short, ByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(short left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator ==(uint, ByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(uint left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator ==(ulong, ByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(ulong left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator ==(ushort, ByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(ushort left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >(char, ByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(char left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char)'></a>

## ByteEnumeration<T>.operator >(ByteEnumeration<T>, char) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal)'></a>

## ByteEnumeration<T>.operator >(ByteEnumeration<T>, decimal) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double)'></a>

## ByteEnumeration<T>.operator >(ByteEnumeration<T>, double) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float)'></a>

## ByteEnumeration<T>.operator >(ByteEnumeration<T>, float) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int)'></a>

## ByteEnumeration<T>.operator >(ByteEnumeration<T>, int) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long)'></a>

## ByteEnumeration<T>.operator >(ByteEnumeration<T>, long) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte)'></a>

## ByteEnumeration<T>.operator >(ByteEnumeration<T>, sbyte) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short)'></a>

## ByteEnumeration<T>.operator >(ByteEnumeration<T>, short) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint)'></a>

## ByteEnumeration<T>.operator >(ByteEnumeration<T>, uint) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong)'></a>

## ByteEnumeration<T>.operator >(ByteEnumeration<T>, ulong) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort)'></a>

## ByteEnumeration<T>.operator >(ByteEnumeration<T>, ushort) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >(decimal, ByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(decimal left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >(double, ByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(double left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >(float, ByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(float left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >(int, ByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(int left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >(long, ByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(long left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >(sbyte, ByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(sbyte left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >(short, ByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(short left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >(uint, ByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(uint left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >(ulong, ByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(ulong left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >(ushort, ByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(ushort left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >=(char, ByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(char left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char)'></a>

## ByteEnumeration<T>.operator >=(ByteEnumeration<T>, char) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal)'></a>

## ByteEnumeration<T>.operator >=(ByteEnumeration<T>, decimal) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double)'></a>

## ByteEnumeration<T>.operator >=(ByteEnumeration<T>, double) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float)'></a>

## ByteEnumeration<T>.operator >=(ByteEnumeration<T>, float) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int)'></a>

## ByteEnumeration<T>.operator >=(ByteEnumeration<T>, int) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long)'></a>

## ByteEnumeration<T>.operator >=(ByteEnumeration<T>, long) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte)'></a>

## ByteEnumeration<T>.operator >=(ByteEnumeration<T>, sbyte) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short)'></a>

## ByteEnumeration<T>.operator >=(ByteEnumeration<T>, short) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint)'></a>

## ByteEnumeration<T>.operator >=(ByteEnumeration<T>, uint) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong)'></a>

## ByteEnumeration<T>.operator >=(ByteEnumeration<T>, ulong) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort)'></a>

## ByteEnumeration<T>.operator >=(ByteEnumeration<T>, ushort) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >=(decimal, ByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(decimal left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >=(double, ByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(double left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >=(float, ByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(float left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >=(int, ByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(int left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >=(long, ByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(long left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >=(sbyte, ByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(sbyte left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >=(short, ByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(short left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >=(uint, ByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(uint left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >=(ulong, ByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(ulong left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator >=(ushort, ByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(ushort left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitdecimal(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.implicit operator decimal(ByteEnumeration<T>) Operator

Performs an implicit conversion from [ByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>') to [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal').

```csharp
public static decimal implicit operator decimal(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitdecimal(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The enumeration.

#### Returns
[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.implicit operator double(ByteEnumeration<T>) Operator

Performs an implicit conversion from [ByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>') to [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').

```csharp
public static double implicit operator double(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The enumeration.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitfloat(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.implicit operator float(ByteEnumeration<T>) Operator

Performs an implicit conversion from [ByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>') to [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').

```csharp
public static float implicit operator float(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitfloat(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The enumeration.

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitint(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.implicit operator int(ByteEnumeration<T>) Operator

Performs an implicit conversion from [ByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>') to [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32').

```csharp
public static int implicit operator int(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitint(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The enumeration.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitlong(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.implicit operator long(ByteEnumeration<T>) Operator

Performs an implicit conversion from [ByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>') to [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').

```csharp
public static long implicit operator long(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitlong(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The enumeration.

#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitshort(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.implicit operator short(ByteEnumeration<T>) Operator

Performs an implicit conversion from [ByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>') to [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16').

```csharp
public static short implicit operator short(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitshort(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The enumeration.

#### Returns
[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicituint(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.implicit operator uint(ByteEnumeration<T>) Operator

Performs an implicit conversion from [ByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>') to [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32').

```csharp
public static uint implicit operator uint(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicituint(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

#### Returns
[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitulong(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.implicit operator ulong(ByteEnumeration<T>) Operator

Performs an implicit conversion from [ByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>') to [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64').

```csharp
public static ulong implicit operator ulong(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitulong(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The enumeration.

#### Returns
[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitushort(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.implicit operator ushort(ByteEnumeration<T>) Operator

Performs an implicit conversion from [ByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>') to [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16').

```csharp
public static ushort implicit operator ushort(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Implicitushort(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The enumeration.

#### Returns
[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator !=(char, ByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(char left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char)'></a>

## ByteEnumeration<T>.operator !=(ByteEnumeration<T>, char) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal)'></a>

## ByteEnumeration<T>.operator !=(ByteEnumeration<T>, decimal) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double)'></a>

## ByteEnumeration<T>.operator !=(ByteEnumeration<T>, double) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float)'></a>

## ByteEnumeration<T>.operator !=(ByteEnumeration<T>, float) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int)'></a>

## ByteEnumeration<T>.operator !=(ByteEnumeration<T>, int) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long)'></a>

## ByteEnumeration<T>.operator !=(ByteEnumeration<T>, long) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte)'></a>

## ByteEnumeration<T>.operator !=(ByteEnumeration<T>, sbyte) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short)'></a>

## ByteEnumeration<T>.operator !=(ByteEnumeration<T>, short) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint)'></a>

## ByteEnumeration<T>.operator !=(ByteEnumeration<T>, uint) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong)'></a>

## ByteEnumeration<T>.operator !=(ByteEnumeration<T>, ulong) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort)'></a>

## ByteEnumeration<T>.operator !=(ByteEnumeration<T>, ushort) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator !=(decimal, ByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(decimal left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator !=(double, ByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(double left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator !=(float, ByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(float left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator !=(int, ByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(int left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator !=(long, ByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(long left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator !=(sbyte, ByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(sbyte left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator !=(short, ByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(short left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator !=(uint, ByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(uint left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator !=(ulong, ByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(ulong left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator !=(ushort, ByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(ushort left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <(char, ByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(char left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char)'></a>

## ByteEnumeration<T>.operator <(ByteEnumeration<T>, char) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal)'></a>

## ByteEnumeration<T>.operator <(ByteEnumeration<T>, decimal) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double)'></a>

## ByteEnumeration<T>.operator <(ByteEnumeration<T>, double) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float)'></a>

## ByteEnumeration<T>.operator <(ByteEnumeration<T>, float) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int)'></a>

## ByteEnumeration<T>.operator <(ByteEnumeration<T>, int) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long)'></a>

## ByteEnumeration<T>.operator <(ByteEnumeration<T>, long) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte)'></a>

## ByteEnumeration<T>.operator <(ByteEnumeration<T>, sbyte) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short)'></a>

## ByteEnumeration<T>.operator <(ByteEnumeration<T>, short) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint)'></a>

## ByteEnumeration<T>.operator <(ByteEnumeration<T>, uint) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong)'></a>

## ByteEnumeration<T>.operator <(ByteEnumeration<T>, ulong) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort)'></a>

## ByteEnumeration<T>.operator <(ByteEnumeration<T>, ushort) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <(decimal, ByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(decimal left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <(double, ByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(double left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <(float, ByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(float left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <(int, ByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(int left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <(long, ByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(long left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <(sbyte, ByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(sbyte left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <(short, ByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(short left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <(uint, ByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(uint left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <(ulong, ByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(ulong left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <(ushort, ByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(ushort left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <=(char, ByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(char left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char)'></a>

## ByteEnumeration<T>.operator <=(ByteEnumeration<T>, char) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal)'></a>

## ByteEnumeration<T>.operator <=(ByteEnumeration<T>, decimal) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double)'></a>

## ByteEnumeration<T>.operator <=(ByteEnumeration<T>, double) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float)'></a>

## ByteEnumeration<T>.operator <=(ByteEnumeration<T>, float) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int)'></a>

## ByteEnumeration<T>.operator <=(ByteEnumeration<T>, int) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long)'></a>

## ByteEnumeration<T>.operator <=(ByteEnumeration<T>, long) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte)'></a>

## ByteEnumeration<T>.operator <=(ByteEnumeration<T>, sbyte) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short)'></a>

## ByteEnumeration<T>.operator <=(ByteEnumeration<T>, short) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint)'></a>

## ByteEnumeration<T>.operator <=(ByteEnumeration<T>, uint) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong)'></a>

## ByteEnumeration<T>.operator <=(ByteEnumeration<T>, ulong) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort)'></a>

## ByteEnumeration<T>.operator <=(ByteEnumeration<T>, ushort) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <=(decimal, ByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(decimal left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <=(double, ByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(double left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <=(float, ByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(float left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(float,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <=(int, ByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(int left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(int,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <=(long, ByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(long left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <=(sbyte, ByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(sbyte left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <=(short, ByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(short left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <=(uint, ByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(uint left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <=(ulong, ByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(ulong left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_)'></a>

## ByteEnumeration<T>.operator <=(ushort, ByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(ushort left, CloudyWing.Enumeration.Abstractions.ByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.ByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.ByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.ByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.