using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supply_control_system.Scripts;
using Supply_control_system.Forms;
using Supply_control_system.Components;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using Supply_control_system.Forms.Client;
using Supply_control_system.Forms.Admin;
using Supply_control_system.Forms.Manager;
using Supply_control_system.Forms.Logistician;
using SpecialFormLibrary;

namespace Supply_control_system
{
    public enum Role
    {
        Admin,
        Manager,
        Logistician,
        Client
    }

    public partial class FormAuthorization : SpecialForm
    {
        private SpecialForm _menu;
        private int _countTries = 0;
        private string _captchaText;
        private int _ticks = 0;

        public FormAuthorization() : base(Properties.Settings.Default.connectionString)
        {
            this.Icon = Properties.Resources.logo1;
            InitializeComponent();
            _autoScalingForm = AutoScalingForm.Init(this);
            this.Refresh();
            textBoxLogin_TextChanged(new object(), new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Properties.Settings.Default.login = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            _countTries++;
            string textCommand = $"SELECT * FROM Accounts WHERE _login = '{textBoxLogin.Text}' and _password = '{textBoxPassword.Text}';";
            DataTable result = _sqlModule.ExeGetTable(textCommand);
            if (result.Rows.Count == 0)
            {
                ErrorData();
                return;
            }
            textCommand = $"SELECT * FROM Users WHERE _account = '{result.Rows[0][0]}';";
            result = _sqlModule.ExeGetTable(textCommand);
            Role role = (Role)int.Parse(result.Rows[0][7].ToString());
            switch (role)
            {
                case Role.Admin:
                    _menu = new MenuAdmin();
                    break;
                case Role.Manager:
                    _menu = new MenuManager();
                    break;
                case Role.Logistician:
                    _menu = new MenuLogistician();
                    break;
                case Role.Client:
                    _menu = new MenuClient();
                    break;
            }
            MessageData data = MessageData.GetData(role, result.Rows[0][2].ToString(), result.Rows[0][3].ToString(), result.Rows[0][6].ToString());
            FormMessage message = new FormMessage(data);
            message.ShowDialog();
            SuccessfulAuth();
        }

        private void SuccessfulAuth()
        {
            AddHistoryAuthentication(true);
            _countTries = 0;
            Properties.Settings.Default.saveAuth = checkBoxRemMe.Checked;
            Properties.Settings.Default.login = textBoxLogin.Text;
            Properties.Settings.Default.password = textBoxPassword.Text;
            Properties.Settings.Default.Save();
            this.Hide();
            _menu.ShowDialog();
            this.Show();
            if (Properties.Settings.Default.saveAuth == false)
            {
                Properties.Settings.Default.login = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
                if (_menu.Finish)
                {
                    this.Close();
                }
                return;
            }
            if (_menu.Finish)
            {
                this.Close();
            }
        }

        private void ErrorData()
        {
            AddHistoryAuthentication(false);
            buttonLogin.Enabled = false;
            textBoxLogin.Enabled = false;
            textBoxPassword.Enabled = false;
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            switch (_countTries)
            {
                case 1:
                    buttonEnterCapcha.Visible = true;
                    buttonChangeCapcha.Visible = true;
                    pictureBoxCaptcha.Visible = true;
                    textBoxCapcha.Visible = true;
                    buttonChangeCapcha_Click(new object(), new EventArgs());
                    MessageBox.Show("Неверный логин или пароль! Введите капчу!");
                    break;
                case 2:
                    timerCaptcha.Start();
                    _ticks = 0;
                    MessageBox.Show("Неверный логин или пароль! Попробуйте ещё раз через 3 минуты!");
                    break;
                case 3:
                    MessageBox.Show("Система заблокирована из-за 3 неудачных попыток ввода! Перезагрузите систему!");
                    break;
            }
        }

        private void AddHistoryAuthentication(bool success)
        {
            string textCommand = $"SELECT _id FROM Accounts WHERE _login = '{textBoxLogin.Text}' and _password = '{textBoxPassword.Text}';";
            string result = _sqlModule.ExeGetValue(textCommand);
            int id = int.Parse(result);
            textCommand = $"INSERT INTO HistoryAuthentication(_date,_id_account,_result) VALUES ('{DateTime.Now}',{id},'{success}')";
            int resultChange = _sqlModule.ExeChangeTable(textCommand);
        }

        private void FormAuthorization_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            if (pictureBoxCaptcha.Visible)
            {
                buttonChangeCapcha_Click(new object(), new EventArgs());
            }
            this.Refresh();
        }

        private void buttonChangeCapcha_Click(object sender, EventArgs e)
        {
            _captchaText = CaptchaGenerator.TextGenerator.GetText();
            pictureBoxCaptcha.Image = CaptchaGenerator.CaptchaGenerator.GetCaptcha(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height, _captchaText, Properties.Settings.Default.selectColor);
        }

        private void buttonEnterCapcha_Click(object sender, EventArgs e)
        {
            if (_captchaText == textBoxCapcha.Text)
            {
                buttonLogin.Enabled = true;
                textBoxLogin.Enabled = true;
                textBoxPassword.Enabled = true;
                buttonEnterCapcha.Visible = false;
                buttonChangeCapcha.Visible = false;
                pictureBoxCaptcha.Visible = false;
                textBoxCapcha.Visible = false;
                return;
            }
            buttonChangeCapcha_Click(new object(), new EventArgs());
        }

        private void timerCaptcha_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks == 180)
            {
                buttonLogin.Enabled = true;
                textBoxLogin.Enabled = true;
                textBoxPassword.Enabled = true;
                timerCaptcha.Stop();
            }
        }

        private void buttonHideShowPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }

        private void FormAuthorization_Shown(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            if (Properties.Settings.Default.login != "" && Properties.Settings.Default.password != "")
            {
                textBoxLogin.Text = Properties.Settings.Default.login;
                textBoxPassword.Text = Properties.Settings.Default.password;
                buttonLogin_Click(new object(), new EventArgs());
                return;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegistration registration = new FormRegistration();
            this.Hide();
            registration.ShowDialog();
            this.Show();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length > 2 && textBoxPassword.Text.Length > 2)
                buttonLogin.Enabled = true;
            else
                buttonLogin.Enabled = false;
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z') return;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z') return;
            if (e.KeyChar >= 'а' && e.KeyChar <= 'я') return;
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я') return;
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == '_') return;
            e.Handled = true;
        }

        private void textBoxCapcha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z') return;
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == (char)Keys.Back) return;
            e.Handled = true;
        }
    }
}
