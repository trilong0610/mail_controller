using MailController.account;
using MailController.common;
using MailController.mail;
using MailController.model;
using MailController.services;
using MailController.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailController
{
    public partial class Form1 : Form
    {
        MailRepository mail;
        Form activeForm;
        Button currentButton;
        public Form1()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            mail = new MailRepository();
            openChildForm(new MailForm(), btn_mail);
            
        }

        

        private void btn_mail_Click(object sender, EventArgs e)
        {
            CommonXml xml = new CommonXml();
            List<ModelAccount> list = xml.getAccounts();

            openChildForm(new MailForm(), sender);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new AccountForm(), sender);
        }

        private void openChildForm(Form childform, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(sender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panel_desktop.Controls.Add(childform);
            this.panel_desktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lbl_tittle.Text = childform.Text;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = CommonCustom.SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                   // panelTitleBar.BackColor = color;
                    //panelLogo.BackColor = color;

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(39, 39, 58);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

            }
        }




    }
}
