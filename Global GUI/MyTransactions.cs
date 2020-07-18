using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class MyTransactions : MetroForm
    {
        private CustomerData cd;
        private CustomerHome ch;
        private double balancee ;

        public MyTransactions(CustomerHome ch,CustomerData cd)
        {
            InitializeComponent();
            this.ch = ch;
            this.cd = cd;
            balanceLabel.Text = "Balance: " + cd.Balance.ToString();
            recieverText.Text = cd.Id;
            recieverText.Enabled = false;

            this.PopulateGridView();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            cbType.SelectedIndex = -1;
            recieverText.Text = cd.Id;
            this.PopulateGridView();
            amountText.Text = passwordText.Text = "";
            this.Visible = false;
            ch.Visible = true;
        }

        private void MyTransactions_FormClosed(object sender, FormClosedEventArgs e)
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
                recieverText.Text = cd.Id;
            }

        }

        private void MyTransactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_loan_systemDataSet.transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.bank_loan_systemDataSet.transactions);

        }

        public void PopulateGridView()
        {
            string sql = "select * from transactions where sender = '" + cd.Id + "' or reciever = '" + cd.Id + "' order by transactionId desc;";
            var Ds = Customer.DataAccess.GetDataSet(sql);

            this.transactionGrid.AutoGenerateColumns = false;
            this.transactionGrid.DataSource = Ds.Tables[0];
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var sq = Customer.DataAccess.Sqcon;
                if(passwordText.Text.ToString()!=cd.Password)
                {
                    MessageBox.Show("Invalid Password!");
                    return;
                }
                string id = recieverText.Text.ToString();
                if(id==cd.Id && cbType.Text.ToString()=="Transfer")
                {
                    MessageBox.Show("Account must be different for Transfer!");
                }
                else if(cbType.Text.ToString()=="Deposit")
                {
                    int flag = Deposit(amountText.Text.ToString(),cd.Id,cd.Id);
                    if(flag==1)
                    {
                        MessageBox.Show("Deposit Done!");
                        passwordText.Text = "";
                        cbType.SelectedIndex = -1;
                        amountText.Text = "";

                        balanceLabel.Text = "Balance: " + cd.Balance.ToString();
                    }

                }
                else if(cbType.Text.ToString()=="Withdraw")
                {
                    int flag = Withdraw(amountText.Text.ToString(),cd.Id,cd.Id);
                    if (flag == 1)
                    {
                        MessageBox.Show("Withdraw Done!");
                        passwordText.Text = "";
                        cbType.SelectedIndex = -1;
                        amountText.Text = "";
                        balanceLabel.Text = "Balance: " + cd.Balance.ToString();
                    }
                }
                else if(cbType.Text.ToString()=="Transfer")
                {
                    if(id.Length==0)
                    {
                        MessageBox.Show("InValid Reciever Id!");
                        return;
                    }
                    string str = @"select * from customer where userid='"+id+"';";
                    if (id[0] == 'E') str = @"select * from Employee where userid='" + id + "';";
                    var dt = Customer.DataAccess.GetDataSet(str);
                    if(dt.Tables[0].Rows.Count==0)
                    {
                        MessageBox.Show("InValid Reciever Id!");
                        return;
                    }
                    var row = dt.Tables[0].Rows[0];

                    string col = row["approval"].ToString();
                    if(col=="No" || col=="Suspend")
                    {
                        MessageBox.Show("Invalid Reciever Id!");
                        return;
                    }
                    col = row["balance"].ToString();
                    double amt = double.Parse(col);
                    this.balancee = amt;
                    int flag = Withdraw(amountText.Text.ToString(), cd.Id, id);
                    if(flag==1)
                    {
                        flag = Deposit(amountText.Text.ToString(), cd.Id, id);
                        MessageBox.Show("Transfer done!");

                        passwordText.Text = "";
                        cbType.SelectedIndex = -1;
                        amountText.Text = "";
                        recieverText.Text = "";
                        balanceLabel.Text="Balance: "+cd.Balance.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Choose A Type!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int Deposit(string amountt,string id1,string id2)
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
                    cd.Balance = cd.Balance + amount;
                    amt = cd.Balance;
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
        private int Withdraw(string amountt,string id1,string id2)
        {

            DateTime now = DateTime.Now;
            string dateTime = now.ToString();
            double amount = double.Parse(amountt.ToString());
            if (amount < 10 || amount > 500000 || cd.Balance - amount < 0)
            {
                MessageBox.Show("Invalid Amount!");
                return 0;
            }
            else
            {
                cd.Balance = cd.Balance - amount;
                string str = @"UPDATE customer SET balance = '" + cd.Balance + "' where userid='" + cd.Id + "'";
                amount *= -1;
                int q = Customer.DataAccess.ExecuteQuery(str);
                str = @"insert into transactions values('" + id1 + "','" + id2 + "','" + amount + "','" + dateTime + "');";
                if(id1==id2)q = Customer.DataAccess.ExecuteQuery(str);
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
