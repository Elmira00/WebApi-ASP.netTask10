using WebApi_ASP.netTask9.Entities;

namespace WebApi_ASP.netTask9.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, Product updatedProduct);
        Task<List<Product>> GetAllAsync();
    }
}
