using System;
using System.Collections.Generic;

namespace AU.Shared.Models
{
    public partial class User
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Image { get; set; }
        public long? DarkTheme { get; set; }
        public long? Notifications { get; set; }
        public string? Password { get; set; }
    }
}
