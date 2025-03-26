using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesetLogica.ImpostEmployees.Entities
{
    public class CompanyEmployee : EmployeeClass
    {

        public int NumberEmployees { get; set; }

        public CompanyEmployee()
        {
        }

        public CompanyEmployee(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }


        public override double Tax()
        {

            double anualIncome = 0.0;
            if (NumberEmployees < 10)
            {
                anualIncome = AnualIncome * 0.16;
            }
            else
            {
                anualIncome = AnualIncome * 0.14;
            }

            return anualIncome;
        }

        public override string ToString()
        {
            return base.ToString() +  Tax().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
