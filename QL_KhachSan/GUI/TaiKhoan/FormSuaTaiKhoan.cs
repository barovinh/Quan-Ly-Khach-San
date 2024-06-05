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

namespace QL_KhachSan.GUI.Account
{
    public partial class FormSuaTaiKhoan : Form
    {
        public Model.Entity.TaiKhoan TaiKhoan { get; set; }
        public FormSuaTaiKhoan(Model.Entity.TaiKhoan tk)
        {
            InitializeComponent();
            TaiKhoan = tk;
        }

        private void FormSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = TaiKhoan.MaNV.ToString();
            txtTenTK.Text = TaiKhoan.TenTK.ToString();
            txtPass.Text = TaiKhoan.MatKhau.ToString();
            cboQuyen.SelectedValue = TaiKhoan.CapQuyen.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TaiKhoan.MaNV = txtMaNV.Text;
            TaiKhoan.TenTK = txtTenTK.Text;
            TaiKhoan.MatKhau = txtPass.Text;
            TaiKhoan.CapQuyen = int.Parse(cboQuyen.Text);
            TaiKhoanDAO tkDAO = new TaiKhoanDAO();
            int kt = tkDAO.UpdateTaiKhoan(TaiKhoan);
            if (kt > 0)
            {
                MessageBox.Show("Sửa thông tin thành công");

            }
            else
            {
                MessageBox.Show("Sửa thất bại");

            }
        }
    }
}
