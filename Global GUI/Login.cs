using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Customer;
using Employee;
using Admin;

namespace Global_GUI
{
    public partial class Login : MetroForm
    {
        ForgotPassword fp;
        public Login()
        {
            InitializeComponent();
            var sq = Customer.DataAccess.Sqcon;
            sq = Employee.DataAccess.Sqcon;
            sq = Admin.DataAccess.Sqcon;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.userIdText.Text = "";
            this.passwordText.Text = "";
            SignUp sgnUp = new SignUp(this);
            sgnUp.Visible = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userid = userIdText.Text.ToString();
                string pass = passwordText.Text.ToString();
                string str = "SELECT * FROM customer WHERE userid ='  * .' AND password = ' * *  '";

                if (userid[0] == 'C') str = "SELECT * FROM customer WHERE userid ='" + userid + "' AND password = '" + pass + "' ";
                if (userid[0] == 'E') str = "SELECT * FROM employee WHERE userid ='" + userid + "' AND password = '" + pass + "' ";
                if (userid[0] == 'A' || userid[0] == 'a') str = "SELECT * FROM admin WHERE userid ='" + userid + "' AND password = '" + pass + "' ";

                var dt = Admin.DataAccess.GetDataSet(str);
                if (dt.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Invalid UserId or Password!");
                }
                else
                {
                    var row = dt.Tables[0].Rows[0];

                    string col = "Yes";
                    if (userid[0] != 'a' && userid[0] != 'A') col = row["approval"].ToString();

                    if (col == "No")
                    {
                        MessageBox.Show("Account has not approved yet!");
                    }
                    else if (col == "Suspend")
                    {
                        MessageBox.Show("Account Suspended!");
                    }
                    else
                    {
                        MessageBox.Show("Successful!");
                       this.Visible = false;
                        if (userid[0] == 'C')
                        {
                            string balan = row["balance"].ToString();
                            double bal = double.Parse(balan);
                            CustomerData cd = new CustomerData(row["userid"].ToString(), row["name"].ToString(), row["email"].ToString(), row["password"].ToString(), bal, row["gender"].ToString(), row["dateOfBirth"].ToString(), row["approval"].ToString());

                            new CustomerHome(this, cd).Visible = true;
                        }
                        else if (userid[0] == 'E')
                        {
                            string sala = row["salary"].ToString();
                            double sal = double.Parse(sala);
                            string balan = row["balance"].ToString();
                            double bal = double.Parse(balan);
                            EmployeeData ed = new EmployeeData(row["userId"].ToString(), row["name"].ToString(), row["email"].ToString(), row["password"].ToString(), row["gender"].ToString(), row["joiningDate"].ToString(), sal, row["approval"].ToString(), bal);
                            new EmployeeHome(this, ed).Visible = true;
                        }
                        else
                        {
                            AdminData ad = new AdminData(row["userId"].ToString(), row["name"].ToString(), row["email"].ToString(), row["password"].ToString(), row["gender"].ToString(), row["joiningDate"].ToString());
                            new AdminHome(this, ad).Visible = true;
                        }
                    }
                    
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid UserID or Password!");
            }
        }

        private void showPasswordBtn_Click(object sender, EventArgs e)
        {
            passwordText.PasswordChar = passwordText.PasswordChar == '●' ? '\0' : '●';
            showPasswordBtn.Text = passwordText.PasswordChar == '●' ? "Show Password" : "Hide Password";
        }

        private void forgotPasswordBtn_Click(object sender, EventArgs e)
        {
            if (fp == null) fp = new ForgotPassword(this);
            fp.Visible = true;
            this.Visible = false;
        }
    }
}
