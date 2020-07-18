using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class AdminData
    {
        private string id;
        private string password;
        private string email;
        private string name;
        private string joiningDate;
        private string gender;
        public AdminData(string id, string name, string email, string password, string gender, string joiningDate)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.gender = gender;
            this.joiningDate = joiningDate;
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
    }
}
