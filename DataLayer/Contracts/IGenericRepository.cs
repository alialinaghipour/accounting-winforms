using System.Linq.Expressions;

namespace DataLayer.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? @where = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy =
                null,
            string includes = "");
        TEntity? GetById(object id);
        TEntity? Get();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
