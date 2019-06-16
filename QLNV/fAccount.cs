using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNV.DTO;
using QLNV.DAO;

namespace QLNV
{
    public partial class fAccount : Form
    {
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
        public fAccount(Account acc)
        {
            this.loginacc = acc;
            InitializeComponent();
            change();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void change()
        {
            tbUsername.Text = loginacc.Username;
            tbName.Text = loginacc.Dispname;
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            update();
        }
        void update()
        {
            string username = tbUsername.Text;
            string dispname = tbName.Text;
            string pass = tbPass.Text;
            string newpass = tbNewPass.Text;
            string renewpass = tbReNewPass.Text;
            if (!newpass.Equals(renewpass))
                MessageBox.Show("Mật khẩu mới không trùng với mật khẩu nhập lại", "Thông báo");
            else
            {
                if (AccountDAO.Instance.update(username, dispname, pass, newpass))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    if (loginacc != null)
                        updateaccount(this,new AccountEvent(AccountDAO.Instance.GetAccount(username) ));
                }
                else
                {
                    MessageBox.Show("Mật khẩu sai", "Thông báo");
                }
            }
        }
        private event EventHandler<AccountEvent> updateaccount;//event cchuyển dữ liệu từ form con về form cha
        public event EventHandler<AccountEvent> Updateaccount
        {
            add { updateaccount += value; }
            remove { updateaccount -= value; }
        }

        
    }
    public class AccountEvent:EventArgs
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }
        public AccountEvent(Account acc)
        {
            this.acc = acc;
        }
    }
}
