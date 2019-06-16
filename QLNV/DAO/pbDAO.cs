using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNV.DTO;
using System.Data;
namespace QLNV.DAO
{
    class pbDAO
    {
        private static pbDAO instance;

        public static pbDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new pbDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private pbDAO() { }
        public List<pb> getlistpb()
        {
            List<pb> list = new List<pb>();
            string query = "select *from phongban";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                pb a = new pb(item);
                list.Add(a);
            }
            return list;
        }
        public List<pb> find(string tem,int t)
        {
            List<pb> list = new List<pb>();
            string query = "select * from phongban where ";
            switch (t)
            {
                case 0:
                    query += string.Format("maphg='{0}'", tem);
                    break;
                case 1:
                    query += string.Format("tenphg like '%{0}%'", tem);
                    break;
                

            }
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                pb a = new pb(item);
                list.Add(a);
            }
            return list;

        }
        public int add(string maphg,string tenphg)
        {
            string query = string.Format("select * from phongban where maphg='{0}'", maphg);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return 0;
            }
            
            query = string.Format("insert into phongban values ('{0}',N'{1}')",maphg,tenphg);
            int a = DataProvider.Instance.ExcuteNoneQuery(query);
            if (a > 0)
                return 2;
            else
                return 3;
        }
        public int update(string mphg,string tenphg)
        {

            
          
            string query = string.Format("update phongban set tenphg=N'{0}' where maphg='{1}'", tenphg,mphg);
            int a = DataProvider.Instance.ExcuteNoneQuery(query);
            if (a > 0)
                return 2;
            else
                return 3;
        }
        public bool delete(string maphg)
        {
            string query = "exec deletephg @maphg";
            int a = DataProvider.Instance.ExcuteNoneQuery(query,new object[] { maphg });
            return a > 0;
        }
    }
}
