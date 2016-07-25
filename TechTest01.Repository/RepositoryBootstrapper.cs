using Ninject;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository
{
    public class RepositoryBootstrapper
    {
        public static void Run(IKernel kernel)
        {
            kernel.Bind<IRepository<Product>>().To<ProductRepository>();
        }
    }
}
