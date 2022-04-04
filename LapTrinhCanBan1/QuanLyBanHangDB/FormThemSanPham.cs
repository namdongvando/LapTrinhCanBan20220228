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
            if (DataBG.EditProduct.ProductID != 0)
            {
                // sửa
                SetFormDefaut();
                btnThem.Visible = false;
                btnSua.Visible = true;
                btnXoa.Visible = true;
            }
            else
            {
                // them
                btnThem.Visible = true;
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
        }

        private void SetFormDefaut()
        {
            Product sp = _db.Products
                .FirstOrDefault(
                item => item.ProductID == DataBG.EditProduct.ProductID);
            if (sp == null)
                return;
            txtMa.Text = sp.ProductID.ToString();
            txtTen.Text = sp.ProductName.ToString();
            txtGia.Text = sp.UnitPrice.ToString();
            cbbNCC.SelectedValue = sp.SupplierID;
            cbbDM.SelectedValue = sp.CategoryID;
            txtTonKho.Text = sp.UnitsInStock.ToString();
            txtGiamGia.Text = sp.SalePrice.ToString();
            txtSapXep.Text = sp.ReorderLevel.ToString();
            ccbNgungBan.Checked = sp.Discontinued;
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
                Category danhMuc = (Category)cbbDM.SelectedItem;
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
            if (double.TryParse(txtGia.Text, out a) == false)
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput();
                Category danhMuc = (Category)cbbDM.SelectedItem;
                Supplier ncc = (Supplier)cbbNCC.SelectedItem;
                // có dữ liệu ok
                Product sp = new Product()
                {
                    ProductID = int.Parse(txtMa.Text),
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

                var producData = _db.Products.FirstOrDefault(item => item.ProductID == sp.ProductID);
                if (producData == null)
                {
                    return;
                }
                producData.ProductName = sp.ProductName;
                producData.CategoryID = sp.CategoryID;
                producData.SupplierID = sp.SupplierID;
                producData.SalePrice = sp.SalePrice;
                producData.UnitPrice = sp.UnitPrice;
                producData.UnitsInStock = sp.UnitsInStock;
                producData.Discontinued = sp.Discontinued;
                producData.UnitsOnOrder = sp.UnitsOnOrder;
                producData.QuantityPerUnit = sp.QuantityPerUnit;
                producData.ReorderLevel = sp.ReorderLevel;
                _db.SubmitChanges();
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var isOK = MessageBox.Show("Bạn Muốn Xóa Sản Phẩm Nảy?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (isOK == DialogResult.OK)
                {
                    // đòng ý xóa
                    // tìm sp muốn xóa
                    var sp = _db.Products.FirstOrDefault(
                        i => i.ProductID == int.Parse(txtMa.Text)
                        );
                    // đăng ký xóa
                    _db.Products.DeleteOnSubmit(sp);
                    // thực hiện xóa
                    _db.SubmitChanges();
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không Thể Xóa Sản Phẩm Này");
            }
            
        }
    }
}
