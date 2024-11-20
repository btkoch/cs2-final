using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal class Agent : Professional
    {
        // Fields
        private readonly decimal _rate = .07m;
        private string _profession = "Agent";

        // Properties

        // Constructors
        public Agent(decimal athleteSalary) { _athleteSalary = athleteSalary; }

        //Methods
        protected override decimal GetRate()
        {
            return _rate;
        }

    }
}
