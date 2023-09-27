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
using SpecialFormLibrary;
using System.IO;

namespace Supply_control_system
{
    public partial class FormRegistration : SpecialForm
    {
        private string _fileImagePath = "(None)";

        public FormRegistration() : base(Properties.Settings.Default.connectionString)
        {
            this.Icon = Properties.Resources.logo1;
            InitializeComponent();
            _autoScalingForm = AutoScalingForm.Init(this);
            this.Refresh();
            labelNamePicture_TextChanged(new object(), new EventArgs());
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
            this.Close();
        }

        private void FormRegistration_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string command = $"INSERT INTO Accounts(_login, _password) VALUES ('{textBoxLogin.Text}','{textBoxPassword.Text}')";
            int resultChange = _sqlModule.ExeChangeTable(command);
            if (resultChange == 0)
            {
                MessageBox.Show("Аккаунт с такми логином существует");
                return;
            }
            command = $"SELECT _id FROM Accounts WHERE _login = '{textBoxLogin.Text}';";
            string result = _sqlModule.ExeGetValue(command);
            int id = int.Parse(result);
            command = $"INSERT INTO Users(_account, _firstName, _secondName, _address, _phone, _pathImage,_type) VALUES " +
                $"({id},'{textBoxFirstName.Text}','{textBoxSecondName.Text}','{textBoxAddress.Text}','{maskedTextBoxPhone.Text}','{_fileImagePath}', 3);";
            resultChange = _sqlModule.ExeChangeTable(command);
            if (resultChange == 0)
            {
                command = $"DELETE FROM Accounts WHERE _id = {id};";
                MessageBox.Show("Данные неверного формата!");
                return;
            }
            MessageBox.Show("Вы успешно зарегистрированы!");
            buttonCancel_Click(new object(), new EventArgs());
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

        private void labelNamePicture_TextChanged(object sender, EventArgs e)
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
                buttonRegister.Enabled = false;
                return;
            }
            labelLogin.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxPassword.Text.Length < 3)
            {
                buttonRegister.Enabled = false;
                return;
            }
            labelPassword.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxPassword.Text != textBoxPasswordRepeat.Text)
            {
                buttonRegister.Enabled = false;
                return;
            }
            labelRepeat.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxFirstName.Text.Length < 3)
            {
                buttonRegister.Enabled = false;
                return;
            }
            labelFirstName.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxSecondName.Text.Length < 3)
            {
                buttonRegister.Enabled = false;
                return;
            }
            labelSecondName.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxAddress.Text.Length < 3)
            {
                buttonRegister.Enabled = false;
                return;
            }
            labelAddress.ForeColor = Properties.Settings.Default.textColor;
            if (maskedTextBoxPhone.MaskCompleted == false)
            {
                buttonRegister.Enabled = false;
                return;
            }
            labelPhone.ForeColor = Properties.Settings.Default.textColor;
            if (labelNamePicture.Text == "(None)")
            {
                buttonRegister.Enabled = false;
                return;
            }
            labelImage.ForeColor = Properties.Settings.Default.textColor;
            buttonRegister.Enabled = true;
        }
    }
}
