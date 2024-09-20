using WebApi_ASP.netTask9.Entities;
using WebApi_ASP.netTask9.Repositories;

namespace WebApi_ASP.netTask9.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task AddAsync(Order order)
        {
            await _orderRepository.AddAsync(order);
        }

        public async Task DeleteAsync(int id)
        {
            await _orderRepository.DeleteAsync(id);
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _orderRepository.GetAllAsync();
        }

        public async Task UpdateAsync(int id, Order updatedOrder)
        {
            await _orderRepository.UpdateAsync(id, updatedOrder);
        }
    }
}
