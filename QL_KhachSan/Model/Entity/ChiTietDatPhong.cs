using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.Entity
{
    public class ChiTietDatPhong
    {
        //  [MaCTDP]
        //,[SoNguoi]
        //,[MaPT]
        //,[MaPH]
        //,[CheckIn]
        //,[CheckOut]
        //,[TrangThai]
        //,[DonGia]
        //,[ThanhTien]
        //,[TheoGio]

        public string MaCTDP { get; set; }
        public int SoNguoi { get; set; }
        public string MaPT { get; set; }
        public Phong Phong { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string TrangThai { get; set; }
        public float DonGia { get; set; }
        public bool TheoGio { get; set; }
        public float ThanhTien { get; set; }
        public ChiTietDatPhong()
        {
            Phong = new Phong();
        }

    }


}
