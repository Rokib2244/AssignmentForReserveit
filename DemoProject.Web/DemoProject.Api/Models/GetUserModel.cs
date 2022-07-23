using Autofac;
using AutoMapper;
using DemoProject.Training.BusinessObjects;
using DemoProject.Training.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Api.Models
{
    public class GetUserModel
    {
        private readonly IUserService _userService;
        
        public User User { get; set; }

        public GetUserModel()
        {
            _userService = Startup.AutofacContainer.Resolve<IUserService>();
        }
        public User GetUser(int id)
        {
           return User = _userService.GetUser(id);
        }
    }
}
