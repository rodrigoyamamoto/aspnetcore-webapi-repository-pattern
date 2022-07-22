using aspnetcore_webapi_repository_pattern.data.models;
using aspnetcore_webapi_repository_pattern.data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_webapi_repository_pattern.data.Repositories;

public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    public CustomerRepository(RepositoryPatternDataContext repository) : base(repository)
    { }

    public async Task<Customer> GetCustomerByIdAsync(int id)
    {
        return (await GetAll().FirstOrDefaultAsync(x => x.Id == id))!;
    }

    public async Task<List<Customer>> GetAllCustomersAsync()
    {
        return await GetAll().ToListAsync();
    }
}