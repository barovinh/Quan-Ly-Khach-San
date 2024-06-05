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

namespace QL_KhachSan.GUI.TienNghi
{
    public partial class FormDanhSachTienNghi : Form
    {
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        public TaiKhoan TK { get; set; }
        List<Model.Entity.TienNghi> listTN = new List<Model.Entity.TienNghi>();
        public FormDanhSachTienNghi(TaiKhoan tk)
        {
            InitializeComponent();
            TK = tk;
            loadDataTienNghi();
            if (TK.CapQuyen == 2)
            {
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;
                btnThemDV.Visible = true;
            }
            else
            {
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                btnThemDV.Visible = false;
            }
        }

        private void txtTenDVCanTim_TextChanged(object sender, EventArgs e)
        {
            if(txtTenDVCanTim.Focused==false)
            {
                loadDataTienNghi();
                return;
            }
            LoadResultSearch();
        }
        public void LoadResultSearch()
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Rows.Clear();
            TienNghiDAO tnDAO = new TienNghiDAO();
            List<Model.Entity.TienNghi> listT = tnDAO.TimTenTienNghi(txtTenDVCanTim.Text);
            foreach (var item in listT)
            {
                dataGridView1.Rows.Add(item.MaTN, item.TenTN, this.edit, this.delete);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void loadDataTienNghi()
        {
            this.dataGridView1.Rows.Clear();
            TienNghiDAO tnDAO = new TienNghiDAO();
            listTN = tnDAO.GetTienNghis();
            foreach (var item in listTN)
            {
                dataGridView1.Rows.Add(item.MaTN, item.TenTN, this.edit, this.delete);
            }

        }
        private void FormDanhSachTienNghi_Load(object sender, EventArgs e)
        {

        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            new FormThemTienNghi().ShowDialog();
            loadDataTienNghi();
        }

        private void txtTenDVCanTim_Leave(object sender, EventArgs e)
        {
            if(txtTenDVCanTim.Text=="")
            {
                txtTenDVCanTim.Text = "Nhập tên tiện nghi cần tìm";

            }
        }

        private void txtTenDVCanTim_Enter(object sender, EventArgs e)
        {
            if (txtTenDVCanTim.Text == "Nhập tên tiện nghi cần tìm")
            {
                txtTenDVCanTim.Text = "";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Sua"].Index)
            {
                Model.Entity.TienNghi tn = new TienNghiDAO().TimDichVuDuaVaoMa(dataGridView1.Rows[e.RowIndex].Cells["MaTN"].Value.ToString());
                if (tn != null)
                {
                    new FormSuaTienNghi(tn).ShowDialog();
                    loadDataTienNghi(); 
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Xoa"].Index)
            {
                TienNghiDAO tnDAO = new TienNghiDAO();
                if (tnDAO.KTKhoaNgoai(dataGridView1.Rows[e.RowIndex].Cells["MaTN"].Value.ToString()))
                {
                    MessageBox.Show("Không thể xóa vì đã dính khóa ngoại");
                }
                else
                {
                    int kt = tnDAO.DeleteTienNghi(dataGridView1.Rows[e.RowIndex].Cells["MaTN"].Value.ToString());
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
            loadDataTienNghi();
        }
    }
}
