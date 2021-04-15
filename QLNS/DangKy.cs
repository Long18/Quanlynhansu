using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyNhanSu.BUS;
using System.Data.SqlClient;
using System.Security.Cryptography;
using QuanLyNhanSu.Entity;

namespace QuanLyNhanSu
{
    public partial class DangKy : Form
    {
        ModelQLNS db = new ModelQLNS();
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }
        
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DangNhap frmdn = new DangNhap();
            frmdn.Show();
            this.Hide();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            String lichsuu = "bat";
            User_BUS ub = new User_BUS();

            StringBuilder s = new StringBuilder(txtMatkhau.Text);
            StringBuilder s1 = new StringBuilder(txtNhaplai.Text);
            string key = "daylachuoimahoa";
            vegeMahoa(ref s, key);
            vegeMahoa(ref s1, key);
            txtMatkhau.Text = Convert.ToString(s);
            txtNhaplai.Text = Convert.ToString(s1);

            byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtMatkhau.Text);
            byte[] temp1 = ASCIIEncoding.ASCII.GetBytes(txtNhaplai.Text);

            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
            byte[] hashData1 = new MD5CryptoServiceProvider().ComputeHash(temp1);

            String hashPass = "!@#*Th4nHl0n9*#@!";
            String hashPass1 = "!@#*Th4nHl0n9*#@!";

            foreach (byte item in hashData)
			{
                hashPass += item;
			}

            foreach (byte item in hashData1)
            {
                hashPass1 += item;
            }

            txtMatkhau.Text = hashPass;
            txtNhaplai.Text = hashPass1;

            try
            {
                if (txtNhaplai.Text == txtMatkhau.Text)
                {
                    String chucvu = "nhanvien";


                    DANGNHAP nv = new DANGNHAP();
                    nv.username = txtTaikhoan.Text.Trim();
                    nv.password = txtMatkhau.Text.Trim();
                    nv.id_Nv = txtMaNv.Text.Trim();
                    nv.chucvu = chucvu;
                    nv.LichSu = lichsuu;

                    db.DANGNHAP.Add(nv);
                    +
                        db.SaveChanges();
                    



                    MessageBox.Show("Đăng ký tài khoản thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng !");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn nhập sai cú pháp !");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
            }

        }



        static void vegaGM(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s[i] = s[i] >= key[j] ?
                              (char)(s[i] - key[j] + 'A') :
                              (char)('A' + ('Z' - key[j] + s[i] - 'A') + 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
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
