using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNV.DAO;
using QLNV.DTO;

namespace QLNV.DTO
{
    class nv
    {
        private string msnv;
        private string hoten;
        private string gioitinh;
        private string phong;

        public nv(string msnv,string name,string gioitinh,string phong)
        {
            this.msnv = msnv;
            this.hoten = name;
            this.gioitinh = gioitinh;
            this.phong = phong;
        }
        public nv(DataRow row)
        {
            this.msnv = row["msnv"].ToString();
            this.hoten = row["hoten"].ToString();
            this.gioitinh = row["gioitinh"].ToString();
            this.phong = row["phg"].ToString();
        }

        public string Msnv { get => msnv; set => msnv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Phong { get => phong; set => phong = value; }
      
    }
}
