using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesetLogica.ImpostEmployees.Entities
{
    public class IndividualEmployee : EmployeeClass
    {
        public double HealthExpenditures { get; set; }

        public IndividualEmployee()
        {
        }

        public IndividualEmployee(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {

            double anualIcomeCalc = 0.0;
            double total = 0.0;
            if (AnualIncome < 20000.00)
            {
                anualIcomeCalc = AnualIncome * 0.15;
            }
            else if(AnualIncome >= 20000.00)
            {
                anualIcomeCalc = AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0)
            {
                total = anualIcomeCalc - (HealthExpenditures * 0.5);
            }

            return total;
        }

        override public string ToString()
        {
            return Name + ": $" + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
