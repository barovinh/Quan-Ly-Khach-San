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

namespace QL_KhachSan.GUI.ChiTietTienNghi
{
    public partial class FormDanhSachChiTietTN : Form
    {
        public string MaPLH { get; set; }
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        public TaiKhoan TK { get; set; }
        public FormDanhSachChiTietTN(string ma,TaiKhoan tk)
        {
            InitializeComponent();
            MaPLH = ma;
            TK = tk;
            LoadCTTN();
            if (TK.CapQuyen == 2)
            {
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = true;
                btnThem.Visible = true;
            }
            else
            {
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                btnThem.Visible = false;
            }
        }
        public void LoadCTTN()
        {
            this.dataGridView1.Rows.Clear();
            DbContext db = new DbContext();
            db.Cmd.CommandText = "SELECT TienNghi.MaTN, TenTN, CTTN.SL, LOAIPHONG.MaLPH" +
                " FROM TienNghi " +
                "INNER JOIN CTTN ON TienNghi.MaTN = CTTN.MaTN " +
                "INNER JOIN LOAIPHONG ON CTTN.MaLPH = LOAIPHONG.MaLPH " +
                "WHERE LoaiPhong.MaLPH = '"+MaPLH+"'";
            DataTable dt = db.getDatatable(db.Cmd.CommandText);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.dataGridView1.Rows.Add(dt.Rows[i]["MaTN"].ToString(),dt.Rows[i]["TenTN"].ToString(), dt.Rows[i]["SL"].ToString(), this.edit, this.delete); 
            }
            dataGridView1.Columns["MaTN"].Visible = false;
        }
        private void FormDanhSachChiTietTN_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Sua"].Index)
            {
                //   Model.Entity.DichVu dv = new DichVuDAO().TimDichVuDuaVaoMa(dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value.ToString());
                string name = dataGridView1.Rows[e.RowIndex].Cells["TenTN"].Value.ToString();
                Model.Entity.ChiTietTienNghi ct = new Model.Entity.ChiTietTienNghi();
                ct.SL = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["SL"].Value.ToString());
                ct.MaLPH = MaPLH;
                ct.MaTN = dataGridView1.Rows[e.RowIndex].Cells["MaTN"].Value.ToString();
                new FormSuaChiTietTienNghiSoLuong(ct, name).ShowDialog();
                LoadCTTN();
            }
           if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Xoa"].Index)
            {
                ChiTietTienNghiDAO cttn = new ChiTietTienNghiDAO();
                string ma = dataGridView1.Rows[e.RowIndex].Cells["MaTN"].Value.ToString();
                int kt = cttn.DeleteChiTietTienNghiCuaPhong(ma);
                if(kt>0)
                {
                    MessageBox.Show("Xóa thành công");

                }
                else
                {
                    MessageBox.Show("Xóa thất bại");

                }
            }
            LoadCTTN();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new FormThemChiTietTienNghi(MaPLH).ShowDialog();
            LoadCTTN();
        }
    }
}
