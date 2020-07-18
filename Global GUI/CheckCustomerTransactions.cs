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
    public partial class CheckCustomerTransactions : MetroForm
    {
        EmployeeHome eh;
        AdminHome ah;
        bool f1;
        bool f2;
        public CheckCustomerTransactions(EmployeeHome eh)
        {
            InitializeComponent();
            this.PopulateGridView();
            this.eh = eh;
            f1 = true;
            f2 = false;
        }
        public CheckCustomerTransactions(AdminHome ah)
        {
            InitializeComponent();
            f1 = false;
            f2 = true;
            this.PopulateGridView();
            this.ah = ah;
        }

        private void CheckCustomerTransactions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CheckCustomerTransactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_loan_systemDataSet.transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.bank_loan_systemDataSet.transactions);

        }

        public void PopulateGridView()
        {
            string sql = "select * from transactions where sender like 'C%' or reciever like 'C%' order by transactionId desc;";
            if (f2 == true) sql = "select * from transactions order by transactionId desc;";
            var Ds = Customer.DataAccess.GetDataSet(sql);

            this.transactionGrid.AutoGenerateColumns = false;
            this.transactionGrid.DataSource = Ds.Tables[0];
        }
        public void PopulateGridView(string sql)
        {
            var Ds = Customer.DataAccess.GetDataSet(sql);

            this.transactionGrid.AutoGenerateColumns = false;
            this.transactionGrid.DataSource = Ds.Tables[0];
        }
        private void searchText_Click(object sender, EventArgs e)
        {
            string s = searchText.Text.ToString();
            string str = @"select * from transactions where (sender like 'C%' or reciever like 'C%') and (sender like '%" + s + "%' or reciever like '%" + s + "%' or transactionId like '%" + s 
                + "%')order by transactionId desc;";
            if(f2==true)
            {
                str = @"select * from transactions where (sender like '%" + s + "%' or reciever like '%" + s + "%' or transactionId like '%" + s
                + "%')order by transactionId desc;";
            }
            this.PopulateGridView(str);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            searchText.Text = "";
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            string s = searchText.Text.ToString();
            string str = @"select * from transactions where (sender like 'C%' or reciever like 'C%') and (sender like '%" + s 
                + "%' or reciever like '%" + s + "%' or transactionId like '%" + s + "%')order by transactionId desc;";
            this.PopulateGridView(str);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            searchText.Text = "";
            this.Visible = false;
            this.PopulateGridView();

            if (f1 == true)
            {
                eh.Visible = true;
            }
            else
            {
                ah.Visible = true;
            }
        }
    }
}
