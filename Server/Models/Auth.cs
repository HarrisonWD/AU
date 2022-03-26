using System;
using System.Collections.Generic;

namespace AU.Server.Models
{
    public partial class Auth
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? Admin { get; set; }
    }
}
