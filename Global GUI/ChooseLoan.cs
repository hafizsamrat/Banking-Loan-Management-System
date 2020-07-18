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
using Admin;

namespace Global_GUI
{
    public partial class ChooseLoan : MetroForm
    {
        LoanApplication la;
        string user;
        public ChooseLoan(LoanApplication la,string user)
        {
            InitializeComponent();
            this.la = la;
            this.user = user;
            this.PopulateGridView();
        }

        private void ChooseLoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            la.Cl = null;
        }

        private void ChooseLoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_loan_systemDataSet5.loan' table. You can move, or remove it, as needed.
            this.loanTableAdapter.Fill(this.bank_loan_systemDataSet5.loan);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.loanTableAdapter.FillBy(this.bank_loan_systemDataSet5.loan, customerToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.loanTableAdapter.FillBy(this.bank_loan_systemDataSet5.loan, customerToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public void PopulateGridView()
        {
            string sql = "select * from loan where consumer='" + this.user + "';";
            var Ds = Customer.DataAccess.GetDataSet(sql);

            this.loanGrid.AutoGenerateColumns = false;
            this.loanGrid.DataSource = Ds.Tables[0];
        }
        public void PopulateGridView(string sql)
        {
            var Ds =Customer.DataAccess.loanSearch(sql);

            this.loanGrid.AutoGenerateColumns = false;
            this.loanGrid.DataSource = Ds.Tables[0];
        }
        private void customerToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            this.PopulateGridView(customerToolStripTextBox.Text.ToString());
        }

        private void loanGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                var row = this.loanGrid.Rows[e.RowIndex];
                la.LoanTypeText = row.Cells[0].Value.ToString();
                la.InterestRateText = row.Cells[1].Value.ToString();
                la.LoanId = Int32.Parse(row.Cells[2].Value.ToString());
                this.Visible = false;
            }
        }
    }
}
