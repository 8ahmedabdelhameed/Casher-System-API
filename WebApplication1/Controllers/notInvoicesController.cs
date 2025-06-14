using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dtos;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class notInvoicesController : ControllerBase
    {
        private readonly IInoviceService _invoiceService;
       

        public notInvoicesController(IInoviceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet]
        public IActionResult la2read()
        {
            return Ok(_invoiceService.GetAll());
        }

        [HttpPost]
        public IActionResult la2create(CreateInvoiceDto createInvoiceDto)
        {
            _invoiceService.add(createInvoiceDto);
            return Ok();
        }

        [HttpDelete]
        public IActionResult la2delete(int id)
        {
            _invoiceService.delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult la2update(InvoiceDto invoiceDto)
        {
            _invoiceService.update(invoiceDto);
            return Ok();
        }

    }
}
