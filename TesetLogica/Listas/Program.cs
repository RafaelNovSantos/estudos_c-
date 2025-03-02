using System.Globalization;

namespace TesetLogica.Listas;

public class Program
{
    public static void q(string[] args)
    {
        List<Employee> employee = new List<Employee>();
        
        Console.Write("How many employees will be registered?");
        int registrees = int.Parse(Console.ReadLine());
        for (int i = 0; i < registrees; i++)
        {
            Console.WriteLine($"Emplyonee #{i + 1}:");
            
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            employee.Add(new Employee()
            {
                Id = id,
                Name = name,
                Salary = salary
            });
        }
        
        Console.Write("Enter the employee id that will have salary increase: ");
        int employeeId = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the percentage: ");
        double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Employee.IncreaseSalary(employeeId, percentage, employee );


        foreach (var e in employee)
        {
            Console.WriteLine(e);
        }
    }
}