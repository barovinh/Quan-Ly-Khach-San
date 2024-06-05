using QL_KhachSan.GUI.Customer;
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

namespace QL_KhachSan.GUI.Account
{
    public partial class FormDanhSachTaiKhoan : Form
    {
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        public TaiKhoan TK { get; set; }
        List<Model.Entity.TaiKhoan> listTK = new List<Model.Entity.TaiKhoan>();
        public FormDanhSachTaiKhoan(TaiKhoan tk)
        {
            InitializeComponent();
            TK = tk;
            loadData();
          if(TK.CapQuyen==2)
            {
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = true;
                btnThemKH.Visible = true;
            }
            else
            {
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                btnThemKH.Visible = false;
            }
        }
        void loadData()
        {
            this.dataGridView1.Rows.Clear();
            TaiKhoanDAO tkDAO = new TaiKhoanDAO();
            listTK = tkDAO.GetTaiKhoans();
            foreach (var item in listTK)
            {
                dataGridView1.Rows.Add(item.TenTK,item.MaNV , item.CapQuyen, this.edit, this.delete);
            }

        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            new FormThemTaiKhoan().ShowDialog();
            loadData();
        }

        private void txtTenNVCanTim_TextChanged(object sender, EventArgs e)
        {
            LoadResultSearch();
        }
        public void LoadResultSearch()
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Rows.Clear();
            TaiKhoanDAO tkDAO = new TaiKhoanDAO();
            List<Model.Entity.TaiKhoan> listT = tkDAO.TimTenTaiKhoan(txtTenNVCanTim.Text);
            foreach (var item in listT)
            {
                dataGridView1.Rows.Add(item.TenTK, item.MaNV, item.CapQuyen, this.edit, this.delete);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Sua"].Index)
            {
                Model.Entity.TaiKhoan tk = new TaiKhoanDAO().TimTaiKhoan(dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value.ToString());
                if (tk != null)
                {
                    new FormSuaTaiKhoan(tk).ShowDialog();
                    loadData();
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Xoa"].Index)
            {
                TaiKhoanDAO khDAO = new TaiKhoanDAO();
                if (khDAO.KTKhoaNgoai(dataGridView1.Rows[e.RowIndex].Cells["MaKH"].Value.ToString()))
                {
                    MessageBox.Show("Không thể xóa vì đã dính khóa ngoại");
                }
                else
                {
                    int kt = khDAO.DeleteTaiKhoan(dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value.ToString());
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

        private void FormDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTenNVCanTim_Enter(object sender, EventArgs e)
        {
            if (txtTenNVCanTim.Text == "Nhập tên tài khoản")
            {
                txtTenNVCanTim.Text = "";
            }
        }

        private void txtTenNVCanTim_Leave(object sender, EventArgs e)
        {
            if (txtTenNVCanTim.Text == "")
            {
                txtTenNVCanTim.Text = "Nhập tên tài khoản";

            }
        }
    }
}
