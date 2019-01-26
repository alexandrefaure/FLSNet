using AutoMapper;
using FlsCommon.DTO;
using FlsDAL;

namespace FlsBLL.Mapper
{
    public class UserDtoMapperProfile : Profile
    {
        public UserDtoMapperProfile()
        {
            CreateMap<global_users, UserDto>();
            CreateMap<UserDto, global_users>();
        }
    }
}
