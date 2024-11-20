using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2_final
{
    internal abstract class Professional
    {
        // Fields
        private string _name;
        private decimal _salary;
        public decimal _athleteSalary;

        // Properties
        public string Name
        { 
            get { return _name; }
            set { _name = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = GetRate() * _athleteSalary; }
        }
        
        // Constructors

        // Methods
        public override string ToString() { return _name + ", " + GetProfession()+ ", " +_salary; }

        protected virtual decimal GetRate()
        {
            return 0;
        }

        protected virtual string GetProfession()
        {
            return "";
        }
    }
}
