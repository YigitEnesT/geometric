using System.Linq.Expressions;
using geometric.Repositories.Contracts;

namespace geometric.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {
        protected readonly AppDbContext _context;

        protected RepositoryBase(AppDbContext context)
        {
            _context = context;
        }

        public void Create(T entity) => _context.Set<T>().Add(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition) => _context.Set<T>().Where(condition);

        public IQueryable<T> GetAll() => _context.Set<T>();


        public void Update(T entity) => _context.Set<T>().Update(entity);
    }
}
