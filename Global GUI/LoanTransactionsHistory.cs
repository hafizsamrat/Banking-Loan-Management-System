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
using Employee;
using Customer;
using Admin;

namespace Global_GUI
{
    public partial class LoanTransactionsHistory : MetroForm
    {
        MyLoans ml;
        string id;
        ManageLoans mls;
        bool f;
        public LoanTransactionsHistory(MyLoans ml,string id)
        {
            InitializeComponent();
            this.ml = ml;
            this.id = id;
            f = false;
            this.PopulateGridView();
        }
        public LoanTransactionsHistory(ManageLoans mls)
        {
            InitializeComponent();
            this.mls = mls;
            f = true;
            this.PopulateGridView("select * from loanTransaction");
            this.loanHistoryGrid.Columns[0].Visible = true;
        }
        public void PopulateGridView()
        {
            string sql = "select * from loanTransaction where userid='" + this.id + "' ;";
            var Ds = Customer.DataAccess.GetDataSet(sql);

            this.loanHistoryGrid.AutoGenerateColumns = false;
            this.loanHistoryGrid.DataSource = Ds.Tables[0];
        }
        public void PopulateGridView(string sql)
        {
            var Ds = Customer.DataAccess.GetDataSet(sql);

            this.loanHistoryGrid.AutoGenerateColumns = false;
            this.loanHistoryGrid.DataSource = Ds.Tables[0];
        }
        private void LoanTransactionsHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_loan_systemDataSet7.loanTransaction' table. You can move, or remove it, as needed.
            this.loanTransactionTableAdapter.Fill(this.bank_loan_systemDataSet7.loanTransaction);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            searchText.Text = "";
            if (f == false)
            {
                this.PopulateGridView();
                ml.Visible = true;
            }
            else
            {
                mls.Visible = true;
                this.PopulateGridView("select * from loanTransaction");
            }

        }

        private void LoanTransactionsHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string str = @"Select * from loanTransaction where userid like '%"+ searchText.Text.ToString() +"%' or loanName like '%" + searchText.Text.ToString() + "%';";
                if(f==false) str = @"Select * from loanTransaction where userid='" + id + "' and loanName like '%" + searchText.Text.ToString() + "%';";
              
                this.PopulateGridView(str);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
