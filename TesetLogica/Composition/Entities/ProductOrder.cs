namespace TesetLogica.Composition.Entities;

public class ProductOrder
{
    public string Name { get; set; }
    public double Price { get; set; }



    public ProductOrder(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return Name;
    }
}