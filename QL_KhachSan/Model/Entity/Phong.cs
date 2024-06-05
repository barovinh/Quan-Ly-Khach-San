using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.Entity
{
 public   class Phong
    {
        //  [MaPH]
        //,[TTPH]
        //,[TTDD]
        //,[GhiChu]
        //,[MaLPH]
        public string MaPH { get; set; }
        public string TTPH { get; set; } // tifn htrajng phong
        public string TTDD { get; set; } // tình trạng dọn dEJPO
        public string GhiChu { get; set; }
        public LoaiPhong Lp { get; set; }
        public Phong()
        {
            MaPH = "";
            Lp = new LoaiPhong();
        }
    }
}
