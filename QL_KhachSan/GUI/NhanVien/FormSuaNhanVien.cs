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

namespace QL_KhachSan.GUI.Staff
{
    public partial class FormSuaNhanVien : Form
    {
        public Model.Entity.NhanVien NhanVien { get; set; }
        public FormSuaNhanVien(Model.Entity.NhanVien nhanVien)
        {
            InitializeComponent();
            NhanVien = nhanVien;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVienDAO NvDAO = new NhanVienDAO();
            Model.Entity.NhanVien Nv = new Model.Entity.NhanVien();
            Nv.TenNV = txtTenNV.Text;
            Nv.ChucVu = txtChucVu.Text;
            Nv.Luong = int.Parse(txtLuong.Text);
            Nv.SDT = txtSDT.Text;
            Nv.NgaySinh = this.dateTimePicker1.Value;
            Nv.CCCD = txtCCD.Text;
            Nv.Email = txtEmail.Text;
            if (NvDAO.UpdateNhanVien(Nv) > 0)
            {
                MessageBox.Show("Cật nhật thành công");
            }
            else
            {
                MessageBox.Show("Cật nhật thất bại");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FormSuaNhanVien_Load(object sender, EventArgs e)
        {
            txtTenNV.Text = NhanVien.TenNV.ToString();
            txtChucVu.Text = NhanVien.ChucVu.ToString();
            txtLuong.Text = NhanVien.Luong.ToString();
            txtSDT.Text = NhanVien.SDT.ToString();
            dateTimePicker1.Value = NhanVien.NgaySinh;
            txtCCD.Text = NhanVien.CCCD.ToString();
            txtDiaChi.Text = NhanVien.DiaChi.ToString();
            txtEmail.Text = NhanVien.Email.ToString();
        }
    }
}
