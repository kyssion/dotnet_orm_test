using System;
using System.Collections.Generic;

namespace efcore_test.modules;

public partial class MediaResourceNovelLabel
{
    public long Id { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime UpdateTime { get; set; }

    public int Status { get; set; }

    public int? ResourceType { get; set; }

    public string? LabelName { get; set; }

    public string? LabeCategory { get; set; }
}
