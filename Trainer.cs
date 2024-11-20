using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal class Trainer : Professional
    {
        public Trainer(string name, decimal athleteSalary) : base(name)
        {
            Category = "Trainer";
            SalaryPercentage = 5m;
            CalculatePayment(athleteSalary);
        }
    }
}
