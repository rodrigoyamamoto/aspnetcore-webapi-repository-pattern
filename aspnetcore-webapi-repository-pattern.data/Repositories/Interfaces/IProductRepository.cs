using aspnetcore_webapi_repository_pattern.data.models;

namespace aspnetcore_webapi_repository_pattern.data.Repositories.Interfaces;

public interface IProductRepository : IRepository<Product>
{
    Task<Product> GetProductByIdAsync(int id);
}