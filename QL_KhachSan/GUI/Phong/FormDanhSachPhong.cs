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

namespace QL_KhachSan.GUI.Phong
{
    public partial class FormDanhSachPhong : Form
    {
        List<Model.Entity.Phong> listPhongs = new List<Model.Entity.Phong>();
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        DbContext db = new DbContext();
        public TaiKhoan TK { get; set; }
        public FormDanhSachPhong(TaiKhoan tk)
        {
            InitializeComponent();
            TK = tk;
            LoadPhongs();
            if(TK.CapQuyen==2)
            {
                btnThemDV.Visible = true;
                dataGridView1.Columns[4].Visible = true;
                dataGridView1.Columns[5].Visible = true;

            }
            else
            {
                btnThemDV.Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {

        }
        public void LoadPhongs()
        {
            this.dataGridView1.Rows.Clear();
            PhongDAO pDAO = new PhongDAO();
            listPhongs = pDAO.GetPhongs();
            foreach (var item in listPhongs)
            {
                dataGridView1.Rows.Add(item.MaPH, item.TTPH, item.TTDD, item.Lp.TenLPH, this.edit, this.delete);
            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            new FormThemPhong().Show();
            LoadPhongs();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Sua"].Index)
            {
                string MaPH = dataGridView1.Rows[e.RowIndex].Cells["MaPH"].Value.ToString();
                PhongDAO Pdao = new PhongDAO();
                Model.Entity.Phong P = Pdao.TimPhongTheoMa(MaPH);
                new FormSuaPhong(P).ShowDialog();
                LoadPhongs();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Xoa"].Index)
            {

                string MaPH = dataGridView1.Rows[e.RowIndex].Cells["MaPH"].Value.ToString();
                PhongDAO Pdao = new PhongDAO();
                if (Pdao.KTKhoaNgoai(MaPH) == true)
                {
                    MessageBox.Show("Không thể xóa phòng này");

                }
                else
                {
                    if (Pdao.DeletePhong(MaPH) > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadPhongs();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
              
            }
        }

        private void txtTenLPHCanTim_Leave(object sender, EventArgs e)
        {
            if (txtTenLPHCanTim.Text == "")
            {
                txtTenLPHCanTim.Text = "Nhập mã phòng cần tìm";
            }
        }

        private void txtTenLPHCanTim_Enter(object sender, EventArgs e)
        {
            if (txtTenLPHCanTim.Text == "Nhập mã phòng cần tìm")
            {
                txtTenLPHCanTim.Text = "";
            }
        }
        public void loadPhongSearch()
        {

            this.dataGridView1.Rows.Clear();
            PhongDAO pDAO = new PhongDAO();
            List<Model.Entity.Phong> listT = pDAO.PSearch(txtTenLPHCanTim.Text); 
            foreach (var item in listT)
            {
                LoaiPhongDAO lpDAO = new LoaiPhongDAO();
                item.Lp = lpDAO.TimLoaiPhongTheoMa(item.Lp.MaLPH);
                dataGridView1.Rows.Add(item.MaPH, item.TTPH, item.TTDD, item.Lp.TenLPH, this.edit, this.delete);
            }
        }
        private void txtTenLPHCanTim_TextChanged(object sender, EventArgs e)
        {
            if (txtTenLPHCanTim.Focused == false)
            {
                LoadPhongs();
                return;
            }
            LoadPhongs();
        }
    }
}
