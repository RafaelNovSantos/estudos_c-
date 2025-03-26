using System.Text;

namespace TesetLogica.Valid_Sudoku;

public class Sudoku
{
    public int NumTabu { get; set; }
    public int NumColunaTab { get; set; }
    public int NumLinhaTab { get; set; }
    public char ValorTabu { get; set; }

    public Sudoku( int numLinhaTab, int numColunaTab, char valorTabu)
    {
        NumTabu = 0;
        NumColunaTab = numColunaTab;
        NumLinhaTab = numLinhaTab;
        ValorTabu = valorTabu;
    }
    
   public static List<Sudoku> lista = new List<Sudoku>();

    public static void s()
    {
        char[][] board =
        {
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
            new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' }

        };

        int numeroTabu = 1;

        for (int blocoLinha = 0; blocoLinha < 9; blocoLinha += 3) // Percorre os blocos 3x3 na vertical
        {
            for (int blocoColuna = 0; blocoColuna < 9; blocoColuna += 3) // Percorre os blocos 3x3 na horizontal
            {
                for (int i = 0; i < 3; i++) // Dentro do bloco, percorre as 3 linhas
                {
                    for (int j = 0; j < 3; j++) // Dentro do bloco, percorre as 3 colunas
                    {
                        int linha = blocoLinha + i;
                        int coluna = blocoColuna + j;
                        lista.Add(new Sudoku(linha, coluna, board[linha][coluna]) { NumTabu = numeroTabu });
                    }
                }
                numeroTabu++; // Atualiza para o próximo bloco 3x3
            }
        }

        char[] ints = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        for (int i = 0; i < 9; i++)
        {

        

            foreach (var item in lista)
            {
                if (item.ValorTabu == '.')
                {
                    List<Sudoku> listaNumTabela = lista.FindAll(x => x.NumTabu == item.NumTabu);
                    List<Sudoku> listaNumLinhaTab = lista.FindAll(x => x.NumLinhaTab == item.NumLinhaTab);
                    List<Sudoku> listaColumTab = lista.FindAll(x => x.NumColunaTab == item.NumColunaTab);

                    var notContainsInListaTabela = ints.Where(k => !listaNumTabela.Any(x => x.ValorTabu == k)).ToList();
                    var notContainsInListaNumLinhaTab = ints.Where(k => !listaNumLinhaTab.Any(x => x.ValorTabu == k)).ToList();
                    var notContainsInListaColumTab = ints.Where(k => !listaColumTab.Any(x => x.ValorTabu == k)).ToList();

                    var numOK = notContainsInListaTabela.Intersect(notContainsInListaNumLinhaTab).Intersect(notContainsInListaColumTab).ToList();

                    if (numOK.Count > 1)
                    {
                   
                }
                else
                {
                    var firstNum = numOK.FirstOrDefault();
                    item.ValorTabu = firstNum;
                }

               
                }
            }
        }

        foreach (var item in lista)
        {
            if (item.ValorTabu == '.')
            {
                Console.WriteLine("Deu errado");
            }
            else if (item.ValorTabu == '\0')
            {
                Console.WriteLine("Deu certo");
            }
           
        }
    }

   
    public static string ListaToString()
    {
        StringBuilder sb = new StringBuilder(); 
        foreach (var sudoku in lista)
        {
            sb.AppendLine(sudoku.ToString());
        };
        return sb.ToString();
    }

    public override string ToString()
    {
        return $"Numero Tabela: {NumTabu}, Linha: {NumLinhaTab}, Coluna: {NumColunaTab}, Valor: {ValorTabu}";
    }
}