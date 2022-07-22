using aspnetcore_webapi_repository_pattern.data.models;
using aspnetcore_webapi_repository_pattern.data.Repositories.Interfaces;
using aspnetcore_webapi_repository_pattern.services.Interfaces;

namespace aspnetcore_webapi_repository_pattern.services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<List<Customer>> GetAllCustomersAsync()
    {
        return await _customerRepository.GetAllCustomersAsync();
    }

    public async Task<Customer> GetCustomerByIdAsync(int id)
    {
        return await _customerRepository.GetCustomerByIdAsync(id);
    }

    public async Task<Customer> AddCustomerAsync(Customer customer)
    {
        return await _customerRepository.AddAsync(customer);
    }
}