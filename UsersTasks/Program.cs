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
using TaskSheduler.DataAccess.Entities;

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
            Application.Run(new Form1());
        }

        //private static Container CreateContainer()
        //{
        //    var container = new Container();
        //    container.Register<IGenericServices<UserDTO>, UserService>(Lifestyle.Singleton);
        //    container.Register<IGenericServices<UserTaskDTO>, UserTaskService>(Lifestyle.Singleton);
        //    container.Register<IGenericRepository<User>, EFGenericRepository<User>(Lifestyle.Singleton);

        //    container.Verify();

        //    return container;
        //}
    }
}
