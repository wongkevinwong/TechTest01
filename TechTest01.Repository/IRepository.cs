using System.Linq;
using TechTest01.Domain;

namespace TechTest01.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll { get; }
        TEntity GetDetail(string slug);
    }
}
