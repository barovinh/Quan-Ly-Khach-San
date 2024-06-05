using QL_KhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan.GUI.Phong
{
    public partial class FormThemPhong : Form
    {
        bool roi = false;
        DbContext db = new DbContext();
        public FormThemPhong()
        {
            InitializeComponent();
            roi = true;
         
        }
        void LoadComboLoaiPhong()
        {
            string sql = "SELECT*FROM LOAIPHONG";
            DataTable dt = db.getDatatable(sql);
            cbLoaiPhong.DataSource = dt;
            cbLoaiPhong.DisplayMember = "TenLPH";
            cbLoaiPhong.ValueMember = "MaLPH";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Model.DAO.PhongDAO pDAO = new Model.DAO.PhongDAO();
            bool ktKhoa = pDAO.KTKhoaNgoai(txtMaPhong.Text);
            if(ktKhoa==true)
            {
                MessageBox.Show("Không thể thêm do trùng mã");
            }
            else
            {
                Model.Entity.Phong p = new Model.Entity.Phong();
                p.GhiChu = txtGhiChu.Text;
                p.Lp.MaLPH = cbLoaiPhong.SelectedValue.ToString();
                p.MaPH = txtMaPhong.Text;
                p.TTDD = cbTinhTrangDonDep.SelectedItem.ToString();
                p.TTPH = cbTTPH.SelectedItem.ToString();               
                int kt = pDAO.InsertPhong(p); 
                if(kt>0)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void FormThemPhong_Load(object sender, EventArgs e)
        {
            LoadComboLoaiPhong();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(roi)
            {

            }
        }

        private void cbTTPH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
