using DemoProject.Training.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Training.Services
{
    public interface IUserService
    {
        void SaveWord(User user);
        User GetUser(int id);
    }
}
