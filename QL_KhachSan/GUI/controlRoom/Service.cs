using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KhachSan.GUI.controlRoom
{
    public partial class Service : UserControl
    {
        public string DV { get; set; }
        public int SL { get; set; }
        public float ThanhTien { get; set; }
        public float DonGia { get; set; }
        public Service()
        {
            InitializeComponent();
        }
        public void setTen(string ten)
        {
            labelTenDV.Text = ten; 
        }
        public void setDonGia(float donGia)
        {
            labelDonGia.Text = string.Format("{0:#,##0}", donGia);
        }
       public void setSL (int sl)
        {
            labelSoLuong.Text = sl.ToString();
        }
        public void setThanhTien(float thanhtien)
        {     
            labelThanhTien.Text = string.Format("{0:#,##0}", thanhtien);
        }
        private void labelThanhTien_Click(object sender, EventArgs e)
        {

        }
    }
}
