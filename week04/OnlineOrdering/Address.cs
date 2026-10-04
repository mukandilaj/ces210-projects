using System;

public class Address
{
    // Member variables
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Methods
    public bool IsAddressInUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetCompleteAddress()
    {
        return ($"{_street}, {_city}, {_state}, {_country}");
    }
}