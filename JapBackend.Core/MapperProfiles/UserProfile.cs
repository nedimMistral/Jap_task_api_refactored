using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.User;

namespace JapBackend.Core.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserInsertRequest, User>()
                .ForMember(x => x.UserName, opt => opt.MapFrom(o => o.Email));

            CreateMap<UserUpdateRequest, User>();
            CreateMap<UserDto, User>()
                .ReverseMap();
        }
    }
}