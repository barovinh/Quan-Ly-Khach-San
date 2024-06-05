using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.Entity
{
   public class DichVu
    {

        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public float DonGia { get; set; }
        public int SLConLai { get; set; }
        public string LoaiDV { get; set; }
        public DichVu()
        {

        }
    }
}
