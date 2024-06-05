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
    public partial class FormSuaChiTietTienNghiSoLuong : Form
    {
        public Model.Entity.ChiTietTienNghi CTTN { get; set; }
        public string Name { get; set; }
        public FormSuaChiTietTienNghiSoLuong(Model.Entity.ChiTietTienNghi cttn,string name)
        {
            InitializeComponent();
            CTTN = cttn;
            Name = name;
        }

        private void LabelThemDichVu_Click(object sender, EventArgs e)
        {

        }

        private void FormSuaChiTietTienNghiSoLuong_Load(object sender, EventArgs e)
        {
            txtTenDV.Text = Name;
            txtSoLuong.Text = CTTN.SL.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChiTietTienNghiDAO ctDAO = new ChiTietTienNghiDAO();
            CTTN.SL = int.Parse( txtSoLuong.Text);
            int kt = ctDAO.UpdateChiTietTienNghiCuaPhong(CTTN);
            if(kt>0)
            {
                MessageBox.Show("Sửa thành công");

            }
            else
            {
                MessageBox.Show("Thao tác thất bại");

            }
        }
    }
}
