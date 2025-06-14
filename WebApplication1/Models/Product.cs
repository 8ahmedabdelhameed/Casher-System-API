namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int ?InvoiceId { get; set; }
        public Invoice ?Invoice { get; set; }

    }
}
