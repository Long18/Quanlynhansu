using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNS.BUS;
namespace QLNS
{
    public partial class Quanlyphongban : Form
    {
        public Quanlyphongban()
        {
            InitializeComponent();
        }
        PhongBan_BUS pbb = new PhongBan_BUS();
        private void btnExit_Click(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPhongban.DataSource = pbb.Search(txtSearch.Text);

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int sonv=0;
            if (txtMaPB.Text.Trim() == "")
                MessageBox.Show("Mã phòng ban không được để trống !");
            else if (txtTenPB.Text.Trim() == "")
                MessageBox.Show("Tên phòng ban không được để trống !");
            else
                pbb.insertPB(txtMaPB.Text,txtTenPB.Text,sonv,txtMota.Text);
            Quanlyphongban_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPB.Text.Trim() == "")
                MessageBox.Show("Mã phòng ban không được để trống !");
            else if (txtTenPB.Text.Trim() == "")
                MessageBox.Show("Tên phòng ban không được để trống !");
            else
            {
                try
                {
                    pbb.updatePB(txtMaPB.Text, txtTenPB.Text, int.Parse(txtSoNV.Text), txtMota.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Số nhân viên phải là kiểu số nguyên !"+ex.Message);
                }
            }
            Quanlyphongban_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            pbb.deletePB(txtMaPB.Text);
            Quanlyphongban_Load(sender, e);
        }

        private void dgvPhongban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaPB.Text = dgvPhongban.Rows[index].Cells[0].Value.ToString();
                txtTenPB.Text = dgvPhongban.Rows[index].Cells[1].Value.ToString();
                txtSoNV.Text = dgvPhongban.Rows[index].Cells[2].Value.ToString();
                txtMota.Text = dgvPhongban.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void Quanlyphongban_Load(object sender, EventArgs e)
        {
            dgvPhongban.DataSource=pbb.getPHONGBAN();
        }
    }
}
