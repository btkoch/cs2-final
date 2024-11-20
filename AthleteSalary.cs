using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cs2_final.athleteDataSetTableAdapters;

namespace cs2_final
{
    public partial class AthleteSalary : Form
    {
        private decimal salary;
        public AthleteSalary()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var athlete = new Athlete(decimal.Parse(salaryTxt.Text));
            var professionalsForm = new ProfessionalsForm(salary);
            professionalsForm.Closed += (s, args) => this.Close();
            professionalsForm.Show();
            this.Hide();
        }

        private void salaryTxt_TextChanged(object sender, EventArgs e)
        {
            // Only enable submit button when valid number is entered
            if (decimal.TryParse(salaryTxt.Text, out salary) && salary > 0) { submitBtn.Enabled = true; }
            else { submitBtn.Enabled = false; }
        }

        private void AthleteSalary_Load(object sender, EventArgs e)
        {
        }
    }
}
