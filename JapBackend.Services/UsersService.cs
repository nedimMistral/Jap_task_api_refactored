using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Common;
using JapBackend.Core.Entities;
using JapBackend.Core.Interfaces;
using JapBackend.Core.Interfaces.Repositories;
using JapBackend.Core.Requests.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace JapBackend.Services
{
    public class UsersService : IUsersService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IUserRepository _userRepository;

        public UsersService(IHttpContextAccessor httpContextAccessor,
                            UserManager<User> userManager,
                            RoleManager<Role> roleManager,
                            IMapper mapper,
                            IUserRepository userRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _roleManager = roleManager;
            _userRepository = userRepository;
        }

        public Task<PagedResult<UserDto>> GetPage(UserSearchRequest search)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> InsertUser(UserInsertRequest insert)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> UpdateUser(int id, UserUpdateRequest update)
        {
            throw new NotImplementedException();
        }
    }
}