using OnlineStoreBackendAPI.Models.ViewModels;

namespace OnlineStoreBackendAPI.DataAccess.Abstracts;

public interface IRepository<TEntity, TKey> where TEntity: BaseModel
{

    /// <summary>
    /// Get pageable collection of entities
    /// </summary>
    /// <param name="fetch"></param>
    /// <param name="skip"></param>
    /// <returns>Collection of entities</returns>
    IEnumerable<TEntity> GetCollection(int fetch = 30, int skip = 0);

    /// <summary>
    /// Get entity by its Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Selected Entity</returns>
    TEntity GetById(TKey id);

    /// <summary>
    /// Insert new entity into the set
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Success</returns>
    int Insert(TEntity entity);

    /// <summary>
    /// Delete the entity by provided Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Success</returns>
    int Delete(TKey id);

    /// <summary>
    /// Delete the entity from the set
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Success</returns>
    int Delete(TEntity entity);

    /// <summary>
    /// Update the entity
    /// </summary>
    /// <param name="id"></param>
    /// <param name="entity"></param>
    /// <returns>Success</returns>
    int Update(TKey id, TEntity entity);




}