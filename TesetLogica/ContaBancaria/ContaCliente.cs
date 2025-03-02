namespace TesetLogica.ContaBancaria;

public class ContaCliente
{
    public static int NumeroConta { get; private set; }
    public static string NomeCliente { get; set; }
    public static double Saldo { get; set; }

    public ContaCliente(int numeroConta, string nomeCliente)
    {
        NumeroConta = numeroConta;
        NomeCliente = nomeCliente;
    }

    public ContaCliente(int numeroConta, string nomeCliente, double saldo) : this(numeroConta, nomeCliente)
    {
        Saldo = saldo;
    }

    public static void DepositoConta(double deposito)
    {
        Saldo = Saldo + deposito;
    }

    public static void SaqueConta(double saque)
    {
        int taxaSaque = 5;

        Saldo = Saldo - saque - taxaSaque;
    }

    public override string ToString()
    {
        return "Conta: " + NumeroConta + ", Titular: " + NomeCliente + ", Saldo: " + "$ " + Saldo;
    }
}