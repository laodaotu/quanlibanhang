using QuanLiBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAO
{
    public class UsersDAO
    {
        private static UsersDAO instance;

        public static UsersDAO Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new UsersDAO();
                    
                } return UsersDAO.instance;
            }
            private set { UsersDAO.instance = value; }
        }
        private UsersDAO() { }
        public List<Users> loadUsers()
        {
            List<Users> tableList = new List<Users>();
            string query = "select * from Users;";
            DataTable data = ConnectDB.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Users users = new Users(item);
                tableList.Add(users);
            }
            return tableList;
        }
    }
}
