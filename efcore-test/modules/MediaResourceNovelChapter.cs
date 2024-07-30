using System;
using System.Collections.Generic;

namespace efcore_test.modules;

public partial class MediaResourceNovelChapter
{
    public long Id { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime UpdateTime { get; set; }

    public long? ResourceId { get; set; }

    public long? NovelId { get; set; }

    public int? ChapterNo { get; set; }

    public string? ChapterSummary { get; set; }

    public string? ChapterTitle { get; set; }

    public string? Content { get; set; }
}
