namespace Supply_control_system
{
    partial class FormSettings
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.buttonLoadPicture = new System.Windows.Forms.Button();
            this.labelNamePicture = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.buttonHideShowPasswordRepeat = new System.Windows.Forms.Button();
            this.textBoxPasswordRepeat = new System.Windows.Forms.TextBox();
            this.labelRepeat = new System.Windows.Forms.Label();
            this.buttonHideShowPassword = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.shadowEffect1 = new ShadowEffect.ShadowEffect(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = global::Supply_control_system.Properties.Settings.Default.backgroundColor;
            this.panel1.Controls.Add(this.maskedTextBoxPhone);
            this.panel1.Controls.Add(this.buttonLoadPicture);
            this.panel1.Controls.Add(this.labelNamePicture);
            this.panel1.Controls.Add(this.labelImage);
            this.panel1.Controls.Add(this.textBoxSecondName);
            this.panel1.Controls.Add(this.labelSecondName);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.textBoxFirstName);
            this.panel1.Controls.Add(this.labelFirstName);
            this.panel1.Controls.Add(this.buttonHideShowPasswordRepeat);
            this.panel1.Controls.Add(this.textBoxPasswordRepeat);
            this.panel1.Controls.Add(this.labelRepeat);
            this.panel1.Controls.Add(this.buttonHideShowPassword);
            this.panel1.Controls.Add(this.buttonChange);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Location = new System.Drawing.Point(110, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 900);
            this.panel1.TabIndex = 0;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.maskedTextBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxPhone.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(773, 529);
            this.maskedTextBoxPhone.Mask = "+7(000)000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(452, 44);
            this.maskedTextBoxPhone.TabIndex = 29;
            this.maskedTextBoxPhone.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // buttonLoadPicture
            // 
            this.buttonLoadPicture.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonLoadPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadPicture.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonLoadPicture.Location = new System.Drawing.Point(1134, 599);
            this.buttonLoadPicture.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLoadPicture.Name = "buttonLoadPicture";
            this.buttonLoadPicture.Size = new System.Drawing.Size(153, 45);
            this.buttonLoadPicture.TabIndex = 28;
            this.buttonLoadPicture.Text = "Load";
            this.buttonLoadPicture.UseVisualStyleBackColor = true;
            this.buttonLoadPicture.Click += new System.EventHandler(this.buttonLoadPicture_Click);
            // 
            // labelNamePicture
            // 
            this.labelNamePicture.AutoSize = true;
            this.labelNamePicture.Location = new System.Drawing.Point(766, 599);
            this.labelNamePicture.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNamePicture.Name = "labelNamePicture";
            this.labelNamePicture.Size = new System.Drawing.Size(116, 37);
            this.labelNamePicture.TabIndex = 27;
            this.labelNamePicture.Text = "(None)";
            this.labelNamePicture.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(461, 599);
            this.labelImage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(192, 37);
            this.labelImage.TabIndex = 26;
            this.labelImage.Text = "Your Image:";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSecondName.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxSecondName.Location = new System.Drawing.Point(773, 393);
            this.textBoxSecondName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(452, 44);
            this.textBoxSecondName.TabIndex = 25;
            this.textBoxSecondName.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(461, 397);
            this.labelSecondName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(223, 37);
            this.labelSecondName.TabIndex = 24;
            this.labelSecondName.Text = "Second name:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonCancel.Location = new System.Drawing.Point(940, 662);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(347, 70);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(461, 532);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(193, 37);
            this.labelPhone.TabIndex = 21;
            this.labelPhone.Text = "Your phone:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxAddress.Location = new System.Drawing.Point(773, 459);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(452, 44);
            this.textBoxAddress.TabIndex = 20;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAddress_KeyPress);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(461, 463);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(218, 37);
            this.labelAddress.TabIndex = 19;
            this.labelAddress.Text = "Your address:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxFirstName.Location = new System.Drawing.Point(773, 322);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(452, 44);
            this.textBoxFirstName.TabIndex = 18;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(461, 326);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(178, 37);
            this.labelFirstName.TabIndex = 17;
            this.labelFirstName.Text = "First name:";
            // 
            // buttonHideShowPasswordRepeat
            // 
            this.buttonHideShowPasswordRepeat.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonHideShowPasswordRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHideShowPasswordRepeat.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonHideShowPasswordRepeat.Location = new System.Drawing.Point(1239, 257);
            this.buttonHideShowPasswordRepeat.Margin = new System.Windows.Forms.Padding(6);
            this.buttonHideShowPasswordRepeat.Name = "buttonHideShowPasswordRepeat";
            this.buttonHideShowPasswordRepeat.Size = new System.Drawing.Size(48, 43);
            this.buttonHideShowPasswordRepeat.TabIndex = 16;
            this.buttonHideShowPasswordRepeat.Text = "!";
            this.buttonHideShowPasswordRepeat.UseVisualStyleBackColor = true;
            this.buttonHideShowPasswordRepeat.Click += new System.EventHandler(this.buttonHideShowPasswordRepeat_Click);
            // 
            // textBoxPasswordRepeat
            // 
            this.textBoxPasswordRepeat.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxPasswordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPasswordRepeat.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxPasswordRepeat.Location = new System.Drawing.Point(773, 257);
            this.textBoxPasswordRepeat.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPasswordRepeat.Name = "textBoxPasswordRepeat";
            this.textBoxPasswordRepeat.Size = new System.Drawing.Size(452, 44);
            this.textBoxPasswordRepeat.TabIndex = 15;
            this.textBoxPasswordRepeat.UseSystemPasswordChar = true;
            this.textBoxPasswordRepeat.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxPasswordRepeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // labelRepeat
            // 
            this.labelRepeat.AutoSize = true;
            this.labelRepeat.Location = new System.Drawing.Point(461, 261);
            this.labelRepeat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRepeat.Name = "labelRepeat";
            this.labelRepeat.Size = new System.Drawing.Size(279, 37);
            this.labelRepeat.TabIndex = 14;
            this.labelRepeat.Text = "Password(repeat):";
            // 
            // buttonHideShowPassword
            // 
            this.buttonHideShowPassword.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonHideShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHideShowPassword.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonHideShowPassword.Location = new System.Drawing.Point(1239, 188);
            this.buttonHideShowPassword.Margin = new System.Windows.Forms.Padding(6);
            this.buttonHideShowPassword.Name = "buttonHideShowPassword";
            this.buttonHideShowPassword.Size = new System.Drawing.Size(48, 43);
            this.buttonHideShowPassword.TabIndex = 13;
            this.buttonHideShowPassword.Text = "!";
            this.buttonHideShowPassword.UseVisualStyleBackColor = true;
            this.buttonHideShowPassword.Click += new System.EventHandler(this.buttonHideShowPassword_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonChange.Location = new System.Drawing.Point(468, 662);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(6);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(347, 70);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxPassword.Location = new System.Drawing.Point(773, 188);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(452, 44);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(461, 192);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(167, 37);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxLogin.Location = new System.Drawing.Point(773, 127);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(452, 44);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(461, 131);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(105, 37);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Login:";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.Resize += new System.EventHandler(this.FormSettings_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonHideShowPassword;
        private ShadowEffect.ShadowEffect shadowEffect1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonHideShowPasswordRepeat;
        private System.Windows.Forms.TextBox textBoxPasswordRepeat;
        private System.Windows.Forms.Label labelRepeat;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Button buttonLoadPicture;
        private System.Windows.Forms.Label labelNamePicture;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
    }
}

