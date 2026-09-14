namespace Clever.Models.Products;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int SupplierID { get; set; }
    public int CategoryID { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public short UnitsInStock { get; set; }
    public short UnitsInOrder { get; set; }
    public short ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
}