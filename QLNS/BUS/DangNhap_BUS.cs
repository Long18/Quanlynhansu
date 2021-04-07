using QuanLyNhanSu.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanSu.BUS
{
	class DangNhap_BUS
	{
        Data dt = new Data();
        public DataTable getTaiKhoan()
        {
            DataTable da = null;
            String sql = "Select * from DANGNHAP ";
            da = dt.getTable(sql);
            return da;
        }

        public void insertTK(String user, String pass, String id, String chucvu)
        {
            String sql = "insert into DANGNHAP values('" + user + "','" + pass + "','" + id + "','" + chucvu + "')";
            
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Thêm thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm thất bại !");
                MessageBox.Show(ex.Message);
            }
        }

        public void updateTK(String user, String pass, String id, String chucvu, bool checklog)
        {
            String sql = "UPDATE DANGNHAP set password=N'" + pass + "',id_Nv='" + id + "',chucvu='" +chucvu +"'" +
                ",checklog= '" + checklog + "'" + "' where username='" + user + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Sửa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa thất bại !");
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteTK(String username)
        {
            String sql = "delete DANGNHAP where username='" + username + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Xóa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi CSDL !" + ex.Message);

            }
        }
    }
}
