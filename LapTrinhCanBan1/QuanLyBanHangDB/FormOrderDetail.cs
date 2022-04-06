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
    public partial class FormOrderDetail : Form
    {
        public FormOrderDetail()
        {
            InitializeComponent();
        }
        DataBanHangDataContext _db = new DataBanHangDataContext();
        private void FormOrderDetail_Load(object sender, EventArgs e)
        {
            string maDonHang = DataBG.OrderId;
            Order donHang = _db.Orders.FirstOrDefault(
                i => i.OrderID.ToString() == maDonHang
                );
            if (donHang == null) {
                return;
            }
            // set các giá trị trong form
            SetFormDefaut(donHang);
             
        }

        private void SetFormDefaut(Order donHang)
        {
            txtMa.Text = donHang.OrderID.ToString();
            txtMaKhachHang.Text = donHang.CustomerID;
            txtDiaChi.Text = donHang.ShipAddress;

            dgvDSSanPham.DataSource = donHang.Order_Details
                .Select(
                i => new {
                    OrderId = i.OrderID,
                    ProductName = i.Product.ProductName,
                    SoLuong = i.Quantity,
                    DonGia = i.UnitPrice,
                    GiamGia = i.Discount,
                    ThanhTien = (i.Quantity* i.UnitPrice
                    * (decimal)(1 - i.Discount)),
                }
                ).ToList();

        }

        private void btnXemKH_Click(object sender, EventArgs e)
        {
            DataBG.KhachHang = txtMaKhachHang.Text;

            Form f = new FormKhachHang();
            f.Show();
        }
    }
}
