using QL_KhachSan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Model.DAO
{
    class ChiTietDatPhongDAO : DbContext
    {
        DbContext db = new DbContext();
        public List<ChiTietDatPhong> GetChiTietDatPhongs()
        {
            db.close();
            List<ChiTietDatPhong> list = new List<ChiTietDatPhong>();
            db.Cmd.CommandText = "SELECT*FROM CTDP";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                ChiTietDatPhong ct = new ChiTietDatPhong();
                ct.MaCTDP = Reader["MaCTDP"].ToString();
                ct.SoNguoi = int.Parse(Reader["SoNguoi"].ToString());
                ct.TrangThai = Reader["TrangThai"].ToString();
                ct.TheoGio = Convert.ToBoolean(Reader["TheoGio"]);
                ct.Phong.MaPH = Reader["MaPH"].ToString();
                ct.DonGia = float.Parse(Reader["DonGia"].ToString());
                ct.MaPT = Reader["MaPT"].ToString();
                ct.ThanhTien = float.Parse(Reader["ThanhTien"].ToString());
                DateTime ngayCheckIn;

                if (DateTime.TryParse(Reader["CheckIn"].ToString().ToString(), out ngayCheckIn))
                {
                    ct.CheckIn = ngayCheckIn;
                }
                DateTime ngayCheckOut;
                if (DateTime.TryParse(Reader["CheckOut"].ToString(), out ngayCheckOut))
                {
                    ct.CheckOut = ngayCheckOut;
                }
                list.Add(ct);
            }
            return list;
        }
        public List<Phong> ListPhongTrongOnTime(DateTime Checkin, DateTime Checkout)
        {
            db.Cmd.CommandText = @"DECLARE @CheckInCheckOut TABLE (CheckIn DATETIME, CheckOut DATETIME);
                INSERT INTO @CheckInCheckOut VALUES (@checkin, @checkout);

                                 SELECT DISTINCT P.MaPH, P.TTPH, P.TTDD, P.GhiChu, LP.TenLPH, LP.MaLPH
                        FROM Phong P
                        JOIN LoaiPhong LP ON P.MaLPH = LP.MaLPH
                        WHERE 
                            P.MaPH NOT IN (
                                SELECT CTDP.MaPH 
                                FROM CTDP
                                WHERE 
                                    (
                                        (@CheckIn BETWEEN CTDP.CheckIn AND CTDP.CheckOut)
                                        OR (@CheckOut BETWEEN CTDP.CheckIn AND CTDP.CheckOut)
                                        OR (CTDP.CheckIn BETWEEN @CheckIn AND @CheckOut)
                                        OR (CTDP.CheckOut BETWEEN @CheckIn AND @CheckOut)
                                    )
                                    AND (CTDP.TrangThai = N'Đã đặt' OR CTDP.TrangThai = N'Đã xong' OR CTDP.TrangThai = N'Đang thuê')
                            );
                        ";
            string CheckinTimeString = Checkin.ToString("yyyy-MM-dd HH:mm:ss");
            string CheckoutTimeString = Checkout.ToString("yyyy-MM-dd HH:mm:ss");

            db.open();

            db.Cmd.Parameters.AddWithValue("@checkin", CheckinTimeString);
            db.Cmd.Parameters.AddWithValue("@checkout", CheckoutTimeString);

            Reader = db.Cmd.ExecuteReader();

            List<Phong> list = new List<Phong>();

            if (Reader.HasRows)
            {
                while (Reader.Read())
                {
                    Phong p = new Phong();
                    p.MaPH = Reader["MaPH"].ToString();
                    p.TTPH = Reader["TTPH"].ToString();
                    p.TTDD = Reader["TTDD"].ToString();
                    p.GhiChu = Reader["GhiChu"].ToString();
                    p.Lp.TenLPH = Reader["TenLPH"].ToString();
                    p.Lp.MaLPH = Reader["MaLPH"].ToString();
                    list.Add(p);
                }
            }
            Reader.Close();
            db.close();

            return list;

        }
        // ý tưởng là truyền vào mã phòng, thời gian checkin sẽ là thời gian checkout cũ
        // thời gian checkout sẽ là thời gian được select
        // nếu sau khi duyệt qua các khoảng thời gian trong ctdp mà danh sách trả về rỗng
        // thì isbooked sẽ được trả về 0 
        // ngược lại có người thuê tiếp theo thì trả về 1
        public int KiemTraGiaHanPhong(string maph, DateTime checkin, DateTime checkout)
        {
            int isBooked = 0;

            try
            {
                db.Cmd.CommandText = @"
            DECLARE @MaPhong VARCHAR(5) = @MaPhongParam;
            DECLARE @NextCheckIn DATETIME = @NextCheckInParam;
            DECLARE @NextCheckOut DATETIME = @NextCheckOutParam;

            DECLARE @IsBooked BIT;

            IF EXISTS (
                SELECT 1
                FROM CTDP
                WHERE MaPH = @MaPhong
                    AND CheckIn < @NextCheckOut
                    AND CheckOut > @NextCheckIn
            )
            BEGIN
                -- Phòng đã được đặt cho khoảng thời gian tiếp theo
                SET @IsBooked = 1;
            END
            ELSE
            BEGIN
                -- Phòng chưa được đặt cho khoảng thời gian tiếp theo
                SET @IsBooked = 0;
            END

            -- Trả về kết quả
            SELECT @IsBooked AS IsBooked;";

                string CheckinTimeString = checkin.ToString("yyyy-MM-dd HH:mm:ss");
                string CheckoutTimeString = checkout.ToString("yyyy-MM-dd HH:mm:ss");
                db.Cmd.Parameters.AddWithValue("@MaPhongParam", maph);
                db.Cmd.Parameters.AddWithValue("@NextCheckInParam", CheckinTimeString);
                db.Cmd.Parameters.AddWithValue("@NextCheckOutParam", CheckoutTimeString);

                object result = db.Cmd.ExecuteScalar();

                if (result != null)
                {
                    isBooked = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return isBooked;
        }
        // gia hạn phòng 
        public int GiaHanPhong(string maCTDP, DateTime checkout)
        {
            db.close();

            string currentTimeString = checkout.ToString("yyyy-MM-dd HH:mm:ss");
            db.Cmd.CommandText = "UPDATE CTDP set Checkout = '" + currentTimeString + "'" + " where MaCTDP = '" + maCTDP + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public ChiTietDatPhong TimCTDP(string maphong, DateTime currentTime)
        {
            db.close();
            ChiTietDatPhong ct = new ChiTietDatPhong();
            string currentTimeString = currentTime.ToString("yyyy-MM-dd HH:mm:ss");

            string sql = "SELECT * FROM CTDP " +
                "WHERE MaPH = '" + maphong + "' AND((CheckIn <= '" + currentTimeString + "' AND '" + currentTimeString + "' <= CheckOut) " +
                "OR CheckIn = GETDATE())AND TrangThai NOT IN('Đã xong', 'Đã hủy')";
            Reader = db.ExcuteQuery(sql);
            while (Reader.Read())
            {
                ct.MaCTDP = Reader["MaCTDP"].ToString();
                ct.SoNguoi = int.Parse(Reader["SoNguoi"].ToString());
                ct.TrangThai = Reader["TrangThai"].ToString();
                ct.TheoGio = Convert.ToBoolean(Reader["TheoGio"]);
                ct.Phong.MaPH = Reader["MaPH"].ToString();
                ct.MaPT = Reader["MaPT"].ToString();
                ct.ThanhTien = float.Parse(Reader["ThanhTien"].ToString());
                DateTime ngayCheckIn;

                if (DateTime.TryParse(Reader["CheckIn"].ToString().ToString(), out ngayCheckIn))
                {
                    ct.CheckIn = ngayCheckIn;
                }
                DateTime ngayCheckOut;
                if (DateTime.TryParse(Reader["CheckOut"].ToString(), out ngayCheckOut))
                {
                    ct.CheckOut = ngayCheckOut;
                }
            }
            if (ct.MaCTDP == null)
            {
                return null;
            }
            return ct;
        }
        public string getNextCTDP()
        {
            List<ChiTietDatPhong> cTDPs;

            cTDPs = GetChiTietDatPhongs();
            if (cTDPs.Count == 0)
            {
                return "CTDP000";
            }
            string MaMax = cTDPs[cTDPs.Count - 1].MaCTDP.ToString();
            MaMax = MaMax.Substring(MaMax.Length - 3, 3);
            int max = int.Parse(MaMax);
            max++;
            if (max < 10)
            {
                return "CTDP00" + max.ToString();
            }
            else if (max < 100)
            {
                return "CTDP0" + max.ToString();
            }
            return "CTDP" + max.ToString();
        }


        public int deletCTDPHuyPhong(string ma)
        {
            db.close();
            db.Cmd.CommandText = "DELETE CTDP WHERE MaPT = '" + ma + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public int InsertCTDP(ChiTietDatPhong ctdp)
        {
            db.close();
            string checkin = ctdp.CheckIn.ToString("yyyy-MM-dd HH:mm:ss");
            string checkout = ctdp.CheckOut.ToString("yyyy-MM-dd HH:mm:ss");
            db.Cmd.CommandText = "INSERT INTO CTDP(MaCTDP,MaPT,MaPH,CheckIn,CheckOut,TrangThai,ThanhTien,DonGia,SoNguoi,TheoGio) " +
                " VALUES('" + ctdp.MaCTDP + "','" + ctdp.MaPT + "','" + ctdp.Phong.MaPH + "','" + checkin + "','" + checkout + "',N'" + ctdp.TrangThai + "','0','0','" + ctdp.SoNguoi + "','" + ctdp.TheoGio + "')";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        public int updateCTDPNhanPhong(ChiTietDatPhong ctdp)
        {
            db.close();
            string checkin = ctdp.CheckIn.ToString("yyyy-MM-dd HH:mm:ss");
            db.Cmd.CommandText = "UPDATE CTDP" +
                " SET TrangThai = N'" + ctdp.TrangThai + "', CheckIn = '" + checkin + "'" +
                " WHERE MaPT = '" + ctdp.MaPT + "' and MaPH = '" + ctdp.Phong.MaPH + "' and MaCTDP ='" + ctdp.MaCTDP + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);

        }
        
        public int updateCTDPDaXong(ChiTietDatPhong ctdp)
        {
            db.close();
            db.Cmd.CommandText = "UPDATE CTDP " +
                " SET TRANGTHAI = N'Đã xong'" +
                " WHERE MaPT ='" + ctdp.MaPT + "' and MaPH='" + ctdp.Phong.MaPH + "' and MaCTDP ='" + ctdp.MaCTDP + "'";
            return db.ExcuteNonQuery(db.Cmd.CommandText);
        }
        // trigger updatectdpsatus đã được bỏ đi do không hoạt động đúng
        // ảnh hưởng đến việc đổi phòng vì trigger đã đè lại
        public int updateCTDPDoiPhong(ChiTietDatPhong ctdp, string maphong)
        {
            try
            {
                //db.Cmd.CommandText = "DISABLE TRIGGER trg_UpdateCTDPStatus ON CTDP";
                //db.ExcuteNonQuery(db.Cmd.CommandText);

                db.Cmd.CommandText = "UPDATE CTDP SET MaPH = '" + maphong + "' WHERE MaCTDP = '" + ctdp.MaCTDP + "'";

                int result = db.ExcuteNonQuery(db.Cmd.CommandText);

                //// Kích hoạt lại trigger sau khi cập nhật
                //db.Cmd.CommandText = "ENABLE TRIGGER trg_UpdateCTDPStatus ON CTDP";
                //db.ExcuteNonQuery(db.Cmd.CommandText);

                return result;
            }
            catch (Exception ex)
            {
                return -1; 
            }
        }


        public string getMaPT(string MaCTDP)
        {
            db.close();
            db.Cmd.CommandText = "SELECT MaPT from CTDP where MaCTDP = '" + MaCTDP + "'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            string mapt = "";
            if (Reader.Read())
            {
                mapt = Reader["MaPT"].ToString();
            }
            return mapt;
        }
        public List<ChiTietDatPhong> dsSearchPhong(string maph)
        {
            db.close();
            db.Cmd.CommandText = "SELECT*FROM CTDP WHERE MaPH ='" + maph + "'";
            List<ChiTietDatPhong> list = new List<ChiTietDatPhong>();
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                ChiTietDatPhong ct = new ChiTietDatPhong();
                ct.MaCTDP = Reader["MaCTDP"].ToString();
                ct.SoNguoi = int.Parse(Reader["SoNguoi"].ToString());
                ct.TrangThai = Reader["TrangThai"].ToString();
                ct.TheoGio = Convert.ToBoolean(Reader["TheoGio"]);
                ct.Phong.MaPH = Reader["MaPH"].ToString();
                ct.DonGia = float.Parse(Reader["DonGia"].ToString());
                ct.MaPT = Reader["MaPT"].ToString();
                ct.ThanhTien = float.Parse(Reader["ThanhTien"].ToString());
                DateTime ngayCheckIn;

                if (DateTime.TryParse(Reader["CheckIn"].ToString().ToString(), out ngayCheckIn))
                {
                    ct.CheckIn = ngayCheckIn;
                }
                DateTime ngayCheckOut;
                if (DateTime.TryParse(Reader["CheckOut"].ToString(), out ngayCheckOut))
                {
                    ct.CheckOut = ngayCheckOut;
                }
                list.Add(ct);
            }
            return list;
        }
        public ChiTietDatPhong getCTDPTheoMaCTDP(string ma)
        {
            db.close();
            db.Cmd.CommandText = "SELECT*FROM CTDP where MaCTDP = '" + ma + "'";
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            ChiTietDatPhong ct = new ChiTietDatPhong();
            while (Reader.Read())
            {
                ct.MaCTDP = Reader["MaCTDP"].ToString();
                ct.SoNguoi = int.Parse(Reader["SoNguoi"].ToString());
                ct.TrangThai = Reader["TrangThai"].ToString();
                ct.TheoGio = Convert.ToBoolean(Reader["TheoGio"]);
                ct.Phong.MaPH = Reader["MaPH"].ToString();
                ct.MaPT = Reader["MaPT"].ToString();
                ct.ThanhTien = float.Parse(Reader["ThanhTien"].ToString());
                DateTime ngayCheckIn;

                if (DateTime.TryParse(Reader["CheckIn"].ToString().ToString(), out ngayCheckIn))
                {
                    ct.CheckIn = ngayCheckIn;
                }
                DateTime ngayCheckOut;
                if (DateTime.TryParse(Reader["CheckOut"].ToString(), out ngayCheckOut))
                {
                    ct.CheckOut = ngayCheckOut;
                }
            }
            if (ct.MaCTDP == null)
            {
                return null;
            }
            return ct;
        }
    // danh sách còn chi tiết phòng còn thời gian 30p để trả phòng và phòng hết thời gian thuê nhưng chưa thanh toán
        public List<ChiTietDatPhong> dsPhongCheckout()
        {
            List<ChiTietDatPhong> list = new List<ChiTietDatPhong>();
            db.close();

            db.Cmd.CommandText=
                @"
              -- Lấy ra các bản ghi mà thời gian thuê đã hết nhưng vẫn có trạng thái đang thuê
                SELECT*
                FROM CTDP
        WHERE CheckOut < GETDATE()-- Thời gian thuê đã hết
           AND TrangThai = N'Đang thuê'-- Trạng thái đang thuê

        UNION ALL

        --Lấy ra các bản ghi mà thời gian checkout sắp hết(trong vòng 30 phút) và trạng thái không phải Đã xong
        SELECT*
        FROM CTDP
        WHERE TrangThai != N'Đã xong'-- Trạng thái không phải Đã xong
    AND CheckOut BETWEEN GETDATE() AND DATEADD(MINUTE, 30, GETDATE()); --Thời gian checkout trong vòng 30 phút
            ";
            ChiTietDatPhong ct = new ChiTietDatPhong();
            Reader = db.ExcuteQuery(db.Cmd.CommandText);
            while (Reader.Read())
            {
                ct.MaCTDP = Reader["MaCTDP"].ToString();
                ct.SoNguoi = int.Parse(Reader["SoNguoi"].ToString());
                ct.TrangThai = Reader["TrangThai"].ToString();
                ct.TheoGio = Convert.ToBoolean(Reader["TheoGio"]);
                ct.Phong.MaPH = Reader["MaPH"].ToString();
                ct.MaPT = Reader["MaPT"].ToString();
                ct.ThanhTien = float.Parse(Reader["ThanhTien"].ToString());
                DateTime ngayCheckIn;

                if (DateTime.TryParse(Reader["CheckIn"].ToString().ToString(), out ngayCheckIn))
                {
                    ct.CheckIn = ngayCheckIn;
                }
                DateTime ngayCheckOut;
                if (DateTime.TryParse(Reader["CheckOut"].ToString(), out ngayCheckOut))
                {
                    ct.CheckOut = ngayCheckOut;
                }
                list.Add(ct);
            }
            return list;
        }
        // Cái này để updadte thời gian phòng trả khi mà nhân viên ko nhấn vào thanh toán
        // nếu đúng hơn sẽ không được gọi ra trong time_tick mà sẽ được dùng cho sql agent
        // vì lí do khách quan nên không tìm hiểu sql agent được. 

    //    public int UpdateThoiGianThuc()
    //    {
    //        db.close();

    //        // Câu lệnh SQL để cập nhật trạng thái của bản ghi trong bảng CTDP
    //        string sql = @"
    //                   DECLARE @MaCTDP VARCHAR(7);
    //            DECLARE @TrangThai NVARCHAR(20);

    //            DECLARE ctdp_cursor CURSOR FOR
    //            SELECT MaCTDP, TrangThai
    //            FROM CTDP
    //            WHERE CheckOut < GETDATE();

    //            OPEN ctdp_cursor;
    //            FETCH NEXT FROM ctdp_cursor INTO @MaCTDP, @TrangThai;

    //            WHILE @@FETCH_STATUS = 0
    //            BEGIN
    //                UPDATE CTDP
    //                SET TrangThai = N'Đã xong'
    //                WHERE MaCTDP = @MaCTDP;

    //                FETCH NEXT FROM ctdp_cursor INTO @MaCTDP, @TrangThai;
    //            END

    //            CLOSE ctdp_cursor;
    //            DEALLOCATE ctdp_cursor;
    //";

    //        // cách 2 
    //    //    string sql = @"
    //    //UPDATE CTDP
    //    //SET TrangThai = N'Đã xong'
    //    //WHERE CheckOut < GETDATE()
    //    //  AND TrangThai != N'Đã xong';";

    //        return db.ExcuteNonQuery(sql);
    //    }

    }
}
