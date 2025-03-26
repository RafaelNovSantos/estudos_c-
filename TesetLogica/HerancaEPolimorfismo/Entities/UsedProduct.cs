using System.Globalization;

namespace TesetLogica.HerancaEPolimorfismo.Entities;

public class UsedProduct : ProductPOO
{
    public DateTime ManufactureDate { get; set; }

    public UsedProduct(string name, double price,DateTime manufactureDate) : base(name, price) 
    {
        ManufactureDate = manufactureDate;
    }

    public override string ToString()
    {
        return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + $" Manufacture date: {ManufactureDate.Date.ToShortDateString()}";
    }
}