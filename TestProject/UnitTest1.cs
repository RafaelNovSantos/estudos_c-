using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesetLogica.Valid_Sudoku;
using Xunit;

namespace TesetLogica.Valid_Sudoku.Tests
{
    public class SudokuTests
    {
        [Fact]
        public void Sudoku_Constructor_ShouldInitializeProperties()
        {
            // Arrange
            int numLinhaTab = 1;
            int numColunaTab = 2;
            char valorTabu = '5';

            // Act
            var sudoku = new Sudoku(numLinhaTab, numColunaTab, valorTabu);

            // Assert
            Assert.Equal(0, sudoku.NumTabu);
            Assert.Equal(numLinhaTab, sudoku.NumLinhaTab);
            Assert.Equal(numColunaTab, sudoku.NumColunaTab);
            Assert.Equal(valorTabu, sudoku.ValorTabu);
        }

        [Fact]
        public void ListaToString_ShouldReturnCorrectString()
        {
            // Arrange
            Sudoku.lista.Clear();
            Sudoku.lista.Add(new Sudoku(0, 0, '5') { NumTabu = 1 });
            Sudoku.lista.Add(new Sudoku(1, 1, '3') { NumTabu = 2 });

            // Act
            string result = Sudoku.ListaToString();

            // Assert
            string expected = "Numero Tabela: 1, Linha: 0, Coluna: 0, Valor: 5\r\nNumero Tabela: 2, Linha: 1, Coluna: 1, Valor: 3\r\n";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ToString_ShouldReturnCorrectString()
        {
            // Arrange
            var sudoku = new Sudoku(1, 2, '5') { NumTabu = 3 };

            // Act
            string result = sudoku.ToString();

            // Assert
            string expected = "Numero Tabela: 3, Linha: 1, Coluna: 2, Valor: 5";
            Assert.Equal(expected, result);
        }
    }
}