using QL_KhachSan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{
    public class TaiKhoanDAO : DbContext
    {
        DbContext db = new DbContext();

        public List<TaiKhoan> GetTaiKhoans()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            db.Cmd.CommandText = "SELECT*FROM TAIKHOAN";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while(Reader.Read())
            {
                TaiKhoan tk = new TaiKhoan();
                tk.CapQuyen = int.Parse(Reader["CapQuyen"].ToString());
                tk.TenTK = Reader["TenTK"].ToString();
                tk.MaNV = Reader["MaNV"].ToString();
                tk.MatKhau = Reader["MatKhau"].ToString();
                list.Add(tk);
            }
            return list;
        }
        public TaiKhoan TimTaiKhoan(string tentk)
        {
            TaiKhoan tk = new TaiKhoan();
            db.Cmd.CommandText = "SELECT*FROM TAIKHOAN WHERE TENTK = '" + tentk + "'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            if(Reader.Read())
            {
                tk.CapQuyen = int.Parse(Reader["CapQuyen"].ToString());
                tk.TenTK = Reader["TenTK"].ToString();
                tk.MaNV = Reader["MaNV"].ToString();
                tk.MatKhau = Reader["MatKhau"].ToString();
                return tk; 
            }
            return null; 
        }
        public int UpdateTaiKhoan(TaiKhoan tk)
        {
            db.close();
            db.Cmd.CommandText = "UPDATE TaiKhoan" +
                " SET TenTK = '" + tk.TenTK + "' , MatKhau = '" + tk.MatKhau + "' , CapQuyen = '" + tk.CapQuyen + "' "+
                "WHERE MaNV ='" + tk.MaNV + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public List<TaiKhoan> TimTenTaiKhoan(string ten)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            db.Cmd.CommandText = "SELECT*FROM TaiKhoan WHERE TENTK LIKE N'%" + ten + "%'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                TaiKhoan kh = new TaiKhoan();
                kh.MaNV = Reader["MaNV"].ToString();
                kh.MatKhau = Reader["MatKhau"].ToString();
                kh.CapQuyen = int.Parse(Reader["CapQuyen"].ToString());
                kh.TenTK = Reader["TenTK"].ToString();
                
                list.Add(kh);
            }
            return list;
        }
        public int DeleteTaiKhoan(string ten)
        {
            db.Cmd.CommandText = "DELETE TaiKhoan WHERE TenTK = '" + ten + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);

        }
        public bool KTKhoaNgoai(string ma)
        {
            db.Cmd.CommandText = "SELECT COUNT(*) FROM NhanVien WHERE MANV = '" + ma + "'";
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
        public int ThemTaiKhoan(TaiKhoan kh)
        {
            db.close(); 
            db.Cmd.CommandText = "INSERT INTO TaiKhoan VALUES('"+kh.TenTK+"','"+kh.MatKhau+"','"+kh.MaNV+"','"+kh.CapQuyen+"')";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
    }
}
