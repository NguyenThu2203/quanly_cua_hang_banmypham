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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuCongdung_Click(object sender, EventArgs e)
        {
            frmCongdung a = new frmCongdung();
            a.Show(); 
        }

        private void mnuHanghoa_Click(object sender, EventArgs e)
        {
            frmHanghoa b = new frmHanghoa();
            b.Show(); 
        }

        private void mnuLoai_Click(object sender, EventArgs e)
        {
            frmLoai c = new frmLoai();
            c.Show();
        }

<<<<<<< HEAD
        private void mnuChatlieu_Click(object sender, EventArgs e)
        {
            frmChatlieu a = new frmChatlieu();
            a.Show();
        }

        private void mnuNuocsx_Click(object sender, EventArgs e)
        {
            frmNuocsanxuat a = new frmNuocsanxuat();
            a.Show();
=======
        private void mnuHangsx_Click(object sender, EventArgs e)
        {
            frmHangsanxuat d = new frmHangsanxuat();
            d.Show();
>>>>>>> e6b12d1ea0038e86810aa3992f92ac0319e13740
        }
    }
}
