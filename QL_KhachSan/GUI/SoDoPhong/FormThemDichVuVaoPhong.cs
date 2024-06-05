using QL_KhachSan.Model;
using QL_KhachSan.Model.DAO;
using QL_KhachSan.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan.GUI.SoDoPhong
{
    public partial class FormThemDichVuVaoPhong : Form
    {
        DbContext db = new DbContext();
        private Image add = Properties.Resources.Add;
        private Image delete = Properties.Resources.delete1;
        List<Model.Entity.DichVu> dichVus;
        public Model.Entity.ChiTietDatPhong CTDP { get; set; }
        public TaiKhoan TK { get; set; }
        public FormThemDichVuVaoPhong(Model.Entity.ChiTietDatPhong ctdp,TaiKhoan tk)
        {
            InitializeComponent();
            CTDP = ctdp;
            TK = tk;
            LoadDichVu();
        }

        private void FormThemDichVuVaoPhong_Load(object sender, EventArgs e)
        {

        }
        public void LoadDichVu()
        {
            dataGridViewDichVu.Rows.Clear();
            DichVuDAO dvDAO = new DichVuDAO();
            dichVus = dvDAO.getDichVus();
            foreach (var item in dichVus)
            {
                if (item.SLConLai == -1)
                {
                    item.SLConLai = 1;
                }
                dataGridViewDichVu.Rows.Add(item.TenDV, item.SLConLai.ToString(), item.DonGia, this.add, item.MaDV);

            }
            dataGridViewDichVu.Columns["MaDV"].Visible = false;
        }
     

        private void dt_DaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDichVu();
        }


        private void dataGridViewDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewDichVu.Columns["Them"].Index)
            {
                DataGridViewRow rowAtIndex = dataGridViewDichVu.Rows[e.RowIndex];
                // 1 là số lượng , 2 là đơn giá
                string madv = rowAtIndex.Cells[4].Value.ToString();
                int soluongconlai = int.Parse(rowAtIndex.Cells[1].Value.ToString());

                if (soluongconlai > 0)
                {
                    // xử lý giảm số lượng của bảng dịch vụ
                    soluongconlai--;
                    dataGridViewDichVu.Rows[e.RowIndex].Cells[1].Value = soluongconlai;
                  // xử lý trùng mã dịch vụ thì ++ số lượng lên
                    int soluongtang = 0;
                    int index = 0;
                    int flag = 0;
                    for (int i = 0; i < dataGridViewDaChon.Rows.Count; i++)
                    {
                        if(dataGridViewDaChon.Rows[i].Cells["MaDV2"].Value.ToString()==madv)
                        {
                            index = i;
                            flag = 1;
                            break;
                        }
                    }
                    if(flag==1)
                    {
                        soluongtang = int.Parse(dataGridViewDaChon.Rows[index].Cells[1].Value.ToString());
                        soluongtang++;
                        dataGridViewDaChon.Rows[index].Cells[1].Value = soluongtang;
                        float dongia = float.Parse(dataGridViewDaChon.Rows[index].Cells[2].Value.ToString());
                        float thanhtien = soluongtang * dongia;
                        dataGridViewDaChon.Rows[index].Cells[3].Value = thanhtien;
                    }
                    else
                    {
                        soluongtang = 0;
                        soluongtang++;
                        float dongia = float.Parse(rowAtIndex.Cells[2].Value.ToString());
                        float thanhtien = soluongtang * dongia;
                        dataGridViewDaChon.Rows.Add(rowAtIndex.Cells[0].Value.ToString(), soluongtang, dongia, thanhtien.ToString(), this.delete, rowAtIndex.Cells[4].Value.ToString());
                        dataGridViewDaChon.Columns["MaDV2"].Visible = false;
                    }
                         
                  
                }
                else
                {
                    MessageBox.Show("Dịch vụ đã hết");
                }


            }
          
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDaChon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewDichVu.Columns[4].Index)
            {
                DataGridViewRow rowAtIndex = dataGridViewDaChon.Rows[e.RowIndex];
                string madv = rowAtIndex.Cells[5].Value.ToString();
                int soluonghientai = int.Parse( rowAtIndex.Cells[1].Value.ToString());
                if(soluonghientai>1)
                {
                    int index = 0;
                    for (int i = 0; i < dataGridViewDichVu.Rows.Count; i++)
                    {
                        // so sánh mã dịch vụ của bảng dịch vụ và bảng đã chọn để cật nhật số lượng đúng vào vị trí
                        if (madv == dataGridViewDichVu.Rows[i].Cells[4].Value.ToString())
                        {
                            index = i;
                            break;
                        }
                    }
                    int soluongton = int.Parse(dataGridViewDichVu.Rows[index].Cells[1].Value.ToString());
                    soluongton++;
                    soluonghientai--;
                    dataGridViewDichVu.Rows[index].Cells[1].Value = soluongton;
                    // giảm số lượng của bảng đã chọn
                    dataGridViewDaChon.Rows[e.RowIndex].Cells[1].Value=soluonghientai;
                    //cật nhật thành tiền
                    float dongia = float.Parse(dataGridViewDaChon.Rows[e.RowIndex].Cells[2].Value.ToString());
                    float thanhtien = soluonghientai * dongia;
                    dataGridViewDaChon.Rows[e.RowIndex].Cells[3].Value = thanhtien;
                }
               else
                {
                    int index = 0;
                    for (int i = 0; i < dataGridViewDichVu.Rows.Count; i++)
                    {
                        // so sánh mã dịch vụ của bảng dịch vụ và bảng đã chọn để cật nhật số lượng đúng vào vị trí
                        if (madv == dataGridViewDichVu.Rows[i].Cells[4].Value.ToString())
                        {
                            index = i;
                            break; 
                       
                        }
                    }
                    int soluongton = int.Parse(dataGridViewDichVu.Rows[index].Cells[1].Value.ToString());
                    soluongton++;
                    dataGridViewDichVu.Rows[index].Cells[1].Value = soluongton;
                    // xóa khỏi bảng đã chọn
                    dataGridViewDaChon.Rows.RemoveAt(e.RowIndex);

                }
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ChiTietDichVuDAO ctdvDAO = new ChiTietDichVuDAO();
            for (int i = 0; i < dataGridViewDaChon.Rows.Count; i++)
            {
                Model.Entity.ChiTietDichVu ctdv = new Model.Entity.ChiTietDichVu();
                ctdv.DichVu.MaDV = dataGridViewDaChon.Rows[i].Cells[5].Value.ToString();
                ctdv.SoLuong = int.Parse(dataGridViewDaChon.Rows[i].Cells[1].Value.ToString());
                ctdv.DichVu.DonGia = float.Parse(dataGridViewDaChon.Rows[i].Cells[2].Value.ToString());
                ctdv.ThanhTien = ctdv.SoLuong * ctdv.DichVu.DonGia;
                ctdv.MaCTDP = CTDP.MaCTDP;
                bool check = ctdvDAO.KiemTraTonTaiMaDV(ctdv);
                if(check==true)
                {
                    ctdvDAO.UpDateCTDV(ctdv);

                }
                else
                {
                    ctdvDAO.ThemCTDichVu(ctdv);
                }
            }
            FormThongTinDangThue f = new FormThongTinDangThue(CTDP,TK);
          //  f.WindowState = FormWindowState.Normal;
            f.Show();
            this.Close();
        }

        private void FormThemDichVuVaoPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
