using System.Globalization;

namespace TesetLogica.ContaBancaria;

public class ContaBancaria
{
    public static void g(string[] args)
    {
        ContaCliente contaCliente;
        double depositoInicial;
        Console.WriteLine("Entre o número da conta:");

        int numeroConta = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre o titular da conta:");

        string nomeCliente = Console.ReadLine();

        Console.WriteLine("Haverá depósito inicial (s/n)?");

        char deposito = char.Parse(Console.ReadLine());

        if (deposito == 's')
        {
            Console.WriteLine("Entre o valor de depósito inicial:");

            depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaCliente = new ContaCliente(numeroConta, nomeCliente, depositoInicial);
            Console.WriteLine();
        }
        else
        {
            contaCliente = new ContaCliente(numeroConta, nomeCliente);
        }



        Console.WriteLine("Dados da conta: " + contaCliente);

        Console.WriteLine("Entre o valor para depósito:");

        depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ContaCliente.DepositoConta(depositoInicial);

        Console.WriteLine("Dados da conta atualizados \n: " + contaCliente);
        Console.WriteLine();
        
        Console.WriteLine("Entre o valor para saque:");

        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ContaCliente.SaqueConta(saque);

        Console.WriteLine("Dados da conta atualizados:\n " + contaCliente);
        Console.WriteLine();
    }
}