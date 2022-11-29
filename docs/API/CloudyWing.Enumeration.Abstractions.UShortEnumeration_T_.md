#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration.Abstractions](CloudyWing.Enumeration.Abstractions.md 'CloudyWing.Enumeration.Abstractions')

## UShortEnumeration<T> Class

The ushort enumeration base.

```csharp
public abstract class UShortEnumeration<T> : CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<T, ushort>
    where T : CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>
```
#### Type parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T'></a>

`T`

The ushort enumeration.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.Enumeration.Abstractions.EnumerationBase&lt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')[&gt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>') &#129106; [CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')[&gt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>') &#129106; UShortEnumeration<T>
### Constructors

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.UShortEnumeration(ushort)'></a>

## UShortEnumeration(ushort) Constructor

Initializes a new instance of the [UShortEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>') class.

```csharp
protected UShortEnumeration(ushort value);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.UShortEnumeration(ushort).value'></a>

`value` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The value.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.UShortEnumeration(ushort,string)'></a>

## UShortEnumeration(ushort, string) Constructor

Initializes a new instance of the [UShortEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>') class.

```csharp
protected UShortEnumeration(ushort value, string name);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.UShortEnumeration(ushort,string).value'></a>

`value` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The value.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.UShortEnumeration(ushort,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name.
### Methods

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.Equals(object)'></a>

## UShortEnumeration<T>.Equals(object) Method

Determines whether the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'), is equal to this instance.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.Equals(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') to compare with this instance.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is equal to this instance; otherwise, `false`.
### Operators

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator ==(byte, UShortEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(byte left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator ==(char, UShortEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(char left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte)'></a>

## UShortEnumeration<T>.operator ==(UShortEnumeration<T>, byte) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char)'></a>

## UShortEnumeration<T>.operator ==(UShortEnumeration<T>, char) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal)'></a>

## UShortEnumeration<T>.operator ==(UShortEnumeration<T>, decimal) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double)'></a>

## UShortEnumeration<T>.operator ==(UShortEnumeration<T>, double) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float)'></a>

## UShortEnumeration<T>.operator ==(UShortEnumeration<T>, float) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int)'></a>

## UShortEnumeration<T>.operator ==(UShortEnumeration<T>, int) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long)'></a>

## UShortEnumeration<T>.operator ==(UShortEnumeration<T>, long) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte)'></a>

## UShortEnumeration<T>.operator ==(UShortEnumeration<T>, sbyte) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short)'></a>

## UShortEnumeration<T>.operator ==(UShortEnumeration<T>, short) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint)'></a>

## UShortEnumeration<T>.operator ==(UShortEnumeration<T>, uint) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong)'></a>

## UShortEnumeration<T>.operator ==(UShortEnumeration<T>, ulong) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort)'></a>

## UShortEnumeration<T>.operator ==(UShortEnumeration<T>, ushort) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator ==(decimal, UShortEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(decimal left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator ==(double, UShortEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(double left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator ==(float, UShortEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(float left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator ==(int, UShortEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(int left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator ==(long, UShortEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(long left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator ==(sbyte, UShortEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(sbyte left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator ==(short, UShortEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(short left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator ==(uint, UShortEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(uint left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator ==(ulong, UShortEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(ulong left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator ==(ushort, UShortEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(ushort left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >(byte, UShortEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(byte left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >(char, UShortEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(char left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte)'></a>

## UShortEnumeration<T>.operator >(UShortEnumeration<T>, byte) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char)'></a>

## UShortEnumeration<T>.operator >(UShortEnumeration<T>, char) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal)'></a>

## UShortEnumeration<T>.operator >(UShortEnumeration<T>, decimal) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double)'></a>

## UShortEnumeration<T>.operator >(UShortEnumeration<T>, double) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float)'></a>

## UShortEnumeration<T>.operator >(UShortEnumeration<T>, float) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int)'></a>

## UShortEnumeration<T>.operator >(UShortEnumeration<T>, int) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long)'></a>

## UShortEnumeration<T>.operator >(UShortEnumeration<T>, long) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte)'></a>

## UShortEnumeration<T>.operator >(UShortEnumeration<T>, sbyte) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short)'></a>

## UShortEnumeration<T>.operator >(UShortEnumeration<T>, short) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint)'></a>

## UShortEnumeration<T>.operator >(UShortEnumeration<T>, uint) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong)'></a>

## UShortEnumeration<T>.operator >(UShortEnumeration<T>, ulong) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort)'></a>

## UShortEnumeration<T>.operator >(UShortEnumeration<T>, ushort) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >(decimal, UShortEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(decimal left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >(double, UShortEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(double left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >(float, UShortEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(float left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >(int, UShortEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(int left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >(long, UShortEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(long left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >(sbyte, UShortEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(sbyte left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >(short, UShortEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(short left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >(uint, UShortEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(uint left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >(ulong, UShortEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(ulong left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >(ushort, UShortEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(ushort left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >=(byte, UShortEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(byte left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >=(char, UShortEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(char left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte)'></a>

## UShortEnumeration<T>.operator >=(UShortEnumeration<T>, byte) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char)'></a>

## UShortEnumeration<T>.operator >=(UShortEnumeration<T>, char) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal)'></a>

## UShortEnumeration<T>.operator >=(UShortEnumeration<T>, decimal) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double)'></a>

## UShortEnumeration<T>.operator >=(UShortEnumeration<T>, double) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float)'></a>

## UShortEnumeration<T>.operator >=(UShortEnumeration<T>, float) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int)'></a>

## UShortEnumeration<T>.operator >=(UShortEnumeration<T>, int) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long)'></a>

## UShortEnumeration<T>.operator >=(UShortEnumeration<T>, long) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte)'></a>

## UShortEnumeration<T>.operator >=(UShortEnumeration<T>, sbyte) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short)'></a>

## UShortEnumeration<T>.operator >=(UShortEnumeration<T>, short) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint)'></a>

## UShortEnumeration<T>.operator >=(UShortEnumeration<T>, uint) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong)'></a>

## UShortEnumeration<T>.operator >=(UShortEnumeration<T>, ulong) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort)'></a>

## UShortEnumeration<T>.operator >=(UShortEnumeration<T>, ushort) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >=(decimal, UShortEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(decimal left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >=(double, UShortEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(double left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >=(float, UShortEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(float left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >=(int, UShortEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(int left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >=(long, UShortEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(long left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >=(sbyte, UShortEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(sbyte left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >=(short, UShortEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(short left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >=(uint, UShortEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(uint left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >=(ulong, UShortEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(ulong left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator >=(ushort, UShortEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(ushort left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicitdecimal(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.implicit operator decimal(UShortEnumeration<T>) Operator

Performs an implicit conversion from [UShortEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>') to [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal').

```csharp
public static decimal implicit operator decimal(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicitdecimal(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The enumeration.

#### Returns
[System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.implicit operator double(UShortEnumeration<T>) Operator

Performs an implicit conversion from [UShortEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>') to [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').

```csharp
public static double implicit operator double(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The enumeration.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicitfloat(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.implicit operator float(UShortEnumeration<T>) Operator

Performs an implicit conversion from [UShortEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>') to [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single').

```csharp
public static float implicit operator float(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicitfloat(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The enumeration.

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicitint(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.implicit operator int(UShortEnumeration<T>) Operator

Performs an implicit conversion from [UShortEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>') to [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32').

```csharp
public static int implicit operator int(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicitint(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The enumeration.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicitlong(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.implicit operator long(UShortEnumeration<T>) Operator

Performs an implicit conversion from [UShortEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>') to [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64').

```csharp
public static long implicit operator long(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicitlong(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The enumeration.

#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicituint(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.implicit operator uint(UShortEnumeration<T>) Operator

Performs an implicit conversion from [UShortEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>') to [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32').

```csharp
public static uint implicit operator uint(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicituint(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The enumeration.

#### Returns
[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicitulong(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.implicit operator ulong(UShortEnumeration<T>) Operator

Performs an implicit conversion from [UShortEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>') to [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64').

```csharp
public static ulong implicit operator ulong(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Implicitulong(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The enumeration.

#### Returns
[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator !=(byte, UShortEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(byte left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator !=(char, UShortEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(char left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte)'></a>

## UShortEnumeration<T>.operator !=(UShortEnumeration<T>, byte) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char)'></a>

## UShortEnumeration<T>.operator !=(UShortEnumeration<T>, char) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal)'></a>

## UShortEnumeration<T>.operator !=(UShortEnumeration<T>, decimal) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double)'></a>

## UShortEnumeration<T>.operator !=(UShortEnumeration<T>, double) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float)'></a>

## UShortEnumeration<T>.operator !=(UShortEnumeration<T>, float) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int)'></a>

## UShortEnumeration<T>.operator !=(UShortEnumeration<T>, int) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long)'></a>

## UShortEnumeration<T>.operator !=(UShortEnumeration<T>, long) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte)'></a>

## UShortEnumeration<T>.operator !=(UShortEnumeration<T>, sbyte) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short)'></a>

## UShortEnumeration<T>.operator !=(UShortEnumeration<T>, short) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint)'></a>

## UShortEnumeration<T>.operator !=(UShortEnumeration<T>, uint) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong)'></a>

## UShortEnumeration<T>.operator !=(UShortEnumeration<T>, ulong) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort)'></a>

## UShortEnumeration<T>.operator !=(UShortEnumeration<T>, ushort) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator !=(decimal, UShortEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(decimal left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator !=(double, UShortEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(double left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator !=(float, UShortEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(float left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator !=(int, UShortEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(int left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator !=(long, UShortEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(long left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator !=(sbyte, UShortEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(sbyte left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator !=(short, UShortEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(short left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator !=(uint, UShortEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(uint left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator !=(ulong, UShortEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(ulong left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator !=(ushort, UShortEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(ushort left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <(byte, UShortEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(byte left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <(char, UShortEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(char left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte)'></a>

## UShortEnumeration<T>.operator <(UShortEnumeration<T>, byte) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char)'></a>

## UShortEnumeration<T>.operator <(UShortEnumeration<T>, char) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal)'></a>

## UShortEnumeration<T>.operator <(UShortEnumeration<T>, decimal) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double)'></a>

## UShortEnumeration<T>.operator <(UShortEnumeration<T>, double) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float)'></a>

## UShortEnumeration<T>.operator <(UShortEnumeration<T>, float) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int)'></a>

## UShortEnumeration<T>.operator <(UShortEnumeration<T>, int) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long)'></a>

## UShortEnumeration<T>.operator <(UShortEnumeration<T>, long) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte)'></a>

## UShortEnumeration<T>.operator <(UShortEnumeration<T>, sbyte) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short)'></a>

## UShortEnumeration<T>.operator <(UShortEnumeration<T>, short) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint)'></a>

## UShortEnumeration<T>.operator <(UShortEnumeration<T>, uint) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong)'></a>

## UShortEnumeration<T>.operator <(UShortEnumeration<T>, ulong) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort)'></a>

## UShortEnumeration<T>.operator <(UShortEnumeration<T>, ushort) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <(decimal, UShortEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(decimal left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <(double, UShortEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(double left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <(float, UShortEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(float left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <(int, UShortEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(int left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <(long, UShortEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(long left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <(sbyte, UShortEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(sbyte left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <(short, UShortEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(short left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <(uint, UShortEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(uint left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <(ulong, UShortEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(ulong left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <(ushort, UShortEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(ushort left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <=(byte, UShortEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(byte left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <=(char, UShortEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(char left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte)'></a>

## UShortEnumeration<T>.operator <=(UShortEnumeration<T>, byte) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char)'></a>

## UShortEnumeration<T>.operator <=(UShortEnumeration<T>, char) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal)'></a>

## UShortEnumeration<T>.operator <=(UShortEnumeration<T>, decimal) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, decimal right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,decimal).right'></a>

`right` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double)'></a>

## UShortEnumeration<T>.operator <=(UShortEnumeration<T>, double) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float)'></a>

## UShortEnumeration<T>.operator <=(UShortEnumeration<T>, float) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, float right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,float).right'></a>

`right` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int)'></a>

## UShortEnumeration<T>.operator <=(UShortEnumeration<T>, int) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long)'></a>

## UShortEnumeration<T>.operator <=(UShortEnumeration<T>, long) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte)'></a>

## UShortEnumeration<T>.operator <=(UShortEnumeration<T>, sbyte) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short)'></a>

## UShortEnumeration<T>.operator <=(UShortEnumeration<T>, short) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint)'></a>

## UShortEnumeration<T>.operator <=(UShortEnumeration<T>, uint) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong)'></a>

## UShortEnumeration<T>.operator <=(UShortEnumeration<T>, ulong) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort)'></a>

## UShortEnumeration<T>.operator <=(UShortEnumeration<T>, ushort) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <=(decimal, UShortEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(decimal left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/System.Decimal 'System.Decimal')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(decimal,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <=(double, UShortEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(double left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <=(float, UShortEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(float left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(float,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <=(int, UShortEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(int left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(int,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <=(long, UShortEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(long left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <=(sbyte, UShortEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(sbyte left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <=(short, UShortEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(short left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <=(uint, UShortEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(uint left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <=(ulong, UShortEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(ulong left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_)'></a>

## UShortEnumeration<T>.operator <=(ushort, UShortEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(ushort left, CloudyWing.Enumeration.Abstractions.UShortEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.UShortEnumeration&lt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.UShortEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.UShortEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.