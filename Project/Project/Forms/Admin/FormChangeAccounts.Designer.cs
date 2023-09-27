namespace Supply_control_system.Forms.Admin
{
    partial class FormChangeAccounts
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTypeAccounts = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonHideShowPassword = new System.Windows.Forms.Button();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.labelNamePicture = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customMenuStrip3 = new Supply_control_system.Components.CustomMenuStrip();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customMenuStrip2 = new Supply_control_system.Components.CustomMenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadowEffect1 = new ShadowEffect.ShadowEffect(this.components);
            this.shadowEffect2 = new ShadowEffect.ShadowEffect(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.customMenuStrip3.SuspendLayout();
            this.customMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = global::Supply_control_system.Properties.Settings.Default.backgroundColor;
            this.panel1.Controls.Add(this.comboBoxTypeAccounts);
            this.panel1.Controls.Add(this.labelType);
            this.panel1.Controls.Add(this.buttonHideShowPassword);
            this.panel1.Controls.Add(this.maskedTextBoxPhone);
            this.panel1.Controls.Add(this.buttonLoadPicture);
            this.panel1.Controls.Add(this.labelNamePicture);
            this.panel1.Controls.Add(this.labelImage);
            this.panel1.Controls.Add(this.textBoxSecondName);
            this.panel1.Controls.Add(this.labelSecondName);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.textBoxFirstName);
            this.panel1.Controls.Add(this.labelFirstName);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.buttonChange);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(110, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 900);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxTypeAccounts
            // 
            this.comboBoxTypeAccounts.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.comboBoxTypeAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTypeAccounts.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.comboBoxTypeAccounts.FormattingEnabled = true;
            this.comboBoxTypeAccounts.Items.AddRange(new object[] {
            "cheaper",
            "more expensive"});
            this.comboBoxTypeAccounts.Location = new System.Drawing.Point(798, 644);
            this.comboBoxTypeAccounts.Name = "comboBoxTypeAccounts";
            this.comboBoxTypeAccounts.Size = new System.Drawing.Size(452, 45);
            this.comboBoxTypeAccounts.TabIndex = 63;
            this.comboBoxTypeAccounts.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(487, 644);
            this.labelType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(96, 37);
            this.labelType.TabIndex = 62;
            this.labelType.Text = "Type:";
            // 
            // buttonHideShowPassword
            // 
            this.buttonHideShowPassword.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonHideShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHideShowPassword.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonHideShowPassword.Location = new System.Drawing.Point(1280, 235);
            this.buttonHideShowPassword.Margin = new System.Windows.Forms.Padding(6);
            this.buttonHideShowPassword.Name = "buttonHideShowPassword";
            this.buttonHideShowPassword.Size = new System.Drawing.Size(48, 45);
            this.buttonHideShowPassword.TabIndex = 61;
            this.buttonHideShowPassword.Text = "!";
            this.buttonHideShowPassword.UseVisualStyleBackColor = true;
            this.buttonHideShowPassword.Click += new System.EventHandler(this.buttonHideShowPassword_Click);
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.maskedTextBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxPhone.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(798, 509);
            this.maskedTextBoxPhone.Mask = "+7(000)000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(452, 44);
            this.maskedTextBoxPhone.TabIndex = 60;
            this.maskedTextBoxPhone.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonLoadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadPicture.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonLoadPicture.Location = new System.Drawing.Point(1159, 579);
            this.buttonLoadPicture.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(153, 45);
            this.buttonLoadPicture.TabIndex = 59;
            this.buttonLoadPicture.Text = "Load";
            this.buttonLoadPicture.UseVisualStyleBackColor = true;
            this.buttonLoadPicture.Click += new System.EventHandler(this.buttonLoadPicture_Click);
            // 
            // labelNamePicture
            // 
            this.labelNamePicture.AutoSize = true;
            this.labelNamePicture.Location = new System.Drawing.Point(791, 579);
            this.labelNamePicture.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNamePicture.Name = "labelNamePicture";
            this.labelNamePicture.Size = new System.Drawing.Size(116, 37);
            this.labelNamePicture.TabIndex = 58;
            this.labelNamePicture.Text = "(None)";
            this.labelNamePicture.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(486, 579);
            this.labelImage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(192, 37);
            this.labelImage.TabIndex = 57;
            this.labelImage.Text = "Your Image:";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSecondName.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxSecondName.Location = new System.Drawing.Point(798, 373);
            this.textBoxSecondName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(452, 44);
            this.textBoxSecondName.TabIndex = 56;
            this.textBoxSecondName.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(486, 377);
            this.labelSecondName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(223, 37);
            this.labelSecondName.TabIndex = 55;
            this.labelSecondName.Text = "Second name:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(486, 512);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(193, 37);
            this.labelPhone.TabIndex = 54;
            this.labelPhone.Text = "Your phone:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxAddress.Location = new System.Drawing.Point(798, 439);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(452, 44);
            this.textBoxAddress.TabIndex = 53;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_KeyPress);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(486, 443);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(218, 37);
            this.labelAddress.TabIndex = 52;
            this.labelAddress.Text = "Your address:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxFirstName.Location = new System.Drawing.Point(798, 302);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(452, 44);
            this.textBoxFirstName.TabIndex = 51;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(486, 306);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(178, 37);
            this.labelFirstName.TabIndex = 50;
            this.labelFirstName.Text = "First name:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxPassword.Location = new System.Drawing.Point(798, 236);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(452, 44);
            this.textBoxPassword.TabIndex = 49;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(486, 238);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(167, 37);
            this.labelPassword.TabIndex = 48;
            this.labelPassword.Text = "Password:";
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonChange.Location = new System.Drawing.Point(493, 713);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(6);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(819, 53);
            this.buttonChange.TabIndex = 47;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxLogin.Location = new System.Drawing.Point(798, 169);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(452, 44);
            this.textBoxLogin.TabIndex = 38;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(486, 169);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(105, 37);
            this.labelLogin.TabIndex = 29;
            this.labelLogin.Text = "Login:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.customMenuStrip3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.customMenuStrip2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1700, 24);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // customMenuStrip3
            // 
            this.customMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem});
            this.customMenuStrip3.Location = new System.Drawing.Point(0, 0);
            this.customMenuStrip3.Name = "customMenuStrip3";
            this.customMenuStrip3.Size = new System.Drawing.Size(850, 24);
            this.customMenuStrip3.TabIndex = 1;
            this.customMenuStrip3.Text = "customMenuStrip3";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.cancelToolStripMenuItem.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // customMenuStrip2
            // 
            this.customMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.customMenuStrip2.Location = new System.Drawing.Point(850, 0);
            this.customMenuStrip2.Name = "customMenuStrip2";
            this.customMenuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customMenuStrip2.Size = new System.Drawing.Size(850, 24);
            this.customMenuStrip2.TabIndex = 0;
            this.customMenuStrip2.Text = "customMenuStrip2";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // shadowEffect1
            // 
            this.shadowEffect1.Depth = 20;
            this.shadowEffect1.ShadowColor = System.Drawing.Color.Black;
            this.shadowEffect1.ShadowPadding = new System.Windows.Forms.Padding(8, 0, 8, 10);
            this.shadowEffect1.ShadowRadius = 10;
            this.shadowEffect1.SourceControl = this.panel1;
            this.shadowEffect1.UseShadowEffect = true;
            // 
            // shadowEffect2
            // 
            this.shadowEffect2.Depth = 20;
            this.shadowEffect2.ShadowColor = System.Drawing.Color.Black;
            this.shadowEffect2.ShadowPadding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.shadowEffect2.ShadowRadius = 10;
            this.shadowEffect2.SourceControl = this.tableLayoutPanel1;
            this.shadowEffect2.UseShadowEffect = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormChangeAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormChangeAccounts";
            this.Text = "Managing accounts";
            this.Load += new System.EventHandler(this.FormChangeAccounts_Load);
            this.Resize += new System.EventHandler(this.FormChangeAccounts_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.customMenuStrip3.ResumeLayout(false);
            this.customMenuStrip3.PerformLayout();
            this.customMenuStrip2.ResumeLayout(false);
            this.customMenuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ShadowEffect.ShadowEffect shadowEffect1;
        private ShadowEffect.ShadowEffect shadowEffect2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Components.CustomMenuStrip customMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private Components.CustomMenuStrip customMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Button buttonLoadPicture;
        private System.Windows.Forms.Label labelNamePicture;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonHideShowPassword;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxTypeAccounts;
    }
}