using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public abstract class BaseRepository<TEntity,TKey> : IRepository<TEntity, TKey> where TEntity : BaseModel
{
    protected readonly IDataContext DbContext;

    protected BaseRepository(IDataContext context)
    {
        DbContext = context; 
    }

    public virtual IEnumerable<TEntity> GetCollection(int fetch = 30, int skip = 0)
    {
        return DbContext.Set<TEntity>().Skip(skip).Take(fetch);
    }

    public virtual TEntity GetById(TKey id)
    {
        return DbContext.Set<TEntity>().Find(id);
    }

    public virtual int Insert(TEntity entity)
    {
        DbContext.Set<TEntity>().Add(entity);
        return DbContext.SaveChanges();
    }

    public virtual int Delete(TKey id)
    {
        var entity = DbContext.Set<TEntity>().Find(id);
        return this.Delete(entity);
    }

    public virtual int Delete(TEntity entity)
    {
        DbContext.Set<TEntity>().Remove(entity);
       return DbContext.SaveChanges();
    }

    public virtual int Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}