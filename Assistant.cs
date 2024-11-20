using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal class Assistant : Professional
    {
        public Assistant(string name, decimal athleteSalary) : base(name)
        {
            Category = "Personal Assistant";
            SalaryPercentage = 3m;
            CalculatePayment(athleteSalary);
        }
    }
}
