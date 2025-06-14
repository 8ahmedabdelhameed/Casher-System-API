using AutoMapper;
using WebApplication1.Data;
using WebApplication1.Dtos;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class InoviceService : IInoviceService
    {
            private readonly IMapper _imapper;
            private readonly AppDbContext _dbContext;
            public  InoviceService(AppDbContext dbContext, IMapper mapper)
            {
                _dbContext = dbContext;
                _imapper = mapper;
            }

            public void add(CreateInvoiceDto Invoicedto)
            {
                var invoice = _imapper.Map<Invoice>(Invoicedto);
                _dbContext.Invoices.Add(invoice);
                _dbContext.SaveChanges();
            }


        public void delete(int id)
            {
                var invoice = _dbContext.Invoices.SingleOrDefault(p => p.Id == id);
                _dbContext.Invoices.Remove(invoice);
                _dbContext.SaveChanges();
            }

            public IEnumerable<InvoiceDto> GetAll()
            {
                var invoice = _dbContext.Invoices.ToList();

                return _imapper.Map<IEnumerable<InvoiceDto>>(invoice);
            }


            public void update(InvoiceDto InvoiceDto)
            {
                var invoice = _imapper.Map<Invoice>(InvoiceDto);
                _dbContext.Invoices.Update(invoice);
                _dbContext.SaveChanges();

            }


    }

    }

