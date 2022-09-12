using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.User;

namespace JapBackend.Core.Interfaces.Repositories
{
    public interface IUserRepository : IAsyncRepository<User, UserSearchRequest, UserInsertRequest, UserUpdateRequest, UserDto>
    {
    }
}