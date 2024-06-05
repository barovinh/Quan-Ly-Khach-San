using QL_KhachSan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{
    class PhieuThueDAO : DbContext
    {
        DbContext db = new DbContext();
        public List<PhieuThuePhong> phieuThuePhongs()
        {
            List<PhieuThuePhong> list = new List<PhieuThuePhong>();
            db.Cmd.CommandText = "SELECT*FROM PHIEUTHUE";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while(Reader.Read())
            {
                PhieuThuePhong pt = new PhieuThuePhong();
                pt.MaKH = Reader["MaKH"].ToString();
                pt.MaPT = Reader["MaPT"].ToString();
                pt.MaNV = Reader["MaNV"].ToString();
                DateTime ngayCheckIn;

                if (DateTime.TryParse(Reader["NgayLap"].ToString().ToString(), out ngayCheckIn))
                {
                    pt.NgayLap = ngayCheckIn;
                }
                list.Add(pt);
            }
            return list;
        }
        public PhieuThuePhong ThongTinPhieuThueTheoMaPhieu(string ma)
        {
            PhieuThuePhong pt = new PhieuThuePhong();
            db.Cmd.CommandText = "SELECT*FROM PHIEUTHUE WHERE MAPT = '" + ma + "'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while(Reader.Read())
            {
                pt.MaKH = Reader["MaKH"].ToString();
                pt.MaPT = Reader["MaPT"].ToString();
                pt.MaNV = Reader["MaNV"].ToString();
                DateTime ngayCheckIn;

                if (DateTime.TryParse(Reader["NgayLap"].ToString().ToString(), out ngayCheckIn))
                {
                    pt.NgayLap = ngayCheckIn;
                }
            }
           
            return pt;
        }
        public string GetMaPTNext()
        {
            List<Model.Entity.PhieuThuePhong> PT = phieuThuePhongs();
            if(PT.Count==0)
            {
                return "PT001";
            }
            string MaMax = PT[PT.Count - 1].MaPT.ToString();

            MaMax = MaMax.Substring(MaMax.Length - 3, 3);
            int max = int.Parse(MaMax);
            max++;
            if (max < 10)
            {
                return "PT00" + max.ToString();
            }
            else if (max < 100)
            {
                return "PT0" + max.ToString();
            }
            return "PT" + max.ToString();
        }
        public int ThemPhieuThue(Model.Entity.PhieuThuePhong ph)
        {
            Reader.Close();
            string currentTime = ph.NgayLap.ToString("yyyy-MM-dd HH:mm:ss");
            db.Cmd.CommandText = "INSERT INTO PhieuThue(MaPT,NgayLap,MaKH,MaNV) " +
                "VALUES ('"+ph.MaPT+"','"+currentTime+"','"+ph.MaKH+"','"+ph.MaNV+"')"; 
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public int DeletePhieuThue(string ma)
        {
            db.close();

            db.Cmd.CommandText = "DELETE PhieuThue WHERE MaPT = '" + ma + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
    }
}
