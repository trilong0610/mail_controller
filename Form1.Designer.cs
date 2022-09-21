namespace MailController
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_mail = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbl_tittle = new System.Windows.Forms.Label();
            this.panel_desktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelMenu.Controls.Add(this.btn_account);
            this.panelMenu.Controls.Add(this.btn_mail);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(183, 719);
            this.panelMenu.TabIndex = 3;
            // 
            // btn_account
            // 
            this.btn_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_account.FlatAppearance.BorderSize = 0;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_account.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_account.Image = global::MailController.Properties.Resources.icons8_account_48;
            this.btn_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_account.Location = new System.Drawing.Point(0, 186);
            this.btn_account.Name = "btn_account";
            this.btn_account.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_account.Size = new System.Drawing.Size(183, 108);
            this.btn_account.TabIndex = 2;
            this.btn_account.Text = " Account";
            this.btn_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_account.UseVisualStyleBackColor = true;
            this.btn_account.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mail
            // 
            this.btn_mail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_mail.FlatAppearance.BorderSize = 0;
            this.btn_mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mail.Image = global::MailController.Properties.Resources.icons8_gmail_48;
            this.btn_mail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mail.Location = new System.Drawing.Point(0, 78);
            this.btn_mail.Name = "btn_mail";
            this.btn_mail.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btn_mail.Size = new System.Drawing.Size(183, 108);
            this.btn_mail.TabIndex = 1;
            this.btn_mail.Text = "   Mail";
            this.btn_mail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_mail.UseVisualStyleBackColor = true;
            this.btn_mail.Click += new System.EventHandler(this.btn_mail_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(90)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(183, 78);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Design By teooo.nt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Control";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(90)))));
            this.panelTitleBar.Controls.Add(this.lbl_tittle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(183, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1098, 78);
            this.panelTitleBar.TabIndex = 4;
            // 
            // lbl_tittle
            // 
            this.lbl_tittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tittle.AutoSize = true;
            this.lbl_tittle.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.lbl_tittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tittle.Location = new System.Drawing.Point(481, 20);
            this.lbl_tittle.Name = "lbl_tittle";
            this.lbl_tittle.Size = new System.Drawing.Size(84, 36);
            this.lbl_tittle.TabIndex = 0;
            this.lbl_tittle.Text = "Form";
            // 
            // panel_desktop
            // 
            this.panel_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_desktop.Location = new System.Drawing.Point(183, 78);
            this.panel_desktop.Name = "panel_desktop";
            this.panel_desktop.Size = new System.Drawing.Size(1098, 641);
            this.panel_desktop.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1281, 719);
            this.Controls.Add(this.panel_desktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Mail Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_mail;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbl_tittle;
        private System.Windows.Forms.Panel panel_desktop;
    }
}

