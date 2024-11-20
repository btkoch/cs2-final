using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal class Lawyer : Professional
    {
        public Lawyer(string firstName, string lastName, decimal athleteSalary) : base(firstName, lastName)
        {
            Category = "Lawyer";
            SalaryPercentage = 10m; 
            CalculatePayment(athleteSalary);
        }
    }
}
