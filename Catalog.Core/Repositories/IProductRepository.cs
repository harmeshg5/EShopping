using Catalog.Core.Entities;

namespace Catalog.Core.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<IEnumerable<Product>> GetProductByName(string name);
        Task<IEnumerable<Product>> GetProductByBrand(string name);
        Task<Product> GetProduct(string id);
        Task<bool> CreateProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(string id);

    }
}
