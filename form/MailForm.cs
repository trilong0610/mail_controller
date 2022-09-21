using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailController.common;
using MailController.model;
using MailController.services;
using MailController.xml;
namespace MailController.mail
{
    public partial class MailForm : Form
    {
        CommonXml xml;
        CheckBox chkAllAccountMail;
        CheckBox chkAllMail;
        List<ModelAccount> mailChecked;
        public MailForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            xml = new CommonXml();
            mailChecked = new List<ModelAccount>();
            // Load danh sach mail
            
            var accounts = xml.getAccounts();
            grid_account_mail.DataSource = accounts;
            grid_account_mail.Columns[3].Visible = false;
            process_mail_load.Visible = false;

            // Thêm nút check all account, check all mail và sự kiện click cho nó
            chkAllAccountMail =  CommonCustom.addHeaderCheckbox(grid_account_mail);
            chkAllMail = CommonCustom.addHeaderCheckbox(grid_view_mail);

            chkAllAccountMail.MouseClick += new MouseEventHandler(chkAllAccountMail_MouseClick);
            chkAllMail.MouseClick += new MouseEventHandler(chkAllMail_MouseClick);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            MailRepository mail = new MailRepository();

            
            grid_view_mail.Refresh();
            // Lay thong tin gmail dang dc chon
            mailChecked = getAccountChecked();

            //Set processbar 
            process_mail_load.Maximum = mailChecked.Count;
            process_mail_load.Visible = true;
            process_mail_load.Value = 0;

            // Lay mail tu gmail dc chon

            var mails = new List<ModelMail>();
            for (int i = 0; i < mailChecked.Count; i++)
            {
                // Lay inbox folder + message
                var messages = await mail.GetUnreadMail("imap.gmail.com", 993, mailChecked[i].username, mailChecked[i].password);
                //Them inbox + message vao list
                mails.AddRange(messages);
                process_mail_load.Value += 1;
            }


            process_mail_load.Visible = false;
            grid_view_mail.DataSource= mails;
            grid_view_mail.Update();
            grid_view_mail.Refresh();
            grid_view_mail.Columns[6].Visible = false; // Ẩn cột nội dung mail

        }

        public List<ModelAccount> getAccountChecked()
        {
            List<ModelAccount> list = new List<ModelAccount>();
            for (int i = 0; i < grid_account_mail.RowCount; i++)
            {
                DataGridViewRow row = grid_account_mail.Rows[i];
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    var account = new ModelAccount();
                    account.id = Convert.ToInt32(row.Cells[1].Value);
                    account.username = row.Cells[2].Value.ToString();
                    account.password = row.Cells[3].Value.ToString();
                    list.Add(account);
                }

                

            }
            return list;
        }

        private void MailForm_Load(object sender, EventArgs e)
        {

        }

        private void chk_all_account_mail_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chkAllAccountMail_MouseClick(object sender, MouseEventArgs e)
        {
            CommonCustom.headerCheckBoxClick((CheckBox)sender, grid_account_mail);
        }

        private void chkAllMail_MouseClick(object sender, MouseEventArgs e)
        {
            CommonCustom.headerCheckBoxClick((CheckBox)sender, grid_view_mail);
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            
            List<ModelAccount> list = new List<ModelAccount>();
            for (int i = 0; i < grid_view_mail.RowCount; i++)
            {
                List<ModelMail> mails = new List<ModelMail>();

                DataGridViewRow row = grid_view_mail.Rows[i];
                // Lay nhung mail duoc tich
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    // Tim id cua account
                    var idMail = Convert.ToInt32(row.Cells[1].Value);
                    var username = row.Cells[5].Value + "@gmail.com";
                    var mail = new ModelMail();
                    mail.id = idMail;
                    mail.to = username;
                    mails.Add(mail);
                }

                // dò từng account, nếu có mail cần mark as read thì mở kết nối và chạy
                foreach (var account in mailChecked)
                {
                    var ids = new List<int>();
                    // Lấy những id đc chọn của mail hiện tại
                    foreach (var mail in mails)
                    {
                        if (mail.to.Equals(account.username))
                        {
                            ids.Add(mail.id);
                        }
                    }

                    // Mở kết nối, đánh dấu đã đọc


                }

            }
        }
    }
}
