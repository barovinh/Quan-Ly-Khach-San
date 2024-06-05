using QL_KhachSan.Model.DAO;
using QL_KhachSan.Model.Entity;
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
    public partial class FormSuaKhachHang : Form
    {
        public Model.Entity.KhachHang KhachHang { get; set; }
        public FormSuaKhachHang(Model.Entity.KhachHang kh)
        {
            InitializeComponent();
            KhachHang = kh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhachHang.TenKH = txtTenkh.Text;
            KhachHang.SDT = txtSDT.Text;
            KhachHang.CCCD = txtCCCD.Text;
            KhachHang.QuocTich = txtQuocTich.Text;
            KhachHang.GioiTinh = txtGioiTinh.Text;
            KhachHangDAO khDAO = new KhachHangDAO();
            int kt = khDAO.UpdateKhachHang(KhachHang);
            if (kt > 0)
            {
                MessageBox.Show("Sửa thông tin thành công");

            }
            else
            {
                MessageBox.Show("Sửa thất bại");

            }
        }

        private void FormSuaKhachHang_Load(object sender, EventArgs e)
        {
            txtTenkh.Text = KhachHang.TenKH.ToString();
            txtSDT.Text = KhachHang.SDT.ToString();
            txtCCCD.Text = KhachHang.CCCD.ToString();
            txtQuocTich.Text = KhachHang.QuocTich.ToString();
            txtGioiTinh.Text = KhachHang.GioiTinh.ToString();
        }

        private void LabelThemDichVu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
