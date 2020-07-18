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

namespace Global_GUI
{
    public partial class ForgotPassword : MetroForm
    {
        Login login;
        string tableName;
        public ForgotPassword(Login login)
        {
            InitializeComponent();
            this.login = login;
            var ds = Admin.DataAccess.Sqcon;
            this.reset();
        }
        private void reset()
        {
            newPasswordLabel.Visible = newPasswordText.Visible = confirmPasswordLabel.Visible = confirmPasswordText.Visible = false;
            resetPasswordBtn.Visible = false;
            newPasswordText.Text = confirmPasswordText.Text = "";
            userIdText.Text = emailText.Text = "";
            userIdText.Enabled = emailText.Enabled = searchBtn.Visible = true;
        }
        private void reset1()
        {
            newPasswordLabel.Visible = newPasswordText.Visible = confirmPasswordLabel.Visible = confirmPasswordText.Visible = true;
            resetPasswordBtn.Visible = true;
            searchBtn.Visible = false;
            userIdText.Enabled = emailText.Enabled = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string id = userIdText.Text.ToString();
            try
            {
                this.tableName = "admin";
                string str = @"select * from admin where userid='" + id + "' and email='" + emailText.Text.ToString() + "' ;";
                if(id[0]=='E')
                {
                    this.tableName = "employee";
                    str = @"select * from employee where userid='" + id + "' and email='" + emailText.Text.ToString() + "' ;";
                }
                else if(id[0]=='C')
                {
                    this.tableName = "customer";
                    str= @"select * from Customer where userid='" + id + "' and email='" + emailText.Text.ToString() + "' ;";
                }
                var ds = Admin.DataAccess.GetDataSet(str);
                if(ds.Tables[0].Rows.Count==0)
                {
                    MessageBox.Show("User Not Found!");
                    return;
                }
                this.reset1();
            }
            catch(Exception)
            {
                MessageBox.Show("User Not Found!");
                return;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login.Visible = true;
            this.reset();
        }

        private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private int verify(string password)
        {
            if (password.Length < 4 || password.Length > 20)
            {
                MessageBox.Show("Password Minimum Length shoule be 4 and not exceed 20!");
                return 0;
            }
            if (password.Contains(' '))
            {
                MessageBox.Show("Invalid Password!"); return 0;
            }
            return 1;
        }
        private void resetPasswordBtn_Click(object sender, EventArgs e)
        {
            string password = newPasswordText.Text.ToString();
            int flag = this.verify(password);
            if (flag == 0) return;
            if(password!=confirmPasswordText.Text.ToString())
            {
                MessageBox.Show("Password did not match!");
                return;
            }
            string str = @"update " + this.tableName + " set password='" + password + "' where userid='" + userIdText.Text.ToString() + "'; ";
            int u = Admin.DataAccess.ExecuteQuery(str);
            MessageBox.Show("Reset Done!");
            this.reset();
        }
    }
}
