using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.DAL;
using QuanLyNhanSu.DTO;
namespace QuanLyNhanSu.BUS
{
    class User_BUS
    {
        User_DTO U = new User_DTO();
        Data da = new Data();
        public DataTable getUser(String condition)
        {
            DataTable dt = null;
            String sql = "Select * from DANGNHAP where " + condition;
            dt=da.getTable(sql);
            return dt;
        }

        public DataTable phanquyen(String id)
        {
            DataTable datb = null;
            String sql = "Select * from DANGNHAP where " + id;
            datb = da.getTable(sql);
            return datb;
        }

        public DataTable lichsu(String ls)
        {
            DataTable datb = null;
            String sql = "Select * from DANGNHAP where " + ls;
            datb = da.getTable(sql);
            return datb;
        }


        public void insertUser(String username, String manv,String chucvu, String lichsu, String pass)
        {
            String sql = "insert into DANGNHAP values('" + username + "','" + pass + "','" + manv + "','" + chucvu + "','" + lichsu + "')";
            da.ExcuteNonQuery(sql);
        }
    }
}
