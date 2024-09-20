namespace WebApi_ASP.netTask9.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Fullname { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
