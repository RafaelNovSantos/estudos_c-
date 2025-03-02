namespace TesetLogica.Matriz;

public class PositionMatriz
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(" ");
        int[,] matriz = new int[int.Parse(input[0]), int.Parse(input[1])]; 

        for (int i = 0; i < int.Parse(input[0]); i++)
        {
            string[] row = Console.ReadLine().Split(" ");

            for (int j = 0; j < int.Parse(input[1]); j++)
            {
                matriz[i, j] =  int.Parse(row[j]);
            }
        }

        Console.WriteLine("Position 0,1:" );
        Console.WriteLine("Left: " + matriz[0, 0]);
    }
}