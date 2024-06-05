using QL_KhachSan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{
    class ChiTietHoaDonIDAO : DbContext
    {
        DbContext db = new DbContext();
        public ChiTietHoaDonI GetThongTinHoaDons(string mahd)
        {
            List<ChiTietHoaDonI> list = new List<ChiTietHoaDonI>();
            db.Cmd.CommandText = @"SELECT
                HD.MaHD,
                CTDP.MaPT,
	                HD.MaNV,
	                CTDP.MaCTDP,
	                CTDP.TheoGio,
                    PT.NgayLap AS NgayThue,
                    KH.TenKH,
	                KH.MaKH,
	                KH.SDT,
                    P.MaPH,
	                HD.TrangThai,
                    LP.TenLPH,
                    SUM(ISNULL(DV.DonGia, 0) * ISNULL(CTDV.SL, 0)) AS TongTienDichVu,
                    SUM(ISNULL(LP.GiaNgay, 0)) AS TongTienPhong,
                    ISNULL(SUM(ISNULL(DV.DonGia, 0) * ISNULL(CTDV.SL, 0)), 0) + ISNULL(SUM(ISNULL(LP.GiaNgay, 0)), 0) AS TriGia
                FROM
                    KhachHang KH
                    JOIN PhieuThue PT ON KH.MaKH = PT.MaKH
                    JOIN CTDP ON PT.MaPT = CTDP.MaPT
                    JOIN Phong P ON CTDP.MaPH = P.MaPH
                    JOIN LoaiPhong LP ON P.MaLPH = LP.MaLPH
	                JOIN HOADON HD ON HD.MaCTDP = CTDP.MaCTDP
                    LEFT JOIN CTDV ON CTDP.MaCTDP = CTDV.MaCTDP
                    LEFT JOIN DichVu DV ON CTDV.MaDV = DV.MaDV
                WHERE HD.MaHD=@MaHD
                GROUP BY
                hd.TrangThai,
                HD.MaHD,
                CTDP.MaPT,
                KH.MAKH,
                HD.MaNV,
                KH.SDT,
	                CTDP.MaCTDP,
	                CTDP.TheoGio,
                    PT.NgayLap,
                    KH.TenKH,
                    P.MaPH,
                    LP.TenLPH
                ORDER BY
                    HD.MaHD asc;
"; 
            ChiTietHoaDonI hd = new ChiTietHoaDonI();
            db.Cmd.Parameters.AddWithValue("@MaHD", mahd);
            Reader = db.Cmd.ExecuteReader();
            while (Reader.Read())
            {
                hd.MaNV = Reader["MaNV"].ToString();
                hd.MaHD = Reader["MaHD"].ToString();
                hd.MaPT = Reader["MaPT"].ToString();
                hd.MaCTDP = Reader["MaCTDP"].ToString();
                hd.TheoGio = Convert.ToBoolean(Reader["TheoGio"]);
                DateTime ngayCheckIn;
                if (DateTime.TryParse(Reader["NgayThue"].ToString().ToString(), out ngayCheckIn))
                {
                    hd.ngayThue = ngayCheckIn;
                }
                hd.TenKH = Reader["TenKH"].ToString();
                hd.MaKH = Reader["MaKH"].ToString();
                hd.MaPH = Reader["MaPH"].ToString();
                hd.SDT = Reader["SDT"].ToString();
                hd.TrangThai = Reader["TrangThai"].ToString();
                hd.TenLPH = Reader["TenLPH"].ToString();
                hd.TongTienDichVu = float.Parse(Reader["TongTienDichVu"].ToString());
                hd.TongTienPhong = float.Parse(Reader["TongTienPhong"].ToString());
                hd.TriGia = float.Parse(Reader["TriGia"].ToString());
                list.Add(hd);
            }
            return hd;
        }
    }
}
