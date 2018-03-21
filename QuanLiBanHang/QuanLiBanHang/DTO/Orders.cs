using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DTO
{
    public class Orders
    {
        private int custemerId;

        private int orderId;

        private string orderDate;

        private int totalAmount;

        public Orders(int custemerId, int orderId, string orderDate, int totalAmount)
        {
            this.custemerId = custemerId;
            this.orderId = orderId;
            this.orderDate = orderDate;
            this.totalAmount = totalAmount;
        }

        public Orders(DataRow row)
        {
            this.custemerId = (int)row["CustomerID"];
            this.orderId = (int)row["OrderID"];
            this.orderDate = row["OderDate"].ToString();
            this.totalAmount = (int)row["TotalAmount"];
        }

        public int TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public string OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public int CustemerId
        {
            get { return custemerId; }
            set { custemerId = value; }
        }
    }
}
