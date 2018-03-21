using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DTO
{
    public class OrderDetails
    {
        private int orderId;
        private int detailId;
        private int productId;
        private int quantity;

        private string note;


        public OrderDetails(int orderId, int detailId, int productId, int quantity, string note)
        {
            this.orderId = orderId;
            this.detailId = detailId;
            this.productId = productId;
            this.quantity = quantity;
            this.note = note;

        }
        public OrderDetails(DataRow row)
        {
            this.orderId = (int)row["OrderID"];
            this.detailId = (int)row["DetailID"];
            this.productId = (int)row["ProductID"];
            this.quantity = (int)row["Quantity"];
            this.note = row["Note"].ToString();
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }


        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public int DetailId
        {
            get { return detailId; }
            set { detailId = value; }
        }

       

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
        public OrderDetails()
        {

        }
    }
}
