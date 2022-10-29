using AutoMapper;
using Matgr.ProductsAPI.Data;
using Matgr.ProductsAPI.Dtos;
using Matgr.ProductsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Matgr.ProductsAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductsDbContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(ProductsDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<bool> DeleteProduct(int id)
        {
            try
            {
                var productToDelete = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == id);

                if (productToDelete is null) return false;

                _context.Products.Remove(productToDelete);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<ProductDto> GetProduct(int Id)
        {
            var productFromRepo = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == Id);
            if (productFromRepo is null) return null;

            var product = _mapper.Map<ProductDto>(productFromRepo);

            return product;

        }

        public async Task<IReadOnlyList<ProductDto>> GetProducts()
        {
            var productsFromRepo = await _context.Products.ToListAsync();
            return _mapper.Map<IReadOnlyList<ProductDto>>(productsFromRepo);
        }

        public async Task<ProductDto> UpsertProduct(ProductDto product)
        {
            var productToRepo = _mapper.Map<Product>(product);
            if (productToRepo.ProductId > 0)
            {
                // Update
                var productToReturn = _context.Products.Update(productToRepo);
                await _context.SaveChangesAsync();
                 
                return _mapper.Map<ProductDto>(productToReturn);
            }
            else
            {
                // Create
                var productToReturn = await _context.Products.AddAsync(productToRepo);

                await _context.SaveChangesAsync();

                 

                return _mapper.Map<ProductDto>(productToReturn);
            }
        }
    }
}
