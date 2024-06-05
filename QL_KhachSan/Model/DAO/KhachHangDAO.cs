using QL_KhachSan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{
    class KhachHangDAO : DbContext
    {
        DbContext db = new DbContext();
        public List<KhachHang> GetKhachHangs()
        {
            List<KhachHang> list = new List<KhachHang>();
            db.Cmd.CommandText = "SELECT*FROM KHACHHANG";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while(Reader.Read())
            {
                KhachHang kh = new KhachHang();
                kh.CCCD = Reader["CCCD"].ToString();
                kh.TenKH = Reader["TenKH"].ToString();
                kh.GioiTinh = Reader["GioiTinh"].ToString();
                kh.SDT = Reader["SDT"].ToString();
                kh.MaKH = Reader["MaKH"].ToString();
                kh.QuocTich = Reader["QuocTich"].ToString();
                list.Add(kh);
            }
            return list;
        }
        public string GetMaKHNext()
        {
        
            List<KhachHang> KH = GetKhachHangs();
            if(KH.Count==0)
            {
                return "KH001";
            }
            string MaMax = KH[KH.Count - 1].MaKH.ToString();
            MaMax = MaMax.Substring(MaMax.Length - 3, 3);
            int max = int.Parse(MaMax);
            max++;
            if (max < 10)
            {
                return "KH00" + max.ToString();
            }
            else if (max < 100)
            {
                return "KH0" + max.ToString();
            }
            return "KH" + max.ToString();

        }
        public int ThemKhachHang(KhachHang kh)
        {
            db.close();
            db.Cmd.CommandText = "INSERT INTO KhachHang VALUES('"+kh.MaKH+"',N'"+kh.TenKH+"','"+kh.SDT+ "','" + kh.CCCD + "',N'" + kh.QuocTich + "',N'" + kh.GioiTinh + "')";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }

        public KhachHang ThongTinKhachHangTheoMa(string ma)
        {
            db.Cmd.CommandText = "SELECT * FROM KHACHHANG WHERE MAKH ='" + ma + "'";
            KhachHang kh = new KhachHang();
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                kh.CCCD = Reader["CCCD"].ToString();
                kh.TenKH = Reader["TenKH"].ToString();
                kh.GioiTinh = Reader["GioiTinh"].ToString();
                kh.SDT = Reader["SDT"].ToString();
                kh.MaKH = Reader["MaKH"].ToString();
                kh.QuocTich = Reader["QuocTich"].ToString();          
            }
            return kh;
        }
        public KhachHang ThongTinKhachHangTheoSDT(string sdt)
        {
            db.Cmd.CommandText = "SELECT * FROM KHACHHANG WHERE SDT ='" + sdt + "'";
            KhachHang kh = new KhachHang();
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            if (Reader.Read())
            {
                kh.CCCD = Reader["CCCD"].ToString();
                kh.TenKH = Reader["TenKH"].ToString();
                kh.GioiTinh = Reader["GioiTinh"].ToString();
                kh.SDT = Reader["SDT"].ToString();
                kh.MaKH = Reader["MaKH"].ToString();
                kh.QuocTich = Reader["QuocTich"].ToString();
                return kh;
            }
            return null;
        }
        public List<KhachHang> TimTenKhachHang(string ten)
        {
            List<KhachHang> list = new List<KhachHang>();
            db.Cmd.CommandText = "SELECT*FROM KhachHang WHERE TENKH LIKE N'%" + ten + "%'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                KhachHang kh = new KhachHang();
                kh.CCCD = Reader["CCCD"].ToString();
                kh.TenKH = Reader["TenKH"].ToString();
                kh.GioiTinh = Reader["GioiTinh"].ToString();
                kh.SDT = Reader["SDT"].ToString();
                kh.MaKH = Reader["MaKH"].ToString();
                kh.QuocTich = Reader["QuocTich"].ToString();
                list.Add(kh);
            }
            return list;
        }
        public int UpdateKhachHang(KhachHang kh)
        {
            db.close();
            db.Cmd.CommandText = "UPDATE KhachHang" +
                " SET TenKH = N'" + kh.TenKH + "' , SDT = '" + kh.SDT + "' , CCCD = '" + kh.CCCD + "' , QuocTich = '" + kh.QuocTich + "' , GioiTinh = '" + kh.GioiTinh + "'" +
                "WHERE MaKH ='" + kh.MaKH + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public int DeleteKhachHang(string ma)
        {
            db.Cmd.CommandText = "DELETE KhachHang WHERE MaKH = '" + ma + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);

        }
        public bool KTKhoaNgoai(string ma)
        {
            db.Cmd.CommandText = "SELECT COUNT(*) FROM PhieuThue WHERE MAKH = '" + ma + "'";
            int kt = (int)db.ExcuteScalar(db.Cmd.CommandText);
            if (kt > 0)
            {
                return true; // là khóa ngoại
            }
            else
            {
                return false;
            }
        }
    }
}

