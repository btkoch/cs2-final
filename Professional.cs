using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal abstract class Professional
    {
        
        public string Name { get; set; }//first name
        public string LastName { get; set; }//last name
        public string Category { get; protected set; }//professional type
        public decimal SalaryPercentage { get; protected set; } 
        public decimal Payment {  get; protected set; }//professionals salary

        public Professional(string name, string lstName)
        {
            Name = name; LastName = lstName;
        }

        public override string ToString()
        {
            return $"{Name}, {LastName},: {Category}, : ${Payment:C}";
        }

        public void CalculatePayment(decimal athleteSalary)
        {
            Payment = athleteSalary * SalaryPercentage / 100;
        }
    }
}
