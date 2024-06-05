using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{
    class PhongDAO : DbContext
    {
        DbContext Db = new DbContext();
        public List<Model.Entity.Phong> GetPhongs()
        {
            Db.close();
            List<Model.Entity.Phong> list = new List<Entity.Phong>();
            Db.Cmd.CommandText = "SELECT *,LoaiPhong.TenLPH" +
                " from Phong" +
                " Inner join LoaiPhong on LoaiPhong.MaLPH = phong.MaLPH";
           Db.Reader = Db.ExcuteQuery(Db.Cmd.CommandText);
            while(Db.Reader.Read())
            {
                Model.Entity.Phong p = new Entity.Phong();
                p.GhiChu = Db.Reader["GhiChu"].ToString();   
                p.MaPH = Db.Reader["MaPH"].ToString();
                p.TTDD = Db.Reader["TTDD"].ToString();
                p.TTPH = Db.Reader["TTPH"].ToString();
                p.Lp.MaLPH = Db.Reader["MaLPH"].ToString();
                p.Lp.TenLPH = Db.Reader["TenLPH"].ToString();
                
                list.Add(p);
            }
            return list;
        }

        public Model.Entity.Phong TimPhongTheoMa(string ma)
        {
            Model.Entity.Phong p = new Entity.Phong();
            Db.Cmd.CommandText = "SELECT*FROM PHONG WHERE MAPH ='" + ma + "'";
            Reader = Db.ExcuteQuery(Db.Cmd.CommandText);
            if(Reader.Read())
            {
                p.GhiChu = Reader["GhiChu"].ToString();
                p.MaPH = Reader["MaPH"].ToString();
                p.TTDD = Reader["TTDD"].ToString();
                p.TTPH = Reader["TTPH"].ToString();
                p.Lp.MaLPH = Reader["MaLPH"].ToString();
            }
            return p;
        }
        public bool KTKhoaNgoai(string ma)
        {
            Db.Cmd.CommandText="SELECT COUNT(*) FROM CTDP WHERE MaPH = '"+ma+"'" ;
            int kt = (int)Db.ExcuteScalar(Db.Cmd.CommandText);
            if(kt>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int InsertPhong(Model.Entity.Phong p)
        {
            Db.close();
            Db.Cmd.CommandText = "INSERT INTO PHONG VALUES('" + p.MaPH + "',N'" + p.TTPH + "',N'" + p.TTDD + "',N'" + p.GhiChu + "','" + p.Lp.MaLPH +"')";
            return Db.ExcuteNonQuery(Db.Cmd.CommandText);
        }
        public int UpdatePhong(Model.Entity.Phong p)
        {
            Db.close();
            Db.Cmd.CommandText = "UPDATE PHONG SET TTPH = N'"+p.TTPH+"',TTDD=N'"+p.TTDD+"',GhiChu =N'"+p.GhiChu+"',MaLPH ='"+p.Lp.MaLPH+"' WHERE MaPH = '"+p.MaPH+"'";
            return Db.ExcuteNonQuery(Db.Cmd.CommandText);
        }
        public int UpdatePhongChuaDonDep(Model.Entity.Phong p)
        {
            Db.Cmd.CommandText = "UPDATE PHONG SET TTPH = N'" + p.TTPH + "',TTDD=N'" + p.TTDD + "',GhiChu =N'" + p.GhiChu+"' WHERE MaPH = '" + p.MaPH + "'";
            return Db.ExcuteNonQuery(Db.Cmd.CommandText);
        }
        public int DeletePhong(string ma)
        {
            Db.Cmd.CommandText="DELETE PHONG WHERE MAPH = '"+ma+"'";
            return Db.ExcuteNonQuery(Db.Cmd.CommandText); 
        }

        public List<Model.Entity.Phong> PSearch(string ma)
        {
            List<Model.Entity.Phong> list = new List<Model.Entity.Phong>();
            Db.Cmd.CommandText = "SELECT *FROM PHONG WHERE MaPH like N'%"+ma+"%'";
           
            Reader = Db.ExcuteQuery(Db.Cmd.CommandText); 
            while (Reader.Read())
            {
                Model.Entity.Phong p = new Entity.Phong();
                p.GhiChu = Reader["GhiChu"].ToString();
                p.MaPH = Reader["MaPH"].ToString();
                p.TTDD = Reader["TTDD"].ToString();
                p.TTPH = Reader["TTPH"].ToString();
                p.Lp.MaLPH = Reader["MaLPH"].ToString();
                list.Add(p);
            }
            return list;
        }
        public List<Model.Entity.Phong> dsPhongTTDD(string ten)
        {
            List<Model.Entity.Phong> list = new List<Entity.Phong>();
            Db.Cmd.CommandText = "SELECT*FROM PHONG WHERE TTDD = N'" + ten + "'";
            Reader = Db.ExcuteQuery(Db.Cmd.CommandText);
            while(Reader.Read())
            {
                Model.Entity.Phong p = new Entity.Phong();
                p.GhiChu = Reader["GhiChu"].ToString();
                p.MaPH = Reader["MaPH"].ToString();
                p.TTDD = Reader["TTDD"].ToString();
                p.TTPH = Reader["TTPH"].ToString();
                p.Lp.MaLPH = Reader["MaLPH"].ToString();
                list.Add(p);
            }
            return list;
        }

        public List<Model.Entity.Phong> dsLoaiPhong(string ten)
        {
            List<Model.Entity.Phong> list = new List<Entity.Phong>();
            Db.Cmd.CommandText = "SELECT *FROM PHONG WHERE MaLPH = '" + ten + "'";
            Reader = Db.ExcuteQuery(Db.Cmd.CommandText);
            while (Reader.Read())
            {
                Model.Entity.Phong p = new Entity.Phong();
                p.GhiChu = Reader["GhiChu"].ToString();
                p.MaPH = Reader["MaPH"].ToString();
                p.TTDD = Reader["TTDD"].ToString();
                p.TTPH = Reader["TTPH"].ToString();
                p.Lp.MaLPH = Reader["MaLPH"].ToString();
                list.Add(p);
            }
            return list;
        }
       
    }
}

