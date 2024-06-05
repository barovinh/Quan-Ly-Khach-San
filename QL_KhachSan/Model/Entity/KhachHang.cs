using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.Entity
{
   public class KhachHang
    {
        //  [MaKH]
        //,[TenKH]
        //,[SDT]
        //,[CCCD]
        //,[QuocTich]
        //,[GioiTinh]
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public string QuocTich { get; set; }
        public string GioiTinh { get; set; }
        public KhachHang()
        {
            
        }
    }
}
