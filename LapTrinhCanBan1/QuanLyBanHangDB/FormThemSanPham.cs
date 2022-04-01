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
    public partial class FormThemSanPham : Form
    {
        // khai báo data kết nối database
        DataBanHangDataContext _db
            = new DataBanHangDataContext();

        public FormThemSanPham()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {


        }

        private void FormThemSanPham_Load(object sender, EventArgs e)
        { 
            LoadDanhMuc();
            LoadNhaCungCap();
            if (DataBG.EditProduct.ProductID != null) {
                SetFormDefaut();
            }
        }

        private void SetFormDefaut()
        {
            Product sp = _db.Products
                .FirstOrDefault(
                item => item.ProductID == DataBG.EditProduct.ProductID);
            txtMa.Text = sp.ProductID.ToString();

        }

        private void LoadNhaCungCap()
        {
            cbbNCC.DataSource =
                _db.Suppliers.ToList();
            //var em = new Supplier();
            //em.SupplierID
            cbbNCC.DisplayMember = "CompanyName";
            cbbNCC.ValueMember = "SupplierID";

        }

        private void LoadDanhMuc()
        {
            cbbDM.DataSource =
                _db.Categories.ToList();
            //Category c = new Category();
            //c.CategoryName
            cbbDM.DisplayMember = "CategoryName";
            cbbDM.ValueMember = "CategoryID";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                 
                CheckInput();
                Category danhMuc = (Category) cbbDM.SelectedItem;
                Supplier ncc = (Supplier)cbbNCC.SelectedItem;
                // có dữ liệu ok
                Product sp = new Product()
                {
                    ProductName = txtTen.Text,
                    CategoryID = danhMuc.CategoryID,
                    SupplierID = ncc.SupplierID,
                    SalePrice = decimal.Parse(txtGiamGia.Text),
                    UnitPrice = decimal.Parse(txtGia.Text),
                    UnitsInStock = short.Parse(txtTonKho.Text),
                    Discontinued = ccbNgungBan.Checked,
                    UnitsOnOrder = 0,
                    QuantityPerUnit = txtQuyCachDongGoi.Text,
                    ReorderLevel = short.Parse(txtSapXep.Text)
                };
                _db.Products.InsertOnSubmit(sp);
                _db.SubmitChanges();
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CheckInput()
        {
            if (txtTen.Text.Trim() == string.Empty)
            {
                txtTen.Focus();
                throw new Exception("Bạn Chưa Nhập Tên Sản Phẩm");
            }
            double a;
            if (double.TryParse(txtGia.Text,out a)==false)
            {
                txtGia.Focus();
                txtGia.SelectAll();
                throw new Exception("Giá Không Đúng Định Dạng");
            }
            if (double.TryParse(txtGiamGia.Text, out a) == false)
            {
                txtGiamGia.Focus();
                txtGiamGia.SelectAll();
                throw new Exception("Giá Không Đúng Định Dạng");
            }

        }
    }
}
