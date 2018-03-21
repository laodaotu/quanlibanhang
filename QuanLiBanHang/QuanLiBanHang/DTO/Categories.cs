using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DTO
{
    public class Categories
    {
        private int categoryId;
        private string categoryName;
        private string description;

        public Categories(int categoryId, string categoryName, string description)
        {
            this.categoryId = categoryId;
            this.categoryName = categoryName;
            this.description = description;
        }

        public Categories(DataRow row)
        {
            this.categoryId = (int)row["CategoryID"];
            this.categoryName = row["CategoryName"].ToString();
            this.description = row["Description"].ToString();
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
    }
}
