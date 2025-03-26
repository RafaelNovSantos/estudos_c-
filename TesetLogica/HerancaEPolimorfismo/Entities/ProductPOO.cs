using System.Globalization;

namespace TesetLogica.HerancaEPolimorfismo.Entities;

public class ProductPOO
{
    public string Name { get; set; }
    public double Price { get; set; }

    public ProductPOO()
    {
    }

    public ProductPOO(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
    }
}