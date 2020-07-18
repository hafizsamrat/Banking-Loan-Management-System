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
using Employee;
using Admin;

namespace Global_GUI
{
    public partial class EmployeeInformation : MetroForm
    {
        EmployeeHome eh;
        EmployeeData ed;
        AdminData ad;
        AdminHome ah;
        bool f;
        public EmployeeInformation(EmployeeHome eh,EmployeeData ed)
        {
            InitializeComponent();
            this.eh = eh;
            this.ed = ed;
            this.reset();
            var sq = Employee.DataAccess.Sqcon;
            f = true;
        }

        public EmployeeInformation(AdminHome ah, AdminData ad)
        {
            InitializeComponent();
            this.ah = ah;
            this.ad = ad;
            this.reset1();
            var sq = Employee.DataAccess.Sqcon;
            sq = Admin.DataAccess.Sqcon;
            f = false;
        }
        private void reset1()
        {
            userIdText.Text = ad.Id;
            nameText.Text = ad.Name;
            emailText.Text = ad.Email;
            passwordText.Text = ad.Password;
            if (ad.Gender == "Male")
            {
                maleRadioBtn.Checked = true;
            }
            else femaleRadioBtn.Checked = true;
            joiningDateText.Text = ad.JoiningDate;
        }

        private void reset()
        {
            userIdText.Text = ed.Id;
            nameText.Text = ed.Name;
            emailText.Text = ed.Email;
            passwordText.Text = ed.Password;
            if (ed.Gender == "Male")
            {
                maleRadioBtn.Checked = true;
            }
            else femaleRadioBtn.Checked = true;
            joiningDateText.Text = ed.JoiningDate;
        }

        private void EmployeeInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void showPasswordBtn_Click(object sender, EventArgs e)
        {
            passwordText.PasswordChar = passwordText.PasswordChar == '●' ? '\0' : '●';
            showPasswordBtn.Text = passwordText.PasswordChar == '●' ? "Show Password" : "Hide Password";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (f == true)
            {
                this.reset();
                eh.Visible = true;
            }
            else
            {
                this.reset1();
                ah.Visible = true;
            }
        }

        private int verify(string password, string email, string name)
        {
            if (password.Length < 4)
            {
                MessageBox.Show("Password Minimum Length shoule be 4!");
                return 0;
            }
            if (password.Contains(' ') || email.Length > 20)
            {
                MessageBox.Show("Invalid Password!"); return 0;
            }
            if (name.Length > 20 || email.Length == 0 || email[0] == '@' || email.Contains('@') == false || email.Contains(".com") == false || email.EndsWith(".com") == false || email.Contains(' '))
            {
                MessageBox.Show("Invalid Email!");
                return 0;
            }
            int c = 0, a = 0, flag = 0;
            for (int i = 0; i < email.Length; i++)
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
                if ((email[i] >= 'A' && email[i] <= 'Z') || (email[i] >= 'a' && email[i] <= 'z') || (email[i] >= '0' && email[i] <= '9'))
                {
                    continue;
                }
                if (email[i] == '_') continue;
                flag = 1;
            }
            if (c > 1 || a > 1 || flag == 1)
            {
                MessageBox.Show("Invalid Email!");
                return 0;
            }
            if (name.Length > 20 || name.Length == 0 || name.Contains("  "))
            {
                MessageBox.Show("Invalid name!"); return 0;
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 'A' && name[i] <= 'Z') continue;
                if (name[i] >= 'a' && name[i] <= 'z') continue;
                if (name[i] == ' ' && i + 1 < name.Length) continue;
                flag = 1;
            }
            if (flag == 1)
            {
                MessageBox.Show("Invalid Name!"); return 0;
            }
            return 1;
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (f == true)
            {
                int flag = this.verify(passwordText.Text.ToString(), emailText.Text.ToString(), nameText.Text.ToString());
                if (flag == 0) return;
                ed.Gender = "Male";
                if (femaleRadioBtn.Checked) ed.Gender = "Female";
                ed.Name = nameText.Text.ToString();
                ed.Password = passwordText.Text.ToString();
                ed.Email = emailText.Text.ToString();
                DateTime d = Convert.ToDateTime(joiningDateText.Text.ToString());
                ed.JoiningDate = d.ToString();
                Employee.DataAccess.update(ed.Id, ed.Name, ed.Email, ed.Password, ed.Gender, ed.JoiningDate, ed.Salary, ed.Approval, ed.Balance);
            }
            else
            {
                int flag = this.verify(passwordText.Text.ToString(), emailText.Text.ToString(), nameText.Text.ToString());
                if (flag == 0) return;
                ad.Gender = "Male";
                if (femaleRadioBtn.Checked) ad.Gender = "Female";
                ad.Name = nameText.Text.ToString();
                ad.Password = passwordText.Text.ToString();
                ad.Email = emailText.Text.ToString();
                DateTime d = Convert.ToDateTime(joiningDateText.Text.ToString());
                ad.JoiningDate = d.ToString();
                Admin.DataAccess.update(ad.Id, ad.Name, ad.Email, ad.Password, ad.Gender, ad.JoiningDate);
            }
        }
    }
}
