using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EO = DemoProject.Training.Entities;
using BO = DemoProject.Training.BusinessObjects;

namespace DemoProject.Training.Profiles
{
    public class TrainingProfile : Profile
    {
        public TrainingProfile()
        {
            CreateMap<EO.User, BO.User>().ReverseMap();
            //CreateMap<EO.Ticket, BO.Ticket>().ReverseMap();
        }
    }
}
