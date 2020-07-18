using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee;
using Customer;
using Admin;
using MetroFramework;
using MetroFramework.Forms;

namespace Global_GUI
{
    public partial class LoanApplication : MetroForm
    {
        CustomerHome ch;
        CustomerData cd;
        EmployeeHome eh;
        EmployeeData ed;
        ChooseLoan cl;
        string userId;
        int loanId,f;
        string user;
        double loanAmount = 0;
        public LoanApplication(CustomerHome ch, CustomerData cd)
        {
            InitializeComponent();
            this.ch = ch;
            this.cd = cd;
            this.userId = cd.Id;
            this.user = "Customer";
            f = 1;
        }
        public LoanApplication(EmployeeHome eh, EmployeeData ed)
        {
            InitializeComponent();
            this.eh = eh;
            this.ed = ed;
            this.userId = ed.Id;
            f = 0;
            this.user = "Employee";
        }
        public string LoanTypeText
        {
            set { loanTypeText.Text = value; }
            get { return loanTypeText.Text.ToString(); }
        }
        public int LoanId
        {
            set { this.loanId = value; }
            get { return this.loanId; }
        }
        public string InterestRateText
        {
            set { interestRateText.Text = value; }
        }
        public ChooseLoan Cl
        {
            set { this.cl = value; }
        }

        private void loanTypeText_Click(object sender, EventArgs e)
        {
            if (cl == null) cl = new ChooseLoan(this,this.user);
            cl.ShowDialog();
        }

        private void LoanApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void reset()
        {
            this.loanAmount = 0;
            this.loanAmountText.Text = loanTypeText.Text = "";
            interestRateText.Text = interestText.Text = "";
            monthlyPaymentText.Text = totalCostOfLoanText.Text = "";
            noOfPaymentsText.Text = "";
            okBtn.Enabled = false;
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (f == 1) ch.Visible = true;
            else eh.Visible = true;
            this.reset();
        }

        private void loanAmountText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(loanAmountText.Text.ToString().Length==0)
                {
                    this.loanAmount = 0;
                    return;
                }
                if(LoanTypeText.Length==0)
                {
                    MessageBox.Show("First Choose A loan Type!");
                    loanAmountText.Text = "";
                    return;
                }
                this.loanAmount = double.Parse(loanAmountText.Text.ToString());
                if(this.loanAmount>1000000000 || this.loanAmount<=0)
                {
                    MessageBox.Show("Invalid Amount");
                    this.loanAmount = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Amount!");
            }
        }

        private void noOfInstallmentText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (noOfPaymentsText.Text.ToString().Length == 0) return;
                if(this.loanAmount==0)
                {
                    MessageBox.Show("Invalid Loan Amount");
                    noOfPaymentsText.Text = "";
                    return;
                }
                int paymentNumber = Int32.Parse(noOfPaymentsText.Text.ToString());
                if (paymentNumber<=0 || paymentNumber>144)
                {
                    MessageBox.Show("Invalid Payment Number!");
                    noOfPaymentsText.Text = "";
                    okBtn.Enabled = false;
                    return;
                }
                double rate = double.Parse(interestRateText.Text.ToString());
                rate = (rate / 1200);
                double monthlyCost = rate * this.loanAmount * Math.Pow(1 + rate, paymentNumber)/ (Math.Pow(1 + rate, paymentNumber)-1);
                monthlyPaymentText.Text = monthlyCost.ToString();
                double total = monthlyCost * paymentNumber;
                totalCostOfLoanText.Text = total.ToString();
                total -= this.loanAmount;
                interestText.Text = total.ToString();
                okBtn.Enabled = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Payment Number!");
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string str = @"select * from activeLoan where (paidNoOfPayments<noOfPayments and userid='" +
                    userId + "' and loanId='" + loanId + "' and approve!='Rejected');";
                var ds = Admin.DataAccess.GetDataSet(str);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("You have to clear your previous Loan first!");
                    return;
                }
                DateTime date = DateTime.Now;
                string d = date.ToString();
                Admin.DataAccess.loanApplyInsert(loanId, userId, loanAmount,double.Parse(monthlyPaymentText.Text.ToString()) ,double.Parse(interestText.Text.ToString()), double.Parse(totalCostOfLoanText.Text.ToString()), double.Parse(totalCostOfLoanText.Text.ToString()), Int32.Parse(noOfPaymentsText.Text.ToString()), 0, d, "No");
                this.reset();
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Field!");
            }
        }
    }
}
