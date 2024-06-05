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
    public partial class FormDanhSachDatPhong : Form
    {
        private Image details = Properties.Resources.details;
        List<ChiTietDatPhong> ctdps = new List<ChiTietDatPhong>();
        public TaiKhoan TK { get; set; }
        public List<ChiTietDatPhong> ListCheckout { get; set; }
        public FormDanhSachDatPhong(TaiKhoan tk)
        {
            InitializeComponent();
            TK = tk;
            loadData();
        }
        public FormDanhSachDatPhong(TaiKhoan tk, List<ChiTietDatPhong> listCheckout)
        {
            InitializeComponent();
            TK = tk;
            loadData();
            ListCheckout = listCheckout;
            if (ListCheckout.Count > 0)
            {
                ToMau();
            }
        }
        void ToMau()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string cellValue = row.Cells[0].Value.ToString();
                if (ListCheckout.Any(item => item.MaCTDP.ToString() == cellValue))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void FormDanhSachDatPhong_Load(object sender, EventArgs e)
        {

        }


        void loadData()
        {
            this.dataGridView1.Rows.Clear();
            ChiTietDatPhongDAO ctdpDAO = new ChiTietDatPhongDAO();
            ctdps = ctdpDAO.GetChiTietDatPhongs();
            foreach (var item in ctdps)
            {
                string CheckinTimeString = item.CheckIn.ToString("yyyy-MM-dd HH:mm:ss");
                string CheckoutTimeString = item.CheckOut.ToString("yyyy-MM-dd HH:mm:ss");
                dataGridView1.Rows.Add(item.MaCTDP, item.Phong.MaPH, item.MaPT, item.SoNguoi, CheckinTimeString, CheckoutTimeString, item.TrangThai,item.DonGia,item.ThanhTien, item.TheoGio ? "√" : "O",this.details);
               
            }
            dataGridView1.Columns[0].Visible = false;
           dataGridView1.Columns[2].Visible = false;

        }

        private void txtTenNVCanTim_TextChanged(object sender, EventArgs e)
        {
            if (txtPhongMuonTim.Focused == false)
            {
                loadData();
                return;
            }
            LoadDanhSachSearch();
        }
        public void LoadDanhSachSearch()
        {
            this.dataGridView1.Rows.Clear();
            ChiTietDatPhongDAO ctdpDAO = new ChiTietDatPhongDAO();
            List<ChiTietDatPhong> lpT = ctdpDAO.dsSearchPhong(txtPhongMuonTim.Text);
            if (lpT != null)
            {
                foreach (var item in lpT)
                {
                    string CheckinTimeString = item.CheckIn.ToString("yyyy-MM-dd HH:mm:ss");
                    string CheckoutTimeString = item.CheckOut.ToString("yyyy-MM-dd HH:mm:ss");
                    dataGridView1.Rows.Add(item.MaCTDP, item.Phong.MaPH, item.MaPT, item.SoNguoi, CheckinTimeString, CheckoutTimeString, item.TrangThai, item.DonGia, item.ThanhTien, item.TheoGio ? "√" : "O", this.details);
                }
            }
            else
            {
                MessageBox.Show("LOI ");
            }
        }

        private void txtPhongMuonTim_Enter(object sender, EventArgs e)
        {
            if (txtPhongMuonTim.Text == "Nhập phòng muốn tìm")
            {
                txtPhongMuonTim.Text = "";
            }
        }

        private void txtPhongMuonTim_Leave(object sender, EventArgs e)
        {
            if (txtPhongMuonTim.Text == "")
            {
                txtPhongMuonTim.Text = "Nhập phòng muốn tìm";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["ChiTiet"].Index)
            {
                ChiTietDatPhongDAO chiTietDatPhongDAO = new ChiTietDatPhongDAO();
                
                ChiTietDatPhong ct = chiTietDatPhongDAO.getCTDPTheoMaCTDP(dataGridView1.Rows[e.RowIndex].Cells["MaCTDP"].Value.ToString());
               if(ct.TrangThai=="Đang thuê")
                {
                    new FormThongTinDangThue(ct, TK).ShowDialog();
                }
                else
                {
                    new FormXacNhanNhanPhong(ct, ct.TrangThai).ShowDialog();
                }
            }
        }
    }
}
