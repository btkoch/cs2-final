using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal class Lawyer : Professional
    {
        public Lawyer(string name, decimal athleteSalary) : base(name)
        {
            Category = "Lawyer";
            SalaryPercentage = 10m; 
            CalculatePayment(athleteSalary);
        }
    }
}
