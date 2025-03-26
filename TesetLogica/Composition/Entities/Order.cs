using System.Text;
using System.Globalization;
using TesetLogica.Composition.Entities.Enums;

namespace TesetLogica.Composition.Entities;

public class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    public Client Client { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    
    public Order()
    {
    }

    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        Client = client;
    }
    
    public  void AddItem(OrderItem orderItem){
        Items.Add(orderItem);
    }

    public void RemoveItem(OrderItem orderItem)
    {
        Items.Remove(orderItem);
    }

    public double Total()
    {
        double total = 0;
        foreach (var item in Items)
        {
            total += item.subTotal();
        }

        return total;
    }

    public override string ToString()
    {
        StringBuilder  stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Order moment:" + Moment);
        stringBuilder.AppendLine("Order status:" + Status);
        stringBuilder.AppendLine("Client:" + Client);
        stringBuilder.AppendLine("Order items:");
        foreach (var item in Items){
        stringBuilder.AppendLine(item.ToString());
        }
        
        stringBuilder.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
        return stringBuilder.ToString();
    }
}