# Changelog

## v0.3.0 (2026-11-09)

### Breaking Changes

- `EnumerationBase<TEnum, TValue>.GetAll()` 改為每次回傳同一個延遲探索的唯讀集合。呼叫 `GetAll()` 本身不再探索成員，首次讀取該集合或呼叫需要成員資料的查找方法時才探索。
- 成員探索遇到宣告為非 nullable 的成員屬性值為 `null` 時，改為擲出說明型別 static 初始化順序問題的 `InvalidOperationException`。失敗的探索結果不寫入快取，型別初始化完成後可重新探索；宣告為 nullable 的屬性回傳 `null` 時維持略過。
- 列舉的 `GetHashCode()` 改為使用 `Value` 的雜湊值，與 `Equals()` 接受 `Value` 的比對行為一致。
- `EnumerationExtensions.ContainsValue()` 與 `TryGetName()` 改以 `EqualityComparer<TValue>.Default` 比對 `Value`。
- Fluent switch 在前段分支已執行後，後續分支延遲求值的條件委派不再執行，行為比照 `if` / `else if`。直接傳入的 `bool` 表達式與集合多載的成員比對仍可能先求值。

### New Features

- 新增 `CloudyWing.Enumeration.Json` 套件，提供 System.Text.Json 的 `EnumerationJsonConverter<TEnum, TValue>` 與 `EnumerationJsonConverterFactory`。預設以 `Value` 序列化，可透過 `EnumerationJsonFormat.Name` 改為以名稱序列化，並支援作為字典鍵。找不到對應成員時擲出 `JsonException`。目標框架為 `netstandard2.0` 與 `net10.0`，`netstandard2.0` 目標相依 `System.Text.Json` 10.0.8。
- 新增 `CloudyWing.Enumeration.Analyzers` 套件，提供下列 Roslyn 分析器規則，三項預設啟用且嚴重度為 Warning，並登錄於 `AnalyzerReleases.Shipped.md` 的 0.3.0 版本。套件為僅供開發階段使用的 opt-in 套件，目標框架為 `netstandard2.0`，需要 Roslyn 4.8 以上的編譯器（Visual Studio 2022 17.8 或 .NET SDK 8.0.100 以上）。
  - `ENUM001`：偵測以常數引數建立的成員有重複的 `Value`。
  - `ENUM002`：偵測以常數引數建立的成員有重複的名稱。
  - `ENUM003`：偵測非抽象列舉宣告 public 建構子。
- 新增 `EnumerationIgnoreAttribute`，標註的屬性（如別名或輔助屬性）不參與成員探索。
- 新增 `EnumerationBase<TEnum, TValue>.GetCount()` 與 `GetAllAsReadOnly()`，直接使用快取的成員集合。
- `net10.0` 新增接受 `ReadOnlySpan<char>` 的 `TryParseName()` 多載，含與不含 `ignoreCase` 兩種，查找時不需配置字串。
- `net10.0` 的列舉基底類別實作 `IParsable<TEnum>` 與 `ISpanParsable<TEnum>`，以明確介面實作提供，先以 Ordinal 比對名稱，再依格式提供者將文字轉換為 `Value` 比對。
- 新增 `EnumerationTypeConverter<TEnum, TValue>`，支援 model binding 與設定繫結。可由名稱、`Value` 或 `Value` 文字轉換為列舉，轉換為字串時回傳名稱。透過 `EnumerationTypeConverter.Register<TEnum, TValue>()` 以 `TypeDescriptor` 註冊，不需修改既有列舉型別。
- `net10.0` 目標啟用 AOT 相容性分析，並為成員探索相關的型別參數與擴充方法加上 trimming 標註。`EnumerationJsonConverterFactory` 的建構子標註 `RequiresDynamicCode` 與 `RequiresUnreferencedCode`，trimming 或 Native AOT 情境建議改用逐型別的 `EnumerationJsonConverter<TEnum, TValue>`。

### Bug Fixes

- 修正別名屬性（回傳同一實例的屬性）使 `GetAll()` 重複回傳成員，並使 `Parse` 擲出例外的問題。探索成員時改以參考相等去重並保留第一次宣告的順序，同時略過不可讀取與具索引參數的 static 屬性。
- 修正列舉基底類別未標示 `Serializable`，導致標示 `Serializable` 的列舉衍生類別無法序列化的問題。反序列化時改為回傳已宣告的實例，維持參考相等。
- 修正數值 Enumeration 與 `null` 比較時拋出 `NullReferenceException` 的問題。`==` 與比較運算子回傳 `false`，`!=` 回傳 `true`。
- 修正 `IConvertible.ToType()` 忽略格式提供者的問題，並支援轉換為列舉型別本身或其列舉基底類別。
- 修正 `Month` 與 `WeekDay` 的加減運算子在位移量接近 `int` 上下限時發生溢位的問題。

### Improvements

- 成員查找改用初始化時建立的快取字典，取代每次線性搜尋已宣告成員。`Value` 或名稱有多個相符成員時仍擲出 `InvalidOperationException`。
- 明確轉換改用與 `Parse` 相同的查找，查無對應值時擲出 `InvalidCastException`，重複值時擲出 `InvalidOperationException`，並補上相關 XML 文件說明。

### Documentation

- 補寫核心概念與進階用法文章，並修正 README 範例。
- 補齊 `CloudyWing.Enumeration.Json` 與 `CloudyWing.Enumeration.Analyzers` 的套件說明，並修正成員探索與比較行為的描述。

### Build / CI

- 新增共用建置設定。啟用 symbols 套件（`snupkg`）、儲存庫 URL 與嵌入未追蹤來源的設定，並以 0.2.0 為基準啟用 PackageValidation 與公開 API 分析器，`PublicAPI.Shipped.txt` 記錄 v0.2.0 的公開 API。同時修正 Calendars 套件描述沿用核心套件的問題。
- CI 改用 devops-templates 的 `reusable-dotnet-ci`，在 Windows 與 Ubuntu 執行建置、測試與打包。發版驗證補裝 .NET 8 SDK，並與 CI 一致以 `-warnaserror` 建置。
- 發佈改為 push 版本標籤時驗證、建立 GitHub Release，並以 Trusted Publishing 發佈 NuGet，不再需要 API Key。發佈前會檢查 nupkg 版號與標籤一致。
- 文件網站改以 GitHub Pages artifact 部署。
- 新增 Dependabot 設定。

## v0.2.0 (2026-03-21)

### New Features

- 新增 `EnumerationBase<TEnum, TValue>` 的查找與探索輔助方法，支援取得已宣告的名稱與值、檢查名稱或值是否已定義，以及提供備援列舉實例。
- 新增 `EnumerationExtensions` 的集合輔助方法，支援名稱檢查、從現有序列解析名稱與值，以及依值或名稱建立字典。
- 擴充 README 與 DocFX 文件，補充新增 API 的實際使用範例。
- 改善 public 查找與探索成員的英文 XML 文件。
