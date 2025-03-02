namespace TesetLogica.Matriz;

public class Matriz
{
    public static void h(string[] args)
    {
        int x = 0;
        int N = int.Parse(Console.ReadLine());
        int negativesNumebers = 0;
        
        double[,] matriz = new double[N, N];

        for (int i = 0; i < N; i++)
        {
            string[] row = Console.ReadLine().Split(" ");

            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = double.Parse(row[j]);

                if (double.Parse(row[j]) < 0)
                {
                    negativesNumebers++;
                }
            }
        }
        
        Console.WriteLine("Main diagonal:");
        

            for (int j = 0; j < N; j++)
            {
                
                Console.WriteLine(matriz[x, j] + " ");
                x++;
            }
        
            Console.WriteLine("Negative numbers = " + negativesNumebers);

        
    }
}