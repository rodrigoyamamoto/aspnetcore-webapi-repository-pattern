using aspnetcore_webapi_repository_pattern.data.models;

namespace aspnetcore_webapi_repository_pattern.services.Interfaces;

public interface IProductService
{
    Task<Product> AddProductAsync(Product product);

    Task<Product> GetProductByIdAsync(int id);
}