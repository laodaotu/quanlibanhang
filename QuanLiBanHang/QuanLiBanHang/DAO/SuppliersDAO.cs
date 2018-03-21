using QuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAO
{
    public class SuppliersDAO
    {

        private static SuppliersDAO instance;

        public static SuppliersDAO Instance
        {
            get
            {
                if (instance ==null)
                {
                    instance = new SuppliersDAO();
                } return SuppliersDAO.instance;
            }
           private set { SuppliersDAO.instance = value; }

        }

        private SuppliersDAO()
        {


        }

        public List<Suppliers> loadSuppliers()
        {
            List<Suppliers> suppList = new List<Suppliers>();
            string query = "SELECT SupplierID,CompanyName,ContactName,Address,Phone,Email FROM Suppliers;;";
            DataTable data = ConnectDB.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Suppliers supp = new Suppliers(item);
                suppList.Add(supp);
            }

            return suppList;

        }
    }
}
