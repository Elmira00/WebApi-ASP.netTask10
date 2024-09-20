using Microsoft.EntityFrameworkCore;
using WebApi_ASP.netTask9.DataAccess;
using WebApi_ASP.netTask9.Entities;

namespace WebApi_ASP.netTask9.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly RetailDbContext _context;

        public EFProductRepository(RetailDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task UpdateAsync(int id, Product updatedProduct)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                throw new Exception("Product not found");
            }

            product.Name = updatedProduct.Name;
            product.Orders = updatedProduct.Orders;

            _context.Entry(product).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
