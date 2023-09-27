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
using System.IO;
using SpecialFormLibrary;

namespace Supply_control_system
{
    public partial class FormSettings : SpecialForm
    {
        private string _fileImagePath = "(None)";
        private string _id_users;
        private string _id_accounts;

        public FormSettings() : base(Properties.Settings.Default.connectionString)
        {
            this.Icon = Properties.Resources.logo1;
            InitializeComponent();
            _autoScalingForm = AutoScalingForm.Init(this);
            this.Refresh();
            textBoxLogin_TextChanged(new object(), new EventArgs());
        }

        private void buttonHideShowPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }

        private void buttonHideShowPasswordRepeat_Click(object sender, EventArgs e)
        {
            textBoxPasswordRepeat.UseSystemPasswordChar = !textBoxPasswordRepeat.UseSystemPasswordChar;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _finsih = false;
            this.Close();
        }

        private void FormSettings_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            string command = $"SELECT Accounts._id, Users._id, _login, _password, _firstName, _secondName, _address, _phone, _pathImage " +
                $"FROM Accounts, Users " +
                $"WHERE Users._account = Accounts._id AND _login = '{Properties.Settings.Default.login}';";
            DataTable result = _sqlModule.ExeGetTable(command);
            if (result == null || result.Rows.Count == 0)
            {
                MessageBox.Show("Ошибка! Не удалось загрузить данные!");
                return;
            }
            _id_accounts = result.Rows[0][0].ToString();
            _id_users = result.Rows[0][1].ToString();
            textBoxLogin.Text = result.Rows[0][2].ToString();
            textBoxPassword.Text = result.Rows[0][3].ToString();
            textBoxPasswordRepeat.Text = "";
            textBoxFirstName.Text = result.Rows[0][4].ToString();
            textBoxSecondName.Text = result.Rows[0][5].ToString();
            textBoxAddress.Text = result.Rows[0][6].ToString();
            maskedTextBoxPhone.Text = result.Rows[0][7].ToString();
            _fileImagePath = result.Rows[0][8].ToString();
            labelNamePicture.Text = Path.GetFileName(_fileImagePath);
        }

        private void buttonLoadPicture_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                labelNamePicture.Text = openFileDialog1.SafeFileName;
                string fileToCopy = openFileDialog1.FileName;
                string folder = @"Images\";
                string copyFile = folder + openFileDialog1.SafeFileName;
                File.Copy(fileToCopy, copyFile, true);
                _fileImagePath = copyFile;
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string command = $"UPDATE Accounts " +
                $"SET _login = '{textBoxLogin.Text}'," +
                $"_password = '{textBoxPassword.Text}' " +
                $"WHERE _id = {_id_accounts}";
            int resultChange = _sqlModule.ExeChangeTable(command);
            if (resultChange == 0)
            {
                MessageBox.Show("Не удалось изменить аккаунт");
                return;
            }
            command = $"UPDATE Users " +
                $"SET _firstName = '{textBoxFirstName.Text}'," +
                $"_secondName = '{textBoxSecondName.Text}'," +
                $"_address = '{textBoxAddress.Text}'," +
                $"_phone = '{maskedTextBoxPhone.Text}'," +
                $"_pathImage = '{_fileImagePath}' " +
                $"WHERE _id = {_id_users}";
            resultChange = _sqlModule.ExeChangeTable(command); 
            if (resultChange == 0)
            {
                MessageBox.Show("Не удалось изменить аккаунт");
                return;
            }
            MessageBox.Show("Вы успешно изменили данные!");
            this.Close();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            labelImage.ForeColor = Color.Red;
            labelAddress.ForeColor = Color.Red;
            labelFirstName.ForeColor = Color.Red;
            labelLogin.ForeColor = Color.Red;
            labelPassword.ForeColor = Color.Red;
            labelPhone.ForeColor = Color.Red;
            labelRepeat.ForeColor = Color.Red;
            labelSecondName.ForeColor = Color.Red;
            if (textBoxLogin.Text.Length < 3)
            {
                buttonChange.Enabled = false;
                return;
            }
            labelLogin.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxPassword.Text.Length < 3)
            {
                buttonChange.Enabled = false;
                return;
            }
            labelPassword.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxPassword.Text != textBoxPasswordRepeat.Text)
            {
                buttonChange.Enabled = false;
                return;
            }
            labelRepeat.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxFirstName.Text.Length < 3)
            {
                buttonChange.Enabled = false;
                return;
            }
            labelFirstName.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxSecondName.Text.Length < 3)
            {
                buttonChange.Enabled = false;
                return;
            }
            labelSecondName.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxAddress.Text.Length < 3)
            {
                buttonChange.Enabled = false;
                return;
            }
            labelAddress.ForeColor = Properties.Settings.Default.textColor;
            if (maskedTextBoxPhone.MaskCompleted == false)
            {
                buttonChange.Enabled = false;
                return;
            }
            labelPhone.ForeColor = Properties.Settings.Default.textColor;
            if (labelNamePicture.Text == "(None)")
            {
                buttonChange.Enabled = false;
                return;
            }
            labelImage.ForeColor = Properties.Settings.Default.textColor;
            buttonChange.Enabled = true;
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

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z') return;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z') return;
            if (e.KeyChar >= 'а' && e.KeyChar <= 'я') return;
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я') return;
            if (e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == ' ' && ((TextBox)sender).Text.IndexOf(' ') == -1) return;
            e.Handled = true;
        }

        private void textBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z') return;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z') return;
            if (e.KeyChar >= 'а' && e.KeyChar <= 'я') return;
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я') return;
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == ' ') return;
            if (e.KeyChar == '.') return;
            if (e.KeyChar == ',') return;
            e.Handled = true;
        }
    }
}
