using QL_KhachSan.GUI.DichVu;
using QL_KhachSan.GUI.TienNghi;
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

namespace QL_KhachSan.GUI.Customer
{
    public partial class FormDanhSachKhachHang : Form
    {
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        public TaiKhoan TK { get; set; }
        List<Model.Entity.KhachHang> listKH = new List<Model.Entity.KhachHang>();
        public FormDanhSachKhachHang(TaiKhoan tk)
        {
            InitializeComponent();
            TK = tk;
            loadData();
            if(TK.CapQuyen ==2)
            {
                dataGridView1.Columns[6].Visible = true;
                dataGridView1.Columns[7].Visible = true;

            }
            else
            {
                dataGridView1.Columns[6].Visible =false;
                dataGridView1.Columns[7].Visible = false;
            }
        }
        void loadData()
        {
            this.dataGridView1.Rows.Clear();
            KhachHangDAO tnDAO = new KhachHangDAO();
            listKH = tnDAO.GetKhachHangs();
            foreach (var item in listKH)
            {
                dataGridView1.Rows.Add(item.MaKH, item.TenKH,item.SDT,item.CCCD,item.QuocTich,item.GioiTinh, this.edit, this.delete);
            }

        }

        private void txtTenKHCanTim_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKHCanTim.Focused == false)
            {
                loadData();
                return;
            }
            LoadResultSearch();
        }
        public void LoadResultSearch()
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Rows.Clear();
            KhachHangDAO KhDAO = new KhachHangDAO();
            List<Model.Entity.KhachHang> listT = KhDAO.TimTenKhachHang(txtTenKHCanTim.Text);
            foreach (var item in listT)
            {
                dataGridView1.Rows.Add(item.MaKH, item.TenKH, item.SDT, item.CCCD, item.QuocTich, item.GioiTinh, this.edit, this.delete);
            }
        }

        private void txtTenKHCanTim_Leave(object sender, EventArgs e)
        {
            if (txtTenKHCanTim.Text == "")
            {
                txtTenKHCanTim.Text = "Nhập tên khách hàng muốn tìm";

            }
        }

        private void txtTenKHCanTim_Enter(object sender, EventArgs e)
        {
            if (txtTenKHCanTim.Text == "Nhập tên khách hàng muốn tìm")
            {
                txtTenKHCanTim.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Sua"].Index)
            {
                Model.Entity.KhachHang kh = new KhachHangDAO().ThongTinKhachHangTheoMa(dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value.ToString());
                if (kh != null)
                {
                    new FormSuaKhachHang(kh).ShowDialog();
                    loadData();
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Xoa"].Index)
            {
                KhachHangDAO khDAO = new KhachHangDAO();
                if (khDAO.KTKhoaNgoai(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Không thể xóa vì đã dính khóa ngoại");
                }
                else
                {
                    int kt = khDAO.DeleteKhachHang(dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value.ToString());
                    if (kt > 0)
                    {
                        MessageBox.Show("Xóa thành công"); loadData();

                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }

            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            new FormThemKhachHang().ShowDialog();
            loadData();
        }
        public void loadKQSearch()
        {

        }
        private void FormDanhSachKhachHang_Load(object sender, EventArgs e)
        {

        }
    }        
    
}
