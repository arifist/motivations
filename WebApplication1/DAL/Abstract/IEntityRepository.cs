using System.Linq.Expressions;

namespace WebApplication1.DAL.Abstract
{
    public interface IEntityRepository<T>
        where T : class, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
    }
}
