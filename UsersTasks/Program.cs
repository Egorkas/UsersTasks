using AutoMapper;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskSheduler.BusinessLayer;
using TaskSheduler.BusinessLayer.DTO;
using TaskSheduler.BusinessLayer.Interfaces;
using TaskSheduler.DataAccess;
using TaskSheduler.DataAccess.EFDb;
using TaskSheduler.DataAccess.Entities;
using TaskSheduler.BusinessLayer.Mapping;


namespace UsersTasks
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = CreateContainer();
            Application.Run(container.GetInstance<Form1>());
        }

        private static Container CreateContainer()
        {
            var container = new Container();
            container.Register<IGenericServices<UserDTO>, UserService>(Lifestyle.Singleton);
            container.Register<IGenericServices<UserTaskDTO>, UserTaskService>(Lifestyle.Singleton);
            container.Register<IGenericRepository<User>, EFGenericRepository<User>>(Lifestyle.Singleton);
            container.Register<IGenericRepository<UserTask>, EFGenericRepository<UserTask>>(Lifestyle.Singleton);
            container.Register<IMapper>(() => CreateMapper(), Lifestyle.Singleton);
            container.Register<UserContext>(Lifestyle.Singleton);
            container.Register<Form1>(Lifestyle.Singleton);
            container.Verify();

            return container;
        }

        private static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg => cfg.AddMaps("TaskSheduler.BusinessLayer"));
            var mapper = config.CreateMapper();

            return mapper;
        }
    }
}
