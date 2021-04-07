using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanSu.DTO
{
    public class User_DTO
    {
        String username;
        String password;
        String id_Nv;
        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public String Id_Nv 
        {
            get { return id_Nv; }
            set { id_Nv = value; }
        }
    }
}
