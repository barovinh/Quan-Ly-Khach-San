
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using QL_KhachSan;
using QL_KhachSan.Model.DAO;
using QL_KhachSan.Model.Entity;

namespace QL_KhachSan.GUI
{
    public partial class FormDangNhap : Form
    {
        bool check = false;
        public FormDangNhap()
        {
            InitializeComponent();
            this.AcceptButton = btnDangNhap;
        }
        
        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
          
        }

     
        private void txtDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtDangNhap.Text == "Tên đăng nhập")
            {
                txtDangNhap.Text = "";
            }

        }

        private void txtDangNhap_Leave(object sender, EventArgs e)
        {
            if(txtDangNhap.Text =="")
            {
                txtDangNhap.Text = "Tên đăng nhập";
                
            }
        }

        private void panel1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if(txtMatKhau.Text=="Mật khẩu")
            {
                txtMatKhau.PasswordChar = '*';
                txtMatKhau.Text = "";
            }    
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if(txtMatKhau.Text=="")
            {
                txtMatKhau.PasswordChar = (char)0;
                txtMatKhau.Text = "Mật khẩu";

            }
        }

        private void picShowPass_Click(object sender, EventArgs e)
        {
            if(check==false)
            {
                this.picShowPass.Image = global::QL_KhachSan.Properties.Resources.show;
                txtMatKhau.UseSystemPasswordChar = true;
                check = true;
            }
            else
            {
                picShowPass.Image = global::QL_KhachSan.Properties.Resources.hide;
              txtMatKhau.UseSystemPasswordChar = false;
                check = false;

            }
        }

        private void labelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtDangNhap.Text.Length==0 || txtMatKhau.Text.Length==0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            TaiKhoanDAO tkDAO = new TaiKhoanDAO();
            TaiKhoan tk = tkDAO.TimTaiKhoan(txtDangNhap.Text);
            
            if(tk!=null)
            {
                if(tk.MatKhau == txtMatKhau.Text && txtDangNhap.Text == tk.TenTK)
                {
                    Menu main = new Menu(tk);
                    main.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên đăng nhập");
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
