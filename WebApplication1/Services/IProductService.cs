using WebApplication1.Dtos;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IProductService
    {
        void add (CreateProductDto productdto);
        void delete (int id);
        void update (ProductDto productDto);
        IEnumerable<ProductDto> GetAll ();
        

    }
}
