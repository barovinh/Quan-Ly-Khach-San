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

namespace QL_KhachSan.GUI.LoaiPhong
{
    public partial class FormSuaLoaiPhong : Form
    {
        public Model.Entity.LoaiPhong LOAIPHONG { get; set; }
        public FormSuaLoaiPhong(Model.Entity.LoaiPhong lp)
        {
            InitializeComponent();
            LOAIPHONG = lp;
        }

        private void FormSuaLoaiPhong_Load(object sender, EventArgs e)
        {
            txtGiaGio.Text = LOAIPHONG.GiaGio.ToString();
            txtGiaNgay.Text = LOAIPHONG.GiaNgay.ToString();
            txtSoGiuong.Text = LOAIPHONG.SoGiuong.ToString();
            txtSoNguoiToiDa.Text = LOAIPHONG.SoNguoiToiDa.ToString();
            txtTenLoaiPhong.Text = LOAIPHONG.TenLPH.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LOAIPHONG.SoGiuong = int.Parse(txtSoGiuong.Text);
            LOAIPHONG.SoNguoiToiDa = int.Parse(txtSoNguoiToiDa.Text);
            LOAIPHONG.TenLPH = txtTenLoaiPhong.Text;
            LOAIPHONG.GiaGio = float.Parse(txtGiaGio.Text);
            LOAIPHONG.GiaNgay = float.Parse(txtGiaNgay.Text);
            LoaiPhongDAO lpDAO = new LoaiPhongDAO();
            int kt = lpDAO.UpdateLoaiPhong(LOAIPHONG);
            if(kt>0)
            {
                MessageBox.Show("Sửa thông tin thành công");

            }
            else
            {
                MessageBox.Show("Sửa thất bại");

            }
        }

        private void txtTenLoaiPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaGio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaNgay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoNguoiToiDa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoGiuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelThemDichVu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
