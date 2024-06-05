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

namespace QL_KhachSan.GUI.Staff
{
    public partial class FormDanhSachNhanVien : Form
    {
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        public TaiKhoan TK { get; set; }
        List<Model.Entity.NhanVien> listKH = new List<Model.Entity.NhanVien>();
        public FormDanhSachNhanVien(TaiKhoan tk)
        {
            InitializeComponent();
            TK = tk;
          
            loadData();
            if (TK.CapQuyen == 2)
            {
                dataGridView1.Columns[9].Visible =true;
                dataGridView1.Columns[10].Visible = true;
                btnThemKH.Visible = true;
            }
            else
            {
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                btnThemKH.Visible = false;
            }
        }

        void loadData()
        {
            this.dataGridView1.Rows.Clear();
            NhanVienDAO NvDAO = new NhanVienDAO();
            listKH = NvDAO.GetNhanViens();
            foreach (var item in listKH)
            {
                dataGridView1.Rows.Add(item.MaNV, item.TenNV, item.ChucVu, item.Luong, item.SDT, item.NgaySinh,item.CCCD,item.DiaChi,item.Email, this.edit, this.delete);
            }

        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            new FormThemNhanVien().ShowDialog();
            loadData();
        }

        private void txtTenNVCanTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Sua"].Index)
            {
                Model.Entity.NhanVien kh = new NhanVienDAO().getNhanVienTheoMa(dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value.ToString());
                if (kh != null)
                {
                    new FormSuaNhanVien(kh).ShowDialog();
                    loadData();
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Xoa"].Index)
            {
                KhachHangDAO khDAO = new KhachHangDAO();
                if (khDAO.KTKhoaNgoai(dataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value.ToString()))
                {
                    MessageBox.Show("Không thể xóa vì đã dính khóa ngoại");
                }
                else
                {
                    int kt = khDAO.DeleteKhachHang(dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value.ToString());
                    if (kt > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }

            }
            loadData();
        }

        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
