using WebApi_ASP.netTask9.Entities;
using WebApi_ASP.netTask9.Repositories;

namespace WebApi_ASP.netTask9.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task AddAsync(Customer customer)
        {
            await _customerRepository.AddAsync(customer);
        }

        public async Task DeleteAsync(int id)
        {
            await _customerRepository.DeleteAsync(id);
        }


        public async Task<List<Customer>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
        }

        public async Task UpdateAsync(int id, Customer updatedCustomer)
        {
            await _customerRepository.UpdateAsync(id, updatedCustomer);
        }
    }
}
