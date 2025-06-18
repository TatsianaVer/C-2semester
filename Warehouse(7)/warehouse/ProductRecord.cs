using warehouse;

/// <summary>
/// Represents a product record in the warehouse system
/// </summary>
public struct ProductRecord
{
    private readonly int _code;
    private readonly string _supplier;
    private readonly decimal _price;
    private readonly int _quantity;

    /// <summary>
    /// Unique identifier for the product
    /// </summary>
    public int Code
    {
        get 
        { 
            return _code; 
        }
    }

    /// <summary>
    /// Name of the supplier for this product
    /// </summary>
    public string Supplier
    {
        get 
        { 
            return _supplier; 
        }
    }

    /// <summary>
    /// Unit price of the product
    /// </summary>
    public decimal Price
    {
        get 
        { 
            return _price; 
        }
    }

    /// <summary>
    /// Quantity of the product in stock
    /// </summary>
    public int Quantity
    {
        get 
        { 
            return _quantity; 
        }
    }

    /// <summary>
    /// Calculated total value of the product (price × quantity)
    /// </summary>
    public decimal TotalValue
    {
        get 
        { 
            return Price * Quantity; 
        }
    }

    /// <summary>
    /// Initializes a new instance of the ProductRecord struct
    /// </summary>
    /// <param name="code">Product identification code</param>
    /// <param name="supplier">Supplier name</param>
    /// <param name="price">Unit price</param>
    /// <param name="quantity">Stock quantity</param>
    public ProductRecord(int code, string supplier, decimal price, int quantity)
    {
        _code = code;
        _supplier = supplier;
        _price = price;
        _quantity = quantity;
    }

    /// <summary>
    /// Gets the product name based on its code
    /// </summary>
    /// <returns>Product name if code is defined, otherwise "Unknown product"</returns>
    public string GetProductName()
    {
        if (Enum.IsDefined(typeof(ProductCode), Code))
        {
            return Enum.GetName(typeof(ProductCode), Code);
        }
        return Constants.UnknownProduct;
    }

    /// <summary>
    /// Formats product information for display purposes
    /// </summary>
    /// <returns>Formatted string containing product details</returns>
    public string FormatProductInfo()
    {
        return string.Format(
            Constants.ProductInfoFormat,
            GetProductName(),
            Supplier,
            Price,
            Quantity,
            TotalValue
        );
    }
}