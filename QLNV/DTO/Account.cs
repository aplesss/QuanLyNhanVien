using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV.DTO
{
    public class Account
    {
        public Account(string username,string dispname,int type,string pass=null)
        {
            this.username = username;
            this.dispname = dispname;
            this.type = type;
            this.pass = pass;
        }
        public Account(DataRow row)
        {
            this.username = row["username"].ToString();
            this.dispname = row["dispname"].ToString();
            this.pass = row["pass"].ToString();
            this.type = (int)row["type1"];
        }
        private string username;
        private string dispname;
        private string pass;
        private int type;

        public string Username { get => username; set => username = value; }
        public string Dispname { get => dispname; set => dispname = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Type { get => type; set => type = value; }
    }
}
