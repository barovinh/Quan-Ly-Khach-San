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
    public partial class FormGiaHanPhong : Form
    {
        List<Model.Entity.Phong> phongs = new List<Model.Entity.Phong>();

        public Model.Entity.ChiTietDatPhong CTDP { get; set; }
        public Model.Entity.KhachHang KH { get; set; }
        DateTime dt = DateTime.Now;
        DateTime timeToAdjourn;
        int flag = 0;
        public FormGiaHanPhong(Model.Entity.ChiTietDatPhong ctdp, TaiKhoan tk)
        {

            InitializeComponent();
            CTDP = ctdp;
            //  TK = tk;
            ThongTinKhachHangCuaPhieu();
            LabelTen.Text = KH.TenKH;
            PhongDAO pDAO = new PhongDAO();
            Model.Entity.Phong phong = pDAO.TimPhongTheoMa(CTDP.Phong.MaPH);
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


            TimeSpan timeLess = ctdp.CheckOut - dt;
            labelThoiGianConLai.Text = $"Thời gian còn lại: {timeLess.Hours} giờ, {timeLess.Minutes} phút";
        }

        public void ThongTinKhachHangCuaPhieu()
        {
            PhieuThueDAO ptDAO = new PhieuThueDAO();
            PhieuThuePhong pt = ptDAO.ThongTinPhieuThueTheoMaPhieu(CTDP.MaPT);
            KhachHangDAO khDAO = new KhachHangDAO();
            KhachHang kh = khDAO.ThongTinKhachHangTheoMa(pt.MaKH);
            KH = kh;
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
        public void DsPhongTrong(DateTime checkin, DateTime checkout)
        {
            ChiTietDatPhongDAO ctdpDAO = new ChiTietDatPhongDAO();
            phongs = ctdpDAO.ListPhongTrongOnTime(checkin, checkout);
            phongs.ForEach(t => Console.WriteLine(t.MaPH));
        }
        private void FormGiaHanPhong_Load(object sender, EventArgs e)
        {
            LoadGio(comboBoxGioGiac2);
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
        private void comboBoxGioGiac2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] gioPhutArr = comboBoxGioGiac2.SelectedItem.ToString().Split(':'); 
            // giây phút giây đang chọn
            int gio = int.Parse(gioPhutArr[0]);
            int phut = int.Parse(gioPhutArr[1]);
            // ngày được chọn để gia hạn
            DateTime selectedDatimePicker = dateTimePicker2.Value;
            TimeSpan gioPhutSelected = new TimeSpan(gio, phut, 0);
            selectedDatimePicker = selectedDatimePicker.Date + gioPhutSelected;
            //DateTime selectedDateTimeCheckin = dateTimePicker2.Value;
            //selectedDateTimeCheckin = SetGio(CTDP.CheckOut, comboBoxGioGiac2.SelectedItem.ToString());
            if (selectedDatimePicker >= dt && selectedDatimePicker > CTDP.CheckOut)
            {
                //  KiemTraNgayGio();
                if (comboBoxGioGiac2.SelectedItem != null)
                {
                    flag = 1;
                    timeToAdjourn = selectedDatimePicker;
                }
                else
                {
                    flag = 0;
                }
            }
            else
            {
                flag = 0;
                MessageBox.Show("Lỗi giờ gia hạn"); return;
            }
        }

        private void btnKtra_Click(object sender, EventArgs e)
        {
            ChiTietDatPhongDAO ctdpDAO = new ChiTietDatPhongDAO();
            DateTime selectedDateTimeCheckin = dateTimePicker2.Value;
            if (comboBoxGioGiac2.SelectedItem != null)
            {               
                if(flag==1)
                {
                    int rs = ctdpDAO.KiemTraGiaHanPhong(CTDP.Phong.MaPH, CTDP.CheckOut, timeToAdjourn);
                    if (rs == 1)
                    {
                        flag = 0;
                        MessageBox.Show("PHÒNG ĐÃ CÓ NGƯỜI ĐẶT Ở GIỜ TIẾP THEO");
                    }
                    else
                    {
                        flag = 1;
                        MessageBox.Show("Có thể gia hạn");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi thời gian");
                    return;

                }
            }
            
        }

        private void btnGiaHanPhong_Click(object sender, EventArgs e)
        {
            ChiTietDatPhongDAO ctdpDAO = new ChiTietDatPhongDAO();
            if (timeToAdjourn != null)
            {
                int rs = ctdpDAO.KiemTraGiaHanPhong(CTDP.MaPT, CTDP.CheckOut, timeToAdjourn);
                if (rs == 1)
                {
                    MessageBox.Show("PHÒNG ĐÃ CÓ NGƯỜI ĐẶT Ở GIỜ TIẾP THEO");
                    return;
                }
                else
                {
                    int rs2 = ctdpDAO.GiaHanPhong(CTDP.MaCTDP, timeToAdjourn);
                        MessageBox.Show("Gia hạn thành công");
                }
            }
        }
    }
}
