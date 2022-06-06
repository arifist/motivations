using System.Linq.Expressions;
using WebApplication1.DAL.Abstract;

namespace WebApplication1.DAL.Concreate
{
    public class EfBaseRepository<T> : IEntityRepository<T>
        where T : class, new()
    {
        public T Get(Expression<Func<T, bool>> filter)
        {
            using (var _context = new WordDbContext())
            {
                return _context.Set<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var _context = new WordDbContext())
            {
                return filter == null ?
                    _context.Set<T>().ToList() :
                    _context.Set<T>().Where(filter).ToList();
            }
        }

    }
}
