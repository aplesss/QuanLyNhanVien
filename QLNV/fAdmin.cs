using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.DAO;
using QLNV.DTO;

namespace QLNV
{
    public partial class fAdmin : Form
    {
        public Account loginacc;
        private BindingSource acclist = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            load();
            addnvbinding();
        }

        private void btAddAcc_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string dispname = tbName.Text;
            int type = Int32.Parse(tbType.Text);
            
            int t = AccountDAO.Instance.add(username,dispname,type);
            switch (t)
            {
                case 0:
                    MessageBox.Show("Tài khoản trùng", "Thông báo");
                    break;
                
                case 1:
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    loadacc();
                    break;
                case 2:
                    MessageBox.Show("Thêm không thành công", "Thông báo");
                    break;
            }
        }
        void load()
        {
            dtgvAcc.DataSource = acclist;
            loadacc();
        }
        void loadacc()
        {
            acclist.DataSource = AccountDAO.Instance.getlist();
        }
        void addnvbinding()
        {
            tbUsername.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "username", true, DataSourceUpdateMode.Never));
            tbName.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "dispname", true, DataSourceUpdateMode.Never));
            tbType.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "type", true, DataSourceUpdateMode.Never));
           
        }

        private void btViewAcc_Click(object sender, EventArgs e)
        {
            loadacc();
        }

        private void btChangeAcc_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string dispname = tbName.Text;
            

            int t = AccountDAO.Instance.update(username, dispname);
            switch (t)
            {
                case 0:
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo");
                    break;

                case 1:
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    loadacc();
                    break;
                case 2:
                    MessageBox.Show("Sửa không thành công", "Thông báo");
                    break;
            }
        }

        private void btDeleteAcc_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            if(loginacc.Username==username)
            {
                MessageBox.Show("Tài khoản đang đăng nhập, không thể xóa", "Thông báo");
            }
            else
            if(AccountDAO.Instance.delete(username))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                loadacc();
            }
            else
                MessageBox.Show("Xóa không thành công", "Thông báo");
        }

        private void btResetPass_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            

            if (AccountDAO.Instance.reset(username))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công", "Thông báo");
                loadacc();
            }
            else
                MessageBox.Show("Đặt lại mật khẩu không thành công", "Thông báo");
        }
    }
}
