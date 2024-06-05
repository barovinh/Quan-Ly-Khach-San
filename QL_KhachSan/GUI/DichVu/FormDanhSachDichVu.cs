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

namespace QL_KhachSan.GUI.DichVu
{
    public partial class FormDanhSachDichVu : Form
    {
        List<Model.Entity.DichVu> DichVus;
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        public TaiKhoan TK { get; set; }
        public FormDanhSachDichVu(TaiKhoan  tk)
        {
            InitializeComponent();
            TK = tk;
          
            loadData();
            if (TK.CapQuyen == 2)
            {
                dataGridView1.Columns[5].Visible = true;
                dataGridView1.Columns[6].Visible = true;
                btnThemKH.Visible = true;
            }
            else
            {
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                btnThemKH.Visible = false;
            }
        }
        void loadData()
        {
            this.dataGridView1.Rows.Clear();
            DichVuDAO dvDAO = new DichVuDAO();
            DichVus = dvDAO.getDichVus();
            foreach (var item in DichVus)
            {
                int? slton;
                if (item.SLConLai == null || item.SLConLai == -1)
                {
                    slton = 0;
                }
                else
                {
                    slton = item.SLConLai;
                }
                dataGridView1.Rows.Add(item.MaDV, item.TenDV, item.DonGia.ToString("#,#"), slton, item.LoaiDV, this.edit, this.delete);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Sua"].Index)
            {
                Model.Entity.DichVu dv = new DichVuDAO().TimDichVuDuaVaoMa(dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value.ToString());
                if (dv != null)
                {
                    new FormSuaDichVu(dv).ShowDialog();
                    loadData();
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Xoa"].Index)
            {
                DichVuDAO dvDAO = new DichVuDAO();
                if (dvDAO.KTKhoaNgoai(dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value.ToString()))
                {
                    MessageBox.Show("Không thể xóa vì đã dính khóa ngoại");
                }
                else
                {
                    int kt = dvDAO.DeleteDichVu(dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value.ToString());
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

        private void FormDanhSachDichVu_Load(object sender, EventArgs e)
        {

        }

        private void txtTenDVCanTim_Leave(object sender, EventArgs e)
        {
            if (txtSDTKHCanTim.Text == "")
            {
                txtSDTKHCanTim.Text = "Nhập tên dịch vụ cần tìm";
            }
        }

        private void txtTenDVCanTim_Enter(object sender, EventArgs e)
        {
            if (txtSDTKHCanTim.Text == "Nhập tên dịch vụ cần tìm")
            {
                txtSDTKHCanTim.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void LoadDataSearch()
        {
            this.dataGridView1.Rows.Clear();

            DichVuDAO dvDAO = new DichVuDAO();
            List<Model.Entity.DichVu> vus = new List<Model.Entity.DichVu>();
            vus = dvDAO.TenDichVuCanTim(txtSDTKHCanTim.Text);
            foreach (var item in vus)
            {
                int? slton;
                if (item.SLConLai == null || item.SLConLai == -1)
                {
                    slton = 0;
                }
                else
                {
                    slton = item.SLConLai;
                }
                dataGridView1.Rows.Add(item.MaDV, item.TenDV, item.DonGia.ToString("#,#"), slton, item.LoaiDV, this.edit, this.delete);
            }
        }
        private void txtTenDVCanTim_TextChanged(object sender, EventArgs e)
        {
            if (txtSDTKHCanTim.Focused == false)
            {
                loadData();
                return;
            }
            LoadDataSearch();
        }

        private void txtTenDVCanTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            FormThemDichVu them = new FormThemDichVu();
            them.ShowDialog();
        }
    }
}
