using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.DAO;
using QLNV.DTO;

namespace QLNV
{
    public partial class fTable : Form
    {
        private BindingSource nvlist = new BindingSource();
        private BindingSource pblist = new BindingSource();
        private int findnv =-1;
        private int findpb;
        private Account loginacc;
        public Account Loginacc
        {
            get
            {
                return loginacc;
            }
            set
            {
                loginacc = value;
                
            }
        }

        public fTable(Account acc)
        {
            
            InitializeComponent();
            this.loginacc = acc;
            changeLoginacctype(loginacc.Type);
            load();
           
            
        }
        void changeLoginacctype(int type)
        {
            adminToolStripMenuItem.Enabled = (type == 1);
            tàiKhoảnToolStripMenuItem.Text += " (" + this.loginacc.Dispname + ")";
        }
        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        void load()
        {
            dtgvNV.DataSource = nvlist;//lưu kết nối binding
            dtgvPB.DataSource = pblist;
            loadNV();
            loadPB();
            addnvbinding();
            addpbbinding();
        }
        void loadNV()
        {
           nvlist.DataSource=nvDAO.Instance.getlistNV();
           
        }
        void loadPB()
        {
           pblist.DataSource = pbDAO.Instance.getlistpb();
            
        }
        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount(loginacc);
            f.Updateaccount += f_Updateaccount;
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginacc = loginacc;
            f.ShowDialog();
        }

        private void btViewNV_Click(object sender, EventArgs e)
        {
            loadNV();
            //addnvbinding();
        }
        void f_Updateaccount(object sender,AccountEvent e)
        {
            tàiKhoảnToolStripMenuItem.Text ="Tài khoản"+ " (" + e.Acc.Dispname + ")";
        }
        private void btViewP_Click(object sender, EventArgs e)
        {
            loadPB();
        }
        void addnvbinding()
        {
            tbNameNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource,"hoten",true,DataSourceUpdateMode.Never));//thay đổi thuộc tính text bằng giá trị hoten nguồn từ dtgv
            tbMSNV.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "msnv", true, DataSourceUpdateMode.Never));
            tbGender.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "Gioitinh", true, DataSourceUpdateMode.Never));
            tbPHG.DataBindings.Add(new Binding("Text", dtgvNV.DataSource, "phong", true, DataSourceUpdateMode.Never));
        }
        void addpbbinding()
        {
            tbMaP.DataBindings.Add(new Binding("Text", dtgvPB.DataSource, "maphg",true,DataSourceUpdateMode.Never));
            tbTenP.DataBindings.Add(new Binding("Text", dtgvPB.DataSource, "tenphg", true, DataSourceUpdateMode.Never));

        }
        private void btAddNV_Click(object sender, EventArgs e)
        {
            string msnv = tbMSNV.Text;
            string hoten = tbNameNV.Text;
            string gioitinh = tbGender.Text;
            string phong = tbPHG.Text;
            int t = nvDAO.Instance.add(msnv, hoten, gioitinh, phong);
            switch(t)
            {
                case 0:
                    MessageBox.Show("MSNV trùng", "Thông báo");
                    break;
                case 1:
                    MessageBox.Show("Không tồn tại phòng", "Thông báo");
                    break;
                case 2:
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    loadNV();
                    break;
                case 3:
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                    break;
            }
        }

        private void btAddP_Click(object sender, EventArgs e)
        {
            string maphg = tbMaP.Text;
            string tenphg = tbTenP.Text;
            int t = pbDAO.Instance.add(maphg, tenphg);
            switch(t)
            {
                case 0:
                    MessageBox.Show("Mã phòng trùng", "Thông báo");
                    break;
                case 1:
                    MessageBox.Show("Không tồn tại phòng", "Thông báo");
                    break;
                case 2:
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    loadPB();
                    break;
                case 3:
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                    break;
            }
        }

        private void btChangeNV_Click(object sender, EventArgs e)
        {
            string msnv = tbMSNV.Text;
            string hoten = tbNameNV.Text;
            string gioitinh = tbGender.Text;
            string phong = tbPHG.Text;
            int t = nvDAO.Instance.update(msnv, hoten, gioitinh, phong);
            switch (t)
            {
                case 0:
                    MessageBox.Show("MSNV trùng", "Thông báo");
                    break;
                case 1:
                    MessageBox.Show("Không tồn tại phòng", "Thông báo");
                    break;
                case 2:
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    loadNV();
                    break;
                case 3:
                    MessageBox.Show("Sửa không thành công", "Thông báo");
                    break;
            }

        }

        private void btDeleteNV_Click(object sender, EventArgs e)
        {
            string msnv = tbMSNV.Text;
            if(nvDAO.Instance.delete(msnv))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                loadNV();
            }
            else
                MessageBox.Show("Xóa không thành công", "Thông báo");
        }

        private void btFindNV_Click(object sender, EventArgs e)
        {
            string msnv = tbFindNV.Text;
            if (findnv != -1)
            {
                List<nv> data = nvDAO.Instance.find(msnv, findnv);
                nvlist.DataSource = data;
            }
            else
                MessageBox.Show("Chọn điều kiện tìm", "Thông báo");
        }

        private void btChangeP_Click(object sender, EventArgs e)
        {
            string maphg = tbMaP.Text;
            string tenphg = tbTenP.Text;
            int t = pbDAO.Instance.update(maphg, tenphg);
            switch (t)
            {
                case 0:
                    MessageBox.Show("Mã phòng trùng", "Thông báo");
                    break;
                case 1:
                    MessageBox.Show("Không tồn tại phòng", "Thông báo");
                    break;
                case 2:
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    loadPB();
                    break;
                case 3:
                    MessageBox.Show("Sửa không thành công", "Thông báo");
                    break;
            }
        }

        private void btFindP_Click(object sender, EventArgs e)
        {
            string mphg = tbFindP.Text;
            if (findpb != -1)
            {
                List<pb> list = pbDAO.Instance.find(mphg,findpb);
                pblist.DataSource = list;
            }
            else
                MessageBox.Show("Chọn điều kiện tìm", "Thông báo");
        }

        private void rbMsnv_CheckedChanged(object sender, EventArgs e)
        {
            findnv = 0;
        }

        private void rbHoten_CheckedChanged(object sender, EventArgs e)
        {
            findnv = 1;
        }

        private void rbGender_CheckedChanged(object sender, EventArgs e)
        {
            findnv = 2;
        }

        private void rbPhg_CheckedChanged(object sender, EventArgs e)
        {
            findnv = 3;
        }

        private void rbMaphg_CheckedChanged(object sender, EventArgs e)
        {
            findpb = 0;
        }

        private void rbTenphg_CheckedChanged(object sender, EventArgs e)
        {
            findpb = 1;
        }

        private void btDeleteP_Click(object sender, EventArgs e)
        {
            string maphg = tbMaP.Text;
            if(pbDAO.Instance.delete(maphg))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                loadPB();
                loadNV();
            }
            else
                MessageBox.Show("Xóa không thành công", "Thông báo");
        }
    }
}
