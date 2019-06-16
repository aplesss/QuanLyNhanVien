using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNV.DTO;
using System.Windows.Forms;
using System.Data;
namespace QLNV.DAO
{
    class nvDAO
    {
        private static nvDAO instance;

        public static nvDAO Instance
        {
           get
            {
                if (instance == null)
                    instance = new nvDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private nvDAO() { }
        public List<nv> getlistNV()
        {
            List<nv> list = new List<nv>();
            string query = "select* from nhanvien";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)//cusor
            {
                nv a = new nv(item);
                list.Add(a);
            }
            return list;
        }
        public List<nv> find(string tem,int t)
        {
            List<nv> list = new List<nv>();
            string query = "select * from nhanvien where ";
            switch(t)
            {
                case 0:
                    query += string.Format("msnv='{0}'", tem);
                    break;
                case 1:
                    query += string.Format("hoten like '%{0}%'", tem);
                    break;
                case 2:
                    query += string.Format("gioitinh=N'{0}'", tem);
                    break;
                case 3:
                    query += string.Format("phg='{0}'", tem);
                    break;

            }

           
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                nv a = new nv(item);
                list.Add(a);
            }
            return list;

        }
        public int add(string msnv,string hoten,string gioitinh,string phong)
        {
            string query = string.Format("select * from nhanvien where msnv='{0}'", msnv);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            if (data.Rows.Count > 0)
            {
                return 0;
            }
            query = string.Format("select* from phongban where maphg='{0}'", phong);
            data = DataProvider.Instance.ExcuteQuery(query);
            if (data.Rows.Count == 0)
            {
                return 1;
            }
            query = string.Format("insert into nhanvien values ('{0}',N'{1}',N'{2}','{3}')", msnv, hoten, gioitinh, phong);
            int a = DataProvider.Instance.ExcuteNoneQuery(query);
            if (a > 0)
                return 2;
            else
                return 3;
        }
        public int update(string msnv, string hoten, string gioitinh, string phong)
        {
            string query = string.Format("select* from phongban where maphg='{0}'", phong);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            if (data.Rows.Count == 0)
            {
                return 1;
            }
            query = string.Format("update nhanvien set hoten=N'{0}',gioitinh=N'{1}',phg='{2}' where msnv='{3}'",hoten, gioitinh, phong,msnv);
            int a = DataProvider.Instance.ExcuteNoneQuery(query);
            if (a > 0)
                return 2;
            else
                return 3;
        }
        public bool delete(string msnv)
        {
            string query = string.Format("delete from nhanvien where msnv='{0}'", msnv);
            int a = DataProvider.Instance.ExcuteNoneQuery(query);
            return a > 0;
        }
       
    }
}
