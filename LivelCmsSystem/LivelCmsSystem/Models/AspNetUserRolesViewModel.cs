using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Models
{
    public partial class AspNetUserRolesViewModel
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual AspNetRolesViewModel Role { get; set; }
        public virtual AspNetUsersViewModel User { get; set; }
    }
}
