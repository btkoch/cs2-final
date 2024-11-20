using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal class Agent : Professional
    {
        public Agent(string firstName, string lastName, decimal athleteSalary) : base(firstName, lastName)
        {
            Category = "Agent";
            SalaryPercentage = 7m;
            CalculatePayment(athleteSalary);
            // fart
        }
    }
}
