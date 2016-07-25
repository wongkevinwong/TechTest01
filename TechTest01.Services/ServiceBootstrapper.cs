using Ninject;
using System.Web.Http;
using TechTest01.Repository;
using TechTest01.Services.Catalog;

namespace TechTest01.Services
{
    public class ServiceBootstrapper
    {
        public static void Run (IKernel kernel)
        {
            kernel.Bind<IProductService>().To<ProductService>();
            RepositoryBootstrapper.Run(kernel);

            GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
        }
    }
}
