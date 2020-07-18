using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Customer;

namespace Global_GUI
{
    public partial class CustomerHome : MetroForm
    {
        private Login login;
        private CustomerData cd;
        CustomerInformation ci;
        MyTransactions mytransaction;
        LoanApplication la;
        MyLoans ml;
        public CustomerHome(Login login, CustomerData cd)
        {
            InitializeComponent();
            this.login = login;
            this.cd = cd;
            welcomeLabel.Text = "Welcome " + cd.Name;
            var sq = Customer.DataAccess.Sqcon;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (ci == null) ci = new CustomerInformation(this, cd);
            ci.Visible = true;
        }

        private void CustomerHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login.Visible = true;
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if(mytransaction==null) mytransaction = new MyTransactions(this, cd);
            mytransaction.Visible = true;
        }

        private void applyLoanBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (la == null) la = new LoanApplication(this, cd);
            la.Visible = true;
        }

        private void myLoansBtn_Click(object sender, EventArgs e)
        {
            if (ml == null) ml = new MyLoans(this, cd);
            ml.Visible = true;
            this.Visible = false;
        }
    }
}
