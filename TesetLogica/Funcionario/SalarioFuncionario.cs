using System.Globalization;

namespace TesetLogica.Funcionario;

public class SalarioFuncionario
{
    public static void d(string[] args)
    {
        Funcionario funcionario = new Funcionario();

        Console.WriteLine("Digite seu nome:");

        funcionario.Nome = Console.ReadLine();

        Console.WriteLine("Digite seu salário bruto:");

        funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o imposto:");

        funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(funcionario);
        Console.WriteLine("Digite a porcentagem para aumentar o salário:");

        double salarioPorcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        funcionario.AumentarSalario(salarioPorcentagem);

        Console.WriteLine("Dados atualizados: " + funcionario);
    }
}