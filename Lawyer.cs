using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal class Lawyer : Professional
    {
        // Fields
        private readonly decimal _rate = .1m;
        private readonly string _profession = "Lawyer";

        // Properties

        // Constructors
        public Lawyer(decimal athleteSalary): base ()
            
        {
            _athleteSalary = athleteSalary;
        }

        // Methods
        protected override decimal GetRate()
        {
            return _rate;
        }

        protected override string GetProfession()
        {
            return _profession;
        }
        
    }
}
