using Clever.Brokers.Storages;
using Clever.Models.Products;

namespace Clever.Services.Products;

public class ProductService : IProductService
{
    private readonly IStorageBroker storageBroker;

    public ProductService(IStorageBroker storageBroker)
    {
        ArgumentNullException.ThrowIfNull(storageBroker);
        this.storageBroker = storageBroker;
    }

    public async Task<IEnumerable<Product>> RetrieveProductsAsync()
    {
        return await storageBroker.SelectAllProductAsync();
    }

    public async Task<Product> RetrieveProductByIdAsync(int productId)
    {
        if (productId <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(productId), "Product ID must be greater than zero.");
        }

        Product maybeProduct = await storageBroker.SelectProductByIdAsync(productId);

        if (maybeProduct is null)
        {
            throw new ProductNotFoundException(productId);
        }

        return maybeProduct;
    }
}