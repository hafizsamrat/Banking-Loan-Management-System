using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Employee;
using Customer;

namespace Global_GUI
{
    public partial class EmployeeHome : MetroForm
    {
        private Login login;
        private EmployeeData ed;
        EmployeeInformation eh;
        EmployeeTransaction et;
        CheckCustomerTransactions cct;
        LoanApplication la;
        CustomerInfo customerInfo;
        MyLoans ml;
        public EmployeeHome(Login login,EmployeeData ed)
        {
            InitializeComponent();
            this.ed = ed;
            this.login = login;
            var sq = Employee.DataAccess.Sqcon;
            sq = Customer.DataAccess.Sqcon;
            welcomeLabel.Text = "Welcome " + ed.Name;
        }

        private void EmployeeHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (eh == null) eh = new EmployeeInformation(this, ed);
            eh.Visible = true;
        }

        private void employeeTransactionBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (et == null) et = new EmployeeTransaction(this, ed);
            et.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login.Visible = true;
        }

        private void customerTransactionsBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (cct == null) cct = new CheckCustomerTransactions(this);
            cct.Visible = true;
        }

        private void manageCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (customerInfo == null) customerInfo = new CustomerInfo(this);
            customerInfo.Visible = true;
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void applyLoanBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (la == null) la = new LoanApplication(this, ed);
            la.Visible = true;
        }

        private void myLoansBtn_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            if (ml == null) ml = new MyLoans(this, ed);
            ml.Visible = true;
        }
    }
}
