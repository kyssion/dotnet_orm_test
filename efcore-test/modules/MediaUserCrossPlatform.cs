using System;
using System.Collections.Generic;

namespace efcore_test.modules;

public partial class MediaUserCrossPlatform
{
    public long Id { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime UpdateTime { get; set; }

    public int Status { get; set; }

    public long UserId { get; set; }

    public long CoreUserId { get; set; }

    public int? PlatformId { get; set; }

    public string? PlatformUserId { get; set; }

    public string? PlatformInformation { get; set; }
}
