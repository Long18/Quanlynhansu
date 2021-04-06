using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNS.BUS;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace QLNS
{
    public partial class Quanlynhanvien : Form
    {
        public Quanlynhanvien()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        NhanVien_BUS nvb = new NhanVien_BUS();
        private void Quanlynhanvien_Load(object sender, EventArgs e)
        {
			// TODO: This line of code loads data into the 'qLNS.DUAN' table. You can move, or remove it, as needed.
			this.dUANTableAdapter.Fill(this.qLNS.DUAN);
			// TODO: This line of code loads data into the 'qLNS.PHONGBAN' table. You can move, or remove it, as needed.
			this.pHONGBANTableAdapter.Fill(this.qLNS.PHONGBAN);
			// TODO: This line of code loads data into the 'qLNS.PHONGBAN' table. You can move, or remove it, as needed.
			this.pHONGBANTableAdapter.Fill(this.qLNS.PHONGBAN);
            dgvNhanVien.DataSource = nvb.getNhanvien();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ManHinhChinh frmmch = new ManHinhChinh();
            frmmch.Show();
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int luongnv=0 ;
            try
            {
                luongnv = int.Parse(txtLuong.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Kiểu dữ liệu của lương phải là kiểu số !");
            }
            if (txtMaNv.Text.Trim() == "")
                MessageBox.Show("Mã nhân viên không được để trống !");
            else if (txtTenNv.Text.Trim() == "")
                MessageBox.Show("Tên nhân viên không được để trống !");
            else if (luongnv == 0)
                MessageBox.Show("Thêm thất bại !");
            else
                nvb.insertNV(txtMaNv.Text, txtTenNv.Text, dtpNgaysinh.Value.ToString("dd/MM/yyyy"), txtDiachi.Text, luongnv, cbxPhongban.SelectedValue.ToString(), cbxDuan.SelectedValue.ToString());
            Quanlynhanvien_Load(sender, e);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int luongnv = 0;
            try
            {
                luongnv = int.Parse(txtLuong.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Kiểu dữ liệu của lương phải là kiểu số !");
            }
            if (txtMaNv.Text.Trim() == "")
                MessageBox.Show("Mã nhân viên không được để trống !");
            else if (txtTenNv.Text.Trim() == "")
                MessageBox.Show("Tên nhân viên không được để trống !");
            else if (luongnv == 0)
                MessageBox.Show("Sửa thất bại !");
            else
                nvb.updateNV(txtMaNv.Text, txtTenNv.Text, dtpNgaysinh.Value.ToString("dd/MM/yyyy"), txtDiachi.Text, luongnv, cbxPhongban.SelectedValue.ToString(), cbxDuan.SelectedValue.ToString());
            Quanlynhanvien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nvb.deleteNV(txtMaNv.Text);
            Quanlynhanvien_Load(sender, e);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String mapb, mada;
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaNv.Text = dgvNhanVien.Rows[row].Cells[0].Value.ToString();
                txtTenNv.Text = dgvNhanVien.Rows[row].Cells[1].Value.ToString();
                dtpNgaysinh.Text = dgvNhanVien.Rows[row].Cells[2].Value.ToString();
                txtDiachi.Text = dgvNhanVien.Rows[row].Cells[3].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[row].Cells[4].Value.ToString();
                mapb = dgvNhanVien.Rows[row].Cells[5].Value.ToString();
                mada = dgvNhanVien.Rows[row].Cells[6].Value.ToString();
                cbxPhongban.Text = nvb.selectPB(mapb);
                cbxDuan.Text = nvb.selectDA(mada);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nvb.Search(txtSearch.Text);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
            txtLuong.Text = "";
            txtMaNv.Text = "";
            txtSearch.Text = "";
            txtTenNv.Text = "";
        }

        private void ExportExcel(DataGridView dgv, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;

            // Lấy cái Header DataGridView
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            //
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportExcel(dgvNhanVien, @"D:\", "xuatfileExcel");
        }

		private void pHONGBANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.pHONGBANBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.qLNS);

		}
	}
}
