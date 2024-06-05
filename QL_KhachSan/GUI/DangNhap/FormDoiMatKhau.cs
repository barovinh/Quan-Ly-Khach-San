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

namespace QL_KhachSan.GUI.Login
{
    public partial class FormDoiMatKhau : Form
    {
        public TaiKhoan TK { get; set; }
        public FormDoiMatKhau(TaiKhoan tk)
        {
            InitializeComponent();
            TK = tk;
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if(txtMKCu.Text.Length==0|| txtMkMoi.Text.Length==0||txtXacNhan.Text.Length==0)
            {
                MessageBox.Show("Các thông tin không được bỏ trống");

            }
            if (txtMKCu.Text==TK.MatKhau)
            {
                if(txtMkMoi.Text==txtXacNhan.Text)
                {
                    TaiKhoanDAO tkDAO = new TaiKhoanDAO();
                    TK.MatKhau = txtMkMoi.Text;
                    int kt = tkDAO.UpdateTaiKhoan(TK);
                    if(kt>0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công");
                        this.Visible = false;
                        new FormDangNhap().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
            }
        }
    }
}
