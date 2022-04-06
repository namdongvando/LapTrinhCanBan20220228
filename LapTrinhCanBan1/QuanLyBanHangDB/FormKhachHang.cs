using QuanLyBanHangDB.Model;
using QuanLyBanHangDB.Services;
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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            cbbQuocGia.DataSource = Countries.GetCountries().ToList();
            cbbQuocGia.DisplayMember = "name";
            cbbQuocGia.ValueMember = "name";
            string maKhachHang = DataBG.KhachHang;
            var CS = new CustomerService();
            var kh = CS.GetById(maKhachHang);
            //MessageBox.Show(kh.CustomerID);
            SetFormDefaut(kh);
        }

        private void SetFormDefaut(Customer kh)
        {
            txtMa.Text = kh.CustomerID;
            txtTenCty.Text = kh.CompanyName;
            txtLienHe.Text = kh.ContactName;
            txtChucVu.Text = kh.ContactTitle;
            txtThanhPho.Text = kh.City;
            txtKhuVuc.Text = kh.Region;
            txtFax.Text = kh.Fax;
            txtPhone.Text = kh.Phone;
            txtDiaChi.Text = kh.Address;
            cbbQuocGia.SelectedValue = kh.Country;
            txtMaBuuDien.Text = kh.PostalCode;
        }
    }
}
