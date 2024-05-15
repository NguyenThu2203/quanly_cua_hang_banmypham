namespace CuaHangMyPham.Forms
{
    partial class frmNuocsanxuat
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
            this.dgridNuocsanxuat = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblManuoc = new System.Windows.Forms.Label();
            this.txtTennuocsx = new System.Windows.Forms.TextBox();
            this.lblTennuoc = new System.Windows.Forms.Label();
            this.txtManuocsx = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblDanhmucnuocsanxuat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridNuocsanxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dgridNuocsanxuat);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.lblManuoc);
            this.panel1.Controls.Add(this.txtTennuocsx);
            this.panel1.Controls.Add(this.lblTennuoc);
            this.panel1.Controls.Add(this.txtManuocsx);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnBoqua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Location = new System.Drawing.Point(2, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 550);
            this.panel1.TabIndex = 14;
            // 
            // dgridNuocsanxuat
            // 
            this.dgridNuocsanxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridNuocsanxuat.Location = new System.Drawing.Point(88, 186);
            this.dgridNuocsanxuat.Name = "dgridNuocsanxuat";
            this.dgridNuocsanxuat.RowHeadersWidth = 82;
            this.dgridNuocsanxuat.RowTemplate.Height = 33;
            this.dgridNuocsanxuat.Size = new System.Drawing.Size(748, 228);
            this.dgridNuocsanxuat.TabIndex = 3;
            this.dgridNuocsanxuat.Click += new System.EventHandler(this.dgridNuocsanxuat_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(770, 473);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(115, 51);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblManuoc
            // 
            this.lblManuoc.AutoSize = true;
            this.lblManuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManuoc.Location = new System.Drawing.Point(83, 40);
            this.lblManuoc.Name = "lblManuoc";
            this.lblManuoc.Size = new System.Drawing.Size(104, 29);
            this.lblManuoc.TabIndex = 1;
            this.lblManuoc.Text = "Mã nước";
            // 
            // txtTennuocsx
            // 
            this.txtTennuocsx.Location = new System.Drawing.Point(241, 111);
            this.txtTennuocsx.Multiline = true;
            this.txtTennuocsx.Name = "txtTennuocsx";
            this.txtTennuocsx.Size = new System.Drawing.Size(273, 41);
            this.txtTennuocsx.TabIndex = 10;
            // 
            // lblTennuoc
            // 
            this.lblTennuoc.AutoSize = true;
            this.lblTennuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTennuoc.Location = new System.Drawing.Point(83, 111);
            this.lblTennuoc.Name = "lblTennuoc";
            this.lblTennuoc.Size = new System.Drawing.Size(114, 29);
            this.lblTennuoc.TabIndex = 2;
            this.lblTennuoc.Text = "Tên nước";
            // 
            // txtManuocsx
            // 
            this.txtManuocsx.Location = new System.Drawing.Point(241, 40);
            this.txtManuocsx.Multiline = true;
            this.txtManuocsx.Name = "txtManuocsx";
            this.txtManuocsx.Size = new System.Drawing.Size(273, 41);
            this.txtManuocsx.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(90, 473);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 51);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(636, 473);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(115, 51);
            this.btnBoqua.TabIndex = 8;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(228, 473);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 51);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(503, 473);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(115, 51);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(366, 473);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 51);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblDanhmucnuocsanxuat
            // 
            this.lblDanhmucnuocsanxuat.AutoSize = true;
            this.lblDanhmucnuocsanxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhmucnuocsanxuat.Location = new System.Drawing.Point(190, -93);
            this.lblDanhmucnuocsanxuat.Name = "lblDanhmucnuocsanxuat";
            this.lblDanhmucnuocsanxuat.Size = new System.Drawing.Size(439, 33);
            this.lblDanhmucnuocsanxuat.TabIndex = 13;
            this.lblDanhmucnuocsanxuat.Text = "DANH MỤC NƯỚC SẢN XUẤT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "DANH MỤC NƯỚC SẢN XUẤT";
            // 
            // frmNuocsanxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 636);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDanhmucnuocsanxuat);
            this.Name = "frmNuocsanxuat";
            this.Text = "Nuocsanxuat";
            this.Load += new System.EventHandler(this.frmNuocsanxuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridNuocsanxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgridNuocsanxuat;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblManuoc;
        private System.Windows.Forms.TextBox txtTennuocsx;
        private System.Windows.Forms.Label lblTennuoc;
        private System.Windows.Forms.TextBox txtManuocsx;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblDanhmucnuocsanxuat;
        private System.Windows.Forms.Label label1;
    }
}