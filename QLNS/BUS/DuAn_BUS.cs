using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyNhanSu.DAL;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.BUS
{
    class DuAn_BUS
    {
        Data dt = new Data();
        public DataTable getDUAN()
        {
            DataTable da = null;
            String sql = "Select * from DUAN ";
            da = dt.getTable(sql);
            return da;
        }
        public void insertDA(String maDA, String tenDA, int sonv, String mota)
        {
            String sql = " insert into DUAN values('" + maDA + "',N'" + tenDA + "','" + sonv + "',N'" + mota + "')";
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
        public void updateDA(String maDA, String tenDA, int sonv, String mota)
        {
            String sql = "UPDATE DUAN set name_DA=N'" + tenDA + "',sonv_DA='" + sonv + "',mota_DA=N'" +
                mota + "' where id_DA='" + maDA + "'";
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
        public void deleteDA(String maDA)
        {
            String sql = "delete DUAN where id_DA='" + maDA + "'";
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
        public DataTable Search(String condi)
        {
            DataTable da = null;
            String sql = "Select * from DUAN where id_DA like N'%" + condi + "%' OR name_DA like N'%" + condi + "%'";
            da = dt.getTable(sql);
            return da;
        }
    }
}
