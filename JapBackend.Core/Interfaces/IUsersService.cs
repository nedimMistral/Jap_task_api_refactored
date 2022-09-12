using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Common;
using JapBackend.Core.Requests.User;

namespace JapBackend.Core.Interfaces
{
    public interface IUsersService
    {
        Task<UserDto> GetUser(int id);
        Task<UserDto> InsertUser(UserInsertRequest insert);
        Task<UserDto> UpdateUser(int id, UserUpdateRequest update);
        Task<PagedResult<UserDto>> GetPage(UserSearchRequest search);
    }
}