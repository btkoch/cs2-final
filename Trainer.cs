using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal class Trainer : Professional
    {
        // Fields
        private static decimal _rate = .05m;
        private string _profession = "Trainer";

        // Properties

        // Constructors
        public Trainer(decimal athleteSalary) { _athleteSalary = athleteSalary; }

        // Methods
        protected override decimal GetRate()
        {
            return _rate;
        }

    }
}
