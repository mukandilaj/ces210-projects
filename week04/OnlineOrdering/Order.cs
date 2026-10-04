using System.Collections.Generic;

public class Order
{
    // Member variables
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Methods
    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }
        return totalPrice + GetShippingCost();
    }

    public double GetShippingCost()
    {
        if (_customer.IsCustomerInUsa())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetProductNameAndProductId() + "\n\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
       return _customer.GetCustomerName() + "\n" + 
       _customer.GetCustomerAddress().GetCompleteAddress();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}