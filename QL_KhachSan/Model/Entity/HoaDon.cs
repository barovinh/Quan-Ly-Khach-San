using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.Entity
{
   public class HoaDon
    {
        public string MaHD { get; set; }  
        public string MaCTDP { get; set; }
        public DateTime ngayLap { get; set; }
        public string TrangThai { get; set; }
        public string MaNV { get; set; }
        public float TriGia { get; set; }
        public HoaDon()
        {
            
                   
        }
    }
}
