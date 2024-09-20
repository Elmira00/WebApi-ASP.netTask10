using Microsoft.EntityFrameworkCore;
using WebApi_ASP.netTask9.DataAccess;
using WebApi_ASP.netTask9.Entities;

namespace WebApi_ASP.netTask9.Repositories
{
    public class EFOrderRepository : IOrderRepository
    {
        private readonly RetailDbContext _context;

        public EFOrderRepository(RetailDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task UpdateAsync(int id, Order updatedOrder)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            order.OrderDate = updatedOrder.OrderDate;
            order.CustomerId = updatedOrder.CustomerId;
            order.ProductId = updatedOrder.ProductId;
            order.Customer = updatedOrder.Customer;
            order.Product = updatedOrder.Product;

            _context.Entry(order).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
