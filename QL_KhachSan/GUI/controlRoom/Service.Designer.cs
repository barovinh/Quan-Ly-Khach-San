
namespace QL_KhachSan.GUI.controlRoom
{
    partial class Service
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelThanhTien = new System.Windows.Forms.Label();
            this.labelTenDV = new System.Windows.Forms.Label();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.labelSoLuong = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.labelDonGia, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelThanhTien, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSoLuong, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTenDV, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelThanhTien
            // 
            this.labelThanhTien.AutoSize = true;
            this.labelThanhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelThanhTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelThanhTien.Location = new System.Drawing.Point(489, 0);
            this.labelThanhTien.Name = "labelThanhTien";
            this.labelThanhTien.Size = new System.Drawing.Size(158, 46);
            this.labelThanhTien.TabIndex = 8;
            this.labelThanhTien.Text = "10000000";
            this.labelThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelThanhTien.Click += new System.EventHandler(this.labelThanhTien_Click);
            // 
            // labelTenDV
            // 
            this.labelTenDV.AutoSize = true;
            this.labelTenDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTenDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelTenDV.Location = new System.Drawing.Point(165, 0);
            this.labelTenDV.Name = "labelTenDV";
            this.labelTenDV.Size = new System.Drawing.Size(156, 46);
            this.labelTenDV.TabIndex = 6;
            this.labelTenDV.Text = "Giặt ủi";
            this.labelTenDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDonGia
            // 
            this.labelDonGia.AutoSize = true;
            this.labelDonGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelDonGia.Location = new System.Drawing.Point(327, 0);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(156, 46);
            this.labelDonGia.TabIndex = 9;
            this.labelDonGia.Text = "10000000";
            this.labelDonGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoLuong
            // 
            this.labelSoLuong.AutoSize = true;
            this.labelSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelSoLuong.Location = new System.Drawing.Point(3, 0);
            this.labelSoLuong.Name = "labelSoLuong";
            this.labelSoLuong.Size = new System.Drawing.Size(156, 46);
            this.labelSoLuong.TabIndex = 7;
            this.labelSoLuong.Text = "2";
            this.labelSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(25, 15, 3, 3);
            this.Name = "Service";
            this.Size = new System.Drawing.Size(650, 46);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelThanhTien;
        private System.Windows.Forms.Label labelTenDV;
        private System.Windows.Forms.Label labelDonGia;
        private System.Windows.Forms.Label labelSoLuong;
    }
}
