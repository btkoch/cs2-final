using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cs2_final.HiredProfessionalsDBDataSetTableAdapters;

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
            string fName, lName;
            decimal salary;
            fName = athFirstnameTxt.Text.Trim();
            lName = athLstnameTxt.Text.Trim();
            //create athlete object if valid inputs are entered then add values from object to athlete database.
            if (fName != "" && lName != "" && decimal.TryParse(salaryTxt.Text, out salary) && salary > 0)
            {
                Athlete athlete = new Athlete(fName,lName,salary);

                this.athletesTableAdapter.Insert(athlete.Firstname, athlete.Lastname, athlete.Salary);
                this.tableAdapterManager.UpdateAll(this.hiredProfessionalsDBDataSet);
                this.athletesTableAdapter.Fill(this.hiredProfessionalsDBDataSet.Athletes);
                //testing to get database to save data
                this.Validate();
                this.athletesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hiredProfessionalsDBDataSet);

            }
            else
            {
                MessageBox.Show("Enter valid athlete information");
            }
            
        }
        private void hireProfBtn_Click(object sender, EventArgs e)
        {
            SetAthIDandAthSal();
            if (athID > 0) 
            {
                //pass the athlete salary and athleteID to the new form
                var professionalsForm = new ProfessionalsForm(athID, athSal);
                professionalsForm.Closed += (s, args) => this.Close();
                professionalsForm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Select an athlete in the table to hire professionals for selected athlete.");
            }
        }

        private void salaryTxt_TextChanged(object sender, EventArgs e)
        {
            // Only enable submit button when valid number is entered
            if (decimal.TryParse(salaryTxt.Text, out salary) && salary > 0) { submitBtn.Enabled = true; }
            else { submitBtn.Enabled = false; }
        }

        private void AthleteSalary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hiredProfessionalsDBDataSet.Athletes' table. You can move, or remove it, as needed.
            this.athletesTableAdapter.Fill(this.hiredProfessionalsDBDataSet.Athletes);
        }

        int athID;
        decimal athSal;
        private void SetAthIDandAthSal()
        {
            //gathers the cell values for athleteID and Salary
            //uses the binding navigator text box to get current row and sets athID & athSal values.
            athID = (int)athletesDataGridView.Rows[int.Parse(bindingNavigatorPositionItem.Text) - 1].Cells[0].Value;
            if (athID < 1) { return; }
            athSal = (decimal)athletesDataGridView.Rows[int.Parse(bindingNavigatorPositionItem.Text) - 1].Cells[3].Value;
            
        }
    }
}
