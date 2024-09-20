using WebApi_ASP.netTask9.Entities;

namespace WebApi_ASP.netTask9.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
        Task AddAsync(Product product);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, Product updatedProduct);
    }
}
