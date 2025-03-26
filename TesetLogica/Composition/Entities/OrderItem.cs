using System.Globalization;

namespace TesetLogica.Composition.Entities;

public class OrderItem
{
    public int Quatity { get; set; }
    public double Price { get; set; }
    public ProductOrder ProductOrder { get; set; }

    public OrderItem()
    {
    }

    public OrderItem(int quatity, double price, ProductOrder productOrder)
    {
        Quatity = quatity;
        Price = price;
        ProductOrder = productOrder;
    }

    public double subTotal()
    {
        return Price * Quatity;
    }

    public override string ToString()
    {
        return  ProductOrder.ToString() + ",\n$" + Price.ToString("F2", CultureInfo.InvariantCulture) + ",\nQuantity:" + Quatity + ",\nSubtotal: $" +  subTotal().ToString("F2", CultureInfo.InvariantCulture) + "\n";
    }
}