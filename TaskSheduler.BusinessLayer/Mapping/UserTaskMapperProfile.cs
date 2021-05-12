using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSheduler.BusinessLayer.DTO;
using TaskSheduler.DataAccess.Entities;
using TaskSheduler.DataAccess.Entities.Enum;

namespace TaskSheduler.BusinessLayer.Mapping
{
    public class UserTaskMapperProfile : Profile
    {
        private const string ActiveTaskMessage = "Активная задача";
        private const string DoneTaskMessage = "Завершённая задача";
        private const string DeadLineTaskMessage = "Не успел";
        public UserTaskMapperProfile()
        {
            CreateMap<UserTask, UserTaskDTO>()
                .ForMember(dst => dst.Status, opts => opts.MapFrom(src => MapIntToString(src.Status)))
                .ReverseMap()
                .ForMember(dst => dst.Status, opts => opts.MapFrom(src => MapStringToInt(src.Status)));
        }

        public string MapIntToString(StatusTask state)
        {
            if (state == StatusTask.Active)
                return ActiveTaskMessage;
            else if (state == StatusTask.Done)
                return DoneTaskMessage;
            else if (state == StatusTask.YouAreFired)
                return DeadLineTaskMessage;

            return string.Empty;
        }

       
        public StatusTask? MapStringToInt(string state)
        {
            if (state == ActiveTaskMessage)
                return StatusTask.Active;
            else if (state == DoneTaskMessage)
                return StatusTask.Done;
            else if (state == DeadLineTaskMessage)
                return StatusTask.YouAreFired;

            return null;
        }
    }
}
