namespace Supply_control_system
{
    partial class FormAuthorization
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
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.buttonHideShowPassword = new System.Windows.Forms.Button();
            this.buttonEnterCapcha = new System.Windows.Forms.Button();
            this.textBoxCapcha = new System.Windows.Forms.TextBox();
            this.buttonChangeCapcha = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxRemMe = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.shadowEffect1 = new ShadowEffect.ShadowEffect(this.components);
            this.shadowEffect2 = new ShadowEffect.ShadowEffect(this.components);
            this.timerCaptcha = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = global::Supply_control_system.Properties.Settings.Default.backgroundColor;
            this.panel1.Controls.Add(this.pictureBoxCaptcha);
            this.panel1.Controls.Add(this.buttonHideShowPassword);
            this.panel1.Controls.Add(this.buttonEnterCapcha);
            this.panel1.Controls.Add(this.textBoxCapcha);
            this.panel1.Controls.Add(this.buttonChangeCapcha);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.checkBoxRemMe);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Location = new System.Drawing.Point(110, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 900);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(546, 713);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(414, 81);
            this.pictureBoxCaptcha.TabIndex = 14;
            this.pictureBoxCaptcha.TabStop = false;
            this.pictureBoxCaptcha.Visible = false;
            // 
            // buttonHideShowPassword
            // 
            this.buttonHideShowPassword.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonHideShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHideShowPassword.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonHideShowPassword.Location = new System.Drawing.Point(1213, 511);
            this.buttonHideShowPassword.Margin = new System.Windows.Forms.Padding(6);
            this.buttonHideShowPassword.Name = "buttonHideShowPassword";
            this.buttonHideShowPassword.Size = new System.Drawing.Size(48, 43);
            this.buttonHideShowPassword.TabIndex = 13;
            this.buttonHideShowPassword.Text = "!";
            this.buttonHideShowPassword.UseVisualStyleBackColor = true;
            this.buttonHideShowPassword.Click += new System.EventHandler(this.buttonHideShowPassword_Click);
            // 
            // buttonEnterCapcha
            // 
            this.buttonEnterCapcha.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonEnterCapcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnterCapcha.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonEnterCapcha.Location = new System.Drawing.Point(975, 806);
            this.buttonEnterCapcha.Margin = new System.Windows.Forms.Padding(6);
            this.buttonEnterCapcha.Name = "buttonEnterCapcha";
            this.buttonEnterCapcha.Size = new System.Drawing.Size(226, 44);
            this.buttonEnterCapcha.TabIndex = 12;
            this.buttonEnterCapcha.Text = "Enter";
            this.buttonEnterCapcha.UseVisualStyleBackColor = true;
            this.buttonEnterCapcha.Visible = false;
            this.buttonEnterCapcha.Click += new System.EventHandler(this.buttonEnterCapcha_Click);
            // 
            // textBoxCapcha
            // 
            this.textBoxCapcha.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxCapcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCapcha.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxCapcha.Location = new System.Drawing.Point(546, 806);
            this.textBoxCapcha.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCapcha.Name = "textBoxCapcha";
            this.textBoxCapcha.Size = new System.Drawing.Size(414, 44);
            this.textBoxCapcha.TabIndex = 11;
            this.textBoxCapcha.Visible = false;
            this.textBoxCapcha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCapcha_KeyPress);
            // 
            // buttonChangeCapcha
            // 
            this.buttonChangeCapcha.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonChangeCapcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeCapcha.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonChangeCapcha.Location = new System.Drawing.Point(975, 713);
            this.buttonChangeCapcha.Margin = new System.Windows.Forms.Padding(6);
            this.buttonChangeCapcha.Name = "buttonChangeCapcha";
            this.buttonChangeCapcha.Size = new System.Drawing.Size(226, 81);
            this.buttonChangeCapcha.TabIndex = 10;
            this.buttonChangeCapcha.Text = "Change";
            this.buttonChangeCapcha.UseVisualStyleBackColor = true;
            this.buttonChangeCapcha.Visible = false;
            this.buttonChangeCapcha.Click += new System.EventHandler(this.buttonChangeCapcha_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonRegister.Location = new System.Drawing.Point(897, 632);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(304, 70);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonLogin.Location = new System.Drawing.Point(546, 632);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(304, 70);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxRemMe
            // 
            this.checkBoxRemMe.AutoSize = true;
            this.checkBoxRemMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRemMe.Location = new System.Drawing.Point(546, 578);
            this.checkBoxRemMe.Margin = new System.Windows.Forms.Padding(6);
            this.checkBoxRemMe.Name = "checkBoxRemMe";
            this.checkBoxRemMe.Size = new System.Drawing.Size(242, 41);
            this.checkBoxRemMe.TabIndex = 6;
            this.checkBoxRemMe.Text = "Remember me";
            this.checkBoxRemMe.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxPassword.Location = new System.Drawing.Point(747, 511);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(452, 44);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 517);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxLogin.Location = new System.Drawing.Point(747, 450);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(452, 44);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 456);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::Supply_control_system.Properties.Resources.logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(667, 26);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonClose.Location = new System.Drawing.Point(1464, 26);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(209, 70);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
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
            this.shadowEffect2.ShadowPadding = new System.Windows.Forms.Padding(8, 0, 8, 10);
            this.shadowEffect2.ShadowRadius = 10;
            this.shadowEffect2.SourceControl = this.pictureBoxLogo;
            this.shadowEffect2.UseShadowEffect = true;
            // 
            // timerCaptcha
            // 
            this.timerCaptcha.Interval = 1000;
            this.timerCaptcha.Tick += new System.EventHandler(this.timerCaptcha_Tick);
            // 
            // FormAuthorization
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
            this.Name = "FormAuthorization";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.FormAuthorization_Load);
            this.Shown += new System.EventHandler(this.FormAuthorization_Shown);
            this.Resize += new System.EventHandler(this.FormAuthorization_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxRemMe;
        private System.Windows.Forms.Button buttonChangeCapcha;
        private System.Windows.Forms.Button buttonEnterCapcha;
        private System.Windows.Forms.TextBox textBoxCapcha;
        private System.Windows.Forms.Button buttonHideShowPassword;
        private ShadowEffect.ShadowEffect shadowEffect1;
        private ShadowEffect.ShadowEffect shadowEffect2;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.Timer timerCaptcha;
    }
}

