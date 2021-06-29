using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmquanlybanhang
{
    public partial class frmChung : Form
    {
        public frmChung()
        {
            InitializeComponent();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadonbanhang HD = new frmhoadonbanhang();
            HD.MdiParent = this;
            HD.Show();
        }

        private void thêmMớiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlyhanghoa Hang = new frmquanlyhanghoa();
            Hang.MdiParent = this;
            Hang.Show();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadonbanhang HD = new frmhoadonbanhang();
            HD.MdiParent = this;
            HD.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CapNhatToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmquanlyhanghoa Hang = new frmquanlyhanghoa();
            Hang.MdiParent = this;
            Hang.Show();
        }

        private void XoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmquanlyhanghoa Hang = new frmquanlyhanghoa();
            Hang.MdiParent = this;
            Hang.Show();
        }

        private void TimKiemHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlyhanghoa Hang = new frmquanlyhanghoa();
            Hang.MdiParent = this;
            Hang.Show();
        }

        private void CapNhatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void XoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadonbanhang HD = new frmhoadonbanhang();
            HD.MdiParent = this;
            HD.Show();
        }

        private void ThongkehanghoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongkehanghoa TKH = new frmthongkehanghoa();
            TKH.MdiParent = this;
            TKH.Show();
        }

        private void ThongkedoanhthuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongkedoanhthu TKDT = new frmthongkedoanhthu();
            TKDT.MdiParent = this;
            TKDT.Show();
        }

        private void frmChung_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlyhanghoa Hang = new frmquanlyhanghoa();
            Hang.MdiParent = this;
            Hang.Show();
        }
       

       

        
       
    }
}
