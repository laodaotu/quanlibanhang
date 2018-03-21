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
    public partial class frmQuanLyBH : Form
    {
        public frmQuanLyBH()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            loadALL();
        }

        private void tabControl1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbHangHoa_Click(object sender, EventArgs e)
        {

        }
        public void loadALL()
        {
            loadNguoiDung();
            loadCustomers();
            loadSuppliers();
            loadProducts();
            loadCate();
        }

        public void loadNguoiDung()
        {
            dgvND.DataSource = UsersDAO.Instance.loadUsers();
        }
        public void loadCustomers()
        {
            dgvKH.DataSource = CustomersDAO.Instance.loadCustomerdd();
        }
        public void loadSuppliers()
        {
            dgvNCC.DataSource = SuppliersDAO.Instance.loadSuppliers();
        }
        public void loadProducts()
        {
            dgvHH.DataSource = ProductDAO.Instance.loadProduct();
        }
        public void loadCate()
        {
            dgvLoaiHH.DataSource = CategoriesDAO.Instance.loadCategories();
        }
        public void load()
        {
            
        }



    }
}
