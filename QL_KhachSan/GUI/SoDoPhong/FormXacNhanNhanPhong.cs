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
    public partial class FormXacNhanNhanPhong : Form
    {
        public Model.Entity.ChiTietDatPhong CTDP { get; set; }
        public Model.Entity.KhachHang KH { get; set; }
        List<Model.Entity.ChiTietDichVu> listCTDV;
    
        public FormXacNhanNhanPhong(Model.Entity.ChiTietDatPhong ctdp)
        {
            InitializeComponent();
            CTDP = ctdp;
            ThongTinKhachHangCuaPhieu();
            PhongDAO pDAO = new PhongDAO();
            Model.Entity.Phong phong = pDAO.TimPhongTheoMa(CTDP.Phong.MaPH);
            LabelSoNguoi.Text = CTDP.SoNguoi.ToString();
            txtGhiChu.Text = phong.GhiChu;
            LabelTen.Text = KH.TenKH;
            LabelThoiGianThue.Text = CTDP.CheckIn.ToString("HH:mm:ss");
            LabelNgayCheckin.Text = CTDP.CheckIn.ToString("dd-MM-yyyy");
            loadThongTinDichVu();
        }
        public FormXacNhanNhanPhong(Model.Entity.ChiTietDatPhong ctdp,string status)
        {
            InitializeComponent();
            CTDP = ctdp;
            ThongTinKhachHangCuaPhieu();
            PhongDAO pDAO = new PhongDAO();
            Model.Entity.Phong phong = pDAO.TimPhongTheoMa(CTDP.Phong.MaPH);
            LabelSoNguoi.Text = CTDP.SoNguoi.ToString();
            txtGhiChu.Text = phong.GhiChu;
            LabelTen.Text = KH.TenKH;
            LabelThoiGianThue.Text = CTDP.CheckIn.ToString("HH:mm:ss");
            LabelNgayCheckin.Text = CTDP.CheckIn.ToString("dd-MM-yyyy");
            loadThongTinDichVu();
            if(status != "Đã đặt")
            {
                btnHuyPhong.Visible = false;
                btnNhanPhong.Visible = false;
            }    
            
        }
        private void FormXacNhanNhanPhong_Load(object sender, EventArgs e)
        {

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
                dataGridView.Rows.Add(item.DichVu.TenDV, item.SoLuong, item.ThanhTien, item.DichVu.MaDV);
            }
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            ChiTietDatPhongDAO ctDAO = new ChiTietDatPhongDAO();
            DateTime dt = DateTime.Now;

            if (dt > CTDP.CheckIn)
            {
                CTDP.TrangThai = "Đang thuê";
                if (ctDAO.updateCTDPNhanPhong(CTDP) > 0)
                {

                    MessageBox.Show("Nhận phòng thành công");
                    this.Close();
                }
            }
            else
            {
                TimeSpan timeDifference = CTDP.CheckIn.Subtract(dt);
                if (timeDifference.TotalMinutes < 30)
                {
                    CTDP.TrangThai = "Đang thuê";
                    CTDP.CheckIn = dt;
                    if (ctDAO.updateCTDPNhanPhong(CTDP) > 0)
                    {

                        MessageBox.Show("Nhận phòng thành công");
                        this.Close();
                    }

                }
                else
                {
                    int timedff = (int)timeDifference.TotalHours;
                    MessageBox.Show("Còn quá sớm để nhận phòng");
                    MessageBox.Show("Còn " + timedff.ToString() + " giờ để nhận phòng");

                    
                }
            }         
        }

        private void btnHuyPhong_Click(object sender, EventArgs e)
        {
            ChiTietDatPhongDAO ct = new ChiTietDatPhongDAO();
            string mapt = ct.getMaPT(CTDP.MaCTDP);
            if (mapt != "")
            {
                int flag = ct.deletCTDPHuyPhong(mapt);
                if(flag==1)
                {
                    PhieuThueDAO phieuThueDAO = new PhieuThueDAO();
                    if (phieuThueDAO.DeletePhieuThue(mapt) == 1)
                    {
                        MessageBox.Show("Hủy phòng thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");

                    }
                }
                else
                {
                    MessageBox.Show("Lỗi");

                }
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
