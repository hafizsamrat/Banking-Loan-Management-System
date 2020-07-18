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

namespace Admin
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

        public static void update(string id, string name, string email, string password, string gender, string joiningDate)
        {
            try
            {
                string str = @"update admin set name='" + name + "',email='" + email + "',password='" + password + "'," +
                    "gender='" + gender + "',joiningDate='" + joiningDate + "' where userid='" + id + "';";
                int okay = ExecuteQuery(str);
                MessageBox.Show("UPGRADATION DONE!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void loanUpdate(int id,string name, double interest, string user)
        {
            try
            {
                string str = @"update loan set name='" + name + "', interestRatePerYear='" + interest
                    + "', consumer='" + user + "' where loanId='" + id + "';";
                int okay = ExecuteQuery(str);
                MessageBox.Show("UPGRADATION DONE!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void loanInsert(string name, double interest, string user)
        {
            try
            {
                string str = @"select * from loan where name='" + name + "' and consumer='" + user + "'; ";
                var ds = GetDataSet(str);
                if(ds.Tables[0].Rows.Count>0)
                {
                    MessageBox.Show("This loan Facility already available! ");
                    return;
                }
                str = @"insert into loan values ( '" + name + "' ,'" + interest + "','" + user + "');";
                int okay = ExecuteQuery(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void loanApplyUpdate(int id,double payableAmount,int paidPayment,string loanApprovalDate,string approve)
        {
            try
            {
                string str = @"update activeLoan set payableAmount='" + payableAmount + "'paidNoOfPayments='" + paidPayment + "',loanAppovalDate='" + loanApprovalDate +
                    "',approve='" + approve + "' where LoanTransactionId='" + id + "' ;  ";
                int u = ExecuteQuery(str);
                MessageBox.Show("Loan Approved!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void loanApplyInsert(int loanId, string userId, double loanAmount, double monthlyPayment,double interest, double totalLoan, double payableAmount, int noOfPayment, int paidPayment, string loanApprovalDate, string approve)
        {
            try
            {
                string str = @"insert into activeLoan values ('"+loanId+"', '" + userId + "','" + loanAmount + "','"+monthlyPayment+"', '" + interest 
                    + "','" + totalLoan + "','" + payableAmount + "','" + noOfPayment + "','" + paidPayment + "','" 
                    + loanApprovalDate + "','" + approve + "','"+loanAmount+"') ;";
                int u = ExecuteQuery(str);
                MessageBox.Show("Appication Recieved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void loanAutoUpdate()
        {
            try
            {
                string str = @"select * from activeLoan where paidNoOfPayments<noOfPayments and approve='Yes';";
                var ds = GetDataSet(str);
                for(var i =0;i<ds.Tables[0].Rows.Count;i++)
                {
                    var row = ds.Tables[0].Rows[i];
                    string id = row["userid"].ToString();
                    int paidNoOfPayments = Int32.Parse(row["paidNoOfPayments"].ToString());
                    DateTime approvalDate = DateTime.Parse(row["loanApprovalDate"].ToString());
                    str = @"select * from customer where userid='" + id + "';";
                    if(id[0]=='E') str = @"select * from employee where userid='" + id + "';";
                    var dt = GetDataSet(str);
                    var userRow = dt.Tables[0].Rows[0];
                    DateTime now = DateTime.Now;
                    TimeSpan s = (now-approvalDate);
                    int time = s.Days;
                    if((time/31 - paidNoOfPayments)>3)
                    {
                        if(id[0]=='E')
                        {
                            str = @"update employee set approve='Suspend' where userid='" + id + "';";
                        }
                        else
                        {
                            str = @"update customer set approve='Suspend' where userid='" + id + "';";
                        }
                        int u = ExecuteQuery(str);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
