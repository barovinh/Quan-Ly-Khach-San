using QL_KhachSan.Model;
using QL_KhachSan.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan.GUI.Customer
{
    public partial class FormThemKhachHang : Form
    {
        DbContext db = new DbContext();
        public FormThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Model.Entity.KhachHang kh = new Model.Entity.KhachHang();
            KhachHangDAO khDAO = new KhachHangDAO();
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.SDT = txtSDT.Text;
            kh.CCCD = txtCCCD.Text;
            kh.QuocTich = txtQuocTich.Text;
            kh.GioiTinh = txtGioiTinh.Text;
            
            if (khDAO.ThemKhachHang(kh) > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
