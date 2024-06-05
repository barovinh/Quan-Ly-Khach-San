using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.Entity
{
    public class ChiTietHoaDonI
    {
        public string MaHD { get; set; }
        public string MaPT { get; set; }
        public string MaNV { get; set; }
        public string MaCTDP { get; set; }
        public bool TheoGio { get; set; }
        public DateTime ngayThue { get; set; }
        public string TenKH { get; set; }
        public string MaKH { get; set; }
        public string MaPH { get; set; }
       public string TrangThai { get; set; }
        public string TenLPH { get; set; }
        public string SDT { get; set; }
        public float TongTienDichVu { get; set; }
        public float TongTienPhong { get; set; }

        public float TriGia { get; set; }
        public ChiTietHoaDonI()
        {

        }
    }
}
