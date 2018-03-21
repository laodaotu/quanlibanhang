using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DTO
{
   public class Suppliers
    {
        private int suppliersID;
        private string commanyName;
        private string contactName;
        private string address;
        private string phone;
        private string email;

        public Suppliers(int suppliersID, string commanyName, string contactName, string address, string phone, string email)
        {
            this.suppliersID = suppliersID;
            this.commanyName = commanyName;
            this.contactName = contactName;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }
        public Suppliers(DataRow row)
        {
            this.suppliersID = (int)row["SupplierID"];
            this.commanyName = row["CompanyName"].ToString();
            this.contactName = row["ContactName"].ToString();
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

        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }
        public string CommanyName
        {
            get { return commanyName; }
            set { commanyName = value; }
        }
        public int SuppliersID
        {
            get { return suppliersID; }
            set { suppliersID = value; }
        }

    }
}
