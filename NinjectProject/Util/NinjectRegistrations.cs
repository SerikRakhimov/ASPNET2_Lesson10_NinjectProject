using Ninject.Modules;
using NinjectProject.Interfaces;
using NinjectProject.Interfaces.Release;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectProject.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
//            Bind<IRepository>().To<JsonRepository>();
              Bind<IRepository>().To<SQLRepository>();
        }
    }
}