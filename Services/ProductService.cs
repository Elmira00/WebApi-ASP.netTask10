using WebApi_ASP.netTask9.Entities;
using WebApi_ASP.netTask9.Repositories;

namespace WebApi_ASP.netTask9.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddAsync(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task DeleteAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }


        public async Task<List<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task UpdateAsync(int id, Product updatedProduct)
        {
            await _productRepository.UpdateAsync(id, updatedProduct);
        }
    }
}
