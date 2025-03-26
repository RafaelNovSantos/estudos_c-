using System.Globalization;
using TesetLogica.Composition.Entities;
using TesetLogica.Composition.Entities.Enums;

namespace TesetLogica.Composition;

public class Composition
{
    public static void w(string[] args)
    {
        Order myOrder = new Order(); // Cria uma instância de Order
        Console.WriteLine("Enter client data:");
        DateTime date = DateTime.Now;
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Email:");
        string email = Console.ReadLine();
        Console.WriteLine("Birth date (DD/MM/YYYY):");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter order data:");
        Console.Write("Status:");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
        Console.Write("How many items to this order?:");
        int quantity = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < quantity; i++){
        Console.WriteLine($"Enter #{i + 1} item data:");
        Console.Write("Enter product name:");
        string productName = Console.ReadLine();
        Console.Write("Enter product price:");
        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Enter product quantity:");
        int quantityProduct = int.Parse(Console.ReadLine());
        
        ProductOrder product = new ProductOrder(productName, price);
        
        OrderItem orderItem = new OrderItem(quantityProduct, price, product);
        
       
        myOrder.AddItem(orderItem); // Agora a chamada é feita corretamente na instância
        
        }

        myOrder.Moment = date;
        myOrder.Status = status;
        
     
        myOrder.Client = new Client(name, email, birthDate);

        Console.WriteLine("\n\nORDER SUMMARY:");
        Console.WriteLine(myOrder);



    }
}