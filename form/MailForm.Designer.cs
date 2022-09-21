namespace MailController.mail
{
    partial class MailForm
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
            this.grid_account_mail = new System.Windows.Forms.DataGridView();
            this.chk_grid_account_mail_id = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_grid_account_mail_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_grid_account_mail_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process_mail_load = new CustomBox.RJControls.RJProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_view_mail = new System.Windows.Forms.DataGridView();
            this.chk_grid_mail_checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txt_grid_mail_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_grid_mail_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_grid_mail_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_grid_mail_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_grid_mail_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_delete_mail = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_account_mail)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_mail)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.grid_account_mail);
            this.panel1.Controls.Add(this.process_mail_load);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 703);
            this.panel1.TabIndex = 0;
            // 
            // grid_account_mail
            // 
            this.grid_account_mail.AllowUserToAddRows = false;
            this.grid_account_mail.AllowUserToResizeColumns = false;
            this.grid_account_mail.AllowUserToResizeRows = false;
            this.grid_account_mail.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.grid_account_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_account_mail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_account_mail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk_grid_account_mail_id,
            this.txt_grid_account_mail_id,
            this.txt_grid_account_mail_username});
            this.grid_account_mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_account_mail.Location = new System.Drawing.Point(0, 0);
            this.grid_account_mail.Name = "grid_account_mail";
            this.grid_account_mail.RowHeadersVisible = false;
            this.grid_account_mail.RowHeadersWidth = 51;
            this.grid_account_mail.RowTemplate.Height = 24;
            this.grid_account_mail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_account_mail.Size = new System.Drawing.Size(306, 588);
            this.grid_account_mail.TabIndex = 1;
            // 
            // chk_grid_account_mail_id
            // 
            this.chk_grid_account_mail_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.chk_grid_account_mail_id.FalseValue = "false";
            this.chk_grid_account_mail_id.HeaderText = "";
            this.chk_grid_account_mail_id.MinimumWidth = 6;
            this.chk_grid_account_mail_id.Name = "chk_grid_account_mail_id";
            this.chk_grid_account_mail_id.TrueValue = "true";
            this.chk_grid_account_mail_id.Width = 6;
            // 
            // txt_grid_account_mail_id
            // 
            this.txt_grid_account_mail_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txt_grid_account_mail_id.DataPropertyName = "id";
            this.txt_grid_account_mail_id.HeaderText = "Id";
            this.txt_grid_account_mail_id.MinimumWidth = 6;
            this.txt_grid_account_mail_id.Name = "txt_grid_account_mail_id";
            this.txt_grid_account_mail_id.ReadOnly = true;
            this.txt_grid_account_mail_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txt_grid_account_mail_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txt_grid_account_mail_id.Width = 24;
            // 
            // txt_grid_account_mail_username
            // 
            this.txt_grid_account_mail_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_grid_account_mail_username.DataPropertyName = "username";
            this.txt_grid_account_mail_username.HeaderText = "Username";
            this.txt_grid_account_mail_username.MinimumWidth = 6;
            this.txt_grid_account_mail_username.Name = "txt_grid_account_mail_username";
            this.txt_grid_account_mail_username.ReadOnly = true;
            // 
            // process_mail_load
            // 
            this.process_mail_load.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.process_mail_load.ChannelHeight = 6;
            this.process_mail_load.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.process_mail_load.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.process_mail_load.ForeColor = System.Drawing.Color.White;
            this.process_mail_load.Location = new System.Drawing.Point(0, 588);
            this.process_mail_load.Name = "process_mail_load";
            this.process_mail_load.ShowMaximun = true;
            this.process_mail_load.ShowValue = CustomBox.RJControls.TextPosition.Sliding;
            this.process_mail_load.Size = new System.Drawing.Size(306, 23);
            this.process_mail_load.SliderColor = System.Drawing.Color.RoyalBlue;
            this.process_mail_load.SliderHeight = 6;
            this.process_mail_load.SymbolAfter = "";
            this.process_mail_load.SymbolBefore = "";
            this.process_mail_load.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(90)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Mail";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grid_view_mail);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(306, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 703);
            this.panel2.TabIndex = 1;
            // 
            // grid_view_mail
            // 
            this.grid_view_mail.AllowUserToAddRows = false;
            this.grid_view_mail.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.grid_view_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_view_mail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_view_mail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk_grid_mail_checked,
            this.txt_grid_mail_id,
            this.txt_grid_mail_from,
            this.txt_grid_mail_to,
            this.txt_grid_mail_subject,
            this.txt_grid_mail_date});
            this.grid_view_mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_view_mail.Location = new System.Drawing.Point(0, 0);
            this.grid_view_mail.Name = "grid_view_mail";
            this.grid_view_mail.RowHeadersVisible = false;
            this.grid_view_mail.RowHeadersWidth = 51;
            this.grid_view_mail.RowTemplate.Height = 24;
            this.grid_view_mail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_view_mail.Size = new System.Drawing.Size(1027, 611);
            this.grid_view_mail.TabIndex = 0;
            // 
            // chk_grid_mail_checked
            // 
            this.chk_grid_mail_checked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.chk_grid_mail_checked.HeaderText = "";
            this.chk_grid_mail_checked.MinimumWidth = 6;
            this.chk_grid_mail_checked.Name = "chk_grid_mail_checked";
            this.chk_grid_mail_checked.Width = 6;
            // 
            // txt_grid_mail_id
            // 
            this.txt_grid_mail_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txt_grid_mail_id.DataPropertyName = "id";
            this.txt_grid_mail_id.HeaderText = "Id";
            this.txt_grid_mail_id.MinimumWidth = 6;
            this.txt_grid_mail_id.Name = "txt_grid_mail_id";
            this.txt_grid_mail_id.ReadOnly = true;
            this.txt_grid_mail_id.Visible = false;
            this.txt_grid_mail_id.Width = 125;
            // 
            // txt_grid_mail_from
            // 
            this.txt_grid_mail_from.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txt_grid_mail_from.DataPropertyName = "from";
            this.txt_grid_mail_from.HeaderText = "From";
            this.txt_grid_mail_from.MinimumWidth = 6;
            this.txt_grid_mail_from.Name = "txt_grid_mail_from";
            this.txt_grid_mail_from.ReadOnly = true;
            this.txt_grid_mail_from.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txt_grid_mail_from.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txt_grid_mail_from.Width = 44;
            // 
            // txt_grid_mail_to
            // 
            this.txt_grid_mail_to.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txt_grid_mail_to.DataPropertyName = "to";
            this.txt_grid_mail_to.HeaderText = "To";
            this.txt_grid_mail_to.MinimumWidth = 6;
            this.txt_grid_mail_to.Name = "txt_grid_mail_to";
            this.txt_grid_mail_to.ReadOnly = true;
            this.txt_grid_mail_to.Width = 53;
            // 
            // txt_grid_mail_subject
            // 
            this.txt_grid_mail_subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_grid_mail_subject.DataPropertyName = "subject";
            this.txt_grid_mail_subject.HeaderText = "Subject";
            this.txt_grid_mail_subject.MinimumWidth = 6;
            this.txt_grid_mail_subject.Name = "txt_grid_mail_subject";
            this.txt_grid_mail_subject.ReadOnly = true;
            // 
            // txt_grid_mail_date
            // 
            this.txt_grid_mail_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txt_grid_mail_date.DataPropertyName = "timeReceiver";
            this.txt_grid_mail_date.HeaderText = "Date";
            this.txt_grid_mail_date.MinimumWidth = 6;
            this.txt_grid_mail_date.Name = "txt_grid_mail_date";
            this.txt_grid_mail_date.ReadOnly = true;
            this.txt_grid_mail_date.Width = 65;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_delete_mail);
            this.panel3.Controls.Add(this.btn_read);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 611);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 92);
            this.panel3.TabIndex = 5;
            // 
            // btn_delete_mail
            // 
            this.btn_delete_mail.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete_mail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_delete_mail.FlatAppearance.BorderSize = 0;
            this.btn_delete_mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_mail.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_delete_mail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete_mail.Location = new System.Drawing.Point(309, 0);
            this.btn_delete_mail.Name = "btn_delete_mail";
            this.btn_delete_mail.Size = new System.Drawing.Size(307, 92);
            this.btn_delete_mail.TabIndex = 3;
            this.btn_delete_mail.Text = "Delete Mail";
            this.btn_delete_mail.UseVisualStyleBackColor = false;
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_read.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_read.FlatAppearance.BorderSize = 0;
            this.btn_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_read.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_read.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_read.Location = new System.Drawing.Point(0, 0);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(309, 92);
            this.btn_read.TabIndex = 2;
            this.btn_read.Text = "Mark As Read";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1333, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MailForm";
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.MailForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_account_mail)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_mail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_delete_mail;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.DataGridView grid_view_mail;
        private System.Windows.Forms.DataGridView grid_account_mail;
        private System.Windows.Forms.Panel panel3;
        private CustomBox.RJControls.RJProgressBar process_mail_load;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_grid_account_mail_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_grid_account_mail_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_grid_account_mail_username;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_grid_mail_checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_grid_mail_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_grid_mail_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_grid_mail_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_grid_mail_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_grid_mail_date;
    }
}