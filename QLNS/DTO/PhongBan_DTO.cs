using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNS.DTO
{
    public class PhongBan_DTO
    {
        String maPb;
        String tenPb;
        int sonvPb;
        String motaPb;
        public String MaPB
        {
            get { return maPb; }
            set { maPb = value; }
        }
        public String TenPb
        {
            get { return tenPb; }
            set { tenPb = value; }
        }
        public int SonvPb
        {
            get { return sonvPb; }
            set { sonvPb = value; }
        }
        public String MotaPb
        {
            get { return motaPb; }
            set { motaPb = value; }
        }
    }
}
