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
    public partial class CustomerInfo : MetroForm
    {
        EmployeeHome eh;
        AdminHome ah;
        bool f1;
        bool f2;
        public CustomerInfo(EmployeeHome eh)
        {
            InitializeComponent();
            this.eh = eh;
            this.PopulateGridView();
            cbCustomerStatus.SelectedIndex = 0;
            okBtn.Text = "Suspend";
            this.customerGrid.Columns[0].Visible = false;
            f1 = true;f2 = false;
        }
        public CustomerInfo(AdminHome ah)
        {
            InitializeComponent();
            this.ah = ah;
            this.PopulateGridView();
            cbCustomerStatus.SelectedIndex = 0;
            okBtn.Text = "Suspend";
            f1 = false;f2 = true;
            this.customerGrid.Columns[0].Visible = false;
            deleteBtn.Visible = true;
        }
        private void CustomerInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_loan_systemDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.bank_loan_systemDataSet1.customer);

        }
        public void PopulateGridView()
        {
            string sql = "select * from customer where approval='Yes';";
            var Ds = Customer.DataAccess.GetDataSet(sql);

            this.customerGrid.AutoGenerateColumns = false;
            this.customerGrid.DataSource = Ds.Tables[0];
        }
        public void PopulateGridView(string sql)
        {
            var Ds = Customer.DataAccess.GetDataSet(sql);

            this.customerGrid.AutoGenerateColumns = false;
            this.customerGrid.DataSource = Ds.Tables[0];
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            searchText.Text = "";
            userIdText.Text = "";
            okBtn.Text = "Suspend";
            cbCustomerStatus.SelectedIndex = 0;
            this.Visible = false;
            if (f1 == true) eh.Visible = true;
            else if(f2==true) ah.Visible = true;
        }
        private void cbCustomerStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.clear();
        }

        private void clear()
        {
            if (cbCustomerStatus.Text.ToString() == "Active Customers")
            {
                okBtn.Text = "Suspend";
                this.yes();
            }
            if (cbCustomerStatus.Text.ToString() == "New Customers")
            {
                okBtn.Text = "Approve";
                this.no();
            }
            if (cbCustomerStatus.Text.ToString() == "Suspended Customers")
            {
                okBtn.Text = "Unsuspend";
                this.suspend();
            }
        }
        private void suspend()
        {
            string sql = "select * from customer where approval='Suspend';";
            this.PopulateGridView(sql);
        }
        private void no()
        {
            string sql = "select * from customer where approval='No';";
            this.PopulateGridView(sql);
        }
        private void yes()
        {
            string sql = "select * from customer where approval='yes';";
            this.PopulateGridView(sql);
        }
        private void searchText_TextChanged(object sender, EventArgs e)
        {
            string s = searchText.Text.ToString();
            string status = "Yes";
            if (cbCustomerStatus.Text.ToString() == "New Customers") status = "No";
            if (cbCustomerStatus.Text.ToString() == "Suspended Customers") status = "Suspend";
            string str = @"select * from customer where (userid like '%" + s + "%' or name like '%" + s + "%' or email like '%" + s
                + "%') and approval='" + status + "';";
            this.PopulateGridView(str);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (okBtn.Text.ToString() == "Suspend") this.yes();
            if (okBtn.Text.ToString() == "Approve") this.no();
            if (okBtn.Text.ToString() == "Unsuspend") this.suspend();
            searchText.Text = "";
            userIdText.Text = "";
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string status = "Suspend";
            if (okBtn.Text.ToString() == "Unsuspend")
            {
                status = "Yes";
            }
            if (okBtn.Text.ToString() == "Approve")
            {
                status = "Yes";
            }
            string str = @"update customer set approval='" + status + "' where userid='" + userIdText.Text.ToString() + "';";
            int u = Customer.DataAccess.ExecuteQuery(str);
            if (u == 0) 
            {
                MessageBox.Show("User Not Found!");
                return;
            }
            if (okBtn.Text.ToString() == "Suspend")
            {
                this.yes();
                MessageBox.Show("Account Suspended!");
            }
            if (okBtn.Text.ToString() == "Approve")
            {
                this.no();
                MessageBox.Show("Account Approved!");
            }
            if (okBtn.Text.ToString() == "Unsuspend")
            {
                this.suspend();
                MessageBox.Show("Account Unsuspended!");
            }
            searchText.Text = "";
            userIdText.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(userIdText.Text.ToString().Length==0)
            {
                MessageBox.Show("User Not Found!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Customer.DataAccess.delete(userIdText.Text.ToString());
                this.clear();
                userIdText.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Delete Cancel!");
            }
        }

        private void customerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                var row = this.customerGrid.Rows[e.RowIndex];
                userIdText.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
