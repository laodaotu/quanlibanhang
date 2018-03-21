using QuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAO
{
    public class CustomersDAO
    {

        private static CustomersDAO instance;

        public static CustomersDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomersDAO();
                } return CustomersDAO.instance;
            }
            private set { CustomersDAO.instance = value; }
        }
        private CustomersDAO() { }

        public List<Customers> loadCustomerdd()
        {
            List<Customers> cusList = new List<Customers>();
            string query = "select * from Customers;";
            DataTable data = ConnectDB.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customers custome = new Customers(item);
                cusList.Add(custome);
            }
            return cusList;
        }
      


    }
}
