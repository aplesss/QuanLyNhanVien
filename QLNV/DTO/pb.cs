using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLNV.DAO;


namespace QLNV.DTO
{
    class pb
    {
        private string maphg;
        private string tenphg;

        public pb(string maphg,string tenphg)
        {
            this.maphg = maphg;
            this.tenphg = tenphg;
        }
        public pb(DataRow row)
        {
            this.maphg = row["maphg"].ToString();
            this.tenphg = row["tenphg"].ToString();
        }


        public string Maphg { get => maphg; set => maphg = value; }
        public string Tenphg { get => tenphg; set => tenphg = value; }
    }
}
