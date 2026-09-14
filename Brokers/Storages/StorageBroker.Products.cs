using Clever.Models.Products;
using Dapper;

namespace Clever.Brokers.Storages;

public partial class StorageBroker : IStorageBroker
{
    public async Task<IEnumerable<Product>> SelectAllProductAsync()
    {
        string selectAllProductsQuery = "SELECT * FROM PRODUCTS";

        return await this.context.QueryAsync<Product>(selectAllProductsQuery);
    }

    public async Task<Product> SelectProductByIdAsync(int productId)
    {
        string selectProductByIdQuery = $"SELECT * FROM Products where ProductID = @productId";

        return await context.QueryFirstOrDefaultAsync<Product>(
            selectProductByIdQuery, new
            {
                productId
            });
    }
}