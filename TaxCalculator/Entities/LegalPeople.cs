using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Entities
{
    internal class LegalPeople : People
    {
        public int Employees { get; set; }

        public LegalPeople()
        {
        }

        public LegalPeople(string name, double annualIncome, int employees) : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            double tax = 0;

            if(Employees > 10) 
            {
                tax = AnnualIncome * 0.14;
            } else
            {
                tax = AnnualIncome * 0.16;
            }

            return tax;
        }
    }
}
