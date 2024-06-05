using QL_KhachSan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{
    class DichVuDAO : DbContext
    {
        DbContext db = new DbContext();
        public  List<DichVu> getDichVus()
        {
            List<DichVu> list = new List<DichVu>();
            db.Cmd.CommandText = "SELECT*FROM DICHVU";
            Reader = db.ExcuteQuery(db.Cmd.CommandText); 
            while(Reader.Read())
            {
                DichVu dv = new DichVu();
                dv.DonGia = float.Parse(Reader["DonGia"].ToString());
                dv.LoaiDV = Reader["LoaiDV"].ToString();
                dv.TenDV = Reader["TenDV"].ToString();
                dv.SLConLai = int.Parse(Reader["SLConLai"].ToString());
                dv.MaDV = Reader["MaDV"].ToString();
                list.Add(dv);
            }
            return list;
        }
        public List<DichVu> TenDichVuCanTim(string ten)
        {
            List<DichVu> list = new List<DichVu>();
            db.Cmd.CommandText = "SELECT*FROM DICHVU WHERE TENDV like N'%" + ten + "%'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                DichVu dv = new DichVu();
                dv.DonGia = float.Parse(Reader["DonGia"].ToString());
                dv.LoaiDV = Reader["LoaiDV"].ToString();
                dv.TenDV = Reader["TenDV"].ToString();
                dv.SLConLai = int.Parse(Reader["SLConLai"].ToString());
                dv.MaDV = Reader["MaDV"].ToString();
                list.Add(dv);
            }
            return list;
        }
        public string GetMaDVNext()
        {
            List<DichVu> list = getDichVus();
            if(list.Count==0)
            {
                return "DV01";
            }
            string MaMax = list[list.Count - 1].MaDV.ToString();
            MaMax = MaMax.Substring(MaMax.Length - 2, 2);
            int max = int.Parse(MaMax);
            max++;
            if (max < 10)
            {
                return "DV0" + max.ToString();
            }
            close();
            return "DV" + max.ToString();
        }

        public int InsertDichVu(DichVu dv)
        {
            db.close();
            db.Cmd.CommandText = "INSERT INTO DiCHVU(MaDV,TenDV,LoaiDV,SLConLai,DonGia)" +
            "VALUES('" + dv.MaDV + "', N'" + dv.TenDV + "', N'" + dv.LoaiDV + "', '" + dv.SLConLai + "', '" + dv.DonGia + "')";
            return db.ExcuteNonQuery(db.Cmd.CommandText); ;
        }
        public int UpdateDichVu (DichVu dv)
        {
            db.close();
            db.Cmd.CommandText = "UPDATE DichVu set TenDV = N'"+dv.TenDV+"',LoaiDV = N'"+dv.LoaiDV+"', SLConLai= '"+dv.SLConLai+"', DonGia ='"+dv.DonGia+"' where MaDV = '"+dv.MaDV+"'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public DichVu TimDichVuDuaVaoMa(string ma)
        {
          
            DichVu dv = new DichVu();
            db.Cmd.CommandText = "SELECT *FROM DICHVU WHERE MaDV ='" + ma + "'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText); 
            if(Reader.Read())
            {
                dv.DonGia = float.Parse(Reader["DonGia"].ToString());
                dv.LoaiDV = Reader["LoaiDV"].ToString();
                dv.TenDV = Reader["TenDV"].ToString();
                dv.SLConLai = int.Parse(Reader["SLConLai"].ToString());
                dv.MaDV = Reader["MaDV"].ToString();
            }
            return dv;
        }

        public bool KTKhoaNgoai(string ma)
        {
            db.Cmd.CommandText = "SELECT  COUNT(*) FROM CTDV WHERE MaDV = '" + ma + "'";
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
        public int DeleteDichVu(string ma)
        {
            db.Cmd.CommandText = "DELETE DICHVU WHERE MADV ='" + ma + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public List<DichVu> dsTheoLoai(string loai)
        {
            List<DichVu> list = new List<DichVu>();
            db.Cmd.CommandText = "SELECT*FROM DICHVU WHERE LoaiDV = N'" + loai + "'";

            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                DichVu dv = new DichVu();
                dv.DonGia = float.Parse(Reader["DonGia"].ToString());
                dv.LoaiDV = Reader["LoaiDV"].ToString();
                dv.TenDV = Reader["TenDV"].ToString();
                dv.SLConLai = int.Parse(Reader["SLConLai"].ToString());
                dv.MaDV = Reader["MaDV"].ToString();
                list.Add(dv);
            }
            return list;
        }
    }
}
