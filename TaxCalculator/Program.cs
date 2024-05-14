using System;
using TaxCalculator.Entities;
using System.Globalization;

namespace TaxCaculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>();
            Console.Write("Enter the number of tax payers: ");
            int numPeople = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numPeople; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Induvidual or company (i / c): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    peoples.Add(new PhysicalPeople(name,anualIncome, healthExpenses));
                } 
                else if (type == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    peoples.Add(new LegalPeople(name, anualIncome, employees));
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double totalTax = 0.0;
            foreach(People people in peoples)
            {
                Console.WriteLine($"{people.Name}: $ {people.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTax += people.Tax();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {totalTax.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}