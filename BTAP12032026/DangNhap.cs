using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTAP13032026
{
    public class DangNhap
    {
        public string username { get; set; }
        public string password { get; set; }
        public DangNhap() { }
        public DangNhap(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
