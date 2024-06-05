using QL_KhachSan.GUI.controlRoom;
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
    public partial class FormSoDoPhong : Form
    {
        List<Model.Entity.Phong> phongs = new List<Model.Entity.Phong>();
        DateTime dateTime = DateTime.Now;
        string timeTemp;
        public TaiKhoan TK { get; set; }
        public FormSoDoPhong( TaiKhoan tk )
        {
            InitializeComponent();
            loadGio();
            comboBoxGioGiac.Items.Add(dateTime.ToString("HH:mm"));        
            comboBoxGioGiac.SelectedItem = dateTime.ToString("HH:mm");
            timeTemp = dateTime.ToString("HH:mm");
            TK = tk;
                     
        }
        public void loadLanDau()
        {
            getAllPhong();
            loadData(phongs,this.dateTime);

        }
        public void getAllPhong()
        {
            PhongDAO pDAO = new PhongDAO();
            phongs = pDAO.GetPhongs();
        }
        private void panelSoDoPhong_Paint(object sender, PaintEventArgs e)
        {

        }
        void loadGio()
        {      
                int startHour = 0;
                int endHour = 23;

                for (int hour = startHour; hour <= endHour; hour++)
                {
                    comboBoxGioGiac.Items.Add($"{hour:00}:00");
                    comboBoxGioGiac.Items.Add($"{hour:00}:30");
                }         
        }
        void setNgay(DateTime dtt)
        {
            this.dateTime = dtt;
        }
        public DateTime setGio(DateTime dt,string time)
        {
            string[] mang = time.Split(':');
            int hour = int.Parse(mang[0]);
            int minute = int.Parse(mang[1]);
            TimeSpan ts = new TimeSpan(hour, minute, 0);
            dt = dt.Date + ts;
            return dt;
        }
        public void loadData(List<Model.Entity.Phong> phongg, DateTime dt)
        {
            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel2.Controls.Clear();
            this.flowLayoutPanel3.Controls.Clear();
            this.flowLayoutPanel4.Controls.Clear();
            this.flowLayoutPanel5.Controls.Clear();
            List<controlRoom.Room> dsPhong = new List<GUI.controlRoom.Room>();
            ChiTietDatPhongDAO ctDAO = new ChiTietDatPhongDAO();
            foreach (var item in phongg)
            {
                ChiTietDatPhong ct = ctDAO.TimCTDP(item.MaPH, dt);

                if (ct != null && item.TTPH == "Bình thường")
                {

                    if (ct.TrangThai == "Đang thuê" && (this.rdPhongDangThue.Checked || this.rdTatCaPhong.Checked))
                    {
                        RoomDangThue roomDangThue = new RoomDangThue(ct, TK);
                        if (item.TTDD == "Đã dọn dẹp")
                            roomDangThue.SetDaDonDep();
                        else
                            roomDangThue.SetChuaDonDep();
                        roomDangThue.SetMaPhong(item.MaPH);
                        roomDangThue.SetLoaiPhong(item.Lp.TenLPH);
                        if (ct.TheoGio == true)
                        {
                            roomDangThue.SetThoiGianNone();

                        }
                        roomDangThue.MaPhong = item.MaPH;
                        roomDangThue.LoaiPhong = item.Lp.TenLPH;
                        dsPhong.Add(roomDangThue);
                    }

                }
                if (item.TTPH == "Bình thường" && ct != null)
                {
                    if (ct.TrangThai == "Đã đặt" && (this.rdPhongDaDat.Checked || this.rdTatCaPhong.Checked))

                    {
                        RoomDaDat room = new RoomDaDat(ct);

                        if (item.TTDD == "Đã dọn dẹp")
                            room.SetDaDonDep();
                        else
                            room.SetChuaDonDep();
                        room.SetMaPhong(item.MaPH);
                        room.SetLoaiPhong(item.Lp.TenLPH);
                        room.MaPhong = item.MaPH;
                        room.LoaiPhong = item.Lp.TenLPH;
                        if (ct.TheoGio == true)
                        {
                            room.SetThoiGianNone();

                        }
                        dsPhong.Add(room);
                    }

                }
                if (item.TTPH == "Bình thường" && (ct == null || ct.TrangThai == "Đã xong") && (this.rdPhongTrong.Checked || this.rdTatCaPhong.Checked))
                {
                    controlRoom.RoomPhongTrong r = new controlRoom.RoomPhongTrong(TK);
                    if (item.TTDD == "Đã dọn dẹp")
                        r.SetDaDonDep();
                    else
                        r.SetChuaDonDep();
                    r.SetMaPhong(item.MaPH);
                    r.SetLoaiPhong(item.Lp.TenLPH);
                    r.MaPhong = item.MaPH;
                    r.LoaiPhong = item.Lp.TenLPH;
                    dsPhong.Add(r);
                }
                if (item.TTPH == "Đang sửa chữa" && (this.rdPhongDangSua.Checked || this.rdTatCaPhong.Checked))
                {
                    controlRoom.RoomDangSuaChua r = new RoomDangSuaChua(TK);
                    if (item.TTDD == "Đã dọn dẹp")
                        r.SetDaDonDep();
                    else
                        r.SetChuaDonDep();
                    r.SetMaPhong(item.MaPH);
                    r.SetLoaiPhong(item.Lp.TenLPH);
                    r.MaPhong = item.MaPH;
                    r.LoaiPhong = item.Lp.TenLPH;
                    dsPhong.Add(r);
                }
            }

            this.flowLayoutPanel1.Controls.Add(
                new Label()
                {
                    Text = "Tầng 1",
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 20, 700, 0)
                }
            );

            this.flowLayoutPanel2.Controls.Add(
                 new Label()
                 {
                     Text = "Tầng 2",
                     Dock = DockStyle.Top,
                     Margin = new Padding(0, 0, 700, 0)
                 }
             );
            this.flowLayoutPanel3.Controls.Add(
                 new Label()
                 {
                     Text = "Tầng 3",
                     Dock = DockStyle.Top,
                     Margin = new Padding(0, 0, 700, 0)
                 }
             );
            this.flowLayoutPanel4.Controls.Add(
                  new Label()
                  {
                      Text = "Tầng 4",
                      Dock = DockStyle.Top,
                      Margin = new Padding(0, 0, 700, 0)
                  }
              );
            this.flowLayoutPanel5.Controls.Add(
                    new Label()
                    {
                        Text = "Tầng 5",
                        Dock = DockStyle.Top,
                        Margin = new Padding(0, 0, 700, 0)
                    }
                );
            foreach (var temp in dsPhong)
            {
                if (temp.MaPhong.StartsWith("P1"))
                {
                    flowLayoutPanel1.Controls.Add(temp);
                }
                if (temp.MaPhong.StartsWith("P2"))
                {
                    flowLayoutPanel2.Controls.Add(temp);
                }
                if (temp.MaPhong.StartsWith("P3"))
                {
                    flowLayoutPanel3.Controls.Add(temp);
                }
                if (temp.MaPhong.StartsWith("P4"))
                {
                    flowLayoutPanel4.Controls.Add(temp);
                }
                if (temp.MaPhong.StartsWith("P5"))
                {
                    flowLayoutPanel5.Controls.Add(temp);
                }
            }
        }
        private void FormSoDoPhong_Load(object sender, EventArgs e)
        {
            loadLanDau();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenLPHCanTim_Enter(object sender, EventArgs e)
        {
            //if (txtTenLPHCanTim.Text == "Nhập mã phòng cần tìm")
            //{
            //    txtTenLPHCanTim.Text = "";

            //}
        }

        private void txtTenLPHCanTim_Leave(object sender, EventArgs e)
        {
            //if(txt.Text=="")
            //{
            //    txtTenLPHCanTim.Text = "Nhập mã phòng cần tìm";

            //}
        }

        private void comboBoxGioGiac_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dtemp= setGio(this.dateTime,comboBoxGioGiac.SelectedItem.ToString());
            setNgay(dateTimePicker1.Value);
            loadData(phongs,dtemp);
            comboBoxGioGiac.Items.Remove(timeTemp);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtemp = setGio(this.dateTime, comboBoxGioGiac.SelectedItem.ToString());
            setNgay(dateTimePicker1.Value);
            loadData(phongs, dtemp);
        }
        
        private void rdPhongTrong_CheckedChanged(object sender, EventArgs e)
        {
            getAllPhong();
            LoadTinhTrangDaDD();
            LoadLoaiPhong();
            loadData(phongs,this.dateTime);
        }
        public void LoadTinhTrangDaDD()
        {
            foreach (Control item in groupBox2.Controls)
            {
                RadioButton rd = item as RadioButton;
                if (rd.Checked && rd.Name == "rdChuaDonDep")
                {
                    LoadPhongChuaDonDep();
                }
               else if (rd.Checked && rd.Name == "rdDaDonDep")
                {
                    LoadPhongDaDonDep();
                }
                
            }
        }
        public void LoadPhongDaDonDep()
        {

            phongs = phongs.Where(t => t.TTDD == "Đã dọn dẹp").ToList();
        }
        public void LoadPhongChuaDonDep()
        {
            phongs = phongs.Where(t => t.TTDD == "Chưa dọn dẹp").ToList();
        }
        private void rdChuaDonDep_CheckedChanged(object sender, EventArgs e)
        {
            getAllPhong();
            LoadTinhTrangDaDD();
            LoadLoaiPhong();
            loadData(phongs,this.dateTime);
        }
        void LoadTPhongTDon()
        {

            phongs = phongs.Where(t => t.Lp.MaLPH == "NOR01").ToList();

        }
        void LoadTPhongDoi()
        {

            phongs = phongs.Where(t => t.Lp.MaLPH == "NOR02").ToList();

        }
        public void LoadVPhongDon()
        {
            phongs = phongs.Where(t => t.Lp.MaLPH == "VIP01").ToList();

        }
        public void LoadVPhongDoi()
        {
            phongs = phongs.Where(t => t.Lp.MaLPH == "VIP02").ToList();

        }
        public void LoadLoaiPhong()
        {
            foreach (Control item in groupBox3.Controls)
            {
                RadioButton rd = item as RadioButton;
                if(rd.Checked && rd.Name=="rdTDon")
                {
                    LoadTPhongTDon();
                }
                if (rd.Checked && rd.Name == "rdTDoi")
                {
                    LoadTPhongDoi();
                }
                if (rd.Checked && rd.Name == "rdVDon")
                {
                    LoadVPhongDon();
                }
                if (rd.Checked && rd.Name == "rdVDoi")
                {
                    LoadVPhongDoi();
                }
            }
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rdVDoi_CheckedChanged(object sender, EventArgs e)
        {
            getAllPhong();
            LoadTinhTrangDaDD();
            LoadLoaiPhong();
            loadData(phongs,this.dateTime);
        }

        private void rdTatCaLoaiPhong_CheckedChanged(object sender, EventArgs e)
        {
            getAllPhong();
            loadData(phongs,this.dateTime);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            getAllPhong();
           
           loadData(phongs,DateTime.Now);
        }
    }
}
