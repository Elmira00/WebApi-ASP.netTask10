using WebApi_ASP.netTask9.Entities;

namespace WebApi_ASP.netTask9.Repositories
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, Order updatedOrder);
        Task<List<Order>> GetAllAsync();
    }
}
