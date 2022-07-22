using aspnetcore_webapi_repository_pattern.data.models;
using aspnetcore_webapi_repository_pattern.data.Repositories.Interfaces;
using aspnetcore_webapi_repository_pattern.services.Interfaces;

namespace aspnetcore_webapi_repository_pattern.services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> AddProductAsync(Product product)
    {
        return await _productRepository.AddAsync(product);
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await _productRepository.GetProductByIdAsync(id);
    }
}