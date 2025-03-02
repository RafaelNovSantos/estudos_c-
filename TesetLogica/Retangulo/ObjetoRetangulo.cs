using System.Globalization;

namespace TesetLogica;

public class ObjetoRetangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }


    public double Area()
    {
        return Largura * Altura;
    }

    public double Perimetro()
    {
        return 2 * Largura + 2 * Altura;
    }

    public double Diagonal()
    {
        return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
    }

    public override string ToString()
    {
        return "Area = " + Area().ToString("F2", CultureInfo.InvariantCulture) + " \nPERÍMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + " \nDIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture); ;
    }
}