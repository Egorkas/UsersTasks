using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSheduler.BusinessLayer.DTO;
using TaskSheduler.DataAccess.Entities;
using TaskSheduler.DataAccess.Entities.Enum;

namespace TaskSheduler.BusinessLayer.Mapping
{
    public class UserMapperProfile : Profile
    {
        private const string RuleAdmin = "Admin";
        private const string RuleUser = "User";
        public UserMapperProfile()
        {
            CreateMap<User, UserDTO>()
            .ForMember(dst => dst.Name, opts => opts.MapFrom(src => src.FirstName + " " + src.LastName))
            .ForMember(dst => dst.Rule, opts => opts.MapFrom(src => MapIntToString(src.Rule)))
            .ReverseMap()
            .ForMember(dst => dst.FirstName, opts => opts.MapFrom(src => MapNameToFirstName(src.Name)))
            .ForMember(dst => dst.LastName, opts => opts.MapFrom(src => MapNameToLastName(src.Name)))
            .ForMember(dst => dst.Rule, opts => opts.MapFrom(src => MapStringToInt(src.Rule)));
        }

        public string MapNameToFirstName(string name)
        {
            if(name.Contains(" "))
            {
                var list = name.Split(' ');
                return list[0];
            }

            return name;
        }

        public string MapNameToLastName(string name)
        {
            if (name.Contains(" "))
            {
                var list = name.Split(' ');
                return list[1];
            }

            return name;
        }
        public string MapIntToString(DataAccess.Entities.Enum.Rule state)
        {
            if (state == DataAccess.Entities.Enum.Rule.Administrator)
                return RuleAdmin;
            else if (state == DataAccess.Entities.Enum.Rule.User)
                return RuleUser;

            return string.Empty;
        }

        public DataAccess.Entities.Enum.Rule? MapStringToInt(string state)
        {
            if (state == RuleAdmin)
                return DataAccess.Entities.Enum.Rule.Administrator;
            else if (state == RuleUser)
                return DataAccess.Entities.Enum.Rule.User;

            return null;
        }
    }
}

