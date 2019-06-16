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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string pass = tbPass.Text;
            if (login(username,pass))
            {
                Account loginacc = AccountDAO.Instance.GetAccount(username);
                fTable f = new fTable(loginacc);
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK);
       
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát?","Thông báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        bool login(string username,string pass)
        {
            return AccountDAO.Instance.login(username, pass);
        }
    }
}
