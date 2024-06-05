using QL_KhachSan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{
    public class NhanVienDAO : DbContext
    {
        DbContext db = new DbContext();
        public NhanVien getNhanVienTheoMa(string ma)
        {
            NhanVien nv = new NhanVien();
            db.Cmd.CommandText = "SELECT*FROM NHANVIEN WHERE MANV = '" + ma + "'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            if (Reader.Read())
            {
                nv.TenNV = Reader["TenNV"].ToString();
                nv.MaNV = Reader["MaNV"].ToString();
                nv.ChucVu = Reader["ChucVu"].ToString();
                nv.SDT = Reader["SDT"].ToString();
                nv.Luong = int.Parse(Reader["Luong"].ToString());
                nv.DiaChi = Reader["DiaChi"].ToString();
                nv.GioiTinh = Reader["GioiTinh"].ToString();
                nv.CCCD = Reader["CCCD"].ToString();
                nv.Email = Reader["email"].ToString();
                DateTime ngaySinh;

                if (DateTime.TryParse(Reader["NgaySinh"].ToString().ToString(), out ngaySinh))
                {
                    nv.NgaySinh = ngaySinh;
                }
            }
            return nv;
        }
        public List<NhanVien> GetNhanViens()
        {
            List<NhanVien> list = new List<NhanVien>();
            db.Cmd.CommandText = "SELECT*FROM NhanVien";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                NhanVien nv = new NhanVien();
                nv.TenNV = Reader["TenNV"].ToString();
                nv.MaNV = Reader["MaNV"].ToString();
                nv.ChucVu = Reader["ChucVu"].ToString();
                nv.Luong = int.Parse(Reader["Luong"].ToString());
                nv.SDT = Reader["SDT"].ToString();
                DateTime ngaySinh;
                if (DateTime.TryParse(Reader["NgaySinh"].ToString().ToString(), out ngaySinh))
                {
                    nv.NgaySinh = ngaySinh;
                }
                nv.DiaChi = Reader["DiaChi"].ToString();
                nv.GioiTinh = Reader["GioiTinh"].ToString();
                nv.CCCD = Reader["CCCD"].ToString();
                nv.Email = Reader["email"].ToString();
                list.Add(nv);
            }
            return list;
        }
        public List<NhanVien> TimTenKhachHang(string ten)
        {
            List<NhanVien> list = new List<NhanVien>();
            db.Cmd.CommandText = "SELECT*FROM NhanVien WHERE TenNV LIKE N'%" + ten + "%'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                NhanVien nv = new NhanVien();
                nv.TenNV = Reader["TenNV"].ToString();
                nv.MaNV = Reader["MaNV"].ToString();
                nv.ChucVu = Reader["ChucVu"].ToString();
                nv.Luong = int.Parse(Reader["Luong"].ToString());
                nv.SDT = Reader["SDT"].ToString();
                DateTime ngaySinh;
                if (DateTime.TryParse(Reader["NgaySinh"].ToString().ToString(), out ngaySinh))
                {
                    nv.NgaySinh = ngaySinh;
                }
                nv.DiaChi = Reader["DiaChi"].ToString();
                nv.GioiTinh = Reader["GioiTinh"].ToString();
                nv.CCCD = Reader["CCCD"].ToString();
                nv.Email = Reader["email"].ToString();
                list.Add(nv);
            }
            return list;
        }
        public int UpdateNhanVien(NhanVien kh)
        {
            db.close();
            db.Cmd.CommandText = "UPDATE NhanVien" +
                " SET TenNV = N'" + kh.TenNV + "' , ChucVu = '" + kh.ChucVu + "' , Luong = '" + kh.Luong + "' , SDT = '" + kh.SDT + "' , NgaySinh = '" + kh.NgaySinh + "', CCCD = '" + kh.CCCD + "' , DiaChi = '" + kh.DiaChi + "', Email = '" + kh.Email + "'"+
                "WHERE MANV ='" + kh.MaNV + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public int DeleteNhanVien(string ma)
        {
            db.Cmd.CommandText = "DELETE NhanVien WHERE MaKH = '" + ma + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);

        }
        public bool KTKhoaNgoai(string ma)
        {
            db.Cmd.CommandText = "SELECT COUNT(*) FROM HoaDon WHERE MANV = '" + ma + "'";
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