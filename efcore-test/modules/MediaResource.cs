using System;
using System.Collections.Generic;

namespace efcore_test.modules;

public partial class MediaResource
{
    public long Id { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime UpdateTime { get; set; }

    public int? Status { get; set; }

    public long? ResouceId { get; set; }

    public string? ResourceName { get; set; }

    public string? ResourceDescription { get; set; }

    public int? ResourceType { get; set; }

    public int? ResouceProvider { get; set; }
}
