using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication2
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void frmComputeSalary_Load(object sender, EventArgs e)
        {

        }

        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string dept = txtDepartment.Text;
            string jobTitle = txtJobTitle.Text;
            double rate = Convert.ToDouble(txtRatePerHour.Text);
            int hours = Convert.ToInt32(txtHoursWorked.Text);

            PartTimeEmployee employee = new PartTimeEmployee(fName, lName, dept, jobTitle);

            employee.computeSalary(hours, rate);

            lblFirstName.Text = employee.FirstName;
            lblLastName.Text = employee.LastName;
            lblSalary.Text = employee.getSalary().ToString("0.00");

        }
    }
}
