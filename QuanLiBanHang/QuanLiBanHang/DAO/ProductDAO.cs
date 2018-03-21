using QuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAO
{
   public  class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new ProductDAO();
                    
                } return ProductDAO.instance;
            }
           private set { ProductDAO.instance = value; }
        }

        private ProductDAO() {  }

        public List<Products> loadProduct()
        {

            List<Products> proList = new List<Products>();
            string query = "select ca.CategoryID,su.SupplierID,pr.*  from Products pr join Categories ca on pr.CategoryID = ca.CategoryID join Suppliers su on pr.SupplierID = su.SupplierID;";
            DataTable data = ConnectDB.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Products pro = new Products(item);
                proList.Add(pro);
                
            }




            return proList;

        }



    }
}
