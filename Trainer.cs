using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal class Trainer : Professional
    {
        public Trainer(string firstName, string lastName, decimal athleteSalary) : base(firstName, lastName)
        {
            Category = "Trainer";
            SalaryPercentage = 5m;
            CalculatePayment(athleteSalary);
        }
    }
}
