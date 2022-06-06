using WebApplication1.DAL.Abstract;
using WebApplication1.Entities;

namespace WebApplication1.DAL.Concreate
{
    public class EfWordDal : EfBaseRepository<Word>,
        IEntityRepository<Word>,
        IWordDal
    {
    }
}
