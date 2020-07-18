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
using Employee;
using Customer;

namespace Global_GUI
{
    public partial class ActiveLoan : MetroForm
    {
        ManageLoans ml;
        public ActiveLoan(ManageLoans ml)
        {
            InitializeComponent();
            this.ml = ml;
            this.populateGridView();
        }

        private void populateGridView()
        {
            string sql = "select * from  activeLoan where approve = 'Yes' order by LoanTransactionId desc;";
            var Ds = Admin.DataAccess.GetDataSet(sql);

            this.activeGrid.AutoGenerateColumns = false;
            this.activeGrid.DataSource = Ds.Tables[0];
        }
        private void ActiveLoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_loan_systemDataSet9.activeLoan' table. You can move, or remove it, as needed.
            this.activeLoanTableAdapter.Fill(this.bank_loan_systemDataSet9.activeLoan);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ml.Visible = true;
        }

        private void ActiveLoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
