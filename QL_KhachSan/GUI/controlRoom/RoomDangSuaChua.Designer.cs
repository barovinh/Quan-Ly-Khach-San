
namespace QL_KhachSan.GUI.controlRoom
{
    partial class RoomDangSuaChua
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTrangThaiPhong = new System.Windows.Forms.Label();
            this.labelLoaiPhong = new System.Windows.Forms.Label();
            this.labelTenPhong = new System.Windows.Forms.Label();
            this.pictureTrangThai = new System.Windows.Forms.PictureBox();
            this.LabelThoiGian = new System.Windows.Forms.Label();
            this.LabelTrangThaiDonDep = new System.Windows.Forms.Label();
            this.pictureTime = new System.Windows.Forms.PictureBox();
            this.PictureBoxTrangThaiDonDep = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTrangThaiDonDep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.labelTrangThaiPhong);
            this.panel1.Controls.Add(this.labelLoaiPhong);
            this.panel1.Controls.Add(this.labelTenPhong);
            this.panel1.Controls.Add(this.pictureTrangThai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 113);
            this.panel1.TabIndex = 19;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelTrangThaiPhong
            // 
            this.labelTrangThaiPhong.AutoSize = true;
            this.labelTrangThaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrangThaiPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTrangThaiPhong.Location = new System.Drawing.Point(89, 70);
            this.labelTrangThaiPhong.Name = "labelTrangThaiPhong";
            this.labelTrangThaiPhong.Size = new System.Drawing.Size(157, 25);
            this.labelTrangThaiPhong.TabIndex = 3;
            this.labelTrangThaiPhong.Text = "Đang sửa chữa";
            // 
            // labelLoaiPhong
            // 
            this.labelLoaiPhong.AutoSize = true;
            this.labelLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLoaiPhong.Location = new System.Drawing.Point(126, 9);
            this.labelLoaiPhong.Name = "labelLoaiPhong";
            this.labelLoaiPhong.Size = new System.Drawing.Size(107, 25);
            this.labelLoaiPhong.TabIndex = 2;
            this.labelLoaiPhong.Text = "Phòng đơn";
            // 
            // labelTenPhong
            // 
            this.labelTenPhong.AutoSize = true;
            this.labelTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTenPhong.Location = new System.Drawing.Point(8, 9);
            this.labelTenPhong.Name = "labelTenPhong";
            this.labelTenPhong.Size = new System.Drawing.Size(82, 32);
            this.labelTenPhong.TabIndex = 1;
            this.labelTenPhong.Text = "P101";
            // 
            // pictureTrangThai
            // 
            this.pictureTrangThai.BackColor = System.Drawing.Color.Red;
            this.pictureTrangThai.Image = global::QL_KhachSan.Properties.Resources.DangSuaChuaBlackMin;
            this.pictureTrangThai.Location = new System.Drawing.Point(14, 70);
            this.pictureTrangThai.Name = "pictureTrangThai";
            this.pictureTrangThai.Size = new System.Drawing.Size(38, 36);
            this.pictureTrangThai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTrangThai.TabIndex = 0;
            this.pictureTrangThai.TabStop = false;
            // 
            // LabelThoiGian
            // 
            this.LabelThoiGian.AutoSize = true;
            this.LabelThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.LabelThoiGian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelThoiGian.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThoiGian.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LabelThoiGian.Location = new System.Drawing.Point(32, 135);
            this.LabelThoiGian.Name = "LabelThoiGian";
            this.LabelThoiGian.Size = new System.Drawing.Size(58, 28);
            this.LabelThoiGian.TabIndex = 22;
            this.LabelThoiGian.Text = "0 giờ";
            // 
            // LabelTrangThaiDonDep
            // 
            this.LabelTrangThaiDonDep.AutoSize = true;
            this.LabelTrangThaiDonDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.LabelTrangThaiDonDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelTrangThaiDonDep.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.LabelTrangThaiDonDep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LabelTrangThaiDonDep.Location = new System.Drawing.Point(151, 143);
            this.LabelTrangThaiDonDep.Name = "LabelTrangThaiDonDep";
            this.LabelTrangThaiDonDep.Size = new System.Drawing.Size(95, 21);
            this.LabelTrangThaiDonDep.TabIndex = 21;
            this.LabelTrangThaiDonDep.Text = "Đã dọn dẹp";
            // 
            // pictureTime
            // 
            this.pictureTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.pictureTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureTime.Image = global::QL_KhachSan.Properties.Resources.ClockPick;
            this.pictureTime.Location = new System.Drawing.Point(6, 143);
            this.pictureTime.Name = "pictureTime";
            this.pictureTime.Size = new System.Drawing.Size(20, 20);
            this.pictureTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTime.TabIndex = 23;
            this.pictureTime.TabStop = false;
            // 
            // PictureBoxTrangThaiDonDep
            // 
            this.PictureBoxTrangThaiDonDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.PictureBoxTrangThaiDonDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxTrangThaiDonDep.Image = global::QL_KhachSan.Properties.Resources.tickblack;
            this.PictureBoxTrangThaiDonDep.Location = new System.Drawing.Point(125, 143);
            this.PictureBoxTrangThaiDonDep.Name = "PictureBoxTrangThaiDonDep";
            this.PictureBoxTrangThaiDonDep.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxTrangThaiDonDep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxTrangThaiDonDep.TabIndex = 20;
            this.PictureBoxTrangThaiDonDep.TabStop = false;
            // 
            // RoomDangSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureTime);
            this.Controls.Add(this.LabelThoiGian);
            this.Controls.Add(this.LabelTrangThaiDonDep);
            this.Controls.Add(this.PictureBoxTrangThaiDonDep);
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "RoomDangSuaChua";
            this.Size = new System.Drawing.Size(249, 173);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTrangThaiDonDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTrangThaiPhong;
        private System.Windows.Forms.Label labelLoaiPhong;
        private System.Windows.Forms.Label labelTenPhong;
        private System.Windows.Forms.PictureBox pictureTrangThai;
        private System.Windows.Forms.PictureBox pictureTime;
        private System.Windows.Forms.Label LabelThoiGian;
        private System.Windows.Forms.Label LabelTrangThaiDonDep;
        private System.Windows.Forms.PictureBox PictureBoxTrangThaiDonDep;
    }
}
