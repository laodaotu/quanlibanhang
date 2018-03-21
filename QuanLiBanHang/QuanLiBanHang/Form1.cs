using QuanLiBanHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (login(user,pass))
            {
                frmQuanLyBH f = new frmQuanLyBH();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
            }
            
        }

        public bool login(string user, string pass)
        {

            return UserDAO.Instance.login(user, pass);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* if (MessageBox.Show("Bạn có muốn thoát ?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }*/
        }
    }
}
