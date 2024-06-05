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

namespace QL_KhachSan.GUI.TienNghi
{
    public partial class FormThemTienNghi : Form
    {
        public FormThemTienNghi()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TienNghiDAO tnDAO = new TienNghiDAO();
            Model.Entity.TienNghi tn = new Model.Entity.TienNghi();
            tn.MaTN = tnDAO.GetMaTNNext();
            tn.TenTN = txtTenTN.Text;
            int kt = tnDAO.InsertTienNghi(tn);
            if(kt>0)
            {
                MessageBox.Show("Thêm thành công");

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
                    
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
