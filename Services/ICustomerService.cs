using WebApi_ASP.netTask9.Entities;

namespace WebApi_ASP.netTask9.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllAsync();
        Task AddAsync(Customer customer);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, Customer updatedCustomer);
    }
}
