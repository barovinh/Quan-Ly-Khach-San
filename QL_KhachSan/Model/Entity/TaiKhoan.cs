using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.Entity
{
   public class TaiKhoan
    {
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public string MaNV { get; set; }
        public int CapQuyen { get; set; }
        public TaiKhoan()
        {

        }
    }
}
