using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeeData
    {
        private string id;
        private string password;
        private string email;
        private string name;
        private string joiningDate;
        private string gender;
        private double salary;
        private double balance;
        private string approval;
        public EmployeeData(string id, string name, string email, string password, string gender, string joiningDate, double salary, string approval, double balance)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.balance = balance;
            this.gender = gender;
            this.joiningDate = joiningDate;
            this.approval = approval;
            this.salary = salary;
        }
        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public string Gender
        {
            set { this.gender = value; }
            get { return this.gender; }
        }
        public string JoiningDate
        {
            set { this.joiningDate = value; }
            get { return this.joiningDate; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public string Approval
        {
            set { this.approval = value; }
            get { return this.approval; }
        }
        public double Salary
        {
            set { this.salary = value; }
            get { return this.salary; }
        }
    }
}
