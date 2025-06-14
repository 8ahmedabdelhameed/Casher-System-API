namespace WebApplication1.Dtos
{
    public class CreateInvoiceDto
    {
        public double Price { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
