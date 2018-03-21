using QuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAO
{
    public class CategoriesDAO
    {
        private static CategoriesDAO instance;

        public static CategoriesDAO Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new CategoriesDAO();
                } return CategoriesDAO.instance;
            }
           private set { CategoriesDAO.instance = value; }
        }
        private CategoriesDAO() {  }


        public List<Categories> loadCategories()
        {
            List<Categories> cateList = new List<Categories>();
            string query = "select CategoryID,CategoryName,Description from Categories;";
            DataTable data = ConnectDB.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Categories cate = new Categories(item);
                cateList.Add(cate);
            }



            return cateList;
        }

    }
}
