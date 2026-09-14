using Clever.Models.Products;

namespace Clever.Brokers.Storages;

public partial interface IStorageBroker
{
    Task<IEnumerable<Product>> SelectAllProductAsync();
    Task<Product> SelectProductByIdAsync(int productId);
}