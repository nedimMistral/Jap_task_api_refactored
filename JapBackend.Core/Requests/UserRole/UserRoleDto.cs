using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Requests.Role;
using JapBackend.Core.Requests.User;

namespace JapBackend.Core.Requests.UserRole
{
    public class UserRoleDto
    {
        public UserDto User { get; set; }
        public RoleDto Role { get; set; }
    }
}