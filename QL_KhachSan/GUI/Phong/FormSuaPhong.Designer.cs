
namespace QL_KhachSan.GUI.Phong
{
    partial class FormSuaPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTinhTrangDonDep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTTPH = new System.Windows.Forms.ComboBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCatNhat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelThemDichVu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.cbLoaiPhong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbTinhTrangDonDep);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbTTPH);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnCatNhat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(70, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 579);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 35);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(187, 410);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(338, 45);
            this.txtGhiChu.TabIndex = 23;
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(191, 328);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(334, 28);
            this.cbLoaiPhong.TabIndex = 22;
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 35);
            this.label5.TabIndex = 21;
            this.label5.Text = "Loại phòng";
            // 
            // cbTinhTrangDonDep
            // 
            this.cbTinhTrangDonDep.FormattingEnabled = true;
            this.cbTinhTrangDonDep.Items.AddRange(new object[] {
            "Chưa dọn dẹp",
            "Đã dọn dẹp"});
            this.cbTinhTrangDonDep.Location = new System.Drawing.Point(189, 241);
            this.cbTinhTrangDonDep.Name = "cbTinhTrangDonDep";
            this.cbTinhTrangDonDep.Size = new System.Drawing.Size(334, 28);
            this.cbTinhTrangDonDep.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 35);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tình trạng dọn dẹp";
            // 
            // cbTTPH
            // 
            this.cbTTPH.FormattingEnabled = true;
            this.cbTTPH.Items.AddRange(new object[] {
            "Bình thường",
            "Đang sửa chữa"});
            this.cbTTPH.Location = new System.Drawing.Point(189, 160);
            this.cbTTPH.Name = "cbTTPH";
            this.cbTTPH.Size = new System.Drawing.Size(334, 28);
            this.cbTTPH.TabIndex = 18;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(189, 68);
            this.txtMaPhong.Multiline = true;
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(338, 44);
            this.txtMaPhong.TabIndex = 17;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Crimson;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::QL_KhachSan.Properties.Resources.error;
            this.btnThoat.Location = new System.Drawing.Point(372, 490);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 64);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCatNhat
            // 
            this.btnCatNhat.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCatNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatNhat.ForeColor = System.Drawing.Color.White;
            this.btnCatNhat.Image = global::QL_KhachSan.Properties.Resources.Add;
            this.btnCatNhat.Location = new System.Drawing.Point(182, 490);
            this.btnCatNhat.Name = "btnCatNhat";
            this.btnCatNhat.Size = new System.Drawing.Size(123, 64);
            this.btnCatNhat.TabIndex = 15;
            this.btnCatNhat.Text = "Cập nhật";
            this.btnCatNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCatNhat.UseVisualStyleBackColor = false;
            this.btnCatNhat.Click += new System.EventHandler(this.btnCatNhat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 35);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tình trạng phòng";
            // 
            // LabelThemDichVu
            // 
            this.LabelThemDichVu.AutoSize = true;
            this.LabelThemDichVu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThemDichVu.Location = new System.Drawing.Point(284, 9);
            this.LabelThemDichVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelThemDichVu.Name = "LabelThemDichVu";
            this.LabelThemDichVu.Size = new System.Drawing.Size(232, 55);
            this.LabelThemDichVu.TabIndex = 5;
            this.LabelThemDichVu.Text = "Sửa phòng";
            // 
            // FormSuaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelThemDichVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuaPhong";
            this.Text = "FormSuaPhong";
            this.Load += new System.EventHandler(this.FormSuaPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTinhTrangDonDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTTPH;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCatNhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelThemDichVu;
    }
}