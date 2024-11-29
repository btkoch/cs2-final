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
        //dont think we need a list now since we will use datagrid view and database to store info
        //private List<Professional> _professionalList = new List<Professional>();

        public ProfessionalsForm(int athID, decimal athleteSalary)
        {
            InitializeComponent();
            _athleteSalary = athleteSalary;
            _athID = athID;
        }
        //method to set athlete salary and athlete ID

        private void AddProfessional()
        {
            Professional prof = GetProfessional();
            //if (prof == null) { return; }
            //add created professionals object to professionals database and update datagridview
            this.professionalsTableAdapter.Insert(prof.FirstName, prof.LastName, prof.Category, prof.Payment, _athID);
            this.tableAdapterManager.UpdateAll(this.hiredProfessionalsDBDataSet);
            this.professionalsTableAdapter.Fill(this.hiredProfessionalsDBDataSet.Professionals);
            RefreshPreview();
        }

        private void RefreshPreview()
        {
            //add code to update professionals table
        }

        private Professional GetProfessional()
        {
            try
            {
                string[] name = nameTxt.Text.Trim().Split(' ');
                if (name.Length > 2)
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
            //this.professionalsTableAdapter.Fill(this.hiredProfessionalsDBDataSet.Professionals);
            salaryLbl.Text = _athleteSalary.ToString("C");
            athIDLbl.Text = _athID.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Only continue if a category is selected
            if (SelectedCategory() == null) return;

            AddProfessional();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {

        }

        private void professionalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professionalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hiredProfessionalsDBDataSet);

        }
    }
}
