using QuanLyNhanSu.BUS;
using QuanLyNhanSu.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
	public partial class QuanLyad : Form
	{
		public QuanLyad()
		{
			InitializeComponent();
			/*if (ckbYes.Checked)
			{

			}*/
		}

		ModelQLNS db = new ModelQLNS();
		public static bool checklog = false;

		DangNhap_BUS dab = new DangNhap_BUS();

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
		private void button1_Click(object sender, EventArgs e)
		{
			ManHinhChinh frmmch = new ManHinhChinh();
			frmmch.Show();
			this.Hide();
		}

		private void QuanLy_Load(object sender, EventArgs e)
		{
			dgvLogin.DataSource = dab.getTaiKhoan();
		}

		private void btnthem_Click(object sender, EventArgs e)
		{

			
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			String log;
			StringBuilder s = new StringBuilder(txtmatkhau.Text);
			string key = "daylachuoimahoa";
			vegeMahoa(ref s, key);
			txtmatkhau.Text = Convert.ToString(s);


			byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtmatkhau.Text);

			byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);

			String hashPass = "!@#*H3LL0WOLD*#@!";

			foreach (byte item in hashData)
			{
				hashPass += item;
			}

			txtmatkhau.Text = hashPass;





			try
			{
				DANGNHAP capquyenn = new DANGNHAP();

				if (txtuser.Text.Trim() == "")
					MessageBox.Show("Tài khoản không được để trống !");
				else if (txtmatkhau.Text.Trim() == "")
					MessageBox.Show("Mật khẩu không được để trống !");

				if (ckbYes.Checked == true)
				{
					//log = "bat";
					capquyenn.LichSu = "bat";
				}
				else
				{
					//log = "tat";
					capquyenn.LichSu = "tat";
				}

				capquyenn.username = txtuser.Text.Trim();
				capquyenn.password = txtmatkhau.Text.Trim();
				capquyenn.id_Nv = txtSoNV.Text.Trim();
				capquyenn.chucvu = txtchucvu.Text.Trim();

				db.Entry(capquyenn).State = System.Data.Entity.EntityState.Modified;
				//db.DANGNHAP.(capquyenn);
				db.SaveChanges();

			}
			catch (FormatException ex)
			{
				MessageBox.Show("Số nhân viên phải là kiểu số nguyên !" + ex.Message);
			}
			
			/*else
			{
				try
				{
					dab.updateTK(txtuser.Text, txtmatkhau.Text, txtSoNV.Text, txtchucvu.Text,log);
				}
				catch (FormatException ex)
				{
					MessageBox.Show("Số nhân viên phải là kiểu số nguyên !" + ex.Message);
				}
			}*/
			QuanLy_Load(sender, e);
		}

		private void dgvLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index >= 0)
			{
				txtuser.Text = dgvLogin.Rows[index].Cells[0].Value.ToString();
				txtchucvu.Text = dgvLogin.Rows[index].Cells[2].Value.ToString();
				txtSoNV.Text = dgvLogin.Rows[index].Cells[1].Value.ToString();
				txtmatkhau.Text = dgvLogin.Rows[index].Cells[4].Value.ToString();
				if (dgvLogin.Rows[index].Cells[3].Value.ToString() == "bat")
				{
					ckbYes.Checked = true;
					ckbNo.Checked = false;
				}
				else
				{
					ckbNo.Checked = true;
					ckbYes.Checked = false;
				}
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			dab.deleteTK(txtuser.Text);
			QuanLy_Load(sender, e);
		}

		private void btnkiemtra_Click(object sender, EventArgs e)
		{
			ActivityLog acl = new ActivityLog();
			acl.Show();
		}
	}
}
