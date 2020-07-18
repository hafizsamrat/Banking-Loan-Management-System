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

namespace Global_GUI
{
    public partial class EmployeeTransaction : MetroForm
    {
        private EmployeeData ed;
        private EmployeeHome eh;
        private double balancee;
        public EmployeeTransaction(EmployeeHome eh, EmployeeData ed)
        {
            InitializeComponent();
            this.eh = eh;
            this.ed = ed;
            balanceLabel.Text = "Balance: " + ed.Balance.ToString();
            recieverText.Text = ed.Id;
            recieverText.Enabled = false;

            this.PopulateGridView();
        }

        private void EmployeeTransaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_loan_systemDataSet.transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.bank_loan_systemDataSet.transactions);

        }
        public void PopulateGridView()
        {
            string sql = "select * from transactions where sender = '" + ed.Id + "' or reciever = '" + ed.Id + "' order by transactionId desc;";
            var Ds = Employee.DataAccess.GetDataSet(sql);

            this.transactionGrid.AutoGenerateColumns = false;
            this.transactionGrid.DataSource = Ds.Tables[0];
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            cbType.SelectedIndex = -1;
            recieverText.Text = ed.Id;
            this.PopulateGridView();
            amountText.Text = passwordText.Text = "";
            this.Visible = false;
            eh.Visible = true;
        }

        private void EmployeeTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.Text.ToString() == "Transfer")
            {
                recieverText.Enabled = true;
                recieverText.Text = "";
            }
            else
            {
                recieverText.Enabled = false;
                recieverText.Text = ed.Id;
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var sq = Customer.DataAccess.Sqcon;
                if (passwordText.Text.ToString() != ed.Password)
                {
                    MessageBox.Show("Invalid Password!");
                    return;
                }
                string id = recieverText.Text.ToString();
                if (id == ed.Id && cbType.Text.ToString() == "Transfer")
                {
                    MessageBox.Show("Account must be different for Transfer!");
                }
                else if (cbType.Text.ToString() == "Deposit")
                {
                    int flag = Deposit(amountText.Text.ToString(), ed.Id, ed.Id);
                    if (flag == 1)
                    {
                        MessageBox.Show("Deposit Done!");
                        passwordText.Text = "";
                        cbType.SelectedIndex = -1;
                        amountText.Text = "";

                        balanceLabel.Text = "Balance: " + ed.Balance.ToString();
                    }

                }
                else if (cbType.Text.ToString() == "Withdraw")
                {
                    int flag = Withdraw(amountText.Text.ToString(), ed.Id, ed.Id);
                    if (flag == 1)
                    {
                        MessageBox.Show("Withdraw Done!");
                        passwordText.Text = "";
                        cbType.SelectedIndex = -1;
                        amountText.Text = "";
                        balanceLabel.Text = "Balance: " + ed.Balance.ToString();
                    }
                }
                else if (cbType.Text.ToString() == "Transfer")
                {
                    if (id.Length == 0)
                    {
                        MessageBox.Show("InValid Reciever Id!");
                        return;
                    }
                    string str = @"select * from customer where userid='" + id + "';";
                    if (id[0] == 'E') str = @"select * from Employee where userid='" + id + "';";
                    var dt = Employee.DataAccess.GetDataSet(str);
                    if (dt.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid Reciever Id!");
                        return;
                    }
                    var row = dt.Tables[0].Rows[0];

                    string col = row["approval"].ToString();
                    if (col == "No" || col == "Suspend")
                    {
                        MessageBox.Show("Invalid Reciever Id!");
                        return;
                    }
                    col = row["balance"].ToString();
                    double amt = double.Parse(col);
                    this.balancee = amt;
                    int flag = Withdraw(amountText.Text.ToString(), ed.Id, id);
                    if (flag == 1)
                    {
                        flag = Deposit(amountText.Text.ToString(), ed.Id, id);
                        MessageBox.Show("Transfer done!");

                        passwordText.Text = "";
                        cbType.SelectedIndex = -1;
                        amountText.Text = "";
                        recieverText.Text = "";
                        balanceLabel.Text = "Balance: " + ed.Balance.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Choose A Type!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int Deposit(string amountt, string id1, string id2)
        {
            DateTime now = DateTime.Now;
            string dateTime = now.ToString();
            double amount = double.Parse(amountt.ToString());
            if (amount < 10 || amount > 500000)
            {
                MessageBox.Show("Invalid Amount!");
                return 0;
            }
            else
            {
                double amt = 0;
                if (id1 == id2)
                {
                    ed.Balance = ed.Balance + amount;
                    amt = ed.Balance;
                }
                else
                {
                    amt = this.balancee + amount;
                }
                string str = @"UPDATE customer SET balance = '" + amt + "' where userid='" + id2 + "'";
                if (id2[0] == 'E') str = @"UPDATE employee SET balance = '" + amt + "' where userid='" + id2 + "'";
                int q = Customer.DataAccess.ExecuteQuery(str);
                str = @"insert into transactions values('" + id1 + "','" + id2 + "','" + amount + "','" + dateTime + "');";
                q = Customer.DataAccess.ExecuteQuery(str);
                this.PopulateGridView();
                return 1;
            }
        }
        private int Withdraw(string amountt, string id1, string id2)
        {

            DateTime now = DateTime.Now;
            string dateTime = now.ToString();
            double amount = double.Parse(amountt.ToString());
            if (amount < 10 || amount > 500000 || ed.Balance - amount < 0)
            {
                MessageBox.Show("Invalid Amount!");
                return 0;
            }
            else
            {
                ed.Balance = ed.Balance - amount;
                string str = @"UPDATE customer SET balance = '" + ed.Balance + "' where userid='" + ed.Id + "'";
                amount *= -1;
                int q = Customer.DataAccess.ExecuteQuery(str);
                str = @"insert into transactions values('" + id1 + "','" + id2 + "','" + amount + "','" + dateTime + "');";
                if (id1 == id2) q = Customer.DataAccess.ExecuteQuery(str);
                this.PopulateGridView();
                return 1;
            }
        }

        private void transactionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            transactionGrid.ReadOnly = true;
        }
    }
}
