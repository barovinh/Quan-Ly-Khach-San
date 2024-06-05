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

namespace QL_KhachSan.GUI.SoDoPhong
{
    public partial class FormThongTinPhongChuaThue : Form
    {
        DbContext db = new DbContext();
        public string TTPH { get; set; }
        public string TTDD { get; set; }
        public string TenPhong { get; set; }
        public TaiKhoan TK { get; set; }
        public FormThongTinPhongChuaThue(string ttph,string ttdd,string tenphong,TaiKhoan tk)
        {
            InitializeComponent();
            TTPH = ttph;
            TTDD = ttdd;
            cbLoadTinhTrangDD.SelectedItem = TTDD;
            cbLoadTinhTrangPhong.SelectedItem = TTPH;
            TK = tk;
            TenPhong = tenphong;
            PhongDAO pDAO = new PhongDAO();
            Model.Entity.Phong phong = pDAO.TimPhongTheoMa(TenPhong);
            txtGhiChu.Text = phong.GhiChu;
            if (cbLoadTinhTrangPhong.SelectedItem.ToString() == "Đang sửa chữa")
            {
                btnDatPhong.Visible = false;
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            FormDatPhong f = new FormDatPhong(TK);
            f.Show();
            this.Close();
        }

        private void FormThongTinPhong_Load(object sender, EventArgs e)
        {

        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // cật nhật ghi chú
            PhongDAO pDAO = new PhongDAO();
            Model.Entity.Phong phong = pDAO.TimPhongTheoMa(TenPhong);
            phong.GhiChu = txtGhiChu.Text;
            pDAO.UpdatePhong(phong);

            // cật nhật tráng thái phòng trống

            string tempT = cbLoadTinhTrangPhong.SelectedItem.ToString(); 

            if(tempT=="Phòng trống")
            {
                tempT = "Bình thường";
              
            }
            else
            {
                tempT = cbLoadTinhTrangPhong.SelectedItem.ToString();
            }
            string sql = "UPDATE PHONG" +
                " SET TTDD = N'" + cbLoadTinhTrangDD.SelectedItem.ToString() + "',TTPH=N'" + tempT+ "'" +
                " WHERE MaPH= '"+TenPhong+"'";
            if (db.ExcuteNonQuery(sql) > 0)
            {
                MessageBox.Show("Thành cong");
            }
            this.Close();
        }
    }
}
