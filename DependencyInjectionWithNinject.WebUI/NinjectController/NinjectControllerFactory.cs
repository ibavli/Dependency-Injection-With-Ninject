using DependencyInjectionWithNinject.Dal.Abstract;
using DependencyInjectionWithNinject.Dal.Concrete;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DependencyInjectionWithNinject.WebUI.NinjectController
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBllBindings();
        }
        private void AddBllBindings()
        {
            ninjectKernel.Bind<IAdminDal>().To<EfAdminDal>();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
    }
}