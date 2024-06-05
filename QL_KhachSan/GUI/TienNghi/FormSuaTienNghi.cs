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
    public partial class FormSuaTienNghi : Form
    {
        public Model.Entity.TienNghi TienNghi { get; set; }
        public FormSuaTienNghi(Model.Entity.TienNghi tn)
        {
         
            InitializeComponent();
            TienNghi = tn;
            txtTenTN.Text = TienNghi.TenTN;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TienNghiDAO tnDAO = new TienNghiDAO();

            TienNghi.TenTN = txtTenTN.Text;

            int kt = tnDAO.UpdateTienNghi(TienNghi);
            if(kt>0)
            {
                MessageBox.Show("Cật nhật sửa tên tiện nghi thành công");

            }
            else
            {
                MessageBox.Show("Cật nhật thất bại");

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
