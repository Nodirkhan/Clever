using Clever.Models.Products;

namespace Clever.Services.Products;

public interface IProductService
{
    Task<IEnumerable<Product>> RetrieveProductsAsync();
    Task<Product> RetrieveProductByIdAsync(int productId);
}