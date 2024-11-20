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
        // Fields
        private readonly decimal _athleteSalary;

        // Properties

        //Constructors
        public ProfessionalsForm(decimal athleteSalary)
        {
            InitializeComponent();
            _athleteSalary = athleteSalary;
        }

        // Methods
        private void AddProfessional()
        {
            var prof = GetProfessional();
            if (prof == null) { return; }

            // TODO: Figure out why prof.Salary is always 0
            MessageBox.Show(prof.Payment.ToString());
        }

        private Professional GetProfessional()
        {
            // Return professional based on selected category
            switch (GetSelectedCategory().Tag.ToString())
            {
                case ("lawyer"):
                    return new Lawyer(nameTxt.Text.Trim(), _athleteSalary);
                case ("asst"):
                    return new Assistant(nameTxt.Text.Trim(), _athleteSalary);
                case ("agent"):
                    return new Agent(nameTxt.Text.Trim(), _athleteSalary);
                case ("trainer"):
                    return new Trainer(nameTxt.Text.Trim(), _athleteSalary);
                default:
                    return null;
            }
        }

        private RadioButton GetSelectedCategory()
        {
            foreach (RadioButton rb in categoryPnl.Controls)
            {
                if (rb.Checked) { return rb; }
            }
            return null;
        }

        // Events
        private void ProfessionalsForm_Load(object sender, EventArgs e)
        {
            salaryLbl.Text = _athleteSalary.ToString("C");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Only continue if a category is selected
            if (GetSelectedCategory() == null) return;

            AddProfessional();
        }
    }
}
