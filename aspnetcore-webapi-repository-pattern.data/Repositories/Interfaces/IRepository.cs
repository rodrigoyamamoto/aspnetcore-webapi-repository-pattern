namespace aspnetcore_webapi_repository_pattern.data.Repositories.Interfaces;

public interface IRepository<TEntity> where TEntity : class, new()
{
    IQueryable<TEntity> GetAll();
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
}