// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Globalization;
using TesetLogica;


internal class Program
{
    public static void pedido(string[] args)
    {
        Product product = new Product();

        double ValorTotal1 = 0;
        double ValorTotal2 = 0;

        Console.WriteLine("Escreva o codigo do produto: ");

        int NumeroPeca1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Coloque a quantidade do produto: ");

        int QuantidadePeca1 = int.Parse(Console.ReadLine());

        ValorTotal1 = product.CalculoValorTotal(NumeroPeca1, QuantidadePeca1);

        Console.WriteLine("Escreva o codigo do segundo produto: ");

        int NumeroPeca2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Coloque a quantidade do segundo produto: ");

        int QuantidadePeca2 = int.Parse(Console.ReadLine());

        ValorTotal2 = product.CalculoValorTotal(NumeroPeca2, QuantidadePeca2);

        double Total = ValorTotal1 + ValorTotal2;
        Console.WriteLine(Total.ToString("F2"), CultureInfo.InvariantCulture);
        Console.ReadLine();
    }
}