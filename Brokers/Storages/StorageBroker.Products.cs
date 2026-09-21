using Clever.Models.Products;
using Dapper;

namespace Clever.Brokers.Storages;

public partial class StorageBroker : IStorageBroker
{
    private const string ProductColumns = """
        ProductID AS ProductId,
        ProductName,
        SupplierID AS SupplierId,
        CategoryID AS CategoryId,
        QuantityPerUnit,
        UnitPrice,
        UnitsInStock,
        UnitsInOrder,
        ReorderLevel,
        Discontinued
        """;

    public async Task<IEnumerable<Product>> SelectAllProductAsync()
    {
        string selectAllProductsQuery = $"SELECT {ProductColumns} FROM Products";

        return await context.QueryAsync<Product>(selectAllProductsQuery);
    }

    public async Task<Product> SelectProductByIdAsync(int productId)
    {
        string selectProductByIdQuery =
            $"SELECT {ProductColumns} FROM Products WHERE ProductID = @productId";

        return await context.QueryFirstOrDefaultAsync<Product>(
            selectProductByIdQuery, new
            {
                productId
            });
    }
}