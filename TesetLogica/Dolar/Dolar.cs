using System.Globalization;

namespace TesetLogica.Dolar;

public class Dolar
{
    public static void q(string[] args)
    {
        Console.WriteLine("Qual é a cotação do dólar?");
        double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.WriteLine("Quantos dólares você vai comprar?");
        double dolarPay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        
        
        Console.WriteLine("Valor a ser pago em reais = " + StaticDolar.GetReais(cotacao, dolarPay).ToString("F2", CultureInfo.InvariantCulture));
    }
}