using AutoMapper;
using DemoProject.Training.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EO = DemoProject.Training.Entities;
using BO = DemoProject.Training.BusinessObjects;

namespace DemoProject.Api.Profiles
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<EO.User, BO.User>().ReverseMap();
        }
    }
}
