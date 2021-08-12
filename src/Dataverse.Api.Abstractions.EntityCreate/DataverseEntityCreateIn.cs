#nullable enable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GGroupp.Infra
{
    public sealed record DataverseEntityCreateIn<TRequestJson>
    {
        public DataverseEntityCreateIn(
            [AllowNull] string entityPluralName,
            [AllowNull] IReadOnlyCollection<string> selectFields,
            TRequestJson entityData)
        {
            EntityPluralName = entityPluralName ?? string.Empty;
            SelectFields = selectFields ?? Array.Empty<string>();
            EntityData = entityData;
        }

        public string EntityPluralName { get; }

        public IReadOnlyCollection<string> SelectFields { get; }

        public TRequestJson EntityData { get; }
    }
}