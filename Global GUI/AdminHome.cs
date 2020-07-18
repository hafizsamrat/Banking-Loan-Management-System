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
using Customer;
using Employee;
using Admin;

namespace Global_GUI
{
    public partial class AdminHome : MetroForm
    {
        private Login login;
        private AdminData ad;
        EmployeeInformation eh;
        CheckCustomerTransactions cct;
        CustomerInfo customerInfo;
        ManageEmployee me;
        ManageLoans ml;
        public AdminHome(Login login, AdminData ad)
        {
            InitializeComponent();
            this.login = login;
            this.ad = ad;
            var sq = Admin.DataAccess.Sqcon;
            welcomeLabel.Text = "Welcome " + ad.Name;
            sq = Employee.DataAccess.Sqcon;
            sq = Customer.DataAccess.Sqcon;
            Admin.DataAccess.loanAutoUpdate();
        }

        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login.Visible = true;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (eh == null) eh = new EmployeeInformation(this, ad);
            eh.Visible = true;
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

        private void manageEmployeeBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (me == null) me = new ManageEmployee(this);
            me.Visible = true;
        }

        private void manageLoansBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (ml == null) ml = new ManageLoans(this);
            ml.Visible = true;
        }
    }
}
