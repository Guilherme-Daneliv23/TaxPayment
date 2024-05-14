using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Entities
{
    abstract internal class People
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public People() 
        {
        }

        public People(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
