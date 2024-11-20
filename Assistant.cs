using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal class Assistant : Professional
    {
        public Assistant(string firstName, string lastName, decimal athleteSalary) : base(firstName, lastName)
        {
            Category = "Personal Assistant";
            SalaryPercentage = 3m;
            CalculatePayment(athleteSalary);
        }
    }
}
