
namespace QL_KhachSan.GUI.LoaiPhong
{
    partial class FormLoaiPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaLPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoiToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNghi = new System.Windows.Forms.DataGridViewImageColumn();
            this.Sua = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTenLPHCanTim = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLPH,
            this.TenLPH,
            this.SoGiuong,
            this.SoNguoiToiDa,
            this.GiaNgay,
            this.GiaGio,
            this.TienNghi,
            this.Sua});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 278);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1277, 454);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaLPH
            // 
            this.MaLPH.DataPropertyName = "MaLPH";
            this.MaLPH.HeaderText = "Mã loại phòng";
            this.MaLPH.MinimumWidth = 8;
            this.MaLPH.Name = "MaLPH";
            this.MaLPH.ReadOnly = true;
            // 
            // TenLPH
            // 
            this.TenLPH.DataPropertyName = "TenLPH";
            this.TenLPH.HeaderText = "Tên loại phòng";
            this.TenLPH.MinimumWidth = 8;
            this.TenLPH.Name = "TenLPH";
            this.TenLPH.ReadOnly = true;
            // 
            // SoGiuong
            // 
            this.SoGiuong.DataPropertyName = "SoGiuong";
            this.SoGiuong.HeaderText = "Số giường";
            this.SoGiuong.MinimumWidth = 8;
            this.SoGiuong.Name = "SoGiuong";
            this.SoGiuong.ReadOnly = true;
            // 
            // SoNguoiToiDa
            // 
            this.SoNguoiToiDa.DataPropertyName = "SoNguoiToiDa";
            this.SoNguoiToiDa.HeaderText = "Số người tối đa";
            this.SoNguoiToiDa.MinimumWidth = 8;
            this.SoNguoiToiDa.Name = "SoNguoiToiDa";
            this.SoNguoiToiDa.ReadOnly = true;
            // 
            // GiaNgay
            // 
            this.GiaNgay.DataPropertyName = "GiaNgay";
            this.GiaNgay.HeaderText = "Giá ngày";
            this.GiaNgay.MinimumWidth = 8;
            this.GiaNgay.Name = "GiaNgay";
            this.GiaNgay.ReadOnly = true;
            // 
            // GiaGio
            // 
            this.GiaGio.DataPropertyName = "GiaGio";
            this.GiaGio.HeaderText = "Giá giờ";
            this.GiaGio.MinimumWidth = 8;
            this.GiaGio.Name = "GiaGio";
            this.GiaGio.ReadOnly = true;
            // 
            // TienNghi
            // 
            this.TienNghi.HeaderText = "Tiện nghi";
            this.TienNghi.MinimumWidth = 8;
            this.TienNghi.Name = "TienNghi";
            this.TienNghi.ReadOnly = true;
            // 
            // Sua
            // 
            this.Sua.HeaderText = "Sửa";
            this.Sua.MinimumWidth = 8;
            this.Sua.Name = "Sua";
            this.Sua.ReadOnly = true;
            // 
            // txtTenLPHCanTim
            // 
            this.txtTenLPHCanTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtTenLPHCanTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLPHCanTim.Location = new System.Drawing.Point(38, 60);
            this.txtTenLPHCanTim.Multiline = true;
            this.txtTenLPHCanTim.Name = "txtTenLPHCanTim";
            this.txtTenLPHCanTim.Size = new System.Drawing.Size(340, 41);
            this.txtTenLPHCanTim.TabIndex = 9;
            this.txtTenLPHCanTim.Text = "Nhập tên loại phòng cần tìm";
            this.txtTenLPHCanTim.TextChanged += new System.EventHandler(this.txtTenLPHCanTim_TextChanged);
            this.txtTenLPHCanTim.Enter += new System.EventHandler(this.txtTenLPHCanTim_Enter);
            this.txtTenLPHCanTim.Leave += new System.EventHandler(this.txtTenLPHCanTim_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::QL_KhachSan.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(329, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 41);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1277, 732);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTenLPHCanTim);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLoaiPhong";
            this.Text = "Danh sách loại phòng";
            this.Load += new System.EventHandler(this.FormLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoiToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaGio;
        private System.Windows.Forms.DataGridViewImageColumn TienNghi;
        private System.Windows.Forms.DataGridViewImageColumn Sua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTenLPHCanTim;
    }
}