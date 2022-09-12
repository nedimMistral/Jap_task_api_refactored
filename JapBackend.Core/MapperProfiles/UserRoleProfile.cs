using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.User;
using JapBackend.Core.Requests.UserRole;

namespace JapBackend.Core.MapperProfiles
{
    public class UserRoleProfile : Profile
    {
        public UserRoleProfile()
        {
            CreateMap<UserRoleDto, UserRole>()
                         .ReverseMap();
        }
    }
}