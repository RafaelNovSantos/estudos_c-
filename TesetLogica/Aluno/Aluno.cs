using System.Globalization;

namespace TesetLogica;

public class Aluno
{
    public string Nome { get; set; }
    public double Nota { get; set; }


    public string Aprovação()
    {
        if (Nota >= 60)
        {
            return "APROVADO";
        }
        double pontosFaltantes = 60 - Nota; 
        return  "REPROVADO \n" + "FALTARAM " + pontosFaltantes + " PONTOS";
    }
    
    public override string ToString()
    {
        return  "NOTA FINAL = " + Nota + "\n" + Aprovação();
    }
}