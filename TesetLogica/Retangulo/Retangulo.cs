using System.Globalization;

namespace TesetLogica;

internal class Retangulo
{
    public static void re(string[] args)
    {
         ObjetoRetangulo retangulo = new ObjetoRetangulo();
         
         Console.WriteLine("Entre a largura e altura do retângulo: ");
         
         retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         
         Console.WriteLine(retangulo);
    }
}