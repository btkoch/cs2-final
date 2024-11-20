using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal class Agent : Professional
    {
        public Agent(string name, decimal athleteSalary) : base(name)
        {
            Category = "Agent";
            SalaryPercentage = 7m;
            CalculatePayment(athleteSalary);
        }
    }
}
