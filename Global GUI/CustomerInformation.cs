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

namespace Global_GUI
{
    public delegate int Verify(string password, string email, string name);
    public partial class CustomerInformation : MetroForm
    {
        private CustomerHome customerHome;
        private CustomerData cd;
        public CustomerInformation(CustomerHome customerHome,CustomerData cd)
        {
            InitializeComponent();
            this.customerHome = customerHome;
            this.cd = cd;

            this.reset();

            var sq = Customer.DataAccess.Sqcon;
        }

        private void reset()
        {
            userIdText.Text = cd.Id;
            nameText.Text = cd.Name;
            emailText.Text = cd.Email;
            passwordText.Text = cd.Password;
            if (cd.Gender == "Male")
            {
                maleRadioBtn.Checked = true;
            }
            else femaleRadioBtn.Checked = true;
            dateOfBirthText.Text = cd.DateOfBith;
        }

        private void showPasswordBtn_Click(object sender, EventArgs e)
        {
            passwordText.PasswordChar = passwordText.PasswordChar == '●' ? '\0' : '●';
            showPasswordBtn.Text = passwordText.PasswordChar == '●' ? "Show Password" : "Hide Password";
        }

        private void CustomerInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.reset();
            customerHome.Visible = true;
            this.Visible = false;
        }

        public static int verify(string password,string email,string name)
        {
            if(password.Length<4)
            {
                MessageBox.Show("Password Minimum Length shoule be 4!");
                return 0;
            }
            if(password.Contains(' ') || email.Length>20)
            {
                MessageBox.Show("Invalid Password!");return 0;
            }
            if (name.Length>20 || email.Length==0 || email[0]=='@' || email.Contains('@')==false || email.Contains(".com")==false || email.EndsWith(".com")==false || email.Contains(' '))
            {
                MessageBox.Show("Invalid Email!");
                return 0;
            }
            int c = 0, a = 0 , flag = 0;
            for(int i=0;i<email.Length;i++)
            {
                if (email[i] == '.')
                {
                    c++;
                    continue;
                }
                if (email[i] == '@')
                {
                    a++;
                    continue;
                }
                if((email[i]>='A' && email[i]<='Z') || (email[i]>='a' && email[i]<='z') || (email[i]>='0' && email[i]<='9'))
                {
                    continue;
                }
                if (email[i] == '_') continue;
                flag = 1;
            }
            if(c>1 || a>1 || flag==1)
            {
                MessageBox.Show("Invalid Email!");
                return 0;
            }
            if(name.Length>20 || name.Length==0 || name.Contains("  "))
            {
                MessageBox.Show("Invalid name!");return 0;
            }
            for(int i=0;i<name.Length;i++)
            {
                if (name[i] >= 'A' && name[i] <= 'Z') continue;
                if (name[i] >= 'a' && name[i] <= 'z') continue;
                if (name[i] == ' ' && i+1<name.Length) continue;
                flag = 1;
            }
            if(flag==1)
            {
                MessageBox.Show("Invalid Name!");return 0;
            }
            return 1;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int flag = verify(passwordText.Text.ToString(), emailText.Text.ToString(),nameText.Text.ToString());
            if (flag == 0) return;
            cd.Gender = "Male";
            if (femaleRadioBtn.Checked) cd.Gender = "Female";
            cd.Name = nameText.Text.ToString();
            cd.Password = passwordText.Text.ToString();
            cd.Email = emailText.Text.ToString();
            DateTime d = Convert.ToDateTime(dateOfBirthText.Text.ToString());
            cd.DateOfBith = d.ToString();
            Customer.DataAccess.update(cd.Id, cd.Name, cd.Email, cd.Password, cd.Balance, cd.Gender, cd.DateOfBith , cd.Approval);
        }
    }
}
