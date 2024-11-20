using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    // Probably should find a way to make this private,
    // but the compiler isn't happy unless it's public.
    public class Athlete
    {
        private decimal _salary;

        public decimal Salary { 
            get { return _salary; } 
            set { _salary = value; } 
        }

        public Athlete(decimal salary) {
            _salary = salary;
        }

    }
}
