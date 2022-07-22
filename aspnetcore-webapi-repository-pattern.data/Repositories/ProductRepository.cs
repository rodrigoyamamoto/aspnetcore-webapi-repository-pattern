using aspnetcore_webapi_repository_pattern.data.models;
using aspnetcore_webapi_repository_pattern.data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_webapi_repository_pattern.data.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(RepositoryPatternDataContext repository) : base(repository)
    {
    }

    public Task<Product> GetProductByIdAsync(int id)
    {
        return GetAll().FirstOrDefaultAsync(x => x.Id == id)!;
    }
}