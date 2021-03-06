using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GGroupp.Infra;

public sealed record class DataverseSearchOut
{
    public DataverseSearchOut(
        int totalRecordCount,
        [AllowNull] IReadOnlyCollection<DataverseSearchItem> value)
    {
        TotalRecordCount = totalRecordCount;
        Value = value ?? Array.Empty<DataverseSearchItem>();
    }

    public int TotalRecordCount { get; }

    public IReadOnlyCollection<DataverseSearchItem> Value { get; }
}