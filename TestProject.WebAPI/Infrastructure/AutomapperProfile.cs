using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TestProject.WebAPI.Data.Entities;
using TestProject.WebAPI.Models;

namespace TestProject.WebAPI.Infrastructure
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<Account, AccountModel>().ReverseMap();
        }
    }
}
