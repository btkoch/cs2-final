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
        public decimal Salary { get; set; }

        public Athlete(decimal salary) {
            Salary = salary;
        }

    }
}
