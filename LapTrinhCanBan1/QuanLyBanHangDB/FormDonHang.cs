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
    public partial class FormDonHang : Form
    {
        DataBanHangDataContext _db = new DataBanHangDataContext();

        public FormDonHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            // ít nhất 3 ký tự
            if (txtTuKhoa.TextLength < 3)
                return;
            var dsDonHang = _db.Orders.Where(
                i => i.OrderID.ToString().Contains(txtTuKhoa.Text)
                || i.CustomerID.Contains(txtTuKhoa.Text)
                ).ToList();
            dataGridView1.DataSource = dsDonHang; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maDonHang =
                dataGridView1.Rows[e.RowIndex].Cells["OrderID"]
                .Value.ToString();
            //MessageBox.Show(maDonHang);
            DataBG.OrderId = maDonHang;
            Form f = new FormOrderDetail();
            f.ShowDialog();
        }
    }
}
