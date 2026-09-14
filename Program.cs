using Clever.Models.Products;
using Clever.Services.Products;
const string rowFormat = "{0,-5} {1,-30} {2,-10} {3,-10} {4,-20} {5,10}";

IProductService productService = new ProductService();

try
{
    Product product = await productService.RetrieveProductByIdAsync(100);
    Console.WriteLine(
        rowFormat,
        product.ProductId,
        product.ProductName,
        product.SupplierID,
        product.CategoryID,
        product.QuantityPerUnit,
        product.UnitPrice.ToString("C"));
}
catch (Exception exeption)
{
    Console.WriteLine(exeption.Message);
}
