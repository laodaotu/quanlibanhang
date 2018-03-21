using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanHang.DTO
{
    public class Users
    {
        private int iD;
        private string fullName;
        private string userName;
        private string passWord;


        public Users(int iD,string fullName,string userName,string passWord)
        {
            this.iD = iD;
            this.fullName = fullName;
            this.userName = userName;
            this.passWord = passWord;
        }
        public Users(DataRow row)
        {
            this.iD = (int)row["UserID"];
            this.fullName = row["FullName"].ToString();
            this.userName = row["UserName"].ToString();
           this.passWord = row["Password"].ToString();
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

      

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
    }
}
