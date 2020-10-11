using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Models
{
    public partial class AspNetUserTokensViewModel
    {
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual AspNetUsersViewModel User { get; set; }
    }
}
