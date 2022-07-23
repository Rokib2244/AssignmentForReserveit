using DemoProject.Data;
using DemoProject.Training.Contexts;
using DemoProject.Training.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Training.UnitOfWorks
{
    public class TrainingUitOfWork : UnitOfWork, ITrainingUnitOfWork
    {
        public IUserRepository Users { get; private set; }
        public TrainingUitOfWork(ITrainingContext context, IUserRepository users)
           : base((DbContext)context)
        {
            Users = users;
        }
    }
}
