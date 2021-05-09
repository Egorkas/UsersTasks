using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSheduler.BusinessLayer.DTO;
using TaskSheduler.DataAccess.Entities;

namespace TaskSheduler.BusinessLayer.Mapping
{
    class UserTaskMapperProfile : Profile
    {
        public UserTaskMapperProfile()
        {
            CreateMap<UserTask, UserTaskDTO>()
                .ForMember(dst => dst.Status, opts => opts.MapFrom(src => src.Status.ToString()))
                .ReverseMap();
        }
    }
}
