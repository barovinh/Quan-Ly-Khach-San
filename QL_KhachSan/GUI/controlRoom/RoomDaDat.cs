using QL_KhachSan.GUI.SoDoPhong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan.GUI.controlRoom
{
    public partial class RoomDaDat : Room
    {
        public Model.Entity.ChiTietDatPhong CTDP { get; set; }

        public RoomDaDat(Model.Entity.ChiTietDatPhong ctdp)
        {
            InitializeComponent();
            CTDP = ctdp;
           
        }

        private void RoomDaDat_Load(object sender, EventArgs e)
        {

        }
      
        public override void SetDaDonDep()
        {
            PictureBoxTrangThaiDonDep.Image = Properties.Resources.tickblack;
            LabelTrangThaiDonDep.Text = "Đã dọn dẹp";
        }
        public override void SetChuaDonDep()
        {
            PictureBoxTrangThaiDonDep.Image = Properties.Resources.x;
            LabelTrangThaiDonDep.Text = "Chưa dọn dẹp";
        }
        public override void SetLoaiPhong(string LoaiPhong)
        {
            labelLoaiPhong.Text = LoaiPhong;
        }
        public override void SetTrangThai(string trangThai)
        {
            labelTrangThaiPhong.Text = trangThai;
        }
        public override void SetMaPhong(string maPhong)
        {
            labelTenPhong.Text = maPhong;
            CTDP.Phong.MaPH = maPhong;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            new FormXacNhanNhanPhong(CTDP).ShowDialog();       
        }
        public override void SetThoiGianNone()
        {
            TimeSpan timeDifference = CTDP.CheckOut - CTDP.CheckIn;
            double sogio = timeDifference.TotalHours;

            LabelThoiGian.Text = sogio.ToString() +" giờ";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
