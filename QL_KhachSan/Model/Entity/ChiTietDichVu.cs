using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.Entity
{
    public class ChiTietDichVu
    {
        public string MaCTDP { get; set; }
        public DichVu DichVu { get; set; }
        public int SoLuong { get; set; }
        public float ThanhTien { get; set; }
        public ChiTietDichVu()
        {
            DichVu = new DichVu();
        }
    }
}
