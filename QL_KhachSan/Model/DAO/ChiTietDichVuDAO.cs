using QL_KhachSan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{ 
   public class ChiTietDichVuDAO : DbContext
    {
        DbContext db = new DbContext();
        public List<ChiTietDichVu> GetchiTietDichVus()
        {
            List<ChiTietDichVu> list = new List<ChiTietDichVu>();
            db.Cmd.CommandText = "SELECT*FROM CHITIETDICHVU";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while(Reader.Read())
            {
                ChiTietDichVu ct = new ChiTietDichVu();
                ct.DichVu.DonGia = float.Parse(Reader["DonGia"].ToString());
                ct.DichVu.MaDV = Reader["MaDV"].ToString();
                ct.MaCTDP = Reader["MaCTDP"].ToString();
                ct.SoLuong = int.Parse( Reader["SL"].ToString());
                ct.ThanhTien = float.Parse(Reader["ThanhTien"].ToString());
                list.Add(ct); 
            }
            return list;
        }

        public List<ChiTietDichVu> LayChiTietDichVuTheoMaCTDP(string ma)
        {
            List<ChiTietDichVu> list = new List<ChiTietDichVu>();
            db.Cmd.CommandText = "SELECT MACTDP,DICHVU.MADV,DICHVU.DONGIA,SL,THANHTIEN,TENDV FROM CTDV " +
                "JOIN DICHVU ON DICHVU.MaDV = CTDV.MaDV WHERE MACTDP = '" + ma + "'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while(Reader.Read())
            {
                ChiTietDichVu ct = new ChiTietDichVu();
                ct.DichVu.DonGia = float.Parse(Reader["DonGia"].ToString());
                ct.DichVu.MaDV = Reader["MaDV"].ToString();
                ct.MaCTDP = Reader["MaCTDP"].ToString();
                ct.DichVu.TenDV = Reader["TENDV"].ToString();
                ct.SoLuong = int.Parse(Reader["SL"].ToString());
                ct.ThanhTien = float.Parse(Reader["ThanhTien"].ToString());
                list.Add(ct);
            }
            return list;

        }
        public int ThemCTDichVu(ChiTietDichVu chiTiet)
        {
            db.close();
            db.Cmd.CommandText = "INSERT INTO CTDV (MACTDP,MADV,DONGIA,SL,THANHTIEN)" +
                " VALUES('"+chiTiet.MaCTDP+"','"+chiTiet.DichVu.MaDV+"','"+chiTiet.DichVu.DonGia+"','"+chiTiet.SoLuong+"','"+chiTiet.ThanhTien+"')";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public int UpDateCTDV(ChiTietDichVu chiTiet)
        {
            db.close();
            db.Cmd.CommandText = "UPDATE CTDV SET SL = SL + '"+chiTiet.SoLuong+"' where MaDV = '"+chiTiet.DichVu.MaDV+"' and MaCTDP = '"+chiTiet.MaCTDP+"'";
                return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public bool KiemTraTonTaiMaDV(ChiTietDichVu chiTiet)
        {
            db.Cmd.CommandText = "SELECT COUNT(*) FROM CTDV WHERE MaDV = '"+chiTiet.DichVu.MaDV+"' AND MaCTDP = '"+chiTiet.MaCTDP+"'";
            int kt = (int)db.ExcuteScalar(db.Cmd.CommandText);
            if(kt>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
