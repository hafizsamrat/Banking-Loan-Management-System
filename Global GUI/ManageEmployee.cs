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
using Employee;
using System.IO;

namespace Global_GUI
{
    public partial class ManageEmployee : MetroForm
    {
        private AdminHome ah;
        string userId;
        public ManageEmployee(AdminHome ah)
        {
            InitializeComponent();
            this.ah = ah;
            this.PopulateGridView();
            cbCustomerStatus.SelectedIndex = 0;
        }
        public void PopulateGridView()
        {
            string sql = "select * from employee where approval='Yes';";
            var Ds = Employee.DataAccess.GetDataSet(sql);

            this.employeeGrid.AutoGenerateColumns = false;
            this.employeeGrid.DataSource = Ds.Tables[0];
        }
        public void PopulateGridView(string sql)
        {
            var Ds = Employee.DataAccess.GetDataSet(sql);

            this.employeeGrid.AutoGenerateColumns = false;
            this.employeeGrid.DataSource = Ds.Tables[0];
        }
        private void cbCustomerStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.clear();
        }
        private void clear()
        {
            if (cbCustomerStatus.Text.ToString() == "Active Employees")
            {
                okBtn.Text = "Suspend";
                this.yes();
                this.flag1();
                this.reset();
                userIdText.Text = "";
            }
            if (cbCustomerStatus.Text.ToString() == "Suspended Employees")
            {
                okBtn.Text = "Unsuspend";
                this.suspend();
                this.flag1();
                this.reset();
                userIdText.Text = "";
            }
            if (cbCustomerStatus.Text.ToString() == "Add Employees")
            {
                okBtn.Text = "Add";
                this.reset();
                this.flag2();
                this.yes();
                this.FileI();
            }
        }

        private void flag1()
        {
            passwordText.Enabled = maleRadioBtn.Enabled = femaleRadioBtn.Enabled = false;
            emailText.Enabled = nameText.Enabled = false;
            okBtn.Visible = true;
            deleteBtn.Visible = true;
            updateBtn.Visible = true;
        }
        private void flag2()
        {
            passwordText.Enabled = maleRadioBtn.Enabled = femaleRadioBtn.Enabled = true;
            emailText.Enabled = nameText.Enabled = true;
            deleteBtn.Visible = false;
            updateBtn.Visible = false;
        }
        private void reset()
        {
            emailText.Text = "";
            nameText.Text = "";
            salaryText.Text = "";
            maleRadioBtn.Checked = false;
            femaleRadioBtn.Checked = false;
            passwordText.Text = "";
        }
        private void suspend()
        {
            string sql = "select * from employee where approval='Suspend';";
            this.PopulateGridView(sql);
        }
        private void yes()
        {
            string sql = "select * from employee where approval='yes';";
            this.PopulateGridView(sql);
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_loan_systemDataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bank_loan_systemDataSet2.employee);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ah.Visible = true;
            cbCustomerStatus.SelectedIndex = 0;
            this.clear();
            userIdText.Text = "";
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (okBtn.Text.ToString() == "Add")
                {
                    Verify V = new Verify(CustomerInformation.verify);
                    int flag = V(passwordText.Text.ToString(), emailText.Text.ToString(), nameText.Text.ToString());
                    if (flag == 0) return;
                    string gender = "Male";
                    if (femaleRadioBtn.Checked) gender = "Female";
                    if (maleRadioBtn.Checked == false && femaleRadioBtn.Checked == false)
                    {
                        MessageBox.Show("Choose Gender!");
                        return;
                    }
                    string id = userIdText.Text.ToString();
                    string name = nameText.Text.ToString();
                    string password = passwordText.Text.ToString();
                    string email = emailText.Text.ToString();
                    DateTime d = DateTime.Now;
                    string joiningDate = d.ToString();
                    double salary;
                    salary = double.Parse(salaryText.Text.ToString());
                    if (salary < 0)
                    {
                        MessageBox.Show("Invalid Salary!");
                        return;
                    }
                    Employee.DataAccess.insert(id, name, email, password, gender, joiningDate, salary, "Yes", 0);
                    this.fileO();
                    this.FileI();
                    this.clear();

                    return;
                }
                string status = "Suspend";
                if (okBtn.Text.ToString() == "Unsuspend")
                {
                    status = "Yes";
                }
                string str = @"update employee set approval='" + status + "' where userid='" + userIdText.Text.ToString() + "';";
                int u = Employee.DataAccess.ExecuteQuery(str);
                if (u == 0)
                {
                    MessageBox.Show("User Not Found!");
                    return;
                }
                if (okBtn.Text.ToString() == "Suspend")
                {
                    this.yes();
                    MessageBox.Show("Account Suspended!");
                }
                if (okBtn.Text.ToString() == "Unsuspend")
                {
                    this.suspend();
                    MessageBox.Show("Account Unsuspended!");
                }
                this.reset();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FileI()
        {
            string textFile = @"C:\Users\Hafiz Samrat\Desktop\Banking Solution\FileInput\employeeId.txt";

            if (File.Exists(textFile))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(textFile);
                this.userId = lines[0];
                int x = Int32.Parse(this.userId);
                x++;
                this.userId = x.ToString("d5");
                userIdText.Text = "E" + this.userId;
            }
        }
        private void fileO()
        {
            string textFile = @"C:\Users\Hafiz Samrat\Desktop\Banking Solution\FileInput\employeeId.txt";

            using (StreamWriter sw = new StreamWriter(textFile))
            {
                sw.WriteLine(this.userId);
            }
        }

        private void ManageEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (userIdText.Text.ToString().Length == 0)
            {
                MessageBox.Show("User Not Found!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Employee.DataAccess.delete(userIdText.Text.ToString());
                this.clear();
                userIdText.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Delete Cancel!");
            }
        }

        private void employeeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = this.employeeGrid.Rows[e.RowIndex];
                userIdText.Text = row.Cells[0].Value.ToString();
                nameText.Text = row.Cells[1].Value.ToString();
                emailText.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString() == "Male") maleRadioBtn.Checked = true;
                if (row.Cells[3].Value.ToString() == "Female") femaleRadioBtn.Checked = true;
                salaryText.Text = row.Cells[5].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double salary = double.Parse(salaryText.Text.ToString());
                if(salary<0)
                {
                    MessageBox.Show("Invalid Salary!");
                    return;
                }
                string str = "update employee set salary='" + salary + "' where userid='" + userIdText.Text.ToString() + "'; ";
                Employee.DataAccess.ExecuteQuery(str);
                MessageBox.Show("UPGRADATION DONE!");
                this.clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            string s = searchText.Text.ToString();
            string status = "Yes";
            if (cbCustomerStatus.Text.ToString() == "Add Employees") status = "Yes";
            if (cbCustomerStatus.Text.ToString() == "Suspended Employees") status = "Suspend";
            string str = @"select * from employee where (userid like '%" + s + "%' or name like '%" + s + "%' or email like '%" + s
                + "%') and approval='" + status + "';";
            this.PopulateGridView(str);
        }
    }
}
