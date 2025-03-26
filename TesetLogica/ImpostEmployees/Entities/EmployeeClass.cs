using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesetLogica.ImpostEmployees.Entities
{
    public abstract class EmployeeClass
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        public EmployeeClass()
        {
        }

        public EmployeeClass(string name ,double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

    }
}
