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
    public partial class FormDatPhong : Form
    {
        List<Model.Entity.Phong> phongs = new List<Model.Entity.Phong>();
        List<Model.Entity.Phong> dsPhongLoadDataGirdView;
        DateTime dateTime = DateTime.Now;
        private Image delete = Properties.Resources.delete;
        public TaiKhoan TK { get; set; }
        private Image add = Properties.Resources.Add;
        DbContext db = new DbContext();
        public int flagKH = 0;
        public FormDatPhong(TaiKhoan tk)
        {
            InitializeComponent();
            TK = tk;
            getAllPhongLanDau();

        }
        public void getAllPhongLanDau()
        {
            PhongDAO pDAO = new PhongDAO();
            phongs = pDAO.GetPhongs();
            ChiTietDatPhongDAO ctDAO = new ChiTietDatPhongDAO();
            dsPhongLoadDataGirdView = new List<Model.Entity.Phong>();
            foreach (var item in phongs)
            {
                Model.Entity.ChiTietDatPhong ct = ctDAO.TimCTDP(item.MaPH, this.dateTime);
                if (item.TTPH == "Bình thường" && (ct == null || ct.TrangThai == "Đã xong"))
                {
                    if (item.TTDD == "Đã dọn dẹp")
                    {
                        dsPhongLoadDataGirdView.Add(item);
                    }
                }
            }
            foreach (var item in dsPhongLoadDataGirdView)
            {
                dt_PhongTrong.Rows.Add(item.MaPH, item.Lp.TenLPH, this.add, item.Lp.MaLPH);
            }
            dt_PhongTrong.Columns["MaLPH"].Visible = false;
        }
        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }
        public void DsPhongTrong(DateTime checkin, DateTime checkout)
        {
            ChiTietDatPhongDAO ctdpDAO = new ChiTietDatPhongDAO();
            phongs = ctdpDAO.ListPhongTrongOnTime(checkin, checkout);
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
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
            foreach (var item in phongs)
            {
                if (item.TTPH == "Bình thường")
                {
                    if (item.TTDD == "Đã dọn dẹp")
                    {
                       dt_PhongTrong.Rows.Add(item.MaPH, item.Lp.TenLPH, this.add, item.Lp.MaLPH);
                    }
                }
            }
            dt_PhongTrong.Columns["MaLPH"].Visible = false;
        }
        private void FormDatPhong_Load(object sender, EventArgs e)
        {
            LoadGio(comboBoxGioGiac);
            LoadGio(comboBoxGioGiac2);

        }
        public void LoadGio(ComboBox combox)
        {
            int startHour = 0;
            int endHour = 23;
            for (int hour = startHour; hour <= endHour; hour++)
            {
                combox.Items.Add($"{hour:00}:00");
                combox.Items.Add($"{hour:00}:30");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dt_PhongTrong.Columns["Them"].Index)
            {
                DataGridViewRow rowAtIndex = dt_PhongTrong.Rows[e.RowIndex];
                LoaiPhongDAO lpDAO = new LoaiPhongDAO();
                int songuoi = lpDAO.SoNguoiLoaiPhong(rowAtIndex.Cells[3].Value.ToString());
                string ngaybatdau = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string ngayketthuc = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                dt_DaChon.Rows.Add(rowAtIndex.Cells[0].Value.ToString(), songuoi, ngaybatdau, ngayketthuc, rowAtIndex.Cells[1].Value.ToString(), this.delete, rowAtIndex.Cells[3].Value.ToString());
                dt_PhongTrong.Rows.RemoveAt(e.RowIndex);
                dt_DaChon.Sort(dt_DaChon.Columns["MaPHDa"], ListSortDirection.Ascending);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dt_DaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dt_DaChon.Columns[5].Index)
            {
                DataGridViewRow rowatindex = dt_DaChon.Rows[e.RowIndex];

                dt_PhongTrong.Rows.Add(rowatindex.Cells[0].Value.ToString(), rowatindex.Cells[4].Value.ToString(), this.add, rowatindex.Cells[6].Value.ToString());

                dt_DaChon.Rows.RemoveAt(e.RowIndex);
                dt_PhongTrong.Sort(dt_PhongTrong.Columns["maph"], ListSortDirection.Ascending);

            }
        }
        public bool KiemTraNgayGio()
        {
            DateTime dt1 = dateTimePicker1.Value;
            string checkin = dt1.ToString("yyyy-MM-dd");
            DateTime dt2 = dateTimePicker2.Value;
            string checkout = dt2.ToString("yyyy-MM-dd");
            int result = checkin.CompareTo(checkout);
            try
            {
                if (result == 0)
                {
                    // Hai ngày giống nhau

                    string gio1 = comboBoxGioGiac.SelectedItem.ToString();
                    string gio2 = comboBoxGioGiac2.SelectedItem.ToString();
                    // Sử dụng phương thức CompareTo để so sánh chuỗi giờ
                    int gioComparisonResult = string.Compare(gio1, gio2);

                    if (gioComparisonResult > 0)
                    {
                        MessageBox.Show("Thời gian kết thúc lỗi"); return false;
                    }
                    else if (gioComparisonResult < 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Thời gian bắt đầu lỗi"); return false;

                    }
                }
                else if (result < 0)
                {
                    //    MessageBox.Show("Ngày giờ 1 trước ngày giờ 2");
                    return false;
                }
                else
                {
                    MessageBox.Show("Lỗi ngày bắt đầu");
                    return false;
                }
            }
            catch (Exception)
            {

                return false;       
            }
            
        }
        public DateTime SetGio(DateTime dt, string time)
        {
            string[] mang = time.Split(':');
            int hour = int.Parse(mang[0]);
            int minute = int.Parse(mang[1]);
            TimeSpan ts = new TimeSpan(hour, minute, 0);
            dt = dt.Date + ts; // Gán giá trị mới cho đối tượng DateTime

            return dt; // Trả về giá trị mới
        }
        private void btnDat_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text.Length == 0 || txtSDT.Text.Length == 0 || txtQuocTich.Text.Length == 0)
            {
                MessageBox.Show("Các thông tin không được để trống "); return;
            }
            if (txtCMT.Text.Length != 12 && txtCMT.Text.Length != 9)
            {
                MessageBox.Show("Độ dài của CCCD/CMNĐ chưa đủ!:");
                return;
            }              
            if(comboGioiTinh.SelectedIndex.ToString().Length==0)
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return;
            }
            KhachHangDAO khDAO = new KhachHangDAO();
            Model.Entity.KhachHang kh = new Model.Entity.KhachHang();
            if (flagKH==0)
            {
                string maKH = khDAO.GetMaKHNext();
                kh.MaKH = maKH;
                kh.TenKH = txtTenKH.Text;
                kh.SDT = txtSDT.Text;
                kh.CCCD = txtCMT.Text;
                kh.QuocTich = txtQuocTich.Text;
                kh.GioiTinh = comboGioiTinh.SelectedItem.ToString();
                int themkh = khDAO.ThemKhachHang(kh);
            }
            else
            {
                kh = khDAO.ThongTinKhachHangTheoSDT(txtSDT.Text);
            }            
                PhieuThueDAO ptDAO = new PhieuThueDAO();
                Model.Entity.PhieuThuePhong ph = new Model.Entity.PhieuThuePhong();
                ph.MaPT = ptDAO.GetMaPTNext();
                ph.MaKH = kh.MaKH;
                ph.MaNV = TK.MaNV; // tạm thời đặt cố định 
                DateTime dateTimeNow = DateTime.Now;
                ph.NgayLap = dateTimeNow;
                int themPT = ptDAO.ThemPhieuThue(ph);
                if (themPT > 0)
                {
                 ChiTietDatPhongDAO ctdpDAO = new ChiTietDatPhongDAO();
                Model.Entity.ChiTietDatPhong ctdp = new Model.Entity.ChiTietDatPhong();
                for (int i = 0; i < dt_DaChon.Rows.Count; i++)
                    {
                        ctdp.MaCTDP = ctdpDAO.getNextCTDP();
                        ctdp.MaPT = ph.MaPT;
                        ctdp.Phong.MaPH = dt_DaChon.Rows[i].Cells[0].Value.ToString();
                        ctdp.SoNguoi = int.Parse(dt_DaChon.Rows[i].Cells[1].Value.ToString());
                        ctdp.ThanhTien = 0;
                        ctdp.DonGia = 0;
                        ctdp.TrangThai = "Đã đặt";
                        ctdp.CheckIn = dateTimePicker1.Value;
                        ctdp.CheckOut = dateTimePicker2.Value;
                        ctdp.CheckIn = SetGio(ctdp.CheckIn, comboBoxGioGiac.SelectedItem.ToString());
                        ctdp.CheckOut = SetGio(ctdp.CheckOut, comboBoxGioGiac2.SelectedItem.ToString());
                        ctdp.TheoGio = KiemTraNgayGio();
                        ctdpDAO.InsertCTDP(ctdp);
                    }
                    MessageBox.Show("Đặt thành công");          
            }
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            KiemTraNgayGio();
        }
        
        private void comboBoxGioGiac_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] gioPhutArr = comboBoxGioGiac.SelectedItem.ToString().Split(':');
            int gio = int.Parse(gioPhutArr[0]);
            int phut = int.Parse(gioPhutArr[1]);

            TimeSpan gioPhutSelected = new TimeSpan(gio, phut, 0);
            TimeSpan gioPhutNow = DateTime.Now.TimeOfDay;
            if (gioPhutSelected > gioPhutNow)
            {
                
                //  KiemTraNgayGio();
                DateTime selectedDateTimeCheckin = dateTimePicker1.Value;
                if(comboBoxGioGiac.SelectedItem!=null)
                {
                    selectedDateTimeCheckin = SetGio(selectedDateTimeCheckin, comboBoxGioGiac.SelectedItem.ToString());
                }

                DateTime selectedDateTimeChekout = dateTimePicker2.Value;
                if(comboBoxGioGiac2.SelectedItem!=null)
                {
                    selectedDateTimeChekout = SetGio(selectedDateTimeChekout, comboBoxGioGiac2.SelectedItem.ToString());
                }
                try
                {
                    DsPhongTrong(selectedDateTimeCheckin, selectedDateTimeChekout);
              //      LoadData();
                    LoadDataGirdView();
                }
                 catch (Exception)
                {
                    throw;
                }
            }
            else if (gioPhutSelected < gioPhutNow)
            {
                //   Console.WriteLine("Giờ và phút đã chọn trước giờ hiện tại.");

                MessageBox.Show("Lỗi giờ bắt đầu");return;
            }
            else
            {
                MessageBox.Show("Lỗi giờ bắt đầu"); return;
            }
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
              
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {

                e.Handled = true;
            }
        }

        private void comboBoxGioGiac2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            KhachHangDAO khDAO = new KhachHangDAO();
           KhachHang kh = khDAO.ThongTinKhachHangTheoSDT(txtSDT.Text);
            if(kh!=null)
            {
                MessageBox.Show("Tìm thấy thông tin khách hàng");
                flagKH = 1;
                txtTenKH.Text = kh.TenKH;
             txtSDT.Text = kh.SDT;
                 txtCMT.Text = kh.CCCD;
              txtQuocTich.Text = kh.QuocTich;
                comboGioiTinh.SelectedItem = kh.GioiTinh;
            }
            else
            {
                MessageBox.Show("Không có thông tin khách hàng");
                flagKH = 0; 
            }
        }

        private void comboBoxGioGiac2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] gioPhutArr = comboBoxGioGiac.SelectedItem.ToString().Split(':');
            int gio = int.Parse(gioPhutArr[0]);
            int phut = int.Parse(gioPhutArr[1]);

            TimeSpan gioPhutBatDau = new TimeSpan(gio, phut, 0);

            string[] gioPhutArr2 = comboBoxGioGiac2.SelectedItem.ToString().Split(':');
            int gio2 = int.Parse(gioPhutArr2[0]);
            int phut2 = int.Parse(gioPhutArr2[1]);

            TimeSpan gioPhutKetThuc = new TimeSpan(gio2, phut2, 0);

            DateTime selectedDateTimeCheckin = dateTimePicker1.Value;
            if (comboBoxGioGiac.SelectedItem != null)
            {
                selectedDateTimeCheckin = SetGio(selectedDateTimeCheckin, comboBoxGioGiac.SelectedItem.ToString());
            }

            DateTime selectedDateTimeChekout = dateTimePicker2.Value;
            if (comboBoxGioGiac2.SelectedItem != null)
            {
                selectedDateTimeChekout = SetGio(selectedDateTimeChekout, comboBoxGioGiac2.SelectedItem.ToString());
            }

            // So sánh cả ngày và giờ của CheckOut với CheckIn
            if (selectedDateTimeChekout < selectedDateTimeCheckin)
            {
                MessageBox.Show("Thời gian kết thúc phải lớn hơn thời gian bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (selectedDateTimeChekout == selectedDateTimeCheckin && gioPhutKetThuc < gioPhutBatDau)
            {
                MessageBox.Show("Giờ kết thúc phải lớn hơn giờ bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DsPhongTrong(selectedDateTimeCheckin, selectedDateTimeChekout);
                    // LoadData();
                    LoadDataGirdView();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
