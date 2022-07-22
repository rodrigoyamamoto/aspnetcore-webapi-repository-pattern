using aspnetcore_webapi_repository_pattern.data.models;

namespace aspnetcore_webapi_repository_pattern.data.Repositories.Interfaces;

public interface ICustomerRepository : IRepository<Customer>
{
    Task<Customer> GetCustomerByIdAsync(int id);
    Task<List<Customer>> GetAllCustomersAsync();
}