
using System.Windows.Forms;

namespace QL_KhachSan.GUI.SoDoPhong
{
    partial class FormSoDoPhong
    {
        public class DoubleBufferPanel : Panel

        {

            public DoubleBufferPanel()

            {

                // Set the value of the double-buffering style bits to true.

                this.DoubleBuffered = true;

                this.SetStyle(ControlStyles.AllPaintingInWmPaint |

                ControlStyles.UserPaint |

                ControlStyles.OptimizedDoubleBuffer, true);

                UpdateStyles();

            }

        }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdVDoi = new System.Windows.Forms.RadioButton();
            this.rdTatCaLoaiPhong = new System.Windows.Forms.RadioButton();
            this.rdVDon = new System.Windows.Forms.RadioButton();
            this.rdTDoi = new System.Windows.Forms.RadioButton();
            this.rdTDon = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTatCaLoaiPhongTinhTrang = new System.Windows.Forms.RadioButton();
            this.rdDaDonDep = new System.Windows.Forms.RadioButton();
            this.rdChuaDonDep = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdPhongDangSua = new System.Windows.Forms.RadioButton();
            this.rdTatCaPhong = new System.Windows.Forms.RadioButton();
            this.rdPhongDangThue = new System.Windows.Forms.RadioButton();
            this.rdPhongDaDat = new System.Windows.Forms.RadioButton();
            this.rdPhongTrong = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGioGiac = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 858);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdVDoi);
            this.groupBox3.Controls.Add(this.rdTatCaLoaiPhong);
            this.groupBox3.Controls.Add(this.rdVDon);
            this.groupBox3.Controls.Add(this.rdTDoi);
            this.groupBox3.Controls.Add(this.rdTDon);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 412);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(206, 235);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại phòng";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rdVDoi
            // 
            this.rdVDoi.AutoSize = true;
            this.rdVDoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdVDoi.Location = new System.Drawing.Point(6, 138);
            this.rdVDoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdVDoi.Name = "rdVDoi";
            this.rdVDoi.Size = new System.Drawing.Size(147, 24);
            this.rdVDoi.TabIndex = 9;
            this.rdVDoi.TabStop = true;
            this.rdVDoi.Text = "Phòng VIP đôi";
            this.rdVDoi.UseVisualStyleBackColor = true;
            this.rdVDoi.CheckedChanged += new System.EventHandler(this.rdVDoi_CheckedChanged);
            this.rdVDoi.Click += new System.EventHandler(this.rdVDoi_CheckedChanged);
            // 
            // rdTatCaLoaiPhong
            // 
            this.rdTatCaLoaiPhong.AutoSize = true;
            this.rdTatCaLoaiPhong.Checked = true;
            this.rdTatCaLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTatCaLoaiPhong.Location = new System.Drawing.Point(6, 168);
            this.rdTatCaLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTatCaLoaiPhong.Name = "rdTatCaLoaiPhong";
            this.rdTatCaLoaiPhong.Size = new System.Drawing.Size(82, 24);
            this.rdTatCaLoaiPhong.TabIndex = 8;
            this.rdTatCaLoaiPhong.TabStop = true;
            this.rdTatCaLoaiPhong.Text = "Tất cả";
            this.rdTatCaLoaiPhong.UseVisualStyleBackColor = true;
            this.rdTatCaLoaiPhong.CheckedChanged += new System.EventHandler(this.rdTatCaLoaiPhong_CheckedChanged);
            // 
            // rdVDon
            // 
            this.rdVDon.AutoSize = true;
            this.rdVDon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdVDon.Location = new System.Drawing.Point(6, 102);
            this.rdVDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdVDon.Name = "rdVDon";
            this.rdVDon.Size = new System.Drawing.Size(153, 24);
            this.rdVDon.TabIndex = 7;
            this.rdVDon.TabStop = true;
            this.rdVDon.Text = "Phòng VIP đơn";
            this.rdVDon.UseVisualStyleBackColor = true;
            this.rdVDon.Click += new System.EventHandler(this.rdVDoi_CheckedChanged);
            // 
            // rdTDoi
            // 
            this.rdTDoi.AutoSize = true;
            this.rdTDoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTDoi.Location = new System.Drawing.Point(6, 72);
            this.rdTDoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTDoi.Name = "rdTDoi";
            this.rdTDoi.Size = new System.Drawing.Size(173, 24);
            this.rdTDoi.TabIndex = 6;
            this.rdTDoi.TabStop = true;
            this.rdTDoi.Text = "Phòng thường đôi";
            this.rdTDoi.UseVisualStyleBackColor = true;
            this.rdTDoi.Click += new System.EventHandler(this.rdVDoi_CheckedChanged);
            // 
            // rdTDon
            // 
            this.rdTDon.AutoSize = true;
            this.rdTDon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTDon.Location = new System.Drawing.Point(6, 42);
            this.rdTDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTDon.Name = "rdTDon";
            this.rdTDon.Size = new System.Drawing.Size(179, 24);
            this.rdTDon.TabIndex = 5;
            this.rdTDon.TabStop = true;
            this.rdTDon.Text = "Phòng thường đơn";
            this.rdTDon.UseVisualStyleBackColor = true;
            this.rdTDon.Click += new System.EventHandler(this.rdVDoi_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdTatCaLoaiPhongTinhTrang);
            this.groupBox2.Controls.Add(this.rdDaDonDep);
            this.groupBox2.Controls.Add(this.rdChuaDonDep);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 272);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(206, 140);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình trạng phòng";
            // 
            // rdTatCaLoaiPhongTinhTrang
            // 
            this.rdTatCaLoaiPhongTinhTrang.AutoSize = true;
            this.rdTatCaLoaiPhongTinhTrang.Checked = true;
            this.rdTatCaLoaiPhongTinhTrang.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTatCaLoaiPhongTinhTrang.Location = new System.Drawing.Point(12, 96);
            this.rdTatCaLoaiPhongTinhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTatCaLoaiPhongTinhTrang.Name = "rdTatCaLoaiPhongTinhTrang";
            this.rdTatCaLoaiPhongTinhTrang.Size = new System.Drawing.Size(169, 24);
            this.rdTatCaLoaiPhongTinhTrang.TabIndex = 5;
            this.rdTatCaLoaiPhongTinhTrang.TabStop = true;
            this.rdTatCaLoaiPhongTinhTrang.Text = "Tất cả loại phòng";
            this.rdTatCaLoaiPhongTinhTrang.UseVisualStyleBackColor = true;
            this.rdTatCaLoaiPhongTinhTrang.Click += new System.EventHandler(this.rdChuaDonDep_CheckedChanged);
            // 
            // rdDaDonDep
            // 
            this.rdDaDonDep.AutoSize = true;
            this.rdDaDonDep.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDaDonDep.Location = new System.Drawing.Point(11, 66);
            this.rdDaDonDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdDaDonDep.Name = "rdDaDonDep";
            this.rdDaDonDep.Size = new System.Drawing.Size(175, 24);
            this.rdDaDonDep.TabIndex = 4;
            this.rdDaDonDep.TabStop = true;
            this.rdDaDonDep.Text = "Phòng đã dọn dẹp";
            this.rdDaDonDep.UseVisualStyleBackColor = true;
            this.rdDaDonDep.Click += new System.EventHandler(this.rdChuaDonDep_CheckedChanged);
            // 
            // rdChuaDonDep
            // 
            this.rdChuaDonDep.AutoSize = true;
            this.rdChuaDonDep.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChuaDonDep.Location = new System.Drawing.Point(11, 36);
            this.rdChuaDonDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdChuaDonDep.Name = "rdChuaDonDep";
            this.rdChuaDonDep.Size = new System.Drawing.Size(194, 24);
            this.rdChuaDonDep.TabIndex = 3;
            this.rdChuaDonDep.TabStop = true;
            this.rdChuaDonDep.Text = "Phòng chưa dọn dẹp";
            this.rdChuaDonDep.UseVisualStyleBackColor = true;
            this.rdChuaDonDep.CheckedChanged += new System.EventHandler(this.rdChuaDonDep_CheckedChanged);
            this.rdChuaDonDep.Click += new System.EventHandler(this.rdChuaDonDep_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdPhongDangSua);
            this.groupBox1.Controls.Add(this.rdTatCaPhong);
            this.groupBox1.Controls.Add(this.rdPhongDangThue);
            this.groupBox1.Controls.Add(this.rdPhongDaDat);
            this.groupBox1.Controls.Add(this.rdPhongTrong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(206, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng thái phòng";
            // 
            // rdPhongDangSua
            // 
            this.rdPhongDangSua.AutoSize = true;
            this.rdPhongDangSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPhongDangSua.Location = new System.Drawing.Point(11, 119);
            this.rdPhongDangSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdPhongDangSua.Name = "rdPhongDangSua";
            this.rdPhongDangSua.Size = new System.Drawing.Size(158, 24);
            this.rdPhongDangSua.TabIndex = 4;
            this.rdPhongDangSua.TabStop = true;
            this.rdPhongDangSua.Text = "Phòng đang sửa";
            this.rdPhongDangSua.UseVisualStyleBackColor = true;
            this.rdPhongDangSua.Click += new System.EventHandler(this.rdPhongTrong_CheckedChanged);
            // 
            // rdTatCaPhong
            // 
            this.rdTatCaPhong.AutoSize = true;
            this.rdTatCaPhong.Checked = true;
            this.rdTatCaPhong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTatCaPhong.Location = new System.Drawing.Point(11, 149);
            this.rdTatCaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTatCaPhong.Name = "rdTatCaPhong";
            this.rdTatCaPhong.Size = new System.Drawing.Size(169, 24);
            this.rdTatCaPhong.TabIndex = 3;
            this.rdTatCaPhong.TabStop = true;
            this.rdTatCaPhong.Text = "Tất cả loại phòng";
            this.rdTatCaPhong.UseVisualStyleBackColor = true;
            this.rdTatCaPhong.Click += new System.EventHandler(this.rdPhongTrong_CheckedChanged);
            // 
            // rdPhongDangThue
            // 
            this.rdPhongDangThue.AutoSize = true;
            this.rdPhongDangThue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPhongDangThue.Location = new System.Drawing.Point(11, 85);
            this.rdPhongDangThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdPhongDangThue.Name = "rdPhongDangThue";
            this.rdPhongDangThue.Size = new System.Drawing.Size(165, 24);
            this.rdPhongDangThue.TabIndex = 2;
            this.rdPhongDangThue.TabStop = true;
            this.rdPhongDangThue.Text = "Phòng đang thuê";
            this.rdPhongDangThue.UseVisualStyleBackColor = true;
            this.rdPhongDangThue.Click += new System.EventHandler(this.rdPhongTrong_CheckedChanged);
            // 
            // rdPhongDaDat
            // 
            this.rdPhongDaDat.AutoSize = true;
            this.rdPhongDaDat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPhongDaDat.Location = new System.Drawing.Point(11, 55);
            this.rdPhongDaDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdPhongDaDat.Name = "rdPhongDaDat";
            this.rdPhongDaDat.Size = new System.Drawing.Size(137, 24);
            this.rdPhongDaDat.TabIndex = 1;
            this.rdPhongDaDat.Text = "Phòng đã đặt";
            this.rdPhongDaDat.UseVisualStyleBackColor = true;
            this.rdPhongDaDat.Click += new System.EventHandler(this.rdPhongTrong_CheckedChanged);
            // 
            // rdPhongTrong
            // 
            this.rdPhongTrong.AutoSize = true;
            this.rdPhongTrong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPhongTrong.Location = new System.Drawing.Point(11, 25);
            this.rdPhongTrong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdPhongTrong.Name = "rdPhongTrong";
            this.rdPhongTrong.Size = new System.Drawing.Size(130, 24);
            this.rdPhongTrong.TabIndex = 0;
            this.rdPhongTrong.TabStop = true;
            this.rdPhongTrong.Text = "Phòng trống";
            this.rdPhongTrong.UseVisualStyleBackColor = true;
            this.rdPhongTrong.CheckedChanged += new System.EventHandler(this.rdPhongTrong_CheckedChanged);
            this.rdPhongTrong.Click += new System.EventHandler(this.rdPhongTrong_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 80);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBoxGioGiac);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 90);
            this.panel2.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnReset.Location = new System.Drawing.Point(768, 28);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 48);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chọn giờ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chọn ngày";
            // 
            // comboBoxGioGiac
            // 
            this.comboBoxGioGiac.FormattingEnabled = true;
            this.comboBoxGioGiac.Location = new System.Drawing.Point(238, 50);
            this.comboBoxGioGiac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGioGiac.Name = "comboBoxGioGiac";
            this.comboBoxGioGiac.Size = new System.Drawing.Size(74, 28);
            this.comboBoxGioGiac.TabIndex = 13;
            this.comboBoxGioGiac.SelectedIndexChanged += new System.EventHandler(this.comboBoxGioGiac_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 50);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.flowLayoutPanel5);
            this.panel4.Controls.Add(this.flowLayoutPanel4);
            this.panel4.Controls.Add(this.flowLayoutPanel3);
            this.panel4.Controls.Add(this.flowLayoutPanel2);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(206, 90);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1130, 768);
            this.panel4.TabIndex = 36;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoScroll = true;
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.panel9);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 416);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1130, 104);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(0, 100);
            this.panel9.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.panel8);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 312);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1130, 104);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(0, 100);
            this.panel8.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.panel7);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 208);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1130, 104);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 100);
            this.panel7.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.panel6);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 104);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1130, 104);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 100);
            this.panel6.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1130, 104);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 100);
            this.panel5.TabIndex = 0;
            // 
            // FormSoDoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1336, 858);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSoDoPhong";
            this.Text = "Sơ đồ phòng";
            this.Load += new System.EventHandler(this.FormSoDoPhong_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private RadioButton rdPhongTrong;
        private Panel panel3;
        private RadioButton rdTatCaPhong;
        private RadioButton rdPhongDangThue;
        private RadioButton rdPhongDaDat;
        private RadioButton rdVDoi;
        private RadioButton rdTatCaLoaiPhong;
        private RadioButton rdVDon;
        private RadioButton rdTDoi;
        private RadioButton rdTDon;
        private RadioButton rdTatCaLoaiPhongTinhTrang;
        private RadioButton rdDaDonDep;
        private RadioButton rdChuaDonDep;
        private RadioButton rdPhongDangSua;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel5;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel6;
        private FlowLayoutPanel flowLayoutPanel5;
        private Panel panel9;
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel panel8;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel7;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxGioGiac;
        private DateTimePicker dateTimePicker1;
        private Timer timer1;
        private Button btnReset;
    }
}