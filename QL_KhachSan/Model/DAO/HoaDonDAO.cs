using QL_KhachSan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{
    class HoaDonDAO : DbContext
    {
        DbContext db = new DbContext();
        
      
        public List<HoaDon> GetHoaDons()
        {
            db.Cmd.CommandText = "SELECT*FROM HOADON";
            List<HoaDon> list = new List<HoaDon>();
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while(Reader.Read())
            {
                HoaDon hd = new HoaDon();
                hd.MaHD = Reader["MaHD"].ToString();
                DateTime ngayCheckIn;

                if (DateTime.TryParse(Reader["NgayLap"].ToString().ToString(), out ngayCheckIn))
                {
                    hd.ngayLap = ngayCheckIn;
                }
                hd.MaNV = Reader["MaNV"].ToString() ;
                hd.TriGia = float.Parse(Reader["TriGia"].ToString());
                hd.TrangThai = Reader["TrangThai"].ToString();
                hd.MaCTDP = Reader["MaCTDP"].ToString();
                list.Add(hd);
            }
            return list;
        }
        public List<HoaDon> TimMaHD(string ma)
        {
            db.Cmd.CommandText = "SELECT*FROM HOADON where MaHD= '"+ma+"'";
            List<HoaDon> list = new List<HoaDon>();
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                HoaDon hd = new HoaDon();
                hd.MaHD = Reader["MaHD"].ToString();
                DateTime ngayCheckIn;

                if (DateTime.TryParse(Reader["NgayLap"].ToString().ToString(), out ngayCheckIn))
                {
                    hd.ngayLap = ngayCheckIn;
                }
                hd.MaNV = Reader["MaNV"].ToString();
                hd.TriGia = float.Parse(Reader["TriGia"].ToString());
                hd.TrangThai = Reader["TrangThai"].ToString();
                hd.MaCTDP = Reader["MaCTDP"].ToString();
                list.Add(hd);
            }
            return list;
        }
        public int ThemHoaDon(HoaDon hd)
        {
            db.close(); 
            // INSERT INTO HoaDon(MaHD, NgayLap, MaNV, MaCTDP, TrangThai, TriGia)
            string currentTime = hd.ngayLap.ToString("yyyy-MM-dd HH:mm:ss");
            db.Cmd.CommandText = "INSERT INTO HOADON(MaHD, NgayLap, MaNV, MaCTDP, TrangThai, TriGia) VALUES('" + hd.MaHD+"','"+currentTime+"','"+hd.MaNV+"','"+hd.MaCTDP+"',N'"+"Đã thanh toán"+"','"+hd.TriGia+"')";

            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public string GetMaHDNext()
        {
            List<HoaDon> hoaDons;

            hoaDons = GetHoaDons();
            if (hoaDons.Count==0)
            {
                return "HD001";
            }
            string MaMax = hoaDons[hoaDons.Count - 1].MaHD.ToString();
            MaMax = MaMax.Substring(MaMax.Length - 3, 3);
            int max = int.Parse(MaMax);
            max++;
            if (max < 10)
            {
                return "HD00" + max.ToString();
            }
            else if (max < 100)
            {
                return "HD0" + max.ToString();
            }
            return "HD" + max.ToString();
        }
    }
}
