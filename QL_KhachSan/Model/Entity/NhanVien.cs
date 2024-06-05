using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.Entity
{
    public class NhanVien
    {
        //  [MaNV]
        //,[TenNV]
        //,[NgaySinh]
        //,[DiaChi]
        //,[GioiTinh]
        //,[Luong]
        //,[ChucVu]
        //,[CCCD]
        //,[SDT]
        //,[Email]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public int Luong { get; set; }
        public string ChucVu { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
    }
}
