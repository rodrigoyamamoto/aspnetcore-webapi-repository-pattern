using aspnetcore_webapi_repository_pattern.data.models;

namespace aspnetcore_webapi_repository_pattern.services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer> GetCustomerByIdAsync(int id);
        Task<Customer> AddCustomerAsync(Customer customer);
    }
}