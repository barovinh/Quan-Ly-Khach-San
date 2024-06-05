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

namespace QL_KhachSan.GUI.Bill
{
    public partial class FormDanhSachHoaDon : Form
    {
        List<Model.Entity.HoaDon> listHD = new List<Model.Entity.HoaDon>();
        private Image details = Properties.Resources.details;
        public TaiKhoan TK { get; set; }
        public FormDanhSachHoaDon(TaiKhoan tk)
        {
            TK = tk;
        
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            dataGridView1.Rows.Clear();
            HoaDonDAO hdDAO = new HoaDonDAO();
            listHD = hdDAO.GetHoaDons();
            foreach (var item in listHD)
            {
                dataGridView1.Rows.Add(item.MaHD, item.ngayLap, item.TriGia,item.MaNV, item.TrangThai,item.MaCTDP, this.details);
            }
        }
        public void LoadResultSearch()
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Rows.Clear();
            HoaDonDAO hdDAO = new HoaDonDAO();
            List<Model.Entity.HoaDon> listT = hdDAO.TimMaHD(txtTenLPHCanTim.Text);
            foreach (var item in listT)
            {
                dataGridView1.Rows.Add(item.MaHD, item.ngayLap, item.TriGia, item.MaNV, item.TrangThai, item.MaCTDP, this.details);
            }
        }

        private void txtTenLPHCanTim_TextChanged(object sender, EventArgs e)
        {
            if (txtTenLPHCanTim.Focused == false)
            {
                loadData();
                return;
            }
            LoadResultSearch();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ChiTiet"].Index)
            {
                string MaHD = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                new FormChiTietHoaDon(MaHD).ShowDialog();
                loadData();

            }
        }

        private void FormDanhSachHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void txtTenLPHCanTim_Leave(object sender, EventArgs e)
        {
            if(txtTenLPHCanTim.Text=="")
            {
                txtTenLPHCanTim.Text = "Nhập mã hóa đơn";

            }
        }

        private void txtTenLPHCanTim_Enter(object sender, EventArgs e)
        {
            if(txtTenLPHCanTim.Text== "Nhập mã hóa đơn")
            {
                txtTenLPHCanTim.Text = "";
            }
        }
    }
}
