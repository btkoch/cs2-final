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
        private readonly decimal _athleteSalary;
        private List<Professional> _professionalList = new List<Professional>();

        public ProfessionalsForm(decimal athleteSalary)
        {
            InitializeComponent();
            _athleteSalary = athleteSalary;
        }

        private void AddProfessional()
        {
            var prof = GetProfessional();
            if (prof == null) { return; }
            _professionalList.Add(prof);
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
                        return new Lawyer(name[0], name[1], _athleteSalary);
                    case ("asst"):
                        return new Assistant(name[0], name[1], _athleteSalary);
                    case ("agent"):
                        return new Agent(name[0], name[1], _athleteSalary);
                    case ("trainer"):
                        return new Trainer(name[0], name[1], _athleteSalary);
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
            this.professionalsTableAdapter.Fill(this.hiredProfessionalsDBDataSet.Professionals);
            salaryLbl.Text = _athleteSalary.ToString("C");
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
