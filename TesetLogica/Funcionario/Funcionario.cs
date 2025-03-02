namespace TesetLogica.Funcionario;

public class Funcionario
{
    public string Nome { get; set; }
    public double SalarioBruto { get; set; }
    public double Imposto { get; set; }

    public double SalarioLiquido()
    {
         return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcentagem)
    {
        double calculo = SalarioBruto / porcentagem;
        
        SalarioBruto = calculo += SalarioBruto;
    }

    public override string ToString()
    {
        return Nome + ", " + SalarioLiquido().ToString("C");
    }
}