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
        private readonly decimal _salary;

        // Properties

        //Constructors
        public ProfessionalsForm(decimal salary)
        {
            InitializeComponent();
            _salary = salary;
        }

        // Methods
        private void AddProfessional()
        {
            var prof = GetProfessional();
            if (prof == null) { return; }

            // TODO: Figure out why prof.Salary is always 0
            MessageBox.Show(prof.ToString());
        }

        private Professional GetProfessional()
        {
            // Return professional based on selected category
            switch (GetSelectedCategory().Tag.ToString())
            {
                case ("lawyer"):
                    return new Lawyer(_salary);
                case ("asst"):
                    return new Assistant(_salary);
                case ("agent"):
                    return new Agent(_salary);
                case ("trainer"):
                    return new Trainer(_salary);
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
            salaryLbl.Text = _salary.ToString("C");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Only continue if a category is selected
            if (GetSelectedCategory() == null) return;

            AddProfessional();
        }
    }
}
