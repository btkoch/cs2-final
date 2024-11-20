using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal abstract class Professional
    {
        
        public string FirstName { get; set; }//first name
        public string LastName { get; set; }//last name
        public string Category { get; protected set; }//professional type
        public decimal SalaryPercentage { get; protected set; } 
        public decimal Payment {  get; protected set; }//professionals salary

        public Professional(string firstName, string lastName)
        {
            FirstName = firstName; 
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Category} | ${Payment:C}";
        }

        public void CalculatePayment(decimal athleteSalary)
        {
            Payment = athleteSalary * SalaryPercentage / 100;
        }
    }
}
