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
using Admin;
using Customer;
using Employee;

namespace Global_GUI
{
    public partial class RequestedLoan : MetroForm
    {
        ManageLoans mls;
        public RequestedLoan(ManageLoans mls)
        {
            InitializeComponent();
            this.mls = mls;
            this.PopulateGridView();

        }
        public void PopulateGridView()
        {
            string sql = "select * from activeLoan where approve='No' ;";
            var Ds = Customer.DataAccess.GetDataSet(sql);

            this.requestLoanGrid.AutoGenerateColumns = false;
            this.requestLoanGrid.DataSource = Ds.Tables[0];
        }

        private void RequestedLoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_loan_systemDataSet9.activeLoan' table. You can move, or remove it, as needed.
            this.activeLoanTableAdapter.Fill(this.bank_loan_systemDataSet9.activeLoan);

        }

        private void requestLoanGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = this.requestLoanGrid.Rows[e.RowIndex];
                loanTransactionIdText.Text = row.Cells[0].Value.ToString();
                rejectBtn.Visible = true;
                approveBtn.Visible = true;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mls.Visible = true;
            this.PopulateGridView();
            loanTransactionIdText.Text = "";
            rejectBtn.Visible = approveBtn.Visible = false;
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(loanTransactionIdText.Text.ToString());
            string str = @"update activeLoan set approve='Yes' where LoanTransactionId='" + id + "';";
            int u = Admin.DataAccess.ExecuteQuery(str);
            MessageBox.Show("Approved!");
            approveBtn.Visible = rejectBtn.Visible = false;
            loanTransactionIdText.Text = "";
            this.PopulateGridView();
        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(loanTransactionIdText.Text.ToString());
            string str = @"update activeLoan set approve='Rejected' where LoanTransactionId='" + id + "';";
            int u = Admin.DataAccess.ExecuteQuery(str);
            MessageBox.Show("Rejected!");
            approveBtn.Visible = rejectBtn.Visible = false;
            loanTransactionIdText.Text = "";
            this.PopulateGridView();
        }

        private void RequestedLoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
