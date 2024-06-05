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

namespace QL_KhachSan.GUI.ChiTietTienNghi
{
    public partial class FormThemChiTietTienNghi : Form
    {
        public string MALPH { get; set; }
        bool roi = false;
        public FormThemChiTietTienNghi(string MaLPH)
        {
            InitializeComponent();
            MALPH = MaLPH;
            LoadCBTienNghi();
            roi = true;
        }

        private void FormThemChiTietTienNghi_Load(object sender, EventArgs e)
        {

        }
        public void LoadCBTienNghi()
        {
            DbContext db = new DbContext();
            db.Cmd.CommandText = "SELECT TienNghi.* " +
                "FROM TienNghi LEFT JOIN CTTN ON TienNghi.MaTN = CTTN.MaTN AND CTTN.MaLPH = '"+MALPH+"' " +
                "WHERE CTTN.MaTN IS NULL ";
            DataTable dt = db.getDatatable(db.Cmd.CommandText);
            cbTenTienNghi.DataSource = dt;
            cbTenTienNghi.DisplayMember = "TenTN";
            cbTenTienNghi.ValueMember = "MaTN";
        }

        private void cbTenTienNghi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(roi)
            {

            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChiTietTienNghiDAO ctDAO = new ChiTietTienNghiDAO();
            Model.Entity.ChiTietTienNghi ct = new Model.Entity.ChiTietTienNghi();
            ct.MaLPH = MALPH;
            ct.MaTN = cbTenTienNghi.SelectedValue.ToString();
            ct.SL = int.Parse(txtSoLuong.Text);
            int kt = ctDAO.InsertChiTietTienNghiCuaPhong(ct);
            if(kt>0)
            {
                MessageBox.Show("Thêm thành công");

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
