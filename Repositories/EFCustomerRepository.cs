using Microsoft.EntityFrameworkCore;
using WebApi_ASP.netTask9.DataAccess;
using WebApi_ASP.netTask9.Entities;

namespace WebApi_ASP.netTask9.Repositories
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private readonly RetailDbContext _context;

        public EFCustomerRepository(RetailDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task UpdateAsync(int id, Customer updatedCustomer)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                throw new Exception("Customer not found");
            }

            customer.Fullname = updatedCustomer.Fullname;
            customer.Orders = updatedCustomer.Orders;
            _context.Entry(customer).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
