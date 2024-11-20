using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal abstract class Professional
    {
        public string Name { get; set; }
        public string Category { get; protected set; }
        public decimal SalaryPercentage { get; protected set; } 
        public decimal Payment {  get; protected set; }

        public Professional(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}, {Category}, {Payment:C}";

        }

        public void CalculatePayment(decimal athleteSalary)
        {
            Payment = athleteSalary * SalaryPercentage / 100;
        }
    }
}
