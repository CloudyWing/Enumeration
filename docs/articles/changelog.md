# Changelog

## Unreleased

### Added

- Added lookup and discovery APIs on `EnumerationBase<TEnum, TValue>`, including `GetValues()`, `GetNames()`, `ParseOrDefault()`, `ParseNameOrDefault()`, `IsDefined()`, and `IsDefinedName()`.
- Added collection lookup helpers on `EnumerationExtensions`, including `ContainsName()`, `TryGetValue()`, `TryGetName()`, and `ToNameValueDictionary()`.

### Documentation

- Expanded README examples for lookup, discovery, and collection conversion scenarios.
- Added DocFX articles for the new lookup/discovery workflow and surfaced the changelog in the site navigation.
- Improved English XML documentation around the new additive APIs and related public members.
