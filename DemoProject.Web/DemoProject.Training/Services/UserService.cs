using AutoMapper;
using DemoProject.Training.BusinessObjects;
using DemoProject.Training.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Training.Services
{
    public class UserService : IUserService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        private readonly IMapper _mapper;
        public UserService(ITrainingUnitOfWork trainingUnitOfWork,
            IMapper mapper)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _mapper = mapper;
        }

        

        public User GetUser(int id)
        {
            //if (id == null)
            //    throw new InvalidOperationException("Word was not found");
            var user= _trainingUnitOfWork.Users.GetById(id);
            if (user == null) return null;
            return _mapper.Map<User>(user);
        }

        //public UserService()
        //{
        //}

        public void SaveWord(User user)
        {
            if (user == null)
                throw new InvalidOperationException("Word was not found");
            _trainingUnitOfWork.Users.Add(
                _mapper.Map<Entities.User>(user)
                );
            _trainingUnitOfWork.Save();
        }
    }
}
