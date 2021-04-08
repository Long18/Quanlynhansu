using QuanLyNhanSu.Entity;
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
        Modellll db = new Modellll();
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


            if (DangNhap.capquyen == true)
            {
                lbContent.Text = "Người dùng: " + DangNhap.user + ", vừa mới vào: " + btnNhanVien.Text;
                lbtaikhoan.Text = DangNhap.user;
                DateTime time = DateTime.Now;
                lbTime.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");


                CHECKLOG log = new CHECKLOG();

                log.Ngay = lbTime.Text.Trim();
                log.Noidung = lbContent.Text.Trim();

                db.CHECKLOG.Add(log);
                db.SaveChanges();
            }

        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            Quanlyphongban frmpb = new Quanlyphongban();
            frmpb.Show();
            this.Hide();

            if (DangNhap.capquyen == true)
            {
                lbContent.Text = "Người dùng: " + DangNhap.user + ", vừa mới vào: " + btnPhongBan.Text;
                lbtaikhoan.Text = DangNhap.user;
                DateTime time = DateTime.Now;
                lbTime.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");


                CHECKLOG log = new CHECKLOG();

                log.Ngay = lbTime.Text.Trim();
                log.Noidung = lbContent.Text.Trim();

                db.CHECKLOG.Add(log);
                db.SaveChanges();
            }

        }

        private void btnDuan_Click(object sender, EventArgs e)
        {
            Quanlyduan frmda = new Quanlyduan();
            frmda.Show();
            this.Hide();

            if (DangNhap.capquyen == true)
            {
                lbContent.Text = "Người dùng: " + DangNhap.user + ", vừa mới vào: " + btnDuan.Text;
                lbtaikhoan.Text = DangNhap.user;
                DateTime time = DateTime.Now;
                lbTime.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");


                CHECKLOG log = new CHECKLOG();

                log.Ngay = lbTime.Text.Trim();
                log.Noidung = lbContent.Text.Trim();

                db.CHECKLOG.Add(log);
                db.SaveChanges();
            }

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
