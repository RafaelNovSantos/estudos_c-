using System.Globalization;
using TesetLogica.Funcionario;
using TesetLogica.HerancaEPolimorfismo.Entities;

namespace TesetLogica.HerancaEPolimorfismo;

public class POO
{
    public static void h(string[] args)
    {
        List<ProductPOO> lista = new List<ProductPOO>();
        
        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Product #{i} data:");
            Console.Write("Common, used or imported (c/u/i)?");
            string common = Console.ReadLine();
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (common == "u")
            {
                Console.Write("Manufacture date (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                lista.Add(new UsedProduct(name, price, date));
            }else if (common == "i")
            {
                Console.WriteLine("Customs fee:");
                double cost = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                
                lista.Add(new ImportedProdutct(name, price,cost));
            }
            else
            {
                lista.Add(new ProductPOO(name, price));
            }
        }

        Console.WriteLine("PRICE TAGS:");
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }
}