using QuanLyNhanSu.BUS;
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
	public partial class ActivityLog : Form
	{
		public ActivityLog()
		{
			InitializeComponent();
		}
		Log_BUS dab = new Log_BUS(); 

		private void button1_Click(object sender, EventArgs e)
		{
			ManHinhChinh frmmch = new ManHinhChinh();
			frmmch.Show();
			this.Hide();
			frmmch.Close();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void ActivityLog_Load(object sender, EventArgs e)
		{
			dgvLog.DataSource = dab.getLog();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			dab.delLog();
			ActivityLog_Load(sender, e);
		}
	}
}
