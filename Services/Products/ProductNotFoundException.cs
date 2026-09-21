using System.Runtime.Serialization;

namespace Clever.Services.Products;

[Serializable]
public class ProductNotFoundException : Exception
{
    public ProductNotFoundException()
    {
    }

    public ProductNotFoundException(string message)
        : base(message)
    {
    }

    public ProductNotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public ProductNotFoundException(int productId)
        : base($"Could not find product with ID {productId}.")
    {
    }

#pragma warning disable SYSLIB0051
    protected ProductNotFoundException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
#pragma warning restore SYSLIB0051
}
