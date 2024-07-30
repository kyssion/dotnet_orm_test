using System;
using System.Collections.Generic;

namespace efcore_test.modules;

public partial class MediaResourceNovel
{
    public long Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int? Status { get; set; }

    public string? Name { get; set; }

    public string? Author { get; set; }

    public string? PublicationInformation { get; set; }

    public string? ContentSummary { get; set; }

    public int? Language { get; set; }

    public int? WordCount { get; set; }

    public string? CoverImage { get; set; }

    public string? Category { get; set; }

    public string? Label { get; set; }
}
