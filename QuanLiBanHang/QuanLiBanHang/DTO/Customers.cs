using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DTO
{
    public class Customers
    {
        private int customerId;
        private string fisrtName;
        private string lastName;
        private string address;
        private string phone;
        private string email;

        public Customers(int customerId, string fisrtName, string lastName, string address, string phone, string email)
        {
            this.customerId = customerId;
            this.fisrtName = fisrtName;
            this.lastName = lastName;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        public Customers(DataRow row)
        {
            this.customerId = (int)row["CustomerID"];
            this.fisrtName = row["FistName"].ToString();
            this.lastName = row["LastName"].ToString();
            this.address = row["Address"].ToString();
            this.phone = row["Phone"].ToString();
            this.email = row["Email"].ToString();
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FisrtName
        {
            get { return fisrtName; }
            set { fisrtName = value; }
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
    }
}
