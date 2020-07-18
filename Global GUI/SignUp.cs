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
using System.IO;

namespace Global_GUI
{
    public partial class SignUp : MetroForm
    {
        Login login;
        string userId;
        public SignUp(Login login)
        {
            InitializeComponent();
            this.login = login;
            var sq = Customer.DataAccess.Sqcon;
            this.FileI();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login.Visible = true;
        }
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            Verify V = new Verify(CustomerInformation.verify);
            int flag = V(passwordText.Text.ToString(), emailText.Text.ToString(), nameText.Text.ToString());
            if (flag == 0) return;
            string gender = "Male";
            if (femaleRadioBtn.Checked) gender = "Female";
            if(maleRadioBtn.Checked==false && femaleRadioBtn.Checked==false)
            {
                MessageBox.Show("Choose Gender!");
                return;
            }
            string id = userIdText.Text.ToString();
            string  name = nameText.Text.ToString();
            string password = passwordText.Text.ToString();
            string email = emailText.Text.ToString();
            DateTime d = Convert.ToDateTime(dateOfBirthText.Text.ToString());
            string dateOfBith = d.ToString();

            Customer.DataAccess.insert(userIdText.Text.ToString(), name, email, password, 0, gender, dateOfBith, "No");
        
            fileO();
            FileI();
            clear();
        }

        private void clear()
        {
            passwordText.Text = "";
            nameText.Text = "";
            emailText.Text = "";
            maleRadioBtn.Checked = false;
            femaleRadioBtn.Checked = false;
            dateOfBirthText.Text = "";
        }

        private void FileI()
        {
            string textFile = @"C:\Users\Hafiz Samrat\Desktop\Banking Solution\FileInput\customerId.txt";

            if (File.Exists(textFile))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(textFile);
                this.userId = lines[0];
                int x = Int32.Parse(this.userId);
                x++;
                this.userId = x.ToString("d5");
                userIdText.Text = "C" + this.userId;
            }
        }
        private void fileO()
        {
            string textFile = @"C:\Users\Hafiz Samrat\Desktop\Banking Solution\FileInput\customerId.txt";

            using (StreamWriter sw = new StreamWriter(textFile))
            {
                sw.WriteLine(this.userId);
            }
        }

        private void showPasswordBtn_Click(object sender, EventArgs e)
        {
            passwordText.PasswordChar = passwordText.PasswordChar == '●' ? '\0' : '●';
            showPasswordBtn.Text = passwordText.PasswordChar == '●' ? "Show Password" : "Hide Password";
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
