namespace TesetLogica;

internal class calculoIntervalos
{
    public static void t()
    {
        Console.Write("Digite o valor da intervalo: ");
        int intervalo = int.Parse(Console.ReadLine());
        int valuein = default;
        int valueout = default;
        for (int i = 0; i < intervalo; i++)
        {
            int valor = int.Parse(Console.ReadLine());


            if (valor >= 10 && valor <= 20)
            {
                valuein++;
            }
            else
            {
                valueout++;
            }
        }

        Console.WriteLine($"{valuein} in {valueout} out");
    }
}