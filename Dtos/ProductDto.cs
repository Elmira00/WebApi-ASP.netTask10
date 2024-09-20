using WebApi_ASP.netTask9.Entities;

namespace WebApi_ASP.netTask9.Dtos
{
    public class ProductDto
    {
        public string ProductName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}