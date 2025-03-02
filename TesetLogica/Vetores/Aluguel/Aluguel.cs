namespace TesetLogica.Vetores.Aluguel;

public class Aluguel
{
    public static void p(string[] args)
    {
        Estudante[] estudantes = new Estudante[10];

        Console.Write("How many rooms will be rented?");
        int roomsBusy = int.Parse(Console.ReadLine());

        for (int i = 0; i < roomsBusy; i++)
        {
            Console.WriteLine("Rent #" + ++i);
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Email:");

            string email = Console.ReadLine();
            Console.Write("Room:");

            int room = int.Parse(Console.ReadLine());

            estudantes[room] = new Estudante
            {
                Name = name,
                Email = email,
                Room = room
            };

            i = --i;
        }
        
        Console.WriteLine("Busy rooms:");
        for (int i = 0; i < estudantes.Length; i++)
        {
            if (estudantes[i] != null)
            {
                Console.WriteLine(estudantes[i].Room + ":" + estudantes[i].Name + "," + estudantes[i].Email);
            }
        }
    }
}