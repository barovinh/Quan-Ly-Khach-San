using QL_KhachSan.GUI.ChiTietTienNghi;
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
namespace QL_KhachSan.GUI.LoaiPhong
{
    public partial class FormLoaiPhong : Form
    {
        List<Model.Entity.LoaiPhong> listLP = new List<Model.Entity.LoaiPhong>();
        private Image edits = Properties.Resources.edit;
        private Image details = Properties.Resources.details;
        public TaiKhoan TK { get; set; }
        public FormLoaiPhong(TaiKhoan tk)
        {
            InitializeComponent();
            TK = tk; 
            LoadDataLoaiPhong();
            if (TK.CapQuyen == 2)
            {
                dataGridView1.Columns[7].Visible = true;
               
            }
            else
            {
                dataGridView1.Columns[7].Visible = false;
            }
        }

        private void FormLoaiPhong_Load(object sender, EventArgs e)
        {

        }
        public void LoadDataLoaiPhong()
        {
            this.dataGridView1.Rows.Clear();

            LoaiPhongDAO lpDAO = new LoaiPhongDAO();
            listLP = lpDAO.GetLoaiPhongs();
            foreach (var item in listLP)
            {
                dataGridView1.Rows.Add(item.MaLPH, item.TenLPH, item.SoGiuong, item.SoNguoiToiDa, item.GiaNgay, item.GiaGio, this.details, this.edits);
            }
        }

        private void txtTenLPHCanTim_Enter(object sender, EventArgs e)
        {
            if (txtTenLPHCanTim.Text == "Nhập tên loại phòng cần tìm")
            {
                txtTenLPHCanTim.Text = "";
            }
        }

        private void txtTenLPHCanTim_Leave(object sender, EventArgs e)
        {
            if(txtTenLPHCanTim.Text=="")
            {
                txtTenLPHCanTim.Text = "Nhập tên loại phòng cần tìm";
            }
        }
        public void LoadDanhSachSearch()
        {
            this.dataGridView1.Rows.Clear();
            LoaiPhongDAO lpDAO = new LoaiPhongDAO();
            List<Model.Entity.LoaiPhong> lpT = lpDAO.TenLoaiPhongCanTim(txtTenLPHCanTim.Text);
            foreach (var item in lpT)
            {
                dataGridView1.Rows.Add(item.MaLPH, item.TenLPH, item.SoGiuong, item.SoNguoiToiDa, item.GiaNgay, item.GiaGio, this.details, this.edits);
            }
        }
        private void txtTenLPHCanTim_TextChanged(object sender, EventArgs e)
        {
            if(txtTenLPHCanTim.Focused==false)
            {
                LoadDataLoaiPhong();
                return;
            }
            LoadDanhSachSearch();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["TienNghi"].Index)
            {
                string MaPLH = dataGridView1.Rows[e.RowIndex].Cells["MaLPH"].Value.ToString();
                new FormDanhSachChiTietTN(MaPLH,TK).ShowDialog();
                LoadDataLoaiPhong();

            }
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Sua"].Index)
                {
                    Model.Entity.LoaiPhong lp = new LoaiPhongDAO().TimLoaiPhongTheoMa(dataGridView1.Rows[e.RowIndex].Cells["MaLPH"].Value.ToString());
                new FormSuaLoaiPhong(lp).ShowDialog();       
                    LoadDataLoaiPhong();
                }
            }
    }
}
