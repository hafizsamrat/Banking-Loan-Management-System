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
using Admin;
using Customer;
using Employee;

namespace Global_GUI
{
    public partial class MyLoans : MetroForm
    {
        CustomerHome ch;
        CustomerData cd;
        EmployeeHome eh;
        EmployeeData ed;
        LoanTransactionsHistory lth;
        bool f;
        int loanId,paidPayments,loanTransactionId;
        double dueLoan,dueAmount;
        public MyLoans(CustomerHome ch, CustomerData cd)
        {
            InitializeComponent();
            this.ch = ch;
            this.cd = cd;
            f = true;
            this.PopulateGridView(this.cd.Id);
            this.reset();
        }
        public MyLoans(EmployeeHome eh, EmployeeData ed)
        {
            InitializeComponent();
            this.eh = eh;
            this.ed = ed;
            f = false;
            this.reset();
            this.PopulateGridView(this.ed.Id);
        }
        private void reset()
        {
            payBtn.Visible = false;
            payInstallmentsText.Text = dueInstallmentsText.Text = "";
            payAmountText.Text = monthlyPaymentText.Text = "";
            if (f == true)
            {
                this.PopulateGridView(cd.Id);
                myBalanceText.Text = cd.Balance.ToString();
            }
            else
            {
                this.PopulateGridView(ed.Id);
                myBalanceText.Text = ed.Balance.ToString();
            }
        }
        private void MyLoans_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MyLoans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_loan_systemDataSet8.activeLoan' table. You can move, or remove it, as needed.
            this.activeLoanTableAdapter1.Fill(this.bank_loan_systemDataSet8.activeLoan);
            // TODO: This line of code loads data into the 'bank_loan_systemDataSet6.activeLoan' table. You can move, or remove it, as needed.
            this.activeLoanTableAdapter.Fill(this.bank_loan_systemDataSet6.activeLoan);

        }
        public void PopulateGridView(string id)
        {
            string sql = "select * from activeLoan where paidNoOfPayments<noOfPayments and approve='Yes' and userid='" + id + "';";
            var Ds = Customer.DataAccess.GetDataSet(sql);

            this.activeLoanGrid.AutoGenerateColumns = false;
            this.activeLoanGrid.DataSource = Ds.Tables[0];
        }

        private void activeLoanGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                var row = this.activeLoanGrid.Rows[e.RowIndex];
                monthlyPaymentText.Text = row.Cells[4].Value.ToString();
                int x = Int32.Parse(row.Cells[8].Value.ToString()) - Int32.Parse(row.Cells[9].Value.ToString());
                dueInstallmentsText.Text = x.ToString();
                payBtn.Visible = true;
                this.dueLoan = double.Parse(row.Cells[12].Value.ToString());
                this.loanId = Int32.Parse(row.Cells[1].Value.ToString());
                this.paidPayments = Int32.Parse(row.Cells[9].Value.ToString());
                this.dueAmount = double.Parse(row.Cells[7].Value.ToString());
                this.loanTransactionId = Int32.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.reset();
            this.Visible = false;
            if (f == true)
            {
                ch.Visible = true;
            }
            else eh.Visible = true;
        }

        private void loanTransactionHistory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if(lth==null)
            {
                if (f == true) lth = new LoanTransactionsHistory(this, cd.Id);
                else lth = new LoanTransactionsHistory(this, ed.Id);
            }
            lth.Visible = true;
            this.reset();
        }

        private void MyLoans_VisibleChanged(object sender, EventArgs e)
        {
            this.reset();
        }

        private void payInstallmentsText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int cnt = Int32.Parse(payInstallmentsText.Text.ToString());
                if(cnt>Int32.Parse(dueInstallmentsText.Text.ToString()))
                {
                    payInstallmentsText.Text = "";
                    payAmountText.Text = "";
                    MessageBox.Show("Invalid No of Installments!");
                    return;
                }
                double  x = double.Parse(monthlyPaymentText.Text.ToString())* double.Parse(cnt.ToString());
                payAmountText.Text = x.ToString();
            }
            catch(Exception)
            {
                payInstallmentsText.Text = "";
                payAmountText.Text = "";
                if (payInstallmentsText.Text.ToString().Length == 0)
                {
                    return;
                }
                MessageBox.Show("Invalid No of Installments!");
            }
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = double.Parse(payAmountText.Text.ToString());
                if(f==true)
                {
                    if(amount>cd.Balance)
                    {
                        MessageBox.Show("You do not have enough balance!");
                        return;
                    }
                    int cnt = Int32.Parse(payInstallmentsText.Text.ToString());
                    while (cnt>0)
                    {
                        cnt--;
                        cd.Balance -= double.Parse(monthlyPaymentText.Text.ToString());
                        this.paidPayments++;
                        this.dueAmount -= double.Parse(monthlyPaymentText.Text.ToString());
                        this.dueLoan=Customer.DataAccess.loanAllUpdate(this.loanTransactionId, cd.Id, loanId, cd.Balance, double.Parse(monthlyPaymentText.Text.ToString()), this.paidPayments, dueAmount, dueLoan);
                    }
                    MessageBox.Show("Payment Done!");
                }
                else
                {
                    if (amount > ed.Balance)
                    {
                        MessageBox.Show("You do not have enough balance!");
                        return;
                    }
                    int cnt = Int32.Parse(payInstallmentsText.Text.ToString());
                    while (cnt > 0)
                    {
                        cnt--;
                        ed.Balance -= double.Parse(monthlyPaymentText.Text.ToString());
                        this.paidPayments++;
                        this.dueAmount -= double.Parse(monthlyPaymentText.Text.ToString());
                        this.dueLoan = Employee.DataAccess.loanAllUpdate(this.loanTransactionId, ed.Id, loanId, ed.Balance, double.Parse(monthlyPaymentText.Text.ToString()), this.paidPayments, dueAmount, dueLoan);
                    }
                    MessageBox.Show("Payment Done!");
                }
                this.reset();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
