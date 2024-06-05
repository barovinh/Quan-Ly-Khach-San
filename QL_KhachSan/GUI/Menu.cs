using QL_KhachSan.GUI.DichVu;
using QL_KhachSan.GUI.LoaiPhong;
using QL_KhachSan.GUI.Phong;
using QL_KhachSan.GUI.SoDoPhong;
using QL_KhachSan.GUI.TienNghi;
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
using QL_KhachSan.GUI.Customer;
using QL_KhachSan.GUI.Account;
using QL_KhachSan.GUI.Staff;
using QL_KhachSan.GUI.ThongKe;
using QL_KhachSan.GUI.Bill;
using QL_KhachSan.GUI.Login;
using QL_KhachSan.Model.DAO;

namespace QL_KhachSan.GUI
{
    public partial class Menu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public TaiKhoan TK { get; set; }
        List<ChiTietDatPhong> listCheckout = new List<ChiTietDatPhong>();
        public FormDanhSachDatPhong formdsdp;
        public Menu(TaiKhoan tk)
        {
            InitializeComponent();
            random = new Random();
            TK = tk;
            label1.Text = tk.MaNV;
            btnCloseChildForm.Visible = false;
            timer1.Interval =  60*1000;//* 30;// Đặt khoảng thời gian giữa các lần tick 30p
            timer1.Enabled = true; // Kích hoạt Timer
            ChiTietDatPhongDAO chiTietDatPhongDAO = new ChiTietDatPhongDAO();
            listCheckout = chiTietDatPhongDAO.dsPhongCheckout();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(design.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(design.ColorList.Count);
            }
            tempIndex = index;
            string color = design.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));                    
                    panelNavBar.BackColor = color;
                    panelLogo.BackColor = design.ChangeColorBrightness(color, -0.3);
                    design.PrimaryColor = color;
                    design.SecondaryColor = design.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.AntiqueWhite;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTittle.Text = childForm.Text;
        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSachPhong(TK), (Button)sender);
        }

        private void btnQLDichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm( new FormDanhSachDichVu(TK), (Button)sender);
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSachNhanVien(TK), (Button)sender);    
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSachKhachHang(TK), (Button)sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSachHoaDon(TK), (Button)sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKe(), (Button)sender);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTittle.Text = "HOME";
            panelNavBar.BackColor = Color.Teal;
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnAccout_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnTienNghi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSachTienNghi(TK), (Button)sender);
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLoaiPhong(TK), (Button)sender); 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnQLPhong_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormSoDoPhong(TK), (Button)sender);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new FormDangNhap().Show();
                this.Visible = false;
                
            }
       
        }

        private void btnAccout_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormDanhSachTaiKhoan(TK),(Button)sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new FormDoiMatKhau(TK).ShowDialog();
            this.Visible=false;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (listCheckout.Count > 0)
            {
                formdsdp = new FormDanhSachDatPhong(TK,listCheckout);
                //    formdsdp.ListCheckout = listCheckout;
                listCheckout.Clear();
                OpenChildForm(formdsdp, (Button)sender);

            }
            else
            {
                formdsdp = new FormDanhSachDatPhong(TK);
                OpenChildForm(formdsdp, (Button)sender);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChiTietDatPhongDAO chiTietDatPhongDAO = new ChiTietDatPhongDAO();
            listCheckout = chiTietDatPhongDAO.dsPhongCheckout();
        }
    }
}