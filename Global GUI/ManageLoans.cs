using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Employee;
using Customer;
using Admin;

namespace Global_GUI
{
    public partial class ManageLoans : MetroForm
    {
        AdminHome ah;
        private int id;
        LoanTransactionsHistory lth;
        ActiveLoan al;
        RequestedLoan rl;
        public ManageLoans(AdminHome ah)
        {
            InitializeComponent();
            this.PopulateGridView();
            cbLoanStatus.SelectedIndex = 0;
            this.ah = ah;
            this.reset();
        }
        private void reset()
        {
            cbLoanStatus.SelectedIndex = 0;
            okBtn.Text = "Update";
            loanNameText.Text = "";
            interestRateEmpText.Text = "";
            interestRateCustomerText.Text = "";
            searchText.Text = "";
            interestRateCustomerText.Enabled = true;
            interestRateEmpText.Enabled = true;
        }
        private void reset1()
        {
            cbLoanStatus.SelectedIndex = 1;
            okBtn.Text = "Add";
            loanNameText.Text = "";
            interestRateEmpText.Text = "";
            interestRateCustomerText.Text = "";
            searchText.Text = "";
            interestRateCustomerText.Enabled = true;
            interestRateEmpText.Enabled = true;
        }
        public void PopulateGridView()
        {
            string sql = "select * from loan;";
            var Ds = Admin.DataAccess.GetDataSet(sql);

            this.loanGrid.AutoGenerateColumns = false;
            this.loanGrid.DataSource = Ds.Tables[0];
        }
        public void PopulateGridView(string sql)
        {
            var Ds = Admin.DataAccess.GetDataSet(sql);

            this.loanGrid.AutoGenerateColumns = false;
            this.loanGrid.DataSource = Ds.Tables[0];
        }
        private void ManageLoans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_loan_systemDataSet5.loan' table. You can move, or remove it, as needed.
            this.loanTableAdapter2.Fill(this.bank_loan_systemDataSet5.loan);

        }

        private void cbCustomerStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.clear();
        }
        private void clear()
        {
            if (cbLoanStatus.SelectedIndex==0)
            {
                this.PopulateGridView();
                this.reset();
            }
            else if (cbLoanStatus.SelectedIndex == 1)
            {
                this.reset1();
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ah.Visible = true;
            this.reset();
            this.PopulateGridView();
        }

        private void ManageLoans_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void searchText_Click(object sender, EventArgs e)
        {
            string s = searchText.Text.ToString();
            string str = @"select * from loan where (loanId like '%" + s + "%' or name like '%" + s + "%');";
            this.PopulateGridView(str);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.clear();
        }
        private int verify(string name, string rate1, string rate2)
        {
            try
            {
                int flag = 0;
                if (name.Length > 20 || name.Length == 0 || name.Contains("  "))
                {
                    MessageBox.Show("Invalid name!"); return 0;
                }
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] >= 'A' && name[i] <= 'Z') continue;
                    if (name[i] >= 'a' && name[i] <= 'z') continue;
                    if (name[i] == ' ' && i + 1 < name.Length) continue;
                    flag = 1;
                }
                if (flag == 1)
                {
                    MessageBox.Show("Invalid Name!"); return 0;
                }
                double r1 = double.Parse(rate1);
                double r2 = double.Parse(rate2);
                if(r1<0 || r1>100 || r2<0 || r2>100)
                {
                    MessageBox.Show("Invalid Interest Rate!");return 0;
                }
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            string name = loanNameText.Text.ToString();
            string rateEmp = interestRateEmpText.Text.ToString();
            string rateCus = interestRateCustomerText.Text.ToString();
            if(cbLoanStatus.SelectedIndex==0)
            {
                if(interestRateCustomerText.Enabled==true && interestRateEmpText.Enabled==true)
                {
                    MessageBox.Show("Select A Loan Type From Table!");
                    return;
                }
                int flag = 0;
                double rate = 0;
                string user = "Customer";
                if (rateCus.Length == 0)
                {
                    flag = this.verify(name, rateEmp, "0");
                    if (flag != 0) rate = double.Parse(rateEmp);
                    user = "Employee";
                }
                else
                {
                    flag = this.verify(name, rateCus, "0");
                    if (flag != 0) rate = double.Parse(rateCus);
                }
                if (flag == 0) return;
                Admin.DataAccess.loanUpdate(id, name, rate, user);
                this.clear();
                this.PopulateGridView();
            }
            else
            {
                int flag = this.verify(name, rateEmp, rateCus);
                if (flag == 0) return;
                Admin.DataAccess.loanInsert(name, double.Parse(rateEmp), "Employee");
                Admin.DataAccess.loanInsert(name, double.Parse(rateCus), "Customer");
                MessageBox.Show("Insertation DONE!");
                this.clear();
                this.PopulateGridView();
            }
        }

        private void loanGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbLoanStatus.SelectedIndex == 1) return;
            if (e.RowIndex >= 0)
            {
                var row = this.loanGrid.Rows[e.RowIndex];
                this.id = Int32.Parse(row.Cells[0].Value.ToString());
                loanNameText.Text = row.Cells[1].Value.ToString();
                if (row.Cells[3].Value.ToString() == "Employee")
                {
                    interestRateCustomerText.Text = "";
                    interestRateCustomerText.Enabled = false;
                    interestRateEmpText.Enabled = true;
                    interestRateEmpText.Text = row.Cells[2].Value.ToString(); ;
                }
                else if (row.Cells[3].Value.ToString() == "Customer")
                {
                    interestRateEmpText.Text = "";
                    interestRateEmpText.Enabled = false;
                    interestRateCustomerText.Enabled = true;
                    interestRateCustomerText.Text = row.Cells[2].Value.ToString();
                }
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            string s = searchText.Text.ToString();
            string str = @"select * from loan where (loanId like '%" + s + "%' or name like '%" + s + "%');";
            this.PopulateGridView(str);
        }

        private void loantransactionsHistoryBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (lth == null) lth = new LoanTransactionsHistory(this);
            lth.Visible = true;
        }

        private void activeLoanBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (al == null) al = new ActiveLoan(this);
            al.Visible = true;
        }

        private void requestedLoanBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (rl == null) rl = new RequestedLoan(this);
            rl.Visible = true;
        }
    }
}
