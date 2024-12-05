using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs2_final
{
    public partial class ProfessionalsForm : Form
    {
        decimal _athleteSalary;
        int _athID;

        public ProfessionalsForm(int athID, decimal athleteSalary)
        {
            //set athlete salary and athlete ID
            InitializeComponent();
            _athleteSalary = athleteSalary;
            _athID = athID;
        }
        private void AddProfessional()
        {
            Professional prof = GetProfessional();
            if (prof == null) { return; }
            //add created professionals object to professionals database and update datagridview
            this.professionalsTableAdapter.Insert(prof.FirstName, prof.LastName, prof.Category, prof.Payment, _athID);
            this.tableAdapterManager.UpdateAll(this.hiredProfessionalsDBDataSet);
            //this.professionalsTableAdapter.Fill(this.hiredProfessionalsDBDataSet.Professionals);
            //filters out professionals hired by other athletes
            this.professionalsTableAdapter.FillBy(this.hiredProfessionalsDBDataSet.Professionals, _athID);
            UpdatePreviewData();
        }
        private Professional GetProfessional()
        {
            try
            {
                string[] name = nameTxt.Text.Trim().Split(' ');
                if (name.Length != 2)
                {
                    MessageBox.Show("Enter first and last name only, or check for and remove double spaces", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                // Return professional based on selected category
                switch (SelectedCategory().Tag.ToString())
                {
                    case ("lawyer"):
                        {
                            Lawyer prof = new Lawyer(name[0], name[1], _athleteSalary);
                            return prof;
                        }
                    case ("asst"):
                        {
                            Assistant prof = new Assistant(name[0], name[1], _athleteSalary);
                            return prof;
                        }
                    case ("agent"):
                        {
                            Agent prof = new Agent(name[0], name[1], _athleteSalary);
                            return prof;
                        }

                    case ("trainer"):
                        {
                            Trainer prof = new Trainer(name[0], name[1], _athleteSalary);
                            return prof;
                        }
                           
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Updates count of each prof type, total expenditures, and athlete's remaining salary
        private void UpdatePreviewData()
        {
            // Counts by type:
            lawyerCountLbl.Text = this.professionalsTableAdapter.CountProfessional(_athID, "Lawyer").ToString();
            asstCountLbl.Text = this.professionalsTableAdapter.CountProfessional(_athID, "Personal Assistant").ToString();
            agentCountLbl.Text = this.professionalsTableAdapter.CountProfessional(_athID, "Agent").ToString();
            trainerCountLbl.Text = this.professionalsTableAdapter.CountProfessional(_athID, "Trainer").ToString();

            // Total expenses:
            decimal totalExpenses = 0;
            if (this.professionalsDataGridView.Rows[0].Cells[0].Value != null)
            {
                totalExpenses = (decimal)this.professionalsTableAdapter.SumSalaries(_athID);
            }
            totalSpentLbl.Text = totalExpenses.ToString("C");

            // Remaining salary:
            remainingLbl.Text = (_athleteSalary - totalExpenses).ToString("C");

        }

        private RadioButton SelectedCategory()
        {
            foreach (RadioButton rb in categoryPnl.Controls)
            {
                if (rb.Checked) { return rb; }
            }
            return null;
        }

        private void ProfessionalsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hiredProfessionalsDBDataSet.Professionals' table. You can move, or remove it, as needed. 
            this.professionalsTableAdapter.Fill(this.hiredProfessionalsDBDataSet.Professionals);
            this.professionalsTableAdapter.FillBy(this.hiredProfessionalsDBDataSet.Professionals,_athID);
            salaryLbl.Text = _athleteSalary.ToString("C");
            athIDLbl.Text = _athID.ToString();
            UpdatePreviewData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Only continue if a category is selected
            if (SelectedCategory() == null)
            {
                MessageBox.Show("Select a category to continue",this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddProfessional();
        }

        private void professionalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professionalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hiredProfessionalsDBDataSet);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AthleteSalary athleteSalary = new AthleteSalary();
            athleteSalary.Show();
            this.Hide();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this\n     professional from the database?", "Remove Professional", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //gathers the cell values for row to remove
                int row = int.Parse(bindingNavigatorPositionItem.Text) - 1;
                if (row >= 0)
                {
                    //show message with professional type, and name of professional removed
                    MessageBox.Show($"{this.professionalsDataGridView.Rows[row].Cells[3].Value.ToString()}:  " +
                                    $"{this.professionalsDataGridView.Rows[row].Cells[1].Value.ToString()} " +
                                    $"{this.professionalsDataGridView.Rows[row].Cells[2].Value.ToString()} removed from database");

                    //uses the binding navigator text box to get current row and sets athID & athSal values.
                    professionalsDataGridView.Rows.RemoveAt(row);
                    //call methods to save changes to DB
                    this.Validate();
                    this.professionalsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.hiredProfessionalsDBDataSet);

                    //call method to update counters and labels
                    UpdatePreviewData();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }


        }
    }
}
