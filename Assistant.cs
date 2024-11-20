using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal class Assistant : Professional
    {
        // Fields
        private static decimal _rate = .03m;
        private string _profession = "Personal Assistant";
        
        // Properties

        // Constructors
        public Assistant(decimal athleteSalary) { _athleteSalary = athleteSalary; }

        // Methods

        protected override decimal GetRate()
        {
            return _rate;
        }

    }
}
