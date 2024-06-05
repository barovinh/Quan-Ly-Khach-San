using QL_KhachSan.GUI.SoDoPhong;
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

namespace QL_KhachSan.GUI.controlRoom
{
    public partial class RoomDangSuaChua : Room
    {
        public TaiKhoan TK { get; set; }
        public RoomDangSuaChua(TaiKhoan tk)
        {
            InitializeComponent();
            TK = tk;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            new FormThongTinPhongChuaThue(labelTrangThaiPhong.Text, LabelTrangThaiDonDep.Text, labelTenPhong.Text,TK).ShowDialog();
            
        }
    }
}
