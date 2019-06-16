using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using QLNV.DTO;

namespace QLNV.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;
        private string defaultpass = "123";

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set
            {
                AccountDAO.instance = value;
            }
        }
        private AccountDAO() { }
        public bool login(string username, string pass)
        {
            pass = haspass(pass);
            string query = "exec loginname @username , @pass";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[]{ username,pass});

            return result.Rows.Count > 0;
        }
        private string haspass(string pass)//mã hóa mật khẩu
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);//mã hóa kí tự theo kiểu md5
            byte[] haspass = new MD5CryptoServiceProvider().ComputeHash(temp);//chuyển kí tự của chuỗi thành chuổi băm
            pass = "";
            foreach (byte item in haspass)
            {
                pass += item.ToString();
            }
            return pass;
        }
        public bool update(string username,string dispname,string pass,string newpass)
        {
            pass = haspass(pass);
            newpass = haspass(newpass);
            int rs = DataProvider.Instance.ExcuteNoneQuery("exec updateacc @username , @dispname , @pass , @newpass", new object[] { username, dispname, pass, newpass });
            return (rs > 0);
        }
        public Account GetAccount(string username)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery(string.Format("select*from account where username='{0}'",username));
            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public int add(string username, string name, int type)
        {
            string pass = haspass(defaultpass);
            string query = string.Format("select * from account where username='{0}'", username);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            if (dt.Rows.Count > 0)
                return 0;
            query = string.Format("insert into account(username,dispname,pass,type1) values('{0}',N'{1}','{2}',{3})", username, name,pass, type);
            int data = DataProvider.Instance.ExcuteNoneQuery(query);
            if (data>0)
                return 1;
            return 2;
        }
        public int update(string username, string name)
        {
           
            string query = string.Format("update account set dispname=N'{0}' where username='{1}'",name,username);
            int a = DataProvider.Instance.ExcuteNoneQuery(query);
            if (a > 0)
                return 1;
            else
                return 2;
        }
        public bool delete(string username)
        {
            string query = string.Format("delete from account where username='{0}'", username);
            int a = DataProvider.Instance.ExcuteNoneQuery(query);
            return a > 0;
        }
        public bool reset(string username)
        {
            string pass = haspass(defaultpass);
            string query = string.Format("update account set pass='{0}' where username='{1}'",pass, username);
            int a = DataProvider.Instance.ExcuteNoneQuery(query);
            return a > 0;
        }
       
        public DataTable getlist()
        {
           
            string query = "select username,dispname,type1 as 'type' from account";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
    }
}
