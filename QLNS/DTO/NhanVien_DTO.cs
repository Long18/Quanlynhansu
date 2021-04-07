using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanSu.DTO
{
    public class NhanVien_DTO
    {
        String maNv;
        String tenNv;
        String luongNv;
        String diachiNv;
        DateTime ngaysinhNv;
        String daNv;
        String pbNv;
        public String MaNv
        {
            get { return maNv; }
            set { maNv = value; }
        }
        public String TenNv
        {
            get { return tenNv; }
            set { tenNv = value; }
        }
        public String LuongNV
        {
            get { return luongNv; }
            set { luongNv = value; }
        }
        public String DiachiNv
        {
            get { return diachiNv; }
            set { diachiNv = value; }
        }
        public String DaNv
        {
            get { return daNv; }
            set { daNv = value; }
        }
        public String PbNv
        {
            get { return pbNv; }
            set { pbNv = value; }
        }
    }
}
