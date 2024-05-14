using CuaHangMyPham.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMyPham.Forms
{
    public partial class frmHanghoa : Form
    {
        public frmHanghoa()
        {
            InitializeComponent();
        }
        DataTable tblHanghoa; 
        private void ResetValues()
        {
            txtMahang.Text = "";
            txtTenhang.Text = "";
            cboMaloai.Text = "";
            cboMakhoiluong.Text = "";
            cboMahangsx.Text = "";
            cboMachatlieu.Text = "";
            cboMacongdung.Text = "";
            cboMamua.Text = "";
            txtAnh.Text = "";
            picAnh.Image = null; 
            cboMamau.Text = "";
            txtSoluong.Text = "0"; 
            txtThoigianbaohanh.Text = "0";
            txtDongiaban.Text = "0";
            txtDongianhap.Text = "0";
        }
        private void frmHanghoa_Load(object sender, EventArgs e)
        {
            txtMahang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
            Functions.FillCombo("SELECT Machatlieu, Tenchatlieu FROM tblChatlieu", cboMachatlieu, "Machatlieu", "Tenchatlieu");
            cboMachatlieu.SelectedIndex = -1;
            Functions.FillCombo("SELECT Maloai, Tenloai FROM tblLoai", cboMaloai, "Maloai", "TenLoai");
            cboMaloai.SelectedIndex = -1;
            Functions.FillCombo("SELECT Machatlieu, Tenchatlieu FROM tblChatlieu", cboMachatlieu, "Machatlieu", "Tenchatlieu");
            cboMakhoiluong.SelectedIndex = -1;
            Functions.FillCombo("SELECT Machatlieu, Tenchatlieu FROM tblChatlieu", cboMachatlieu, "Machatlieu", "Tenchatlieu");
            cboMahangsx.SelectedIndex = -1;
            Functions.FillCombo("SELECT Machatlieu, Tenchatlieu FROM tblChatlieu", cboMachatlieu, "Machatlieu", "Tenchatlieu");
            cboMacongdung.SelectedIndex = -1;
            Functions.FillCombo("SELECT Machatlieu, Tenchatlieu FROM tblChatlieu", cboMachatlieu, "Machatlieu", "Tenchatlieu");
            cboMamua.SelectedIndex = -1;
            Functions.FillCombo("SELECT Machatlieu, Tenchatlieu FROM tblChatlieu", cboMachatlieu, "Machatlieu", "Tenchatlieu");
            cboMamau.SelectedIndex = -1;
            Functions.FillCombo("SELECT Machatlieu, Tenchatlieu FROM tblChatlieu", cboMachatlieu, "Machatlieu", "Tenchatlieu");
            cboManuocSX.SelectedIndex = -1;



            ResetValues();
        }
        private void Load_DataGridView()
        {
            MessageBox.Show("Theem bang"); 
            string sql; 
            //sql = "Select MaHang, TenHang, "
        }
    }
}
