using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSheduler.BusinessLayer.Mapping
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<User, UserDTO>()
            .ForMember(dst => dst.Name, opts => opts.MapFrom(src => src.FirstName + " " + src.SecondName))
            .ForMember(dst => dst.Rule, opts => opts.MapFrom(src => src.Rule));
                //.ReverseMap()
                //.ForMember(dst => dst.)
        }
    }
}
