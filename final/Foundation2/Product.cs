

using System.Runtime.CompilerServices;

public class Product
{
    private string _name;
    private string _productID;
    private double _pricePerUnit;
    private int _quantity;

    public Product(String name, string productID, double pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public double GetPricePerUnit()
    {
        return _pricePerUnit;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}