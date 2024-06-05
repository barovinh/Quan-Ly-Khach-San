using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.Entity
{
   public class PhieuThuePhong
    {
        //  [MaPT]
        //,[NgayLap]
        //,[MaKH]
        //,[MaNV]
        public string MaPT { get; set; }
        public DateTime NgayLap { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public PhieuThuePhong()
        {

        }
    }
}
