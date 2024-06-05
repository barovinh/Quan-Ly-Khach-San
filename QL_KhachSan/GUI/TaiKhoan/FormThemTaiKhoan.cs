using QL_KhachSan.Model;
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
    public partial class FormThemTaiKhoan : Form
    {
        DbContext db = new DbContext();
        public FormThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Model.Entity.TaiKhoan kh = new Model.Entity.TaiKhoan();
            TaiKhoanDAO khDAO = new TaiKhoanDAO();
            kh.MaNV = cboMaNV.SelectedValue.ToString();
            kh.TenTK = txtTenTK.Text;
            kh.MatKhau = txtPass.Text;
            if(cboQuyen.SelectedItem.ToString()==string.Empty)
            {
                MessageBox.Show("Không được bỏ trống quyền");
                return;
            }
            if(txtTenTK.Text.Length==0 || txtPass.Text.Length==0)
            {
                MessageBox.Show("Các thông tin không được bỏ trống");
                return;
            }
            kh.CapQuyen = int.Parse(cboQuyen.SelectedItem.ToString());
            if (khDAO.ThemTaiKhoan(kh) > 0)
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        void LoadComboNhanVien()
        {
            string sql = "SELECT * FROM NhanVien\r\nWHERE MaNV NOT IN (SELECT MaNV FROM TaiKhoan);";
            DataTable dt = db.getDatatable(sql);
            cboMaNV.DataSource = dt;
            cboMaNV.DisplayMember = "TenNV";
            cboMaNV.ValueMember = "MaNV";
        }
        private void FormThemTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadComboNhanVien();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
