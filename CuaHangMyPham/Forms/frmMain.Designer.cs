﻿namespace CuaHangMyPham.Forms
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHanghoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmucHDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhmucHDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhacungcap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChatlieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuocsx = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCongdung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHanghoaNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTracuuHDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTracuuHDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTracuuhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTracuuKH = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocaoBH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocaoDT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocaoTK = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.hàngHóaToolStripMenuItem1,
            this.traCứuToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHanghoa,
            this.mnuHoadon,
            this.mnuKhachhang,
            this.mnuNhacungcap,
            this.mnuNhanvien});
            this.danhMụcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // mnuHanghoa
            // 
            this.mnuHanghoa.Name = "mnuHanghoa";
            this.mnuHanghoa.Size = new System.Drawing.Size(270, 34);
            this.mnuHanghoa.Text = "Hàng hóa";
            this.mnuHanghoa.Click += new System.EventHandler(this.mnuHanghoa_Click);
            // 
            // mnuHoadon
            // 
            this.mnuHoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhmucHDN,
            this.mnuDanhmucHDB});
            this.mnuHoadon.Name = "mnuHoadon";
            this.mnuHoadon.Size = new System.Drawing.Size(270, 34);
            this.mnuHoadon.Text = "Hóa đơn";
            // 
            // mnuDanhmucHDN
            // 
            this.mnuDanhmucHDN.Name = "mnuDanhmucHDN";
            this.mnuDanhmucHDN.Size = new System.Drawing.Size(235, 34);
            this.mnuDanhmucHDN.Text = "Hóa đơn nhập";
            // 
            // mnuDanhmucHDB
            // 
            this.mnuDanhmucHDB.Name = "mnuDanhmucHDB";
            this.mnuDanhmucHDB.Size = new System.Drawing.Size(235, 34);
            this.mnuDanhmucHDB.Text = "Hóa đơn bán";
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.Size = new System.Drawing.Size(270, 34);
            this.mnuKhachhang.Text = "Khách hàng";
            // 
            // mnuNhacungcap
            // 
            this.mnuNhacungcap.Name = "mnuNhacungcap";
            this.mnuNhacungcap.Size = new System.Drawing.Size(270, 34);
            this.mnuNhacungcap.Text = "Nhà cung cấp";
            // 
            // mnuNhanvien
            // 
            this.mnuNhanvien.Name = "mnuNhanvien";
            this.mnuNhanvien.Size = new System.Drawing.Size(270, 34);
            this.mnuNhanvien.Text = "Nhân viên";
            // 
            // hàngHóaToolStripMenuItem1
            // 
            this.hàngHóaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChatlieu,
            this.mnuNuocsx,
            this.mnuCongdung,
            this.mnuHanghoaNCC});
            this.hàngHóaToolStripMenuItem1.Name = "hàngHóaToolStripMenuItem1";
            this.hàngHóaToolStripMenuItem1.Size = new System.Drawing.Size(106, 29);
            this.hàngHóaToolStripMenuItem1.Text = "Hàng hóa";
            // 
            // mnuChatlieu
            // 
            this.mnuChatlieu.Name = "mnuChatlieu";
            this.mnuChatlieu.Size = new System.Drawing.Size(227, 34);
            this.mnuChatlieu.Text = "Chất liệu ";
            // 
            // mnuNuocsx
            // 
            this.mnuNuocsx.Name = "mnuNuocsx";
            this.mnuNuocsx.Size = new System.Drawing.Size(227, 34);
            this.mnuNuocsx.Text = "Nước sản xuất";
            // 
            // mnuCongdung
            // 
            this.mnuCongdung.Name = "mnuCongdung";
            this.mnuCongdung.Size = new System.Drawing.Size(227, 34);
            this.mnuCongdung.Text = "Công dụng";
            this.mnuCongdung.Click += new System.EventHandler(this.mnuCongdung_Click);
            // 
            // mnuHanghoaNCC
            // 
            this.mnuHanghoaNCC.Name = "mnuHanghoaNCC";
            this.mnuHanghoaNCC.Size = new System.Drawing.Size(227, 34);
            this.mnuHanghoaNCC.Text = "Nhà cung cấp";
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTracuuHDN,
            this.mnuTracuuHDB,
            this.mnuTracuuhang,
            this.mnuTracuuKH});
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.traCứuToolStripMenuItem.Text = "Tra cứu ";
            // 
            // mnuTracuuHDN
            // 
            this.mnuTracuuHDN.Name = "mnuTracuuHDN";
            this.mnuTracuuHDN.Size = new System.Drawing.Size(270, 34);
            this.mnuTracuuHDN.Text = "Hóa đơn nhập ";
            // 
            // mnuTracuuHDB
            // 
            this.mnuTracuuHDB.Name = "mnuTracuuHDB";
            this.mnuTracuuHDB.Size = new System.Drawing.Size(270, 34);
            this.mnuTracuuHDB.Text = "Hóa đơn bán";
            // 
            // mnuTracuuhang
            // 
            this.mnuTracuuhang.Name = "mnuTracuuhang";
            this.mnuTracuuhang.Size = new System.Drawing.Size(270, 34);
            this.mnuTracuuhang.Text = "Hàng hóa";
            // 
            // mnuTracuuKH
            // 
            this.mnuTracuuKH.Name = "mnuTracuuKH";
            this.mnuTracuuKH.Size = new System.Drawing.Size(270, 34);
            this.mnuTracuuKH.Text = "Khách hàng";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaocaoBH,
            this.mnuBaocaoDT,
            this.mnuBaocaoTK});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // mnuBaocaoBH
            // 
            this.mnuBaocaoBH.Name = "mnuBaocaoBH";
            this.mnuBaocaoBH.Size = new System.Drawing.Size(270, 34);
            this.mnuBaocaoBH.Text = "Báo cáo bán hàng";
            // 
            // mnuBaocaoDT
            // 
            this.mnuBaocaoDT.Name = "mnuBaocaoDT";
            this.mnuBaocaoDT.Size = new System.Drawing.Size(270, 34);
            this.mnuBaocaoDT.Text = "Báo cáo doanh thu";
            // 
            // mnuBaocaoTK
            // 
            this.mnuBaocaoTK.Name = "mnuBaocaoTK";
            this.mnuBaocaoTK.Size = new System.Drawing.Size(270, 34);
            this.mnuBaocaoTK.Text = "Báo cáo tồn kho";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHanghoa;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmucHDN;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhmucHDB;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhacungcap;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanvien;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuChatlieu;
        private System.Windows.Forms.ToolStripMenuItem mnuNuocsx;
        private System.Windows.Forms.ToolStripMenuItem mnuCongdung;
        private System.Windows.Forms.ToolStripMenuItem mnuHanghoaNCC;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTracuuHDN;
        private System.Windows.Forms.ToolStripMenuItem mnuTracuuHDB;
        private System.Windows.Forms.ToolStripMenuItem mnuTracuuhang;
        private System.Windows.Forms.ToolStripMenuItem mnuTracuuKH;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocaoBH;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocaoDT;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocaoTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}