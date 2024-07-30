using System;
using System.Collections.Generic;

namespace efcore_test.modules;

public partial class MediaUser
{
    public long Id { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime UpdateTime { get; set; }

    public int Status { get; set; }

    public long CoreUserId { get; set; }

    public string? AccountId { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }
}
