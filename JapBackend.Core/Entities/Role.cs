using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace JapBackend.Core.Entities
{
    public class Role : IdentityRole<int>
    { 
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}