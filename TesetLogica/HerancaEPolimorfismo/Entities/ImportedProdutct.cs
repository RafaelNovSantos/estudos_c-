using System.Globalization;

namespace TesetLogica.HerancaEPolimorfismo.Entities;

public class ImportedProdutct : ProductPOO
{
    public double CustomsFee { get; set; }

    public ImportedProdutct()
    {
    }

    public ImportedProdutct(double customsFee)
    {
        CustomsFee = customsFee;
    }

    public ImportedProdutct(string name, double price, double customsFee) : base(name, price)
    {
        CustomsFee = customsFee;
    }

    public double TotalPrice()
    {
        return Price + CustomsFee;
    }

    public override string ToString()
    {
        return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + $" (Custom fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
    }
}