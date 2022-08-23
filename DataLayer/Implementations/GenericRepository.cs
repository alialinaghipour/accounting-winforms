using DataLayer;
using DataLayer.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataLayer.Implementations
{
    public class EfGenericRepository<TEntity> :
        IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _dbSet;

        public EfGenericRepository(ApplicationDbContext context)
        {
            _dbSet = context.Set<TEntity>();
        }

        public List<TEntity> GetAll(
            Expression<Func<TEntity, bool>>? @where = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy =
                null,
            string includes = "")
        {
            IQueryable<TEntity> query = _dbSet;
            if (where != null)
            {
                query = query.Where(where);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            if (includes != "")
            {
                foreach (string include in includes.Split(','))
                {
                    query = query.Include(include);
                }
            }
            return query.ToList();
        }

        public TEntity? GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Add(TEntity entity)
        {
            _dbSet.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public TEntity? Get()
        {
            return _dbSet.FirstOrDefault();
        }
    }

}
