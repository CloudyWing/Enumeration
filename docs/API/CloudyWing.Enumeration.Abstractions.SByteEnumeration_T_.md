#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration.Abstractions](CloudyWing.Enumeration.Abstractions.md 'CloudyWing.Enumeration.Abstractions')

## SByteEnumeration<T> Class

The sbyte enumeration base.

```csharp
public abstract class SByteEnumeration<T> : CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<T, sbyte>
    where T : CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>
```
#### Type parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T'></a>

`T`

The sbyte enumeration.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.Enumeration.Abstractions.EnumerationBase&lt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')[&gt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>') &#129106; [CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')[&gt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>') &#129106; SByteEnumeration<T>
### Constructors

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.SByteEnumeration(sbyte)'></a>

## SByteEnumeration(sbyte) Constructor

Initializes a new instance of the [SByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>') class.

```csharp
protected SByteEnumeration(sbyte value);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.SByteEnumeration(sbyte).value'></a>

`value` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The value.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.SByteEnumeration(sbyte,string)'></a>

## SByteEnumeration(sbyte, string) Constructor

Initializes a new instance of the [SByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>') class.

```csharp
protected SByteEnumeration(sbyte value, string name);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.SByteEnumeration(sbyte,string).value'></a>

`value` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The value.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.SByteEnumeration(sbyte,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name.
### Methods

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.Equals(object)'></a>

## SByteEnumeration<T>.Equals(object) Method

Determines whether the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'), is equal to this instance.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.Equals(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') to compare with this instance.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is equal to this instance; otherwise, `false`.
### Operators

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator ==(byte, SByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(byte left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator ==(char, SByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(char left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte)'></a>

## SByteEnumeration<T>.operator ==(SByteEnumeration<T>, byte) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char)'></a>

## SByteEnumeration<T>.operator ==(SByteEnumeration<T>, char) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal)'></a>

## SByteEnumeration<T>.operator ==(SByteEnumeration<T>, decimal) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double)'></a>

## SByteEnumeration<T>.operator ==(SByteEnumeration<T>, double) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float)'></a>

## SByteEnumeration<T>.operator ==(SByteEnumeration<T>, float) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int)'></a>

## SByteEnumeration<T>.operator ==(SByteEnumeration<T>, int) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long)'></a>

## SByteEnumeration<T>.operator ==(SByteEnumeration<T>, long) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short)'></a>

## SByteEnumeration<T>.operator ==(SByteEnumeration<T>, short) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint)'></a>

## SByteEnumeration<T>.operator ==(SByteEnumeration<T>, uint) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort)'></a>

## SByteEnumeration<T>.operator ==(SByteEnumeration<T>, ushort) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator ==(decimal, SByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(decimal left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator ==(double, SByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(double left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator ==(float, SByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(float left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator ==(int, SByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(int left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator ==(long, SByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(long left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator ==(short, SByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(short left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator ==(uint, SByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(uint left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator ==(ushort, SByteEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(ushort left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >(byte, SByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(byte left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >(char, SByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(char left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte)'></a>

## SByteEnumeration<T>.operator >(SByteEnumeration<T>, byte) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char)'></a>

## SByteEnumeration<T>.operator >(SByteEnumeration<T>, char) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal)'></a>

## SByteEnumeration<T>.operator >(SByteEnumeration<T>, decimal) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double)'></a>

## SByteEnumeration<T>.operator >(SByteEnumeration<T>, double) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float)'></a>

## SByteEnumeration<T>.operator >(SByteEnumeration<T>, float) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int)'></a>

## SByteEnumeration<T>.operator >(SByteEnumeration<T>, int) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long)'></a>

## SByteEnumeration<T>.operator >(SByteEnumeration<T>, long) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short)'></a>

## SByteEnumeration<T>.operator >(SByteEnumeration<T>, short) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint)'></a>

## SByteEnumeration<T>.operator >(SByteEnumeration<T>, uint) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort)'></a>

## SByteEnumeration<T>.operator >(SByteEnumeration<T>, ushort) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >(decimal, SByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(decimal left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >(double, SByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(double left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >(float, SByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(float left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >(int, SByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(int left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >(long, SByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(long left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >(short, SByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(short left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >(uint, SByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(uint left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >(ushort, SByteEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(ushort left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >=(byte, SByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(byte left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >=(char, SByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(char left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte)'></a>

## SByteEnumeration<T>.operator >=(SByteEnumeration<T>, byte) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char)'></a>

## SByteEnumeration<T>.operator >=(SByteEnumeration<T>, char) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal)'></a>

## SByteEnumeration<T>.operator >=(SByteEnumeration<T>, decimal) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double)'></a>

## SByteEnumeration<T>.operator >=(SByteEnumeration<T>, double) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float)'></a>

## SByteEnumeration<T>.operator >=(SByteEnumeration<T>, float) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int)'></a>

## SByteEnumeration<T>.operator >=(SByteEnumeration<T>, int) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long)'></a>

## SByteEnumeration<T>.operator >=(SByteEnumeration<T>, long) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short)'></a>

## SByteEnumeration<T>.operator >=(SByteEnumeration<T>, short) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint)'></a>

## SByteEnumeration<T>.operator >=(SByteEnumeration<T>, uint) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort)'></a>

## SByteEnumeration<T>.operator >=(SByteEnumeration<T>, ushort) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >=(decimal, SByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(decimal left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >=(double, SByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(double left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >=(float, SByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(float left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >=(int, SByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(int left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >=(long, SByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(long left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >=(short, SByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(short left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >=(uint, SByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(uint left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator >=(ushort, SByteEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(ushort left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Implicitdecimal(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.implicit operator decimal(SByteEnumeration<T>) Operator

Performs an implicit conversion from [SByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>') to [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal').

```csharp
public static decimal implicit operator decimal(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Implicitdecimal(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The enumeration.

#### Returns
[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.implicit operator double(SByteEnumeration<T>) Operator

Performs an implicit conversion from [SByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>') to [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').

```csharp
public static double implicit operator double(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The enumeration.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Implicitfloat(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.implicit operator float(SByteEnumeration<T>) Operator

Performs an implicit conversion from [SByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>') to [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').

```csharp
public static float implicit operator float(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Implicitfloat(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The enumeration.

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Implicitint(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.implicit operator int(SByteEnumeration<T>) Operator

Performs an implicit conversion from [SByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>') to [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32').

```csharp
public static int implicit operator int(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Implicitint(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The enumeration.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Implicitlong(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.implicit operator long(SByteEnumeration<T>) Operator

Performs an implicit conversion from [SByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>') to [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').

```csharp
public static long implicit operator long(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Implicitlong(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The enumeration.

#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Implicitshort(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.implicit operator short(SByteEnumeration<T>) Operator

Performs an implicit conversion from [SByteEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>') to [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16').

```csharp
public static short implicit operator short(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Implicitshort(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The enumeration.

#### Returns
[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator !=(byte, SByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(byte left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator !=(char, SByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(char left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte)'></a>

## SByteEnumeration<T>.operator !=(SByteEnumeration<T>, byte) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char)'></a>

## SByteEnumeration<T>.operator !=(SByteEnumeration<T>, char) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal)'></a>

## SByteEnumeration<T>.operator !=(SByteEnumeration<T>, decimal) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double)'></a>

## SByteEnumeration<T>.operator !=(SByteEnumeration<T>, double) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float)'></a>

## SByteEnumeration<T>.operator !=(SByteEnumeration<T>, float) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int)'></a>

## SByteEnumeration<T>.operator !=(SByteEnumeration<T>, int) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long)'></a>

## SByteEnumeration<T>.operator !=(SByteEnumeration<T>, long) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short)'></a>

## SByteEnumeration<T>.operator !=(SByteEnumeration<T>, short) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint)'></a>

## SByteEnumeration<T>.operator !=(SByteEnumeration<T>, uint) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort)'></a>

## SByteEnumeration<T>.operator !=(SByteEnumeration<T>, ushort) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator !=(decimal, SByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(decimal left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator !=(double, SByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(double left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator !=(float, SByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(float left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator !=(int, SByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(int left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator !=(long, SByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(long left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator !=(short, SByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(short left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator !=(uint, SByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(uint left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator !=(ushort, SByteEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(ushort left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <(byte, SByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(byte left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <(char, SByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(char left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte)'></a>

## SByteEnumeration<T>.operator <(SByteEnumeration<T>, byte) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char)'></a>

## SByteEnumeration<T>.operator <(SByteEnumeration<T>, char) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal)'></a>

## SByteEnumeration<T>.operator <(SByteEnumeration<T>, decimal) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double)'></a>

## SByteEnumeration<T>.operator <(SByteEnumeration<T>, double) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float)'></a>

## SByteEnumeration<T>.operator <(SByteEnumeration<T>, float) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int)'></a>

## SByteEnumeration<T>.operator <(SByteEnumeration<T>, int) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long)'></a>

## SByteEnumeration<T>.operator <(SByteEnumeration<T>, long) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short)'></a>

## SByteEnumeration<T>.operator <(SByteEnumeration<T>, short) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint)'></a>

## SByteEnumeration<T>.operator <(SByteEnumeration<T>, uint) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort)'></a>

## SByteEnumeration<T>.operator <(SByteEnumeration<T>, ushort) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <(decimal, SByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(decimal left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <(double, SByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(double left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <(float, SByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(float left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <(int, SByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(int left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <(long, SByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(long left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <(short, SByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(short left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <(uint, SByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(uint left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <(ushort, SByteEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(ushort left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <=(byte, SByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(byte left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <=(char, SByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(char left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte)'></a>

## SByteEnumeration<T>.operator <=(SByteEnumeration<T>, byte) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char)'></a>

## SByteEnumeration<T>.operator <=(SByteEnumeration<T>, char) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal)'></a>

## SByteEnumeration<T>.operator <=(SByteEnumeration<T>, decimal) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double)'></a>

## SByteEnumeration<T>.operator <=(SByteEnumeration<T>, double) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float)'></a>

## SByteEnumeration<T>.operator <=(SByteEnumeration<T>, float) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int)'></a>

## SByteEnumeration<T>.operator <=(SByteEnumeration<T>, int) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long)'></a>

## SByteEnumeration<T>.operator <=(SByteEnumeration<T>, long) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short)'></a>

## SByteEnumeration<T>.operator <=(SByteEnumeration<T>, short) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint)'></a>

## SByteEnumeration<T>.operator <=(SByteEnumeration<T>, uint) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort)'></a>

## SByteEnumeration<T>.operator <=(SByteEnumeration<T>, ushort) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <=(decimal, SByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(decimal left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <=(double, SByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(double left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <=(float, SByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(float left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(float,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <=(int, SByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(int left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(int,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <=(long, SByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(long left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <=(short, SByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(short left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <=(uint, SByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(uint left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_)'></a>

## SByteEnumeration<T>.operator <=(ushort, SByteEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(ushort left, CloudyWing.Enumeration.Abstractions.SByteEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.SByteEnumeration&lt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.SByteEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.SByteEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.