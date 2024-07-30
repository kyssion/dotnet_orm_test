using System;
using System.Collections.Generic;

namespace efcore_test.modules;

public partial class MediaUserPersonalise
{
    public long Id { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime UpdateTime { get; set; }

    public int Status { get; set; }

    public long UserId { get; set; }

    public long CoreUserId { get; set; }

    public int? Gender { get; set; }

    public DateOnly? Birthday { get; set; }

    public int? Language { get; set; }

    public int? Region { get; set; }

    public string? Introduction { get; set; }

    public string? Portrait { get; set; }
}
