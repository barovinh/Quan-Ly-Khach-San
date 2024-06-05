namespace QL_KhachSan.GUI
{
    partial class Menu
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnLoaiPhong = new System.Windows.Forms.Button();
            this.btnQLDichVu = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnQLKhachHang = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnAccout = new System.Windows.Forms.Button();
            this.btnTienNghi = new System.Windows.Forms.Button();
            this.btnQLPhong = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelNavBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.Teal;
            this.panelNavBar.Controls.Add(this.btnCloseChildForm);
            this.panelNavBar.Controls.Add(this.lblTittle);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(240, 0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(963, 87);
            this.panelNavBar.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::QL_KhachSan.Properties.Resources.x_24_icon;
            this.btnCloseChildForm.Location = new System.Drawing.Point(889, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(74, 87);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(400, 24);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(99, 31);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panelDesktop.Location = new System.Drawing.Point(240, 87);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(963, 743);
            this.panelDesktop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QL_KhachSan.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(963, 743);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 87);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 87);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 78);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnPhong.FlatAppearance.BorderSize = 0;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.Location = new System.Drawing.Point(0, 87);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPhong.Size = new System.Drawing.Size(240, 44);
            this.btnPhong.TabIndex = 1;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnQLPhong_Click);
            // 
            // btnLoaiPhong
            // 
            this.btnLoaiPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoaiPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnLoaiPhong.FlatAppearance.BorderSize = 0;
            this.btnLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiPhong.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaiPhong.Location = new System.Drawing.Point(0, 131);
            this.btnLoaiPhong.Name = "btnLoaiPhong";
            this.btnLoaiPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLoaiPhong.Size = new System.Drawing.Size(240, 44);
            this.btnLoaiPhong.TabIndex = 10;
            this.btnLoaiPhong.Text = "Loại Phòng";
            this.btnLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaiPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoaiPhong.UseVisualStyleBackColor = true;
            this.btnLoaiPhong.Click += new System.EventHandler(this.btnLoaiPhong_Click);
            // 
            // btnQLDichVu
            // 
            this.btnQLDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDichVu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnQLDichVu.FlatAppearance.BorderSize = 0;
            this.btnQLDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDichVu.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnQLDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDichVu.Location = new System.Drawing.Point(0, 175);
            this.btnQLDichVu.Name = "btnQLDichVu";
            this.btnQLDichVu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLDichVu.Size = new System.Drawing.Size(240, 44);
            this.btnQLDichVu.TabIndex = 12;
            this.btnQLDichVu.Text = "Dịch vụ";
            this.btnQLDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDichVu.UseVisualStyleBackColor = true;
            this.btnQLDichVu.Click += new System.EventHandler(this.btnQLDichVu_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnQLNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnQLNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.Location = new System.Drawing.Point(0, 219);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLNhanVien.Size = new System.Drawing.Size(240, 44);
            this.btnQLNhanVien.TabIndex = 14;
            this.btnQLNhanVien.Text = "Nhân viên";
            this.btnQLNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNhanVien.UseVisualStyleBackColor = true;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKhachHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnQLKhachHang.FlatAppearance.BorderSize = 0;
            this.btnQLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKhachHang.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnQLKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.Location = new System.Drawing.Point(0, 263);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLKhachHang.Size = new System.Drawing.Size(240, 44);
            this.btnQLKhachHang.TabIndex = 15;
            this.btnQLKhachHang.Text = "Khách hàng";
            this.btnQLKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKhachHang.UseVisualStyleBackColor = true;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 307);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(240, 44);
            this.btnHoaDon.TabIndex = 16;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 351);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(240, 44);
            this.btnThongKe.TabIndex = 17;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnAccout
            // 
            this.btnAccout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnAccout.FlatAppearance.BorderSize = 0;
            this.btnAccout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccout.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnAccout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccout.Location = new System.Drawing.Point(0, 395);
            this.btnAccout.Name = "btnAccout";
            this.btnAccout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccout.Size = new System.Drawing.Size(240, 44);
            this.btnAccout.TabIndex = 18;
            this.btnAccout.Text = "Tài khoản";
            this.btnAccout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccout.UseVisualStyleBackColor = true;
            this.btnAccout.Click += new System.EventHandler(this.btnAccout_Click_1);
            // 
            // btnTienNghi
            // 
            this.btnTienNghi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTienNghi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnTienNghi.FlatAppearance.BorderSize = 0;
            this.btnTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienNghi.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnTienNghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTienNghi.Location = new System.Drawing.Point(0, 439);
            this.btnTienNghi.Name = "btnTienNghi";
            this.btnTienNghi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTienNghi.Size = new System.Drawing.Size(240, 44);
            this.btnTienNghi.TabIndex = 19;
            this.btnTienNghi.Text = "Tiện nghi";
            this.btnTienNghi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTienNghi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTienNghi.UseVisualStyleBackColor = true;
            this.btnTienNghi.Click += new System.EventHandler(this.btnTienNghi_Click);
            // 
            // btnQLPhong
            // 
            this.btnQLPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnQLPhong.FlatAppearance.BorderSize = 0;
            this.btnQLPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPhong.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnQLPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhong.Location = new System.Drawing.Point(0, 483);
            this.btnQLPhong.Name = "btnQLPhong";
            this.btnQLPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnQLPhong.Size = new System.Drawing.Size(240, 44);
            this.btnQLPhong.TabIndex = 21;
            this.btnQLPhong.Text = "Quản lý phòng";
            this.btnQLPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLPhong.UseVisualStyleBackColor = true;
            this.btnQLPhong.Click += new System.EventHandler(this.btnQLPhong_Click_1);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 777);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(240, 53);
            this.btnDangXuat.TabIndex = 22;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatPhong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.Location = new System.Drawing.Point(0, 527);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDatPhong.Size = new System.Drawing.Size(240, 44);
            this.btnDatPhong.TabIndex = 23;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnDatPhong);
            this.panelMenu.Controls.Add(this.btnDangXuat);
            this.panelMenu.Controls.Add(this.btnQLPhong);
            this.panelMenu.Controls.Add(this.btnTienNghi);
            this.panelMenu.Controls.Add(this.btnAccout);
            this.panelMenu.Controls.Add(this.btnThongKe);
            this.panelMenu.Controls.Add(this.btnHoaDon);
            this.panelMenu.Controls.Add(this.btnQLKhachHang);
            this.panelMenu.Controls.Add(this.btnQLNhanVien);
            this.panelMenu.Controls.Add(this.btnQLDichVu);
            this.panelMenu.Controls.Add(this.btnLoaiPhong);
            this.panelMenu.Controls.Add(this.btnPhong);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 830);
            this.panelMenu.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1203, 830);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelNavBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Quản lý khách sạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelNavBar.ResumeLayout(false);
            this.panelNavBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnLoaiPhong;
        private System.Windows.Forms.Button btnQLDichVu;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnQLKhachHang;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnAccout;
        private System.Windows.Forms.Button btnTienNghi;
        private System.Windows.Forms.Button btnQLPhong;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Timer timer1;
    }
}

