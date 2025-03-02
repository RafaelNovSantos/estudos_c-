using System.Globalization;

namespace TesetLogica;

internal class NotaAluno
{
    public static void w(string[] args)
    {
         Aluno aluno = new Aluno();
         
         Console.WriteLine("Digite o nome do aluno: ");
         
         aluno.Nome = Console.ReadLine();
         
         Console.WriteLine("Digite as três notas do aluno: ");


         aluno.Nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         aluno.Nota += aluno.Nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         
         aluno.Nota += aluno.Nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         aluno.Aprovação();
         
         Console.WriteLine(aluno);
    }
}