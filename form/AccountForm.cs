using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailController.xml;
using MailController.common;

namespace MailController.account
{
    public partial class AccountForm : Form
    {
        CommonXml commonXml;

        public AccountForm()
        {

            InitializeComponent();
            load();
            loadDataAccount();
        }

        private void load()
        {
            commonXml = new CommonXml();
        }

        private void btn_account_add_Click(object sender, EventArgs e)
        {
            commonXml.addAccount(txt_account_username.Text, txt_account_password.Text);
            loadDataAccount();
        }

        private void loadDataAccount()
        {
            var data = commonXml.getAccounts();

            txt_account_username.DataBindings.Clear();
            txt_account_password.DataBindings.Clear();

            txt_account_username.DataBindings.Add("text", data, "username", false, DataSourceUpdateMode.OnPropertyChanged);
            txt_account_password.DataBindings.Add("text", data, "password", false, DataSourceUpdateMode.OnPropertyChanged);

            grid_account.DataSource = data;
        }

        private void btn_account_delete_Click(object sender, EventArgs e)
        {
            List<string> idChecked = CommonCustom.getMailChecked(grid_account);

            idChecked.ForEach(x => commonXml.deleteAccount(x));
            
            loadDataAccount();
        }

        private void btn_account_change_Click(object sender, EventArgs e)
        {
            string id = grid_account.CurrentRow.Cells[1].Value.ToString();
            commonXml.updateAccount(id, txt_account_username.Text, txt_account_password.Text);
            loadDataAccount();
        }
    }
}
