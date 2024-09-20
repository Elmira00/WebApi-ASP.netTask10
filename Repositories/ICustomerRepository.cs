using WebApi_ASP.netTask9.Entities;

namespace WebApi_ASP.netTask9.Repositories
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, Customer updatedCustomer);
        Task<List<Customer>> GetAllAsync();
    }
}
