﻿using System;
using System.Collections.Generic;

namespace AU.Server.Models
{
    public partial class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Image { get; set; }
        public long? DarkTheme { get; set; }
        public long? Notifications { get; set; }
    }
}
