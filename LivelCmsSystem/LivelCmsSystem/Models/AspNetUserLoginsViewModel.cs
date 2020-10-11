using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Models
{
    public partial class AspNetUserLoginsViewModel
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsersViewModel User { get; set; }
    }
}
