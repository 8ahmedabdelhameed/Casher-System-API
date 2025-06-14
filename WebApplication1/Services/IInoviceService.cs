using WebApplication1.Dtos;

namespace WebApplication1.Services
{
    public interface IInoviceService
    {
        void add(CreateInvoiceDto Invoicedto);
        void delete(int id);
        void update(InvoiceDto InvoiceDto);
        IEnumerable<InvoiceDto> GetAll();
    }
}
