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
    public partial class FormThongTinDangThue : Form
    {
        public Model.Entity.ChiTietDatPhong CTDP { get; set; }
        public Model.Entity.KhachHang KH { get; set; }
        List<Model.Entity.ChiTietDichVu> listCTDV;
        public NhanVien NhanVien { get; set; }
        DateTime dt = DateTime.Now;
        public TaiKhoan TK { get; set; }
        public FormThongTinDangThue(Model.Entity.ChiTietDatPhong ctdp,TaiKhoan tk)
        {
            InitializeComponent();
            CTDP = ctdp;
            TK = tk;
            ThongTinKhachHangCuaPhieu();
            LabelSoNguoi.Text = CTDP.SoNguoi.ToString();
            LabelTen.Text = KH.TenKH;
            PhongDAO pDAO = new PhongDAO();
            Model.Entity.Phong phong = pDAO.TimPhongTheoMa(CTDP.Phong.MaPH);
            txtGhiChu.Text = phong.GhiChu;
            LabelNgayCheckin.Text = CTDP.CheckIn.ToString("dd-MM-yyyy");
            if(ctdp.TheoGio==true)
            {
                TimeSpan timeDifference = CTDP.CheckOut - CTDP.CheckIn;
                int sogio = (int)timeDifference.TotalHours;
                LabelThoiGianThue.Text = sogio.ToString() + " giờ";
            }
            else
            {
                TimeSpan timeDifference = CTDP.CheckOut - CTDP.CheckIn;
                int songay = (int)timeDifference.TotalDays;
                LabelThoiGianThue.Text = songay.ToString() + " ngày";
            }
          

            loadThongTinDichVu();
        }

        public void ThongTinKhachHangCuaPhieu()
        {
            PhieuThueDAO ptDAO = new PhieuThueDAO();
            PhieuThuePhong pt = ptDAO.ThongTinPhieuThueTheoMaPhieu(CTDP.MaPT);
            KhachHangDAO khDAO = new KhachHangDAO();
            KhachHang kh = khDAO.ThongTinKhachHangTheoMa(pt.MaKH);
            KH = kh;
        }
        private void FormThongTinDangThue_Load(object sender, EventArgs e)
        {

        }
        public void loadThongTinDichVu()
        {
            ChiTietDichVuDAO ctdvDAO = new ChiTietDichVuDAO();
            listCTDV = ctdvDAO.LayChiTietDichVuTheoMaCTDP(CTDP.MaCTDP);
            foreach (var item in listCTDV)
            {
                dataGridView.Rows.Add(item.DichVu.TenDV, item.SoLuong, item.ThanhTien,item.DichVu.MaDV);
            }
        }
        private void LabelTen_Click(object sender, EventArgs e)
        {

        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            FormThemDichVuVaoPhong f = new FormThemDichVuVaoPhong(CTDP,TK);
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
            this.Close(); 

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhongDAO pDAO = new PhongDAO();
            string note = txtGhiChu.Text;
            if(note!="")
            {
                Model.Entity.Phong phong = pDAO.TimPhongTheoMa(CTDP.Phong.MaPH);
                phong.GhiChu = note;
                pDAO.UpdatePhong(phong);
            }


            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            HoaDonDAO hoaDonDAO = new HoaDonDAO();
            ChiTietDatPhongDAO ctDAO = new ChiTietDatPhongDAO();
            HoaDon hd = new HoaDon();
            hd.MaHD = hoaDonDAO.GetMaHDNext();
            hd.MaCTDP = CTDP.MaCTDP;
            hd.MaNV = TK.MaNV;
            hd.ngayLap = dt;
            hd.TriGia = 0;
            int kt = hoaDonDAO.ThemHoaDon(hd);
            if (kt > 0)
            {
                int catnhattinhtrang = ctDAO.updateCTDPDaXong(CTDP);
                if (catnhattinhtrang > 0)
                {
                    PhongDAO pDAO = new PhongDAO();
                    CTDP.Phong.TTPH = "Bình thường";
                    CTDP.Phong.TTDD = "Chưa dọn dẹp";
                    CTDP.Phong.GhiChu = "";
                    pDAO.UpdatePhongChuaDonDep(CTDP.Phong);
                    MessageBox.Show("Đã xong");
                }
            }
            new FormHoaDon(hd.MaHD).ShowDialog();
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDoiPhong_Click(object sender, EventArgs e)
        {
            new FormDoiPhong(CTDP,TK).ShowDialog();
            this.Close();
        }

        private void btnGiaHanPhong_Click(object sender, EventArgs e)
        {
            new FormGiaHanPhong(CTDP, TK).ShowDialog();
            
        }
    }
}
