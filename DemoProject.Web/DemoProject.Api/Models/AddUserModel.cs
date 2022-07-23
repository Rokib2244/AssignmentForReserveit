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
    public class AddUserModel
    {
        public string Word { get; set; }
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
       

        public AddUserModel()
        {
            _userService = Startup.AutofacContainer.Resolve<IUserService>();
            //_mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public AddUserModel(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        internal void SaveWord()
        {
            //var user = _mapper.Map<User>(this);
            var user = new User
            {
                Word =Word
            };
            _userService.SaveWord(user);
        }
    }
}
