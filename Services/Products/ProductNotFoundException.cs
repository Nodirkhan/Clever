namespace Clever.Services.Products;

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(int productId)
        : base($"Could not find product with ID {productId}.")
    {
    }
}
