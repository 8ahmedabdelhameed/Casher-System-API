namespace WebApplication1.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }

        public List<Product> Products { get; set; }

    }
}
