using System;
using System.Collections.Generic;

namespace LivelCMSSystem.Models
{
    public partial class AspNetRoleClaimsViewModel
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AspNetRolesViewModel Role { get; set; }
    }
}
