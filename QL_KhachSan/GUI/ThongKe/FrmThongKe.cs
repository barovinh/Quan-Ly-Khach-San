using QL_KhachSan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QL_KhachSan.GUI.ThongKe
{
    public partial class FrmThongKe : Form
    {
        DbContext db = new DbContext();
        public FrmThongKe()
        {
            InitializeComponent();
            loadDoanhThuHomNay(); 
            loadSoPhongTrong();
            loadSoPhongDaDat();
            loadSoPhongDangThue();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {

        }
        public void loadDoanhThuHomNay()
        {
       
            db.Cmd.CommandText = "EXEC DoanhThuHomNay";
            db.Reader = db.ExcuteQuery(db.Cmd.CommandText);
            float tongDT = 0;
            if(db.Reader.Read())
            {
                tongDT = float.Parse(db.Reader[0].ToString());
            }
            db.Reader.Close();
            lblDoanhThuHomNay.Text = tongDT.ToString("N0") + " VND";
        }
        public void loadSoPhongDangThue()
        {
            db.Cmd.CommandText = "EXEC GetSoPhongDangThueHomNay";
            db.Reader = db.ExcuteQuery(db.Cmd.CommandText);
            int sop = 0;
            if(db.Reader.Read())
            {
                sop = int.Parse(db.Reader[0].ToString());

            }
            db.Reader.Close();

            lblSoPhongDangThue.Text = sop.ToString();
        }
        public void loadSoPhongDaDat()
        {
            db.Cmd.CommandText = "EXEC GetSoPhongDaDatHomNay";
            db.Reader = db.ExcuteQuery(db.Cmd.CommandText);
            int sop = 0;
            if (db.Reader.Read())
            {
                sop = int.Parse(db.Reader[0].ToString());

            }
            db.Reader.Close();

            lblSoPhongDangDat.Text = sop.ToString();
        }
        public void loadSoPhongTrong()
        {
            db.Cmd.CommandText = "EXEC GetSoPhongTrongHomNay";
            db.Reader = db.ExcuteQuery(db.Cmd.CommandText);
            int sop = 0;
            if (db.Reader.Read())
            {
                sop = int.Parse(db.Reader[0].ToString());

            }
            db.Reader.Close();
            lblSoPhongDangTrong.Text = sop.ToString();
        }


        // xử lý chart
        void clearChart()
        {
            chart.Series["Doanh thu"].Points.Clear();

        }
        void loadChart(string query)
        {
 
            DataTable dt = db.getDatatable(query);
            if (dt.Rows.Count > 0)
            {
                chart.Series["Doanh thu"].XValueType = ChartValueType.Auto;
                chart.ChartAreas["ChartArea1"].AxisX.Title = "Ngày";
                if (cbDate.SelectedItem.ToString() == "Năm nay")
                {
                    chart.Series["Doanh thu"].XValueType = ChartValueType.String;

                    chart.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
                }


                chart.ChartAreas["ChartArea1"].AxisY.Title = "Số tiền";
                chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                chart.Series["Doanh thu"]["DrawingStyle"] = "Cylinder";
                chart.Series["Doanh thu"].LabelFormat = "{0:0,0} VNĐ";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart.Series["Doanh thu"].Points.AddXY(dt.Rows[i]["NgayLap"], dt.Rows[i]["TongTienTongCong"]);
                }
                loadTongDoanhThu();
            }

        }
        void loadTongDoanhThu()
        {
            double tong = 0;

            // Tạo DataTable
            // doanh thu được tính theo biểu đồ chart
            foreach (var item in chart.Series["Doanh thu"].Points)
            {
                double value = item.YValues[0];
                tong += value;
            }
            string temp = string.Format("{0:N0} VNĐ", tong);
            lblTongDoanhThu.Text = temp;
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearChart();
            string query = "";
            if (cbDate.SelectedItem.ToString() == "7 ngày qua")
            {
                query = @"SELECT CAST(NgayLap AS DATE) AS NgayLap, SUM(TriGia) AS TongTienTongCong
                     FROM HOADON
                    WHERE NgayLap >= DATEADD(DAY, -7, GETDATE()) AND NgayLap <= GETDATE() and TrangThai = N'Đã thanh toán'
                     GROUP BY CAST(NgayLap AS DATE)
                    ORDER BY CAST(NgayLap AS DATE) ASC;
                ";

            }
            if (cbDate.SelectedItem.ToString() == "Hôm nay")
            {
                query = @"SELECT 
                        CAST(NgayLap AS DATE) AS NgayLap,
                        SUM(TriGia) AS TongTienTongCong
                    FROM HoaDon
                    WHERE CAST(NgayLap AS DATE) = CAST(GETDATE() AS DATE) and TrangThai = N'Đã thanh toán'
                    GROUP BY CAST(NgayLap AS DATE)
                    ORDER BY CAST(NgayLap AS DATE) ASC;
                ";
            }
            if (cbDate.SelectedItem.ToString() == "Hôm qua")
            {
                query = @"SELECT CAST(NgayLap AS DATE) AS NgayLap, SUM(TriGia) AS TongTienTongCong
                    FROM HOADON
                   WHERE CAST(NgayLap AS DATE) = CAST(DATEADD(DAY, -1, GETDATE()) AS DATE) AND TrangThai = N'Đã thanh toán'
                   GROUP BY CAST(NgayLap AS DATE)
                   ORDER BY CAST(NgayLap AS DATE) ASC; ";
            }
            if (cbDate.SelectedItem.ToString() == "Tháng trước")
            {
                query = @"SELECT CAST(NgayLap AS DATE) AS NgayLap, SUM(TriGia) AS TongTienTongCong
                     FROM HOADON
                     WHERE DATEPART(YEAR, NgayLap) = DATEPART(YEAR, DATEADD(MONTH, -1, GETDATE()))
                    AND DATEPART(MONTH, NgayLap) = DATEPART(MONTH, DATEADD(MONTH, -1, GETDATE()))
                     AND TrangThai = N'Đã thanh toán'
                    GROUP BY CAST(NgayLap AS DATE)
                    ORDER BY CAST(NgayLap AS DATE) ASC; ";
            }
            if (cbDate.SelectedItem.ToString() == "Tháng này")
            {
                query = @"SELECT CAST(NgayLap AS DATE) AS NgayLap, SUM(TriGia) AS TongTienTongCong
        FROM HOADON
         WHERE DATEPART(YEAR, NgayLap) = DATEPART(YEAR, GETDATE())
         AND DATEPART(MONTH, NgayLap) = DATEPART(MONTH, GETDATE())
        AND TrangThai = N'Đã thanh toán'
        GROUP BY CAST(NgayLap AS DATE)
        ORDER BY CAST(NgayLap AS DATE) ASC; ";
            }
            if (cbDate.SelectedItem.ToString() == "Năm nay")
            {
                query = @"SELECT MONTH(HOADON.NgayLap) AS NgayLap, SUM(TriGia) as TongTienTongCong
                     FROM HOADON
                     WHERE YEAR(HOADON.NgayLap) = DATEPART(YEAR, GETDATE()) AND TrangThai = N'Đã thanh toán' GROUP BY MONTH(HOADON.NgayLap)
                    ORDER BY  MONTH(HOADON.NgayLap)";
            }
            loadChart(query);

        }
        private void cbDate_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

      
    }
}
