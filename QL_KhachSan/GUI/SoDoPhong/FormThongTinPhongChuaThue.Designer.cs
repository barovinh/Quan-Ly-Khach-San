
namespace QL_KhachSan.GUI.SoDoPhong
{
    partial class FormThongTinPhongChuaThue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelSoNguoi = new System.Windows.Forms.Label();
            this.LabelThoiGianThue = new System.Windows.Forms.Label();
            this.LabelNgayCheckin = new System.Windows.Forms.Label();
            this.LabelTen = new System.Windows.Forms.Label();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLoadTinhTrangDD = new System.Windows.Forms.ComboBox();
            this.cbLoadTinhTrangPhong = new System.Windows.Forms.ComboBox();
            this.LabelCapNhatTinhTrangDonDep = new System.Windows.Forms.Label();
            this.LabelCapNhatTinhTrangPhong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSoNguoi
            // 
            this.LabelSoNguoi.AutoSize = true;
            this.LabelSoNguoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSoNguoi.Location = new System.Drawing.Point(809, 68);
            this.LabelSoNguoi.Name = "LabelSoNguoi";
            this.LabelSoNguoi.Size = new System.Drawing.Size(111, 32);
            this.LabelSoNguoi.TabIndex = 4;
            this.LabelSoNguoi.Text = "Số người";
            // 
            // LabelThoiGianThue
            // 
            this.LabelThoiGianThue.AutoSize = true;
            this.LabelThoiGianThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThoiGianThue.Location = new System.Drawing.Point(572, 68);
            this.LabelThoiGianThue.Name = "LabelThoiGianThue";
            this.LabelThoiGianThue.Size = new System.Drawing.Size(171, 32);
            this.LabelThoiGianThue.TabIndex = 5;
            this.LabelThoiGianThue.Text = "Thời gian thuê";
            // 
            // LabelNgayCheckin
            // 
            this.LabelNgayCheckin.AutoSize = true;
            this.LabelNgayCheckin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNgayCheckin.Location = new System.Drawing.Point(362, 68);
            this.LabelNgayCheckin.Name = "LabelNgayCheckin";
            this.LabelNgayCheckin.Size = new System.Drawing.Size(159, 32);
            this.LabelNgayCheckin.TabIndex = 6;
            this.LabelNgayCheckin.Text = "Ngày checkin";
            // 
            // LabelTen
            // 
            this.LabelTen.AutoSize = true;
            this.LabelTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTen.Location = new System.Drawing.Point(97, 68);
            this.LabelTen.Name = "LabelTen";
            this.LabelTen.Size = new System.Drawing.Size(219, 32);
            this.LabelTen.TabIndex = 7;
            this.LabelTen.Text = "Họ tên khách hàng";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDatPhong.Location = new System.Drawing.Point(356, 494);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(189, 62);
            this.btnDatPhong.TabIndex = 13;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbLoadTinhTrangDD);
            this.panel1.Controls.Add(this.cbLoadTinhTrangPhong);
            this.panel1.Controls.Add(this.LabelCapNhatTinhTrangDonDep);
            this.panel1.Controls.Add(this.LabelCapNhatTinhTrangPhong);
            this.panel1.Location = new System.Drawing.Point(635, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 179);
            this.panel1.TabIndex = 14;
            // 
            // cbLoadTinhTrangDD
            // 
            this.cbLoadTinhTrangDD.FormattingEnabled = true;
            this.cbLoadTinhTrangDD.Items.AddRange(new object[] {
            "Đã dọn dẹp",
            "Chưa dọn dẹp"});
            this.cbLoadTinhTrangDD.Location = new System.Drawing.Point(180, 138);
            this.cbLoadTinhTrangDD.Name = "cbLoadTinhTrangDD";
            this.cbLoadTinhTrangDD.Size = new System.Drawing.Size(186, 28);
            this.cbLoadTinhTrangDD.TabIndex = 7;
            // 
            // cbLoadTinhTrangPhong
            // 
            this.cbLoadTinhTrangPhong.FormattingEnabled = true;
            this.cbLoadTinhTrangPhong.Items.AddRange(new object[] {
            "Phòng trống",
            "Đang sửa chữa"});
            this.cbLoadTinhTrangPhong.Location = new System.Drawing.Point(180, 64);
            this.cbLoadTinhTrangPhong.Name = "cbLoadTinhTrangPhong";
            this.cbLoadTinhTrangPhong.Size = new System.Drawing.Size(186, 28);
            this.cbLoadTinhTrangPhong.TabIndex = 6;
            // 
            // LabelCapNhatTinhTrangDonDep
            // 
            this.LabelCapNhatTinhTrangDonDep.AutoSize = true;
            this.LabelCapNhatTinhTrangDonDep.BackColor = System.Drawing.Color.White;
            this.LabelCapNhatTinhTrangDonDep.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCapNhatTinhTrangDonDep.Location = new System.Drawing.Point(17, 95);
            this.LabelCapNhatTinhTrangDonDep.Name = "LabelCapNhatTinhTrangDonDep";
            this.LabelCapNhatTinhTrangDonDep.Size = new System.Drawing.Size(388, 40);
            this.LabelCapNhatTinhTrangDonDep.TabIndex = 4;
            this.LabelCapNhatTinhTrangDonDep.Text = "Cập nhật tình trạng dọn dẹp";
            // 
            // LabelCapNhatTinhTrangPhong
            // 
            this.LabelCapNhatTinhTrangPhong.AutoSize = true;
            this.LabelCapNhatTinhTrangPhong.BackColor = System.Drawing.Color.White;
            this.LabelCapNhatTinhTrangPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCapNhatTinhTrangPhong.Location = new System.Drawing.Point(17, 17);
            this.LabelCapNhatTinhTrangPhong.Name = "LabelCapNhatTinhTrangPhong";
            this.LabelCapNhatTinhTrangPhong.Size = new System.Drawing.Size(365, 40);
            this.LabelCapNhatTinhTrangPhong.TabIndex = 5;
            this.LabelCapNhatTinhTrangPhong.Text = "Cập nhật tình trạng phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(635, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 111);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.White;
            this.txtGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGhiChu.Location = new System.Drawing.Point(3, 35);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(438, 73);
            this.txtGhiChu.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DichVu,
            this.SoLuong,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(55, 157);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(574, 314);
            this.dataGridView1.TabIndex = 16;
            // 
            // DichVu
            // 
            this.DichVu.HeaderText = "Dịch vụ";
            this.DichVu.MinimumWidth = 8;
            this.DichVu.Name = "DichVu";
            this.DichVu.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Cyan;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(659, 494);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(189, 62);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::QL_KhachSan.Properties.Resources.SoNguoi;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(67, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 33);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::QL_KhachSan.Properties.Resources.ClockPick;
            this.pictureBox3.Location = new System.Drawing.Point(541, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 33);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QL_KhachSan.Properties.Resources.CalendarPick;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(322, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QL_KhachSan.Properties.Resources._3people;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(761, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 29);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormThongTinPhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1116, 584);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelSoNguoi);
            this.Controls.Add(this.LabelThoiGianThue);
            this.Controls.Add(this.LabelNgayCheckin);
            this.Controls.Add(this.LabelTen);
            this.Name = "FormThongTinPhongTrong";
            this.Text = "FormThongTinPhong";
            this.Load += new System.EventHandler(this.FormThongTinPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSoNguoi;
        private System.Windows.Forms.Label LabelThoiGianThue;
        private System.Windows.Forms.Label LabelNgayCheckin;
        private System.Windows.Forms.Label LabelTen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLoadTinhTrangDD;
        private System.Windows.Forms.ComboBox cbLoadTinhTrangPhong;
        private System.Windows.Forms.Label LabelCapNhatTinhTrangDonDep;
        private System.Windows.Forms.Label LabelCapNhatTinhTrangPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnLuu;
    }
}