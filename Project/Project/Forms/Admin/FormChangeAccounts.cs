using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supply_control_system.Scripts;
using System.Windows.Forms;
using Supply_control_system.Components;
using System.IO;
using SpecialFormLibrary;

namespace Supply_control_system.Forms.Admin
{
    public partial class FormChangeAccounts : SpecialForm
    {
        private int _id_account;
        private int _id_user;
        private string _fileImagePath;

        public FormChangeAccounts(int id) : base(Properties.Settings.Default.connectionString)
        {
            this.Icon = Properties.Resources.logo1;
            InitializeComponent();
            _autoScalingForm = AutoScalingForm.Init(this);
            this.Refresh();
            _id_account = id;
            textBoxLogin_TextChanged(new object(), new EventArgs());
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _finsih = false;
            this.Close();
        }

        private void FormChangeAccounts_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void FormChangeAccounts_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            LoadData();
        }

        private void LoadData()
        {
            accountToolStripMenuItem.Text = Properties.Settings.Default.login;
            string command = $"SELECT _type FROM Type_Accounts";
            DataTable result = _sqlModule.ExeGetTable(command);
            comboBoxTypeAccounts.Items.Clear();
            foreach (DataRow rowRes in result.Rows)
            {
                comboBoxTypeAccounts.Items.Add(rowRes[0]);
            }
            command = $"SELECT Users._id, _login, _password, _firstName, _secondName, _address, _phone, _pathImage, _type " +
                $"FROM Accounts, Users " +
                $"WHERE Users._account = Accounts._id AND Accounts._id = '{_id_account}';";
            result = _sqlModule.ExeGetTable(command);
            DataRow row = result.Rows[0];
            _id_user = (int)row[0];
            textBoxLogin.Text = row[1].ToString();
            textBoxPassword.Text = row[2].ToString();
            textBoxFirstName.Text = row[3].ToString();
            textBoxSecondName.Text = row[4].ToString();
            textBoxAddress.Text = row[5].ToString();
            maskedTextBoxPhone.Text = row[6].ToString();
            _fileImagePath = row[7].ToString();
            labelNamePicture.Text = Path.GetFileName(_fileImagePath);
            comboBoxTypeAccounts.SelectedIndex = (int)row[8];
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string command = $"UPDATE Accounts SET _login = '{textBoxLogin.Text}',_password = '{textBoxPassword.Text}' WHERE _id = {_id_account}";
            int result = _sqlModule.ExeChangeTable(command);
            if (result == -1)
            {
                MessageBox.Show("Ошибка! Не удалось обновить аккаунт!");
                return;
            }
            command = $"UPDATE Users SET _firstName = '{textBoxFirstName.Text}', " +
                $"_secondName = '{textBoxSecondName.Text}', " +
                $"_address = '{textBoxAddress.Text}', " +
                $"_phone = '{maskedTextBoxPhone.Text}'," +
                $"_pathImage = '{_fileImagePath}'," +
                $"_type = {comboBoxTypeAccounts.SelectedIndex}" +
                $"WHERE _id = {_id_user}";
            result = _sqlModule.ExeChangeTable(command);
            if (result == -1)
            {
                MessageBox.Show("Ошибка! Не удалось обновить пользователя!");
                return;
            }
            MessageBox.Show("Успешно изменен аккаунт!");
            _finsih = false;
            this.Close();
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

        private void buttonHideShowPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
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

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            labelImage.ForeColor = Color.Red;
            labelAddress.ForeColor = Color.Red;
            labelFirstName.ForeColor = Color.Red;
            labelLogin.ForeColor = Color.Red;
            labelPassword.ForeColor = Color.Red;
            labelPhone.ForeColor = Color.Red;
            labelSecondName.ForeColor = Color.Red;
            labelType.ForeColor = Color.Red;
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
            if (comboBoxTypeAccounts.Text == "")
            {
                buttonChange.Enabled = false;
                return;
            }
            labelType.ForeColor = Properties.Settings.Default.textColor;
            buttonChange.Enabled = true;
        }
    }
}
