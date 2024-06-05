using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{
    public class ChiTietTienNghiDAO
    {
        DbContext db = new DbContext();

        public int UpdateChiTietTienNghiCuaPhong(Model.Entity.ChiTietTienNghi cttn)
        {
            db.Cmd.CommandText = "UPDATE CTTN" +
                " SET SL = '" + cttn.SL + "'" +
                " WHERE MaLPH ='"+cttn.MaLPH+"' and MaTN = '"+cttn.MaTN+"'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public int DeleteChiTietTienNghiCuaPhong(string ma)
        {
            db.close();
            db.Cmd.CommandText = "DELETE CTTN WHERE MaTN = '" + ma+ "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }

        public int InsertChiTietTienNghiCuaPhong(Model.Entity.ChiTietTienNghi cttn)
        {
            db.Cmd.CommandText = "INSERT INTO CTTN (MaLPH,MaTN, SL)" +
                "VALUES('"+cttn.MaLPH+"', '"+cttn.MaTN+"', '"+cttn.SL+"')";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
    }
}
