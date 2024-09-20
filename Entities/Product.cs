namespace WebApi_ASP.netTask9.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
