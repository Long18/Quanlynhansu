using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanSu.DTO
{
    public class DuAn_DTO
    {
        String maDa;
        String tenDa;
        int sonvDa;
        String motaDa;
        public String MaDa
        {
            get { return maDa; }
            set { maDa = value; }
        }
        public String TenDa
        {
            get { return tenDa; }
            set { tenDa = value; }
        }
        public int SonvDa
        {
            get { return sonvDa; }
            set { sonvDa = value; }
        }
        public String MotaDa
        {
            get { return motaDa; }
            set { motaDa = value; }
        }
    }
}
