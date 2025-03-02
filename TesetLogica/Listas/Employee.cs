using System.Globalization;

namespace TesetLogica.Listas;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public static void IncreaseSalary(int id, double percentageSalary, List<Employee> employee)
    {
        Employee incrementSalary = employee.Find(e => e.Id == id);

        if (incrementSalary != null)
        {
            incrementSalary.Salary = ((incrementSalary.Salary / 100) * percentageSalary) + incrementSalary.Salary;
        }
    }

    public override string ToString()
    {
     
        return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
    }
}