using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.Role;

namespace JapBackend.Core.MapperProfiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleDto, Role>()
                .ReverseMap();
        }
    }
}