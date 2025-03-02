using System;
using System.Globalization;

namespace TesetLogica
{
    internal class CalculoRaio
    {
        public static void t(string[] args)
        {
            double pi = 3.14159;

            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double total = Math.Pow(valor, 2);
            
            Console.WriteLine((total * pi).ToString("F4", CultureInfo.InvariantCulture)); 
        }
    }
}