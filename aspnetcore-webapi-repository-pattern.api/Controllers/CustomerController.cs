using aspnetcore_webapi_repository_pattern.data.models;
using aspnetcore_webapi_repository_pattern.services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_webapi_repository_pattern.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<ActionResult<Customer>> CreateCustomer()
        {
            var customer = new Customer()
            {
                Age = 39,
                FirstName = "Rodrigo",
                LastName = "Yamamoto"
            };

            return await _customerService.AddCustomerAsync(customer);
        }

        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            return await _customerService.GetAllCustomersAsync();
        }

        public async Task<ActionResult<Customer>> GetCustomerById(int id)
        {
            return await _customerService.GetCustomerByIdAsync(id);
        }
    }
}
