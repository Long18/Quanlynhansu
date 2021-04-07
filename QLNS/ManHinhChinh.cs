using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
            if (DangNhap.phanquyen == true)
            {
                btnNhanVien.Enabled = true;
                btnPhongBan.Enabled = true;
                button1.Visible = true;
            }
        }
        private void frm_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Quanlynhanvien frmnv = new Quanlynhanvien();
            frmnv.Show();
            this.Hide();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            Quanlyphongban frmpb = new Quanlyphongban();
            frmpb.Show();
            this.Hide();
        }

        private void btnDuan_Click(object sender, EventArgs e)
        {
            Quanlyduan frmda = new Quanlyduan();
            frmda.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DangNhap frmdn = new DangNhap();
            frmdn.Show();
            this.Hide();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            QuanLyad quanLy = new QuanLyad();
            quanLy.Show();
            this.Hide();
		}
	}
}
