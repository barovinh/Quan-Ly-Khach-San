using QL_KhachSan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{
    class TienNghiDAO :DbContext
    {
        DbContext db = new DbContext();
        public List<TienNghi> GetTienNghis()
        {
            List<TienNghi> tienNghis = new List<TienNghi>();
            db.Cmd.CommandText = "SELECT*FROM TIENNGHI";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while(Reader.Read())
            {
                TienNghi tn = new TienNghi();
                tn.MaTN = Reader["MaTN"].ToString();
                tn.TenTN = Reader["TenTN"].ToString();
                tienNghis.Add(tn);
            }
            return tienNghis;
        }
        public List<TienNghi> TimTenTienNghi(string ten)
        {
            List<TienNghi> list = new List<TienNghi>();
            db.Cmd.CommandText = "SELECT*FROM TIENNGHI WHERE TENTN LIKE N'%" + ten + "%'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while(Reader.Read())
            {
                TienNghi tn = new TienNghi();
                tn.MaTN = Reader["MaTN"].ToString();
                tn.TenTN = Reader["TenTN"].ToString();
                list.Add(tn);
            }
            return list;
        }
        public int UpdateTienNghi(TienNghi tn)
        {
            db.close();
            db.Cmd.CommandText = "UPDATE TIENNGHI SET TENTN = N'" + tn.TenTN + "' where MaTN = '" + tn.MaTN + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public bool KTKhoaNgoai(string ma)
        {
            db.Cmd.CommandText = "SELECT COUNT(*) FROM CTTN WHERE MATN = '" + ma + "'";
            int kt = (int)db.ExcuteScalar(db.Cmd.CommandText);
            if(kt>0)
            {
                return true; // là khóa ngoại
            }
            else
            {
                return false;
            }
        }
        public int DeleteTienNghi(string ma)
        {
            db.Cmd.CommandText = "DELETE TIENNGHI WHERE MaTN = '" + ma + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);

        }
        public string GetMaTNNext()
        {
            List<TienNghi> list = GetTienNghis();
            if(list.Count==0)
            {
                return "TN01";
            }
            string MaMax = list[list.Count - 1].MaTN.ToString();
            MaMax = MaMax.Substring(MaMax.Length - 2, 2);
            int max = int.Parse(MaMax);
            max++;
            if (max < 10)
            {
                return "TN0" + max.ToString();
            }
            close();
            return "TN" + max.ToString();
        }

        public int InsertTienNghi(TienNghi tn)
        {
            db.close();
            db.Cmd.CommandText = "INSERT INTO TienNghi(MaTN,TenTN)" +
            "VALUES('" + tn.MaTN + "', N'" + tn.TenTN + "')";
            return db.ExcuteNonQuery(db.Cmd.CommandText); ;
        }
        public int UpdateTienNghi(DichVu dv)
        {
          
            db.Cmd.CommandText = "UPDATE DichVu set TenDV = N'" + dv.TenDV + "',LoaiDV = N'" + dv.LoaiDV + "', SLConLai= '" + dv.SLConLai + "', DonGia ='" + dv.DonGia + "' where MaDV = '" + dv.MaDV + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public TienNghi TimDichVuDuaVaoMa(string ma)
        {
            TienNghi tn = new TienNghi();
          
            db.Cmd.CommandText = "SELECT *FROM TIENNGHI WHERE MaTN ='" + ma + "'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            if (Reader.Read())
            {
                tn.MaTN = Reader["MaTN"].ToString();
                tn.TenTN = Reader["TenTN"].ToString();
            }
            return tn;
        }
    }
}
