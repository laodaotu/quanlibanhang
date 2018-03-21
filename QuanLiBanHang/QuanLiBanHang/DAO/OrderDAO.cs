using QuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;

        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                    
                } return OrderDAO.instance;
            }
           private set { OrderDAO.instance = value; }
        }
        private OrderDAO() { }

        public List<Orders> loadOrder()
        {
            List<Orders> orderList = new List<Orders>();

            string query = "";

            DataTable data = ConnectDB.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Orders order = new Orders(item);
                orderList.Add(order);
            }

            return orderList;

        }
    }
}
