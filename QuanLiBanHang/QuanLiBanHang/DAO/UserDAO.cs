using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DAO
{
    public class UserDAO
    {
        private static  UserDAO instance;

        public static  UserDAO Instance
        {
            get {
                if (instance ==null)
                {
                    instance = new UserDAO();
                }
                return instance; 
            }
            private set { instance = value; }
        }

        private UserDAO()
        {

        }
        public bool login(string user,string pass)
        {
            string query = "select * from Users where UserName = N'" + user + "' and Password = '" + pass + "';";
            DataTable result = ConnectDB.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }


    }
}
