using System;

public class Product
{
    // Member variables
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Methods
    public double GetTotalCost()
    {
        return (_price * _quantity);
    }

    public string GetProductNameAndProductId()
    {
        return _productName + " " + _productId;
    }
}