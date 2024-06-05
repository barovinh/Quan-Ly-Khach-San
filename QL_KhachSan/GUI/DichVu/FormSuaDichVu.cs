using QL_KhachSan.Model;
using QL_KhachSan.Model.DAO;
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
    public partial class FormSuaDichVu : Form
    {
        DbContext db = new DbContext();
        public Model.Entity.DichVu DichVu { get; set; }
        public FormSuaDichVu(Model.Entity.DichVu dv)
        {
            InitializeComponent();
            DichVu = dv;           
        }

        private void LabelThemDichVu_Click(object sender, EventArgs e)
        {

        }
        public void LoadCBDV()
        {
            db.Cmd.CommandText = "SELECT LoaiDV FROM DichVu GROUP BY LoaiDV";
            DataTable dt = db.getDatatable(db.Cmd.CommandText);
            comboBoxDV.DataSource = dt;
            comboBoxDV.ValueMember = "LoaiDV";
            comboBoxDV.DisplayMember = "LoaiDV";
        }
        private void FormSuaDichVu_Load(object sender, EventArgs e)
        {
            LoadCBDV();
            comboBoxDV.SelectedValue = DichVu.LoaiDV;
            txtDonGia.Text = DichVu.DonGia.ToString();
            txtTenDV.Text = DichVu.TenDV;
            txtSoLuong.Text = DichVu.SLConLai.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DichVuDAO dvDAO = new DichVuDAO();
            Model.Entity.DichVu dv = new Model.Entity.DichVu();
            dv.DonGia = float.Parse(txtDonGia.Text);
            dv.LoaiDV = comboBoxDV.SelectedValue.ToString();
            dv.MaDV = DichVu.MaDV;
            dv.SLConLai = int.Parse(txtSoLuong.Text);
            dv.TenDV = txtTenDV.Text;
            if(dvDAO.UpdateDichVu(dv)>0)
            {
                MessageBox.Show("Cật nhật thành công");
            }
            else
            {
                MessageBox.Show("Cật nhật thất bại");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            // Lưu vị trí con trỏ trước khi thay đổi văn bản
            int selectionStart = txtDonGia.SelectionStart;

            // Xóa các dấu phẩy trong văn bản để có thể chuyển đổi sang số
            string cleanedText = txtDonGia.Text.Replace(",", "");

            // Kiểm tra nếu là số hợp lệ
            if (int.TryParse(cleanedText, out int number))
            {
                // Định dạng số và gán lại vào TextBox
                txtDonGia.Text = number.ToString("#,###");

                // Tính lại vị trí con trỏ
                int newSelectionStart = selectionStart + (txtDonGia.Text.Length - cleanedText.Length);

                // Đảm bảo rằng vị trí con trỏ không vượt quá độ dài của văn bản
                newSelectionStart = Math.Max(0, Math.Min(newSelectionStart, txtDonGia.Text.Length));

                // Đặt lại vị trí con trỏ
                txtDonGia.SelectionStart = newSelectionStart;
            }

        }
    }
}
