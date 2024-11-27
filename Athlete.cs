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
        private string _firstname;
        private string _lastname;
        private decimal _salary;

        public string Firstname { get { return _firstname; } set { _firstname = value; } }
        public string Lastname { get { return _lastname; } set { _lastname = value; } }
        public decimal Salary { get { return _salary; } set { _salary = value; } }
        

        public Athlete(string fN, string lN, decimal salary) {
            Firstname = fN; Lastname = lN; Salary = salary;
        }

    }
}
