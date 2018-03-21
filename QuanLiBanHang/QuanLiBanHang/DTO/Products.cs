using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DTO
{
    public class Products
    {

        public Products(int categoryId, int supplierId, int productId, string productName, string unit, int price, string description)
        {

            this.categoryId = categoryId;
            this.supplierId = supplierId;
            this.productId = productId;
            this.productName = productName;
            this.unit = unit;
            this.price = price;
            this.description = description;
        }

        public Products(DataRow row)
        {

            this.categoryId = (int)row["CategoryID"];
            this.supplierId = (int)row["SupplierID"];
            this.productId = (int)row["ProductID"];
            this.productName = row["ProductName"].ToString();
            this.unit = row["Unit"].ToString();
            this.price = (int)row["Price"];
            this.description = row["Description"].ToString();
        }

        private int categoryId;

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
        private int supplierId;

        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }
        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private string unit;

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
