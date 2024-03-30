

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.CalculateTotalCost();
        }

        totalCost += _customer.IsInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in _products)
        {
            label += $"Name: {product.GetName()}, Product ID: {product.GetProductID()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Customer Name: {_customer.GetName()}\n{_customer.GetAddress().GetAddressDetails()}";
    }
}