using Autofac;
using DemoProject.Api.Models;
using DemoProject.Training.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Api
{
    public class ApiModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public ApiModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void Load(ContainerBuilder builder)
        {

            //builder.RegisterType<TrainingContext>().AsSelf()
            //    .WithParameter("connectionString", _connectionString)
            //    .WithParameter("migrationAssemblyName", _migrationAssemblyName)
            //    .InstancePerLifetimeScope();
            //builder.RegisterType<TrainingContext>().As<ITrainingContext>()
            //   .WithParameter("connectionString", _connectionString)
            //   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
            //   .InstancePerLifetimeScope();

            //builder.RegisterType<UserRepository>().As<IUserRepository>()
            //    .InstancePerLifetimeScope();
            //builder.RegisterType<UserService>().As<IUserService>()
            //    .InstancePerLifetimeScope();
            //builder.RegisterType<TrainingUitOfWork>().As<ITrainingUnitOfWork>()
            //    .InstancePerLifetimeScope();
            builder.RegisterType<AddUserModel>().AsSelf();

            base.Load(builder);

        }
    }
}
