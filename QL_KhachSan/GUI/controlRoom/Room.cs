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
    public partial class Room : UserControl
    {
        public string LoaiPhong { get; set; }
        public string MaPhong { get; set; }
        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {

        }
        public virtual void SetLoaiPhong(string LoaiPhong) { }
        public virtual void SetMaPhong(string maPhong) { }
        public virtual void SetTrangThai(string trangThai) { }
        public virtual void SetThoiGianNone() { }
        public virtual void SetThoiGian(string thoiGian) { }
        public virtual void SetPhongTrong() { }
        public virtual void SetChuaDonDep() { }
        public virtual void SetDaDonDep() { }
        public virtual void SetGhiChu(string ghiChu) { }
    }
}
