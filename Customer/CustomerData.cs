using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class CustomerData
    {
        private string id;
        private string password;
        private string email;
        private string name;
        private string dateOfBirth;
        private string gender;
        private double balance;
        private string approval;

        public CustomerData(string id,string name,string email,string password,double balance,string gender,string dob,string approval)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.balance = balance;
            this.gender = gender;
            dateOfBirth = dob;
            this.approval = approval;
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
        public string DateOfBith
        {
            set { this.dateOfBirth = value; }
            get { return this.dateOfBirth; }
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
    }
}
