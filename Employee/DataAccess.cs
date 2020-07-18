using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Employee
{
    public class DataAccess
    {
        private static SqlConnection sqcon;

        public static SqlConnection Sqcon
        {
            get
            {
                if (sqcon == null)
                {
                    sqcon = new SqlConnection(@"Data Source=DESKTOP-QN5IDS1;Initial Catalog=Bank loan system;Persist Security Info=True;User ID=sa;Password=hafiz126");
                }
                else if (sqcon.State != ConnectionState.Open)
                {
                    sqcon.Open();
                }
                return sqcon;
            }
        }

        public static DataSet GetDataSet(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, Sqcon);
            return sqcom.ExecuteNonQuery();
        }

        public static void update(string id, string name, string email, string password, string gender, string joiningDate, double salary, string approval, double balance)
        {
            try
            {
                string str = @"update employee set name='" + name + "',email='" + email + "',password='" + password + "'," +
                    "gender='" + gender + "',joiningDate='" + joiningDate + "',salary='" + salary + "'," +
                    "approval='" + approval + "',balance='" + balance + "' where userid='" + id + "';";
                int okay = ExecuteQuery(str);
                MessageBox.Show("UPGRADATION DONE!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void insert(string id, string name, string email, string password, string gender, string joiningDate, double salary, string approval, double balance)
        {
            try
            {
                string str = @"insert into employee values('" + id + "','" + name + "','" + email + "','" + password +
                    "','" + gender + "','" + joiningDate + "','" + salary + "','" + approval + "','" + balance + "');";
                int okay = ExecuteQuery(str);
                MessageBox.Show("Insertation DONE!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void delete(string id)
        {
            try
            {
                string str = @"delete from employee where userid='" + id + "';";
                int okay = ExecuteQuery(str);
                MessageBox.Show("Deletion Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static double loanAllUpdate(int loanTranId, string userId, int loanId, double balance, double monthlyPayment, int installments, double dueAmount, double dueLoan)
        {
            try
            {
                string str = @"update employee set balance = '" + balance + "' where userid='" + userId + "';";
                int u = ExecuteQuery(str);
                DateTime d = DateTime.Now;
                string date = d.ToString();
                str = "select * from loan where loanId='" + loanId + "';";
                var ds = GetDataSet(str);
                var row = ds.Tables[0].Rows[0];
                string loanName = row["name"].ToString();
                double rate = double.Parse(row["interestRatePerYear"].ToString());
                double beginningBalance = dueLoan;
                double interest = (dueLoan * rate) / 1200;
                double principal = monthlyPayment - interest;
                double endingBalance = dueLoan - principal;
                if (endingBalance <= 0) endingBalance = 0;
                dueLoan = endingBalance;
                if (dueAmount <= 0.000001) dueAmount = 0;
                str = @"update activeLoan set payableAmount= '" + dueAmount + "',paidNoOfPayments='" + installments + "', dueLoanAmount='" + dueLoan + "' where LoanTransactionId='" + loanTranId + "';";
                u = ExecuteQuery(str);
                str = @"insert into loanTransaction values ('" + userId + "', '" + loanName + "', '" + date + "', '" + beginningBalance + "', '" + monthlyPayment + "','" + principal + "', '" + interest + "', '" + endingBalance + "') ;";
                u = ExecuteQuery(str);
                return dueLoan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dueLoan;
            }
        }
    }
}
