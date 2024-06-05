using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.Entity
{
    public class LoaiPhong
    {
        public string MaLPH { get; set; }
        public string TenLPH { get; set; }
        public int SoGiuong { get; set; }
        public int SoNguoiToiDa { get; set; }
        public float GiaNgay { get; set; }
        public float GiaGio { get; set; }

        public LoaiPhong()
        {

        }
    }
}
