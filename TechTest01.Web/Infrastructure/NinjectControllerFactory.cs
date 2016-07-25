using Ninject;
using System;
using System.Web.Mvc;
using System.Web.Routing;
using TechTest01.Services;

namespace TechTest01.Web.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _ninjectKernel;

        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType==null?null:(IController)_ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            ServiceBootstrapper.Run(_ninjectKernel);
        }
    }
}
