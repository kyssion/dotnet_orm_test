using System;
using System.Collections.Generic;

namespace efcore_test.modules;

public partial class UserLoginHistory
{
    public long Id { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime UpdateTime { get; set; }

    public int Status { get; set; }

    public long UserId { get; set; }

    public long CoreUserId { get; set; }

    public DateTime? LoginTime { get; set; }

    public string? LoginIpv4 { get; set; }

    public string? LoginIpv6 { get; set; }

    public int? LoginType { get; set; }

    public string? DeviceInfo { get; set; }

    public int? Os { get; set; }

    public float? Latitude { get; set; }

    public float? Longitude { get; set; }
}
