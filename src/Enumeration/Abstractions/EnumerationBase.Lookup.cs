using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CloudyWing.Enumeration.Abstractions {
    public abstract partial class EnumerationBase<TEnum, TValue> {
        /// <summary>
        /// 保存已探索成員與 Value、Name 查找表的快取。
        /// </summary>
        /// <remarks>
        /// 字典的值為 <see langword="null" /> 時代表該鍵對應到多個成員，查找時拋出例外以維持重複即失敗的行為。
        /// </remarks>
        private sealed class EnumerationLookup {
#pragma warning disable CS8714 // TValue 可能為 null 的情況由 nullValueMember 另外處理，不會以 null 作為字典鍵
            private readonly Dictionary<TValue, TEnum?> valueMap;
#pragma warning restore CS8714
            private readonly Dictionary<string, TEnum?> nameMap;
            private readonly Dictionary<string, TEnum?> ignoreCaseNameMap;
#if NET9_0_OR_GREATER
            private readonly Dictionary<string, TEnum?>.AlternateLookup<ReadOnlySpan<char>> spanNameMap;
            private readonly Dictionary<string, TEnum?>.AlternateLookup<ReadOnlySpan<char>> ignoreCaseSpanNameMap;
#endif
            private readonly bool hasNullValueMember;
            private readonly TEnum? nullValueMember;

            public EnumerationLookup(TEnum[] members) {
                Members = members;
                ReadOnlyMembers = new ReadOnlyCollection<TEnum>(members);
#pragma warning disable CS8714
                valueMap = new Dictionary<TValue, TEnum?>(members.Length, EqualityComparer<TValue>.Default);
#pragma warning restore CS8714
                nameMap = new Dictionary<string, TEnum?>(members.Length, StringComparer.Ordinal);
                ignoreCaseNameMap = new Dictionary<string, TEnum?>(members.Length, StringComparer.OrdinalIgnoreCase);

                foreach (TEnum member in members) {
                    if (member.Value is null) {
                        nullValueMember = hasNullValueMember ? null : member;
                        hasNullValueMember = true;
                    } else {
                        AddOrMarkDuplicate(valueMap, member.Value, member);
                    }

                    // Name 宣告為不可為 null，但未啟用 NRT 的衍生類別仍可能傳入 null
                    if (member.Name is not null) {
                        AddOrMarkDuplicate(nameMap, member.Name, member);
                        AddOrMarkDuplicate(ignoreCaseNameMap, member.Name, member);
                    }
                }

#if NET9_0_OR_GREATER
                spanNameMap = nameMap.GetAlternateLookup<ReadOnlySpan<char>>();
                ignoreCaseSpanNameMap = ignoreCaseNameMap.GetAlternateLookup<ReadOnlySpan<char>>();
#endif
            }

            public TEnum[] Members { get; }

            public ReadOnlyCollection<TEnum> ReadOnlyMembers { get; }

            public bool TryGetByValue(TValue value, out TEnum member) {
                if (value is null) {
                    return Resolve(hasNullValueMember, nullValueMember, "value", out member);
                }

                bool isFound = valueMap.TryGetValue(value, out TEnum? candidate);
                return Resolve(isFound, candidate, "value", out member);
            }

            public bool TryGetByName(string? name, bool ignoreCase, out TEnum member) {
                if (name is null) {
                    member = null!;
                    return false;
                }

                Dictionary<string, TEnum?> map = ignoreCase ? ignoreCaseNameMap : nameMap;
                bool isFound = map.TryGetValue(name, out TEnum? candidate);
                return Resolve(isFound, candidate, "name", out member);
            }

#if NET9_0_OR_GREATER
            public bool TryGetByName(ReadOnlySpan<char> name, bool ignoreCase, out TEnum member) {
                bool isFound = ignoreCase
                    ? ignoreCaseSpanNameMap.TryGetValue(name, out TEnum? candidate)
                    : spanNameMap.TryGetValue(name, out candidate);
                return Resolve(isFound, candidate, "name", out member);
            }
#endif

            private static void AddOrMarkDuplicate<TKey>(Dictionary<TKey, TEnum?> map, TKey key, TEnum member)
                where TKey : notnull {
                map[key] = map.ContainsKey(key) ? null : member;
            }

            private static bool Resolve(bool isFound, TEnum? candidate, string keyKind, out TEnum member) {
                if (!isFound) {
                    // 呼叫端以 [MaybeNullWhen(false)] 對外宣告查無結果時為 null
                    member = null!;
                    return false;
                }

                member = candidate ?? throw new InvalidOperationException(
                    $"More than one declared enumeration of '{typeof(TEnum).FullName}' matches the specified {keyKind}."
                );
                return true;
            }
        }

        /// <summary>
        /// 延後到第一次讀取時才探索成員的唯讀集合，讓 <see cref="GetAll" /> 回傳同一個快取實例。
        /// </summary>
        private sealed class DeferredMemberList : IReadOnlyList<TEnum>, ICollection<TEnum> {
            public int Count => GetLookup().Members.Length;

            public bool IsReadOnly => true;

            public TEnum this[int index] => GetLookup().Members[index];

            public IEnumerator<TEnum> GetEnumerator() {
                return ((IEnumerable<TEnum>)GetLookup().Members).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator() {
                return GetEnumerator();
            }

            public bool Contains(TEnum item) {
                return Array.IndexOf(GetLookup().Members, item) >= 0;
            }

            public void CopyTo(TEnum[] array, int arrayIndex) {
                GetLookup().Members.CopyTo(array, arrayIndex);
            }

            void ICollection<TEnum>.Add(TEnum item) {
                throw new NotSupportedException("The collection is read-only.");
            }

            void ICollection<TEnum>.Clear() {
                throw new NotSupportedException("The collection is read-only.");
            }

            bool ICollection<TEnum>.Remove(TEnum item) {
                throw new NotSupportedException("The collection is read-only.");
            }
        }
    }
}
