using Matgr.ProductsAPI.Dtos;
using Matgr.ProductsAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Matgr.ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        private ProductResponseDto _respones;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _respones = new ProductResponseDto();
        }

        [HttpGet("GetAllProduct")]
        public async Task<ProductResponseDto> GetAllProducts()
        {
            try
            {
                var products = await _productRepository.GetProducts();

                _respones.Resualt = products;
            }
            catch (Exception ex)
            {
                _respones.IsSuccess = false;

                _respones.ErrorMessages = new List<string> { ex.ToString() };

            }

            return _respones;


        }

        [HttpGet("{id}")]
        public async Task<ProductResponseDto> GetProduct(int id)
        {
            try
            {
                var product = await _productRepository.GetProduct(id);

                _respones.Resualt = product;
            }
            catch (Exception ex)
            {
                _respones.IsSuccess = false;

                _respones.ErrorMessages = new List<string> { ex.ToString() };

            }

            return _respones;


        }

        [HttpDelete("{id}")]
        public async Task<ProductResponseDto> DeleteProduct(int id)
        {
            try
            {
                await _productRepository.DeleteProduct(id);

                _respones.Resualt = true;
            }
            catch (Exception ex)
            {
                _respones.IsSuccess = false;

                _respones.ErrorMessages = new List<string> { ex.ToString() };

            }

            return _respones;


        }

        [HttpPost]
        public async Task<ProductResponseDto> CreateProduct(ProductDto product)
        {
            try
            {
                var resualt = await _productRepository.UpsertProduct(product);

                _respones.Resualt = resualt;
                _respones.DispalyMessage = "Product has been created";
            }
            catch (Exception ex)
            {
                _respones.IsSuccess = false;

                _respones.ErrorMessages = new List<string> { ex.ToString() };

            }

            return _respones;
        }


        [HttpPut]
        public async Task<ProductResponseDto> UpdateProduct(ProductDto product)
        {
            try
            {
                var resualt = await _productRepository.UpsertProduct(product);

                _respones.Resualt = resualt;
            }
            catch (Exception ex)
            {
                _respones.IsSuccess = false;

                _respones.ErrorMessages = new List<string> { ex.ToString() };

            }

            return _respones;
        }


    }
}
