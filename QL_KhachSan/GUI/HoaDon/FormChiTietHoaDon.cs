using QL_KhachSan.GUI.controlRoom;
using QL_KhachSan.Model.DAO;
using QL_KhachSan.Model;
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
    public partial class FormChiTietHoaDon : Form
    {
        DateTime dt = DateTime.Now;
        DbContext db = new DbContext();
        public string MaHD { get; set; }
        public ChiTietHoaDonI CTHD { get; set; }
        public FormChiTietHoaDon(string mahd)
        { 
            InitializeComponent();
            MaHD = mahd;
            LoadCTHD();
            loadTienPhong();
        }

        public void LoadCTHD()
        {
            ChiTietHoaDonIDAO ctDAO = new ChiTietHoaDonIDAO();
            CTHD = ctDAO.GetThongTinHoaDons(MaHD);
            labelNgayLap.Text = dt.ToString("MM-dd-yyyy");
            labelHoaDonSo.Text = CTHD.MaHD;
            labelTen.Text = CTHD.TenKH;
            labelSDT.Text = CTHD.SDT;
            labelLoaiPhong.Text = CTHD.TenLPH;
            labelPhong.Text = CTHD.MaPH;
            labelNgayCheckIn.Text = CTHD.ngayThue.ToString("MM-dd-yyyy");
            labelNgayDi.Text = dt.ToString("MM-dd-yyyy");
            TimeSpan ts = dt.Subtract(CTHD.ngayThue);

            int sodem = (int)ts.TotalDays;
            labelSoDem.Text = sodem.ToString();
            NhanVienDAO nvDAO = new NhanVienDAO();
            NhanVien nv = nvDAO.getNhanVienTheoMa(CTHD.MaNV);
            HoaDonDAO hdDAO = new HoaDonDAO();
            List<HoaDon> hoaDons = hdDAO.TimMaHD(MaHD);
            labelNV.Text = nv.TenNV;
            float tong = hoaDons[0].TriGia;
            labelThanhTien.Text = string.Format("{0:#,##0}", tong);
            ChiTietDichVuDAO dvDAO = new ChiTietDichVuDAO();
            List<Model.Entity.ChiTietDichVu> dichVus = dvDAO.LayChiTietDichVuTheoMaCTDP(CTHD.MaCTDP);
            foreach (var item in dichVus)
            {
                Service sv = new Service();
                sv.setSL(item.SoLuong);
                sv.setTen(item.DichVu.TenDV);
                sv.setDonGia(item.DichVu.DonGia);
                sv.setThanhTien(item.ThanhTien);
                panelload.Controls.Add(sv);
                sv.Dock = DockStyle.Top;
            }
        }
        public void loadTienPhong()
        {
            ChiTietDatPhongDAO ctDAO = new ChiTietDatPhongDAO();
            List<ChiTietDatPhong> ct = ctDAO.GetChiTietDatPhongs();
            ChiTietDatPhong dp = ct.Where(t=>t.MaCTDP == CTHD.MaCTDP).FirstOrDefault();
            lblTienPhong.Text= string.Format("{0:#,##0}",dp.ThanhTien);
        }
        public void loadData()
        {

        }

        private void txtTenLPHCanTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
