using QL_KhachSan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{
    class LoaiPhongDAO : DbContext
    {
        DbContext db = new DbContext();
        public List<LoaiPhong> GetLoaiPhongs()
        {
            List<LoaiPhong> list = new List<LoaiPhong>();
            db.Cmd.CommandText = "SELECT*FROM LOAIPHONG";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                LoaiPhong lp = new LoaiPhong();
                lp.GiaGio = float.Parse(Reader["GiaGio"].ToString());
                lp.GiaNgay = float.Parse(Reader["GiaNgay"].ToString());
                lp.MaLPH = Reader["MaLPH"].ToString();
                lp.SoGiuong = int.Parse(Reader["SoGiuong"].ToString());
                lp.SoNguoiToiDa = int.Parse(Reader["SoNguoiToiDa"].ToString());
                lp.TenLPH = Reader["TenLPH"].ToString();
                list.Add(lp);

            }
            return list;
        }
        public List<LoaiPhong> TenLoaiPhongCanTim(string ten)
        {
            List<LoaiPhong> list = new List<LoaiPhong>();
            db.Cmd.CommandText = "SELECT*FROM LOAIPHONG WHERE TenLPH LIKE N'%" + ten + "%'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                LoaiPhong lp = new LoaiPhong();
                lp.GiaGio = float.Parse(Reader["GiaGio"].ToString());
                lp.GiaNgay = float.Parse(Reader["GiaNgay"].ToString());
                lp.MaLPH = Reader["MaLPH"].ToString();
                lp.SoGiuong = int.Parse(Reader["SoGiuong"].ToString());
                lp.SoNguoiToiDa = int.Parse(Reader["SoNguoiToiDa"].ToString());
                lp.TenLPH = Reader["TenLPH"].ToString();
                list.Add(lp);
            }
            return list;
        }
        public LoaiPhong TimLoaiPhongTheoMa(string ma)
        {
            LoaiPhong lp = new LoaiPhong();
            db.Cmd.CommandText = "SELECT *FROM LOAIPHONG WHERE MALPH = '" + ma + "'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            if (Reader.Read())
            {
                lp.GiaGio = float.Parse(Reader["GiaGio"].ToString());
                lp.GiaNgay = float.Parse(Reader["GiaNgay"].ToString());
                lp.MaLPH = Reader["MaLPH"].ToString();
                lp.SoGiuong = int.Parse(Reader["SoGiuong"].ToString());
                lp.SoNguoiToiDa = int.Parse(Reader["SoNguoiToiDa"].ToString());
                lp.TenLPH = Reader["TenLPH"].ToString();
            }
            return lp;
        }
        public int UpdateLoaiPhong(LoaiPhong lp)
        {
            db.close();
            db.Cmd.CommandText = "UPDATE LOAIPHONG" +
                " SET TenLPH = N'" + lp.TenLPH + "' , SoGiuong = '" + lp.SoGiuong + "' , SoNguoiToiDa = '" + lp.SoNguoiToiDa + "' , GiaNgay = '" + lp.GiaNgay + "' , GiaGio = '" + lp.GiaGio + "'" +
                "WHERE MaLPH ='" + lp.MaLPH + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public int SoNguoiLoaiPhong(string ma)
        {
            db.close();
            db.Cmd.CommandText = "  select SoNguoiToiDa from LoaiPhong where MaLPH='" + ma + "'";
            int songuoi = 0;
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            if (Reader.Read())
            {
                songuoi = int.Parse(Reader["SoNguoiToiDa"].ToString());

            }
            return songuoi;
        }
    }
}
