using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Entities
{
    internal class PhysicalPeople : People
    {
        public double HealthExpenses { get; set; }

        public PhysicalPeople() 
        {
        } 

        public PhysicalPeople(string name, double annualIncome, double healthExpenses) : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Tax()
        {
            double tax = 0;

            if(AnnualIncome < 20000.00)
            {
                tax = AnnualIncome * 0.15;
            } else
            {
                tax = AnnualIncome * 0.25;
            }

            return tax - (HealthExpenses * 0.50);
        }
    }
}
