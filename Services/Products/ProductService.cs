using Clever.Brokers.Storages;
using Clever.Models.Products;

namespace Clever.Services.Products;

public class ProductService : IProductService
{
    private readonly IStorageBroker storageBroker;

    public ProductService()
    {
        storageBroker = new StorageBroker();
    }

    public async Task<IEnumerable<Product>> RetrieveProductsAsync()
    {
        return await this.storageBroker.SelectAllProductAsync();
    }

    public async Task<Product> RetrieveProductByIdAsync(int productId)
    {
        if (productId <= 0)
        {
            throw new ArgumentException("Invalid product id.");
        }

        Product maybeProduct = await this.storageBroker.SelectProductByIdAsync(productId);

        if (maybeProduct is null)
        {
            throw new ArgumentNullException($"Could not find product with product id: {productId}");
        }

        return maybeProduct;
    }
}