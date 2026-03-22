# 入門指南

歡迎使用 Enumeration 函式庫。本指南將幫助您快速開始使用強類型列舉。

## 安裝

透過 NuGet 安裝套件：

```bash
dotnet add package CloudyWing.Enumeration
```

## 基本用法

定義一個自訂列舉類別：

```csharp
using CloudyWing.Enumeration;

public class Status : EnumerationBase<Status, int> {
  public static Status Active { get; } = new(1, "Active");
  public static Status Inactive { get; } = new(2, "Inactive");

  private Status(int value, string name) : base(value, name) { }
}
```

## 使用列舉

```csharp
// 取得所有列舉值
var allStatuses = Status.GetAll();

// 按值解析
var status = Status.Parse(1);  // Status.Active

// 按名稱解析
var status = Status.ParseName("Active");  // Status.Active

// 嘗試解析
if (Status.TryParse(1, out var status)) {
  // 使用 status
}
```

## 支援的值型別

Enumeration 支援以下基礎值型別：

- `int`
- `long`
- `short`
- `byte`
- `float`
- `double`
- `decimal`
- `char`
- 自訂的 `IComparable` 型別。

## 下一步

請查看 [核心概念](core-concepts.md) 了解更多詳細資訊。
