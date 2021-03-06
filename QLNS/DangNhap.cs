using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;

using QuanLyNhanSu.BUS;
using QuanLyNhanSu.Entity;
using System.Security.Cryptography;

namespace QuanLyNhanSu
{
    public partial class DangNhap : Form
    {
        public static bool phanquyen, capquyen = false;
        public static String user = "";

        ModelQLNS db = new ModelQLNS();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void frmdangky_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void frmmhc_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        User_BUS ub = new User_BUS();
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            String condition, id,lichsu , taikhoan, matkhau;

            

            StringBuilder s = new StringBuilder(txtPassword.Text);
            string key = "daylachuoimahoa";
            vegeMahoa(ref s, key);
            txtPassword.Text = Convert.ToString(s);



            byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtPassword.Text);

            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);

            String hashPass = "!@#*Th4nHl0n9*#@!";

            foreach (byte item in hashData)
            {
                hashPass += item;
            }

            txtPassword.Text = hashPass;

            taikhoan = txtUsername.Text;
            matkhau = txtPassword.Text;


            id = "chucvu LIKE '%ad%' AND username ='" + taikhoan + "'";
            condition = " username ='" + taikhoan + "' AND password ='" + matkhau + "'";
            lichsu = " LichSu='" + "bat" + "'";

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            lbContent.Text = "Người dùng: " + txtUsername.Text + ", vừa mới: " + btnDangnhap.Text;
            lbtaikhoan.Text = txtUsername.Text;
            user = lbtaikhoan.Text;
            DateTime time = DateTime.Now;
            lbTime.Text = time.ToString("dd/MM/yyyy, HH:mm:ss");


            CHECKLOG log = new CHECKLOG();

            

            try
            {
                dt2 = ub.lichsu(lichsu);
                dt1 = ub.phanquyen(id);
                dt = ub.getUser(condition);

                if(dt2.Rows.Count > 0)
				{
                    capquyen = true;
				}


                if (dt.Rows.Count > 0 && dt1.Rows.Count > 0 && dt2.Rows.Count > 0)
                {
                    phanquyen = true;
                    MessageBox.Show("Đăng nhập thành công !" + "\nAdmin Login!!");
                    ManHinhChinh frmmhc = new ManHinhChinh();
                    frmmhc.FormClosed += new FormClosedEventHandler(frmmhc_Closed);
                    frmmhc.Show();
                    this.Hide();

                    log.Ngay = lbTime.Text.Trim();
                    log.Noidung = lbContent.Text.Trim();

                    db.CHECKLOG.Add(log);
                    db.SaveChanges();
                }
                else if (dt.Rows.Count > 0 && dt1.Rows.Count == 0){
                    phanquyen = false;
                    MessageBox.Show("Đăng nhập thành công !");
                    ManHinhChinh frmmhc = new ManHinhChinh();
                    frmmhc.FormClosed += new FormClosedEventHandler(frmmhc_Closed);
                    frmmhc.Show();
                    this.Hide();

                    log.Ngay = lbTime.Text.Trim();
                    log.Noidung = lbContent.Text.Trim();

                    db.CHECKLOG.Add(log);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công. \nSai mật khẩu hoặc tài khoản không tồn tại!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai cú pháp");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối CSDL !");
            }

            


		}

        private void btnDangky_Click(object sender, EventArgs e)
        {
            DangKy frmdk = new DangKy();
            frmdk.FormClosed += new FormClosedEventHandler(frmdangky_Closed);
            frmdk.Show();
            this.Hide();
        }



        public void vegeMahoa(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++) s[i] = char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    s[i] = (char)((s[i]) + key[j] - 'A');
                    if (s[i] > 'Z') s[i] = (char)(s[i] - 'Z' + 'A' - 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }
    }
}
