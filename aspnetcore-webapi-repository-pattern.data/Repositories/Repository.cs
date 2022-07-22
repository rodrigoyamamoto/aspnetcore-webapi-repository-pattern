using aspnetcore_webapi_repository_pattern.data.models;
using aspnetcore_webapi_repository_pattern.data.Repositories.Interfaces;

namespace aspnetcore_webapi_repository_pattern.data.Repositories;

public class Repository<TEntity>: IRepository<TEntity> where TEntity : class, new()
{
    private readonly RepositoryPatternDataContext _repository;

    public Repository(RepositoryPatternDataContext repository)
    {
        _repository = repository;
    }

    public IQueryable<TEntity> GetAll()
    {
        try
        {
            return _repository.Set<TEntity>();
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't retrieve entities: {ex.Message}");
        }
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
        }

        try
        {
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
        }
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
        }

        try
        {
            _repository.Update(entity);
            await _repository.SaveChangesAsync();

            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
        }
    }
}