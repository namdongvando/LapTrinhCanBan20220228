using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangDB
{
    public partial class FormProduct : Form
    {
        DataBanHangDataContext _db = new DataBanHangDataContext();
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            dgvDSSanPham.DataSource = _db.Products.ToList();
            // lấy danh sách danh muc
            List<Category> dsDanhMuc = _db.Categories.ToList();
            // Thêm chon danh muc
            dsDanhMuc.Insert(0, new Category()
            {
                CategoryID = 0,
                CategoryName = "Chọn Danh Mục Sản Phẩm"
            }); 
            cbbDanhMuc.DataSource = dsDanhMuc;
            //Category c = new Category();
            //c.CategoryID;
            cbbDanhMuc.DisplayMember = "CategoryName";
            cbbDanhMuc.ValueMember = "CategoryID";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTuKhoa.Text;
            Category danhMuc = (Category) cbbDanhMuc.SelectedItem;
            //MessageBox.Show("");
            var dsSanPham = _db.Products
                .Where(sp => sp.CategoryID 
                == danhMuc.CategoryID 
                && sp.ProductName.Contains(tukhoa)).ToList();

            dgvDSSanPham.DataSource = dsSanPham;
        }

        private void cbbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category danhMuc = (Category) cbbDanhMuc.SelectedItem;
            dgvDSSanPham.DataSource = 
                _db.Products
                .Where(sp => sp.CategoryID == danhMuc.CategoryID)
                .ToList();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataBG.EditProduct = new Product();
            Form f = new FormThemSanPham();
            f.ShowDialog();
        }

        private void dgvDSSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maSanPham =
                dgvDSSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (DataBG.EditProduct == null) {
                DataBG.EditProduct = new Product();
            }
            DataBG.EditProduct.ProductID = int.Parse(maSanPham);

            Form f = new FormThemSanPham();
            if (f.ShowDialog() == DialogResult.OK) {
                _db = new DataBanHangDataContext();
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
