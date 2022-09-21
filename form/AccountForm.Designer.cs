namespace MailController.account
{
    partial class AccountForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_account = new System.Windows.Forms.DataGridView();
            this.chk_grid_account_select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_grid_account_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_grid_account_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_grid_account_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_account_password = new System.Windows.Forms.TextBox();
            this.txt_account_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_account_add = new System.Windows.Forms.Button();
            this.btn_account_change = new System.Windows.Forms.Button();
            this.btn_account_delete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_account)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.grid_account);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 724);
            this.panel1.TabIndex = 0;
            // 
            // grid_account
            // 
            this.grid_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk_grid_account_select,
            this.txt_grid_account_id,
            this.txt_grid_account_username,
            this.txt_grid_account_password});
            this.grid_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_account.Location = new System.Drawing.Point(0, 0);
            this.grid_account.Name = "grid_account";
            this.grid_account.RowHeadersVisible = false;
            this.grid_account.RowHeadersWidth = 51;
            this.grid_account.RowTemplate.Height = 24;
            this.grid_account.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_account.Size = new System.Drawing.Size(804, 724);
            this.grid_account.TabIndex = 0;
            // 
            // chk_grid_account_select
            // 
            this.chk_grid_account_select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.chk_grid_account_select.HeaderText = "";
            this.chk_grid_account_select.MinimumWidth = 6;
            this.chk_grid_account_select.Name = "chk_grid_account_select";
            this.chk_grid_account_select.Width = 40;
            // 
            // txt_grid_account_id
            // 
            this.txt_grid_account_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txt_grid_account_id.DataPropertyName = "id";
            this.txt_grid_account_id.HeaderText = "ID";
            this.txt_grid_account_id.MinimumWidth = 6;
            this.txt_grid_account_id.Name = "txt_grid_account_id";
            this.txt_grid_account_id.ReadOnly = true;
            this.txt_grid_account_id.Width = 49;
            // 
            // txt_grid_account_username
            // 
            this.txt_grid_account_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_grid_account_username.DataPropertyName = "username";
            this.txt_grid_account_username.HeaderText = "Username";
            this.txt_grid_account_username.MinimumWidth = 6;
            this.txt_grid_account_username.Name = "txt_grid_account_username";
            this.txt_grid_account_username.ReadOnly = true;
            // 
            // txt_grid_account_password
            // 
            this.txt_grid_account_password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_grid_account_password.DataPropertyName = "password";
            this.txt_grid_account_password.HeaderText = "Password";
            this.txt_grid_account_password.MinimumWidth = 6;
            this.txt_grid_account_password.Name = "txt_grid_account_password";
            this.txt_grid_account_password.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_account_add);
            this.panel2.Controls.Add(this.btn_account_change);
            this.panel2.Controls.Add(this.btn_account_delete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(811, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 726);
            this.panel2.TabIndex = 1;
            // 
            // txt_account_password
            // 
            this.txt_account_password.Location = new System.Drawing.Point(105, 86);
            this.txt_account_password.Name = "txt_account_password";
            this.txt_account_password.Size = new System.Drawing.Size(368, 22);
            this.txt_account_password.TabIndex = 20;
            // 
            // txt_account_username
            // 
            this.txt_account_username.Location = new System.Drawing.Point(105, 38);
            this.txt_account_username.Name = "txt_account_username";
            this.txt_account_username.Size = new System.Drawing.Size(368, 22);
            this.txt_account_username.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username:";
            // 
            // btn_account_add
            // 
            this.btn_account_add.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_account_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_account_add.FlatAppearance.BorderSize = 0;
            this.btn_account_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account_add.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_account_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_account_add.Location = new System.Drawing.Point(0, 450);
            this.btn_account_add.Name = "btn_account_add";
            this.btn_account_add.Size = new System.Drawing.Size(494, 92);
            this.btn_account_add.TabIndex = 7;
            this.btn_account_add.Text = "Add";
            this.btn_account_add.UseVisualStyleBackColor = false;
            this.btn_account_add.Click += new System.EventHandler(this.btn_account_add_Click);
            // 
            // btn_account_change
            // 
            this.btn_account_change.BackColor = System.Drawing.Color.Gold;
            this.btn_account_change.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_account_change.FlatAppearance.BorderSize = 0;
            this.btn_account_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account_change.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_account_change.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_account_change.Location = new System.Drawing.Point(0, 542);
            this.btn_account_change.Name = "btn_account_change";
            this.btn_account_change.Size = new System.Drawing.Size(494, 92);
            this.btn_account_change.TabIndex = 6;
            this.btn_account_change.Text = "Change";
            this.btn_account_change.UseVisualStyleBackColor = false;
            this.btn_account_change.Click += new System.EventHandler(this.btn_account_change_Click);
            // 
            // btn_account_delete
            // 
            this.btn_account_delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_account_delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_account_delete.FlatAppearance.BorderSize = 0;
            this.btn_account_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account_delete.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_account_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_account_delete.Location = new System.Drawing.Point(0, 634);
            this.btn_account_delete.Name = "btn_account_delete";
            this.btn_account_delete.Size = new System.Drawing.Size(494, 92);
            this.btn_account_delete.TabIndex = 5;
            this.btn_account_delete.Text = "Delete";
            this.btn_account_delete.UseVisualStyleBackColor = false;
            this.btn_account_delete.Click += new System.EventHandler(this.btn_account_delete_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txt_account_username);
            this.panel3.Controls.Add(this.txt_account_password);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 135);
            this.panel3.TabIndex = 21;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AccountForm";
            this.Text = "Account";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_account)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_account;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_account_add;
        private System.Windows.Forms.Button btn_account_change;
        private System.Windows.Forms.Button btn_account_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_grid_account_select;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_grid_account_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_grid_account_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_grid_account_password;
        private System.Windows.Forms.TextBox txt_account_password;
        private System.Windows.Forms.TextBox txt_account_username;
        private System.Windows.Forms.Panel panel3;
    }
}