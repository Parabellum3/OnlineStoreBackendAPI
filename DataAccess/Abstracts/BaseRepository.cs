using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public abstract class BaseRepository<TEntity,TKey> : IRepository<TEntity, TKey> where TEntity : BaseModel
{
    protected readonly IDataContext _context;

    protected BaseRepository(IDataContext context)
    {
        _context = context;
    }

    public virtual IEnumerable<TEntity> GetCollection(int fetch = 30, int skip = 0)
    {
        return _context.Set<TEntity>().Skip(skip).Take(fetch);
    }

    public virtual  TEntity GetById(TKey id)
    {
        return _context.Set<TEntity>().Find(id);
    }

    public  virtual int Insert(TEntity entity)
    {
        _context.Set<TEntity>().AddAsync(entity);
        return _context.SaveChanges();
    }

    public virtual int Delete(TKey id)
    {
        var entity = _context.Set<TEntity>().Find(id);
        if (entity != null)
        {
            return Delete(entity);
        }
        return 0;
    }

    public virtual int Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
       return _context.SaveChanges();
    }

    public virtual int Update(TKey id,TEntity entity)
    {
        throw new NotImplementedException();
    }
}