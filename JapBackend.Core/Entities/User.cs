using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities.Base;
using Microsoft.AspNetCore.Identity;

namespace JapBackend.Core.Entities
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? CreatedById { get; set; }
        public User? CreatedBy { get; set; }
        public int? ModifiedById { get; set; }
        public User? ModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }

    }
}