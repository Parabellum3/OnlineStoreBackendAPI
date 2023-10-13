using System.Net.Mime;
using OnlineStoreBackendAPI.Models.Entities;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public abstract class BaseRepository<TEntity,TKey> : IRepository<TEntity, TKey> where TEntity : BaseModel
{
    protected readonly IDataContext Context;

    protected BaseRepository(IDataContext context)
    {
        Context = context;
    }

    public virtual IEnumerable<TEntity> GetCollection(int fetch = 30, int skip = 0)
    {
        return Context.Set<TEntity>().Skip(skip).Take(fetch);
    }

    public virtual  TEntity GetById(TKey id)
    {
        var result = Context.Set<TEntity>().Find(id);
        if (result == null)
        {
            throw new ArgumentException("Record with this Id doesn't exist");
        }
        return result;

    }

    public  virtual int Insert(TEntity entity)
    {
        Context.Set<TEntity>().Add(entity);
        return Context.SaveChanges();
    }

    public virtual int Delete(TKey id)
    {
        var entity = Context.Set<TEntity>().Find(id);
        if (entity != null)
        {
            return Delete(entity);
        }
        return 0;
    }

    public virtual int Delete(TEntity entity)
    {
        Context.Set<TEntity>().Remove(entity);
       return Context.SaveChanges();
    }
    
    public virtual int Update(TEntity entity)
    {
        Context.Set<TEntity>().Update(entity);
        return Context.SaveChanges();
    }
}