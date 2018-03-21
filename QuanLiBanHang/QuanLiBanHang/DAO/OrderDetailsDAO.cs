using QuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAO
{
   public class OrderDetailsDAO
    {
        private static OrderDetailsDAO instance;

        public static OrderDetailsDAO Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new OrderDetailsDAO();
                } return OrderDetailsDAO.instance;
            }
           private set { OrderDetailsDAO.instance = value; }
        }

        private OrderDetailsDAO()
        {

        }

        public List<OrderDetails> loadOrderDetails()
        {
            List<OrderDetails> orderDetailsList = new List<OrderDetails>();

            string query = "";
            DataTable  data = ConnectDB.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                OrderDetails orderDetails = new OrderDetails(item);
                orderDetailsList.Add(orderDetails);
            }


            return orderDetailsList;

        }


    }
}
