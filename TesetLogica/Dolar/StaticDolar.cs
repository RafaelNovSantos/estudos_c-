namespace TesetLogica.Dolar;

public class StaticDolar
{
  public static double GetReais( double cotacao, double dolar)
  {
    double valueReais = dolar * cotacao;
    double calcIoF = valueReais / 100 * 6;
    return calcIoF + valueReais;
  }  
}