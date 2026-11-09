---
_layout: landing
---

# Enumeration

Enumeration 是一個提供強類型列舉模式的函式庫，允許建立型別安全的列舉，支援多種基礎值型別和靈活的解析方法。

## 文檔導航

### 使用指南

- [入門指南](articles/getting-started.md)
- [核心概念](articles/core-concepts.md)
- [查找與探索](articles/lookup-and-discovery.md)
- [進階用法](articles/advanced-usage.md)

### 套件

| 套件 | 說明 |
| --- | --- |
| `CloudyWing.Enumeration` | 列舉基底類別、查找 API、Fluent 條件判斷與 `TypeConverter`。 |
| `CloudyWing.Enumeration.Calendars` | 月份（`Month`）與星期（`WeekDay`）列舉，支援循環位移運算，見 [進階用法](articles/advanced-usage.md)。 |
| `CloudyWing.Enumeration.Json` | System.Text.Json 轉換器，安裝與範例見 [進階用法](articles/advanced-usage.md#systemtextjson)。 |
| `CloudyWing.Enumeration.Analyzers` | 偵測重複 Value、重複 Name 與 public 建構子的 Analyzer，規則與編譯器需求見 [進階用法](articles/advanced-usage.md#analyzer)。 |

各套件的目標框架與 `dotnet add package` 安裝命令，請參考 [進階用法](articles/advanced-usage.md)。

## License

This project is MIT [licensed](https://github.com/CloudyWing/Enumeration/blob/main/LICENSE.md).
