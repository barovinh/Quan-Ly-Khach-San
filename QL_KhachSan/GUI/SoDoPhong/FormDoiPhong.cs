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
    public partial class FormDoiPhong : Form
    {
        public Model.Entity.ChiTietDatPhong CTDP { get; set; }
        public Model.Entity.KhachHang KH { get; set; }
        public NhanVien NhanVien { get; set; }
        DateTime dt = DateTime.Now;
        public TaiKhoan TK { get; set; }
        List<Model.Entity.Phong> phongs = new List<Model.Entity.Phong>();
        List<Model.Entity.Phong> dsPhongLoadDataGirdView;
        DateTime dateTime = DateTime.Now;
        private Image delete = Properties.Resources.delete;
        private Image add = Properties.Resources.Add;

        public FormDoiPhong(Model.Entity.ChiTietDatPhong ctdp, TaiKhoan tk)
        {
            InitializeComponent();
            CTDP = ctdp;
            ThongTinKhachHangCuaPhieu();
            LabelSoNguoi.Text = CTDP.SoNguoi.ToString();
            LabelTen.Text = KH.TenKH;
            lbPhongDangO.Text = ctdp.Phong.MaPH;
            LabelNgayCheckin.Text = CTDP.CheckIn.ToString("dd-MM-yyyy");
            if (ctdp.TheoGio == true)
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
            //getAllPhongLanDau();
            DsPhongTrong(CTDP.CheckIn, CTDP.CheckOut);
            LoadDataGirdView();
        }

        private void FormDoiPhong_Load(object sender, EventArgs e)
        {

        }
        //public void getAllPhongLanDau()
        //{
        //    PhongDAO pDAO = new PhongDAO();
        //    phongs = pDAO.GetPhongs();
        //    ChiTietDatPhongDAO ctDAO = new ChiTietDatPhongDAO();
        //    dsPhongLoadDataGirdView = new List<Model.Entity.Phong>();
        //    foreach (var item in phongs)
        //    {
        //        Model.Entity.ChiTietDatPhong ct = ctDAO.TimCTDP(item.MaPH, this.dateTime);
        //        if (item.TTPH == "Bình thường" && (ct == null || ct.TrangThai == "Đã xong"))
        //        {
        //            if (item.TTDD == "Đã dọn dẹp")
        //            {
        //                dsPhongLoadDataGirdView.Add(item);
        //            }
        //        }
        //    }
        //    foreach (var item in dsPhongLoadDataGirdView)
        //    {
        //        dt_PhongTrong.Rows.Add(item.MaPH, item.Lp.TenLPH, this.add, item.Lp.MaLPH);
        //    }
        //    dt_PhongTrong.Columns["MaLPH"].Visible = false;
        //}
        public void LoadData()
        {
            ChiTietDatPhongDAO ctDAO = new ChiTietDatPhongDAO();
            dsPhongLoadDataGirdView = new List<Model.Entity.Phong>();
            foreach (var item in phongs)
            {

                if (item.TTPH == "Bình thường")
                {
                    if (item.TTDD == "Đã dọn dẹp")
                    {
                        dsPhongLoadDataGirdView.Add(item);
                    }
                }
            }
        }
        public void LoadDataGirdView()
        {
            dt_PhongTrong.Rows.Clear();
            LoaiPhongDAO lpDAO = new LoaiPhongDAO();
            foreach (var item in phongs)
            {
                if (item.TTPH == "Bình thường")
                {
                    if (item.TTDD == "Đã dọn dẹp")
                    {
                        int songuoi = lpDAO.SoNguoiLoaiPhong(item.Lp.MaLPH);
                        dt_PhongTrong.Rows.Add(item.MaPH,songuoi, item.Lp.TenLPH, this.add, item.Lp.MaLPH);
                    }
                }
            }
            dt_PhongTrong.Columns["MaLPH"].Visible = false;
        }

        public void DsPhongTrong(DateTime checkin, DateTime checkout)
        {
            ChiTietDatPhongDAO ctdpDAO = new ChiTietDatPhongDAO();
            phongs = ctdpDAO.ListPhongTrongOnTime(checkin, checkout);
        }

        public void ThongTinKhachHangCuaPhieu()
        {
            PhieuThueDAO ptDAO = new PhieuThueDAO();
            PhieuThuePhong pt = ptDAO.ThongTinPhieuThueTheoMaPhieu(CTDP.MaPT);
            KhachHangDAO khDAO = new KhachHangDAO();
            KhachHang kh = khDAO.ThongTinKhachHangTheoMa(pt.MaKH);
            KH = kh;
        }

        private void dt_PhongTrong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dt_PhongTrong.Columns["Them"].Index)
            {
                if(dt_DaChon.Rows.Count>0)
                {
                    MessageBox.Show("Bạn đã chọn 1 phòng để đổi rồi"); return;
                }
                DataGridViewRow rowAtIndex = dt_PhongTrong.Rows[e.RowIndex];
                LoaiPhongDAO lpDAO = new LoaiPhongDAO();
                dt_DaChon.Rows.Add(rowAtIndex.Cells[0].Value.ToString(), rowAtIndex.Cells[1].Value.ToString(), rowAtIndex.Cells[2].Value.ToString(), this.delete, rowAtIndex.Cells[3].Value.ToString());
                dt_PhongTrong.Rows.RemoveAt(e.RowIndex);
                dt_DaChon.Sort(dt_DaChon.Columns["MaPHDa"], ListSortDirection.Ascending);
            }
        }

        private void dt_DaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dt_DaChon.Columns["Xoa"].Index)
            {
                DataGridViewRow rowatindex = dt_DaChon.Rows[e.RowIndex];
                dt_PhongTrong.Rows.Add(rowatindex.Cells[0].Value.ToString(), rowatindex.Cells[1].Value.ToString(),rowatindex.Cells[2].Value.ToString(), this.add, rowatindex.Cells[3].Value.ToString());
                dt_DaChon.Rows.RemoveAt(e.RowIndex);
                dt_PhongTrong.Sort(dt_PhongTrong.Columns["maph"], ListSortDirection.Ascending);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietDatPhongDAO ctDAO = new ChiTietDatPhongDAO();
                string maphong = dt_DaChon.Rows[0].Cells[0].Value.ToString();
                if(maphong!="")
                {
                    ctDAO.updateCTDPDoiPhong(CTDP, maphong);
                    MessageBox.Show("Đổi phòng thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("CÓ LỖI Ở ĐÂU ĐÓ");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("z");
            }
            
        }
    }
}
