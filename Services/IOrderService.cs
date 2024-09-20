using WebApi_ASP.netTask9.Entities;

namespace WebApi_ASP.netTask9.Services
{
    public interface IOrderService
    {
        Task AddAsync(Order order);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, Order updatedOrder);
        Task<List<Order>> GetAllAsync();
    }
}
