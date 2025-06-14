using AutoMapper;
using System.Runtime.InteropServices;
using WebApplication1.Data;
using WebApplication1.Dtos;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _imapper;
        private readonly AppDbContext _dbContext;
        public ProductService(AppDbContext dbContext , IMapper mapper)
        {
            _dbContext = dbContext;
            _imapper = mapper;
        }

        public void add(CreateProductDto productdto)
        {
           var product = _imapper.Map<Product>(productdto);
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }


        public void delete(int id)
        {
            var product = _dbContext.Products.SingleOrDefault(p => p.Id == id);
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var Products = _dbContext.Products.ToList();

            return _imapper.Map<IEnumerable<ProductDto>>(Products);
        }


        public void update(ProductDto productDto)
        {
            var product = _imapper.Map<Product>(productDto);
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();

        }

   
    }
}
