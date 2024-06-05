using QL_KhachSan.GUI.controlRoom;
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
    public partial class FormHoaDon : Form
    {
        DateTime dt = DateTime.Now;
        DbContext db = new DbContext();
        public string MaHD { get; set; }
        public ChiTietHoaDonI CTHD { get; set; }
        public FormHoaDon(string mahd)
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
            
            labelSoDem.Text =sodem.ToString();
            NhanVienDAO nvDAO = new NhanVienDAO();
            NhanVien nv = nvDAO.getNhanVienTheoMa(CTHD.MaNV);
            HoaDonDAO hdDAO = new HoaDonDAO();
            List<HoaDon> hoaDons = hdDAO.TimMaHD(MaHD);
            labelNV.Text = nv.TenNV;
            float tong = hoaDons[0].TriGia;
            labelThanhTien.Text = string.Format("{0:#,##0}", tong);
            ChiTietDichVuDAO dvDAO = new ChiTietDichVuDAO();
            List<Model.Entity. ChiTietDichVu> dichVus = dvDAO.LayChiTietDichVuTheoMaCTDP(CTHD.MaCTDP);
            foreach (var item in dichVus)
            {
                Service sv = new Service();
                sv.setSL(item.SoLuong);
                sv.setDonGia(item.DichVu.DonGia);
                sv.setTen(item.DichVu.TenDV);
                sv.setThanhTien(item.ThanhTien);
                panelload.Controls.Add(sv);
                sv.Dock = DockStyle.Top;
            }
        }
        public void loadTienPhong()
        {
            ChiTietDatPhongDAO ctDAO = new ChiTietDatPhongDAO();
            List<ChiTietDatPhong> ct = ctDAO.GetChiTietDatPhongs();
            ChiTietDatPhong dp = ct.Where(t => t.MaCTDP == CTHD.MaCTDP).FirstOrDefault();
            lblTienPhong.Text = string.Format("{0:#,##0}", dp.ThanhTien);
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
           
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelNV_Click(object sender, EventArgs e)
        {

        }

        private void labelSoDem_Click(object sender, EventArgs e)
        {

        }

        private void labelNgayDi_Click(object sender, EventArgs e)
        {

        }

        private void labelNgayCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void labelLoaiPhong_Click(object sender, EventArgs e)
        {

        }

        private void labelPhong_Click(object sender, EventArgs e)
        {

        }

        private void labelSDT_Click(object sender, EventArgs e)
        {

        }

        private void labelTen_Click(object sender, EventArgs e)
        {

        }

        private void labelHoaDonSo_Click(object sender, EventArgs e)
        {

        }

        private void labelNgayLap_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panelload_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

    }
}
