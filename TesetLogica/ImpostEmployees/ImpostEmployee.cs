using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesetLogica.ImpostEmployees.Entities;

namespace TesetLogica.ImpostEmployees;

    internal class ImpostEmployee
    {
        public static void Main()
        {
             List<EmployeeClass> list = new List<EmployeeClass>();

             Console.WriteLine("Enter the number of tax payers:");
             int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name:");
                string name = Console.ReadLine();

                Console.Write("Anual income:");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (type == 'i')
                {
                Console.WriteLine("Health expenditures:");
                double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new IndividualEmployee(name, anualIncome, healthExpenditures));
            }
                else if (type == 'c')
            {
                Console.WriteLine("Number of employees:");
                int numberOfEmployees = int.Parse(Console.ReadLine());
                list.Add(new CompanyEmployee(name, anualIncome, numberOfEmployees));
            }
            
            }

        Console.WriteLine("TAXES PAID:");
        double sum = 0;
        foreach (var item in list)
        {
            sum += item.Tax();
            Console.WriteLine(item.ToString());
        }

        Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");

    }
    }

