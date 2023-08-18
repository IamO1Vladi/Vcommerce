namespace VCommerce.Common.DataBaseValidations;

public static class OrderValidations
{

    public const int MaxCountryLength = 54;
    public const int MinConttyLength = 4;

    public const int MaxCityLength = 85;
    public const int MinCityLength = 3;

    public const int MaxStreetLength = 85;
    public const int MinStretLength = 3;

    public const int MaxPostalCodeLength = 10;
    public const int MinPostalCodeLength = 4;

    public const int MaxTotalClothingPrice= 9999900;
    public const int MinTotalClothingPrice = 0;

    public const int MaxShippingPrice = 100;
    public const int MinShhippingPrice = 0;

    public const int MaxTotalPrice = 1000000;
    public const int MinTotalPrice = 0;

   
}