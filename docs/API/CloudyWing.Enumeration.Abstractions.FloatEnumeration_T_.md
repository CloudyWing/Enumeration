#### [CloudyWing.Enumeration](index.md 'index')
### [CloudyWing.Enumeration.Abstractions](CloudyWing.Enumeration.Abstractions.md 'CloudyWing.Enumeration.Abstractions')

## FloatEnumeration<T> Class

The float enumeration base.

```csharp
public abstract class FloatEnumeration<T> : CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<T, float>
    where T : CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>
```
#### Type parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T'></a>

`T`

The float enumeration.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CloudyWing.Enumeration.Abstractions.EnumerationBase&lt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](CloudyWing.Enumeration.Abstractions.EnumerationBase_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.EnumerationBase<TEnum,TValue>') &#129106; [CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration&lt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[,](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration_TEnum,TValue_.md 'CloudyWing.Enumeration.Abstractions.ConvertibleEnumeration<TEnum,TValue>') &#129106; FloatEnumeration<T>
### Constructors

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.FloatEnumeration(float)'></a>

## FloatEnumeration(float) Constructor

Initializes a new instance of the [FloatEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>') class.

```csharp
protected FloatEnumeration(float value);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.FloatEnumeration(float).value'></a>

`value` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The value.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.FloatEnumeration(float,string)'></a>

## FloatEnumeration(float, string) Constructor

Initializes a new instance of the [FloatEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>') class.

```csharp
protected FloatEnumeration(float value, string name);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.FloatEnumeration(float,string).value'></a>

`value` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The value.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.FloatEnumeration(float,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name.
### Methods

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.Equals(object)'></a>

## FloatEnumeration<T>.Equals(object) Method

Determines whether the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object'), is equal to this instance.

```csharp
public override bool Equals(object obj);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.Equals(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') to compare with this instance.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if the specified [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') is equal to this instance; otherwise, `false`.
### Operators

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator ==(byte, FloatEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(byte left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator ==(char, FloatEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(char left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte)'></a>

## FloatEnumeration<T>.operator ==(FloatEnumeration<T>, byte) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char)'></a>

## FloatEnumeration<T>.operator ==(FloatEnumeration<T>, char) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double)'></a>

## FloatEnumeration<T>.operator ==(FloatEnumeration<T>, double) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int)'></a>

## FloatEnumeration<T>.operator ==(FloatEnumeration<T>, int) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long)'></a>

## FloatEnumeration<T>.operator ==(FloatEnumeration<T>, long) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte)'></a>

## FloatEnumeration<T>.operator ==(FloatEnumeration<T>, sbyte) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short)'></a>

## FloatEnumeration<T>.operator ==(FloatEnumeration<T>, short) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint)'></a>

## FloatEnumeration<T>.operator ==(FloatEnumeration<T>, uint) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong)'></a>

## FloatEnumeration<T>.operator ==(FloatEnumeration<T>, ulong) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort)'></a>

## FloatEnumeration<T>.operator ==(FloatEnumeration<T>, ushort) Operator

Implements the operator ==.

```csharp
public static bool operator ==(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator ==(double, FloatEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(double left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator ==(int, FloatEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(int left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator ==(long, FloatEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(long left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator ==(sbyte, FloatEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(sbyte left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator ==(short, FloatEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(short left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator ==(uint, FloatEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(uint left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator ==(ulong, FloatEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(ulong left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator ==(ushort, FloatEnumeration<T>) Operator

Implements the operator ==.

```csharp
public static bool operator ==(ushort left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Equality(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >(byte, FloatEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(byte left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >(char, FloatEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(char left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte)'></a>

## FloatEnumeration<T>.operator >(FloatEnumeration<T>, byte) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char)'></a>

## FloatEnumeration<T>.operator >(FloatEnumeration<T>, char) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double)'></a>

## FloatEnumeration<T>.operator >(FloatEnumeration<T>, double) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int)'></a>

## FloatEnumeration<T>.operator >(FloatEnumeration<T>, int) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long)'></a>

## FloatEnumeration<T>.operator >(FloatEnumeration<T>, long) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte)'></a>

## FloatEnumeration<T>.operator >(FloatEnumeration<T>, sbyte) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short)'></a>

## FloatEnumeration<T>.operator >(FloatEnumeration<T>, short) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint)'></a>

## FloatEnumeration<T>.operator >(FloatEnumeration<T>, uint) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong)'></a>

## FloatEnumeration<T>.operator >(FloatEnumeration<T>, ulong) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort)'></a>

## FloatEnumeration<T>.operator >(FloatEnumeration<T>, ushort) Operator

Implements the operator >.

```csharp
public static bool operator >(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >(double, FloatEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(double left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >(int, FloatEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(int left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >(long, FloatEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(long left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >(sbyte, FloatEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(sbyte left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >(short, FloatEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(short left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >(uint, FloatEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(uint left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >(ulong, FloatEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(ulong left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >(ushort, FloatEnumeration<T>) Operator

Implements the operator >.

```csharp
public static bool operator >(ushort left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThan(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >=(byte, FloatEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(byte left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >=(char, FloatEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(char left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte)'></a>

## FloatEnumeration<T>.operator >=(FloatEnumeration<T>, byte) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char)'></a>

## FloatEnumeration<T>.operator >=(FloatEnumeration<T>, char) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double)'></a>

## FloatEnumeration<T>.operator >=(FloatEnumeration<T>, double) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int)'></a>

## FloatEnumeration<T>.operator >=(FloatEnumeration<T>, int) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long)'></a>

## FloatEnumeration<T>.operator >=(FloatEnumeration<T>, long) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte)'></a>

## FloatEnumeration<T>.operator >=(FloatEnumeration<T>, sbyte) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short)'></a>

## FloatEnumeration<T>.operator >=(FloatEnumeration<T>, short) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint)'></a>

## FloatEnumeration<T>.operator >=(FloatEnumeration<T>, uint) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong)'></a>

## FloatEnumeration<T>.operator >=(FloatEnumeration<T>, ulong) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort)'></a>

## FloatEnumeration<T>.operator >=(FloatEnumeration<T>, ushort) Operator

Implements the operator >=.

```csharp
public static bool operator >=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >=(double, FloatEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(double left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >=(int, FloatEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(int left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >=(long, FloatEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(long left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >=(sbyte, FloatEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(sbyte left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >=(short, FloatEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(short left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >=(uint, FloatEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(uint left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >=(ulong, FloatEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(ulong left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator >=(ushort, FloatEnumeration<T>) Operator

Implements the operator >=.

```csharp
public static bool operator >=(ushort left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_GreaterThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.implicit operator double(FloatEnumeration<T>) Operator

Performs an implicit conversion from [FloatEnumeration&lt;T&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>') to [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').

```csharp
public static double implicit operator double(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> enumeration);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Implicitdouble(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).enumeration'></a>

`enumeration` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The enumeration.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The result of the conversion.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator !=(byte, FloatEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(byte left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator !=(char, FloatEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(char left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte)'></a>

## FloatEnumeration<T>.operator !=(FloatEnumeration<T>, byte) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char)'></a>

## FloatEnumeration<T>.operator !=(FloatEnumeration<T>, char) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double)'></a>

## FloatEnumeration<T>.operator !=(FloatEnumeration<T>, double) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int)'></a>

## FloatEnumeration<T>.operator !=(FloatEnumeration<T>, int) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long)'></a>

## FloatEnumeration<T>.operator !=(FloatEnumeration<T>, long) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte)'></a>

## FloatEnumeration<T>.operator !=(FloatEnumeration<T>, sbyte) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short)'></a>

## FloatEnumeration<T>.operator !=(FloatEnumeration<T>, short) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint)'></a>

## FloatEnumeration<T>.operator !=(FloatEnumeration<T>, uint) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong)'></a>

## FloatEnumeration<T>.operator !=(FloatEnumeration<T>, ulong) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort)'></a>

## FloatEnumeration<T>.operator !=(FloatEnumeration<T>, ushort) Operator

Implements the operator !=.

```csharp
public static bool operator !=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator !=(double, FloatEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(double left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator !=(int, FloatEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(int left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator !=(long, FloatEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(long left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator !=(sbyte, FloatEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(sbyte left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator !=(short, FloatEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(short left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator !=(uint, FloatEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(uint left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator !=(ulong, FloatEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(ulong left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator !=(ushort, FloatEnumeration<T>) Operator

Implements the operator !=.

```csharp
public static bool operator !=(ushort left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_Inequality(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <(byte, FloatEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(byte left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <(char, FloatEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(char left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte)'></a>

## FloatEnumeration<T>.operator <(FloatEnumeration<T>, byte) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char)'></a>

## FloatEnumeration<T>.operator <(FloatEnumeration<T>, char) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double)'></a>

## FloatEnumeration<T>.operator <(FloatEnumeration<T>, double) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int)'></a>

## FloatEnumeration<T>.operator <(FloatEnumeration<T>, int) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long)'></a>

## FloatEnumeration<T>.operator <(FloatEnumeration<T>, long) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte)'></a>

## FloatEnumeration<T>.operator <(FloatEnumeration<T>, sbyte) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short)'></a>

## FloatEnumeration<T>.operator <(FloatEnumeration<T>, short) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint)'></a>

## FloatEnumeration<T>.operator <(FloatEnumeration<T>, uint) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong)'></a>

## FloatEnumeration<T>.operator <(FloatEnumeration<T>, ulong) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort)'></a>

## FloatEnumeration<T>.operator <(FloatEnumeration<T>, ushort) Operator

Implements the operator <.

```csharp
public static bool operator <(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <(double, FloatEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(double left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <(int, FloatEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(int left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <(long, FloatEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(long left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <(sbyte, FloatEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(sbyte left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <(short, FloatEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(short left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <(uint, FloatEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(uint left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <(ulong, FloatEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(ulong left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <(ushort, FloatEnumeration<T>) Operator

Implements the operator <.

```csharp
public static bool operator <(ushort left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThan(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <=(byte, FloatEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(byte left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(byte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <=(char, FloatEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(char left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(char,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte)'></a>

## FloatEnumeration<T>.operator <=(FloatEnumeration<T>, byte) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, byte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,byte).right'></a>

`right` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char)'></a>

## FloatEnumeration<T>.operator <=(FloatEnumeration<T>, char) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, char right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,char).right'></a>

`right` [System.Char](https://docs.microsoft.com/en-us/dotnet/api/System.Char 'System.Char')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double)'></a>

## FloatEnumeration<T>.operator <=(FloatEnumeration<T>, double) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, double right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,double).right'></a>

`right` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int)'></a>

## FloatEnumeration<T>.operator <=(FloatEnumeration<T>, int) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, int right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,int).right'></a>

`right` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long)'></a>

## FloatEnumeration<T>.operator <=(FloatEnumeration<T>, long) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, long right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,long).right'></a>

`right` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte)'></a>

## FloatEnumeration<T>.operator <=(FloatEnumeration<T>, sbyte) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, sbyte right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,sbyte).right'></a>

`right` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short)'></a>

## FloatEnumeration<T>.operator <=(FloatEnumeration<T>, short) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, short right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,short).right'></a>

`right` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint)'></a>

## FloatEnumeration<T>.operator <=(FloatEnumeration<T>, uint) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, uint right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,uint).right'></a>

`right` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong)'></a>

## FloatEnumeration<T>.operator <=(FloatEnumeration<T>, ulong) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, ulong right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ulong).right'></a>

`right` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort)'></a>

## FloatEnumeration<T>.operator <=(FloatEnumeration<T>, ushort) Operator

Implements the operator <=.

```csharp
public static bool operator <=(CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> left, ushort right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort).left'></a>

`left` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_,ushort).right'></a>

`right` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <=(double, FloatEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(double left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(double,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <=(int, FloatEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(int left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(int,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <=(long, FloatEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(long left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(long,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <=(sbyte, FloatEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(sbyte left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(sbyte,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <=(short, FloatEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(short left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(short,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <=(uint, FloatEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(uint left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(uint,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <=(ulong, FloatEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(ulong left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(ulong,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_)'></a>

## FloatEnumeration<T>.operator <=(ushort, FloatEnumeration<T>) Operator

Implements the operator <=.

```csharp
public static bool operator <=(ushort left, CloudyWing.Enumeration.Abstractions.FloatEnumeration<T> right);
```
#### Parameters

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).left'></a>

`left` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The left.

<a name='CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.op_LessThanOrEqual(ushort,CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_).right'></a>

`right` [CloudyWing.Enumeration.Abstractions.FloatEnumeration&lt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')[T](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md#CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.T 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>.T')[&gt;](CloudyWing.Enumeration.Abstractions.FloatEnumeration_T_.md 'CloudyWing.Enumeration.Abstractions.FloatEnumeration<T>')

The right.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the operator.