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
    public partial class FormSuaPhong : Form
    {
        DbContext db = new DbContext();
        public Model.Entity.Phong P { get; set; }
        bool roi = false;
        public FormSuaPhong(Model.Entity.Phong p)
        {
            InitializeComponent();
            P = p;
            LoadComboLoaiPhong();
            roi = true;
        }   

        private void FormSuaPhong_Load(object sender, EventArgs e)
        {
            txtGhiChu.Text = P.GhiChu;
            txtMaPhong.Text = P.MaPH;
            txtMaPhong.Enabled = false;
            cbTinhTrangDonDep.SelectedItem = P.TTDD;
            cbTTPH.SelectedItem = P.TTPH;
            cbLoaiPhong.SelectedValue = P.Lp.MaLPH;
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

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(roi==true)
            {

            }    
        }

        private void btnCatNhat_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE PHONG " +
                " SET TTDD= N'"+cbTinhTrangDonDep.SelectedItem.ToString()+"',TTPH = N'"+cbTTPH.SelectedItem.ToString()+"'" +
                " , MaLPH = '"+cbLoaiPhong.SelectedValue.ToString()+"',GhiChu= '"+txtGhiChu.Text+  "'" +
                " WHERE MaPH ='"+txtMaPhong.Text+"'";
            if(db.ExcuteNonQuery(sql)>0)
            {
                MessageBox.Show("Sua thanh cong");

            }
            else
            {
                MessageBox.Show("Sua that bai");

            }

        }
    }
}
