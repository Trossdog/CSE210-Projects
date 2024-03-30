

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public Boolean IsInUSA()
    {
        if (_country.ToUpper() == "USA")
        {
            return true;
        }
        return false;
    }

    public string GetAddressDetails()
    {
        return $"Address: {_streetAddress}, {_city}, {_stateProvince}, {_country}";
    }
        
}