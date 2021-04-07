using QuanLyNhanSu.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyNhanSu.BUS
{
	class Log_BUS
	{

        Data dt = new Data();
        public DataTable getLog()
        {
            DataTable da = null;
            String sql = "Select * from Log ";
            da = dt.getTable(sql);
            return da;
        }

        public DataTable delLog()
        {
            DataTable da = null;
            String sql = "Delete from Log ";
            da = dt.getTable(sql);
            return da;
        }
    }
}
