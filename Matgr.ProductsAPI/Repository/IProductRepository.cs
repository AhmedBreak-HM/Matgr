using Matgr.ProductsAPI.Dtos;

namespace Matgr.ProductsAPI.Repository
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<ProductDto>> GetProducts();

        Task<ProductDto> GetProduct(int Id);

        Task<ProductDto> UpsertProduct(ProductDto product);

        Task<bool> DeleteProduct(int id);
    }
}
