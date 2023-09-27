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
    public partial class FormAddAccounts : SpecialForm
    {
        private int _id;
        private string _fileImagePath;

        public FormAddAccounts() : base(Properties.Settings.Default.connectionString)
        {
            this.Icon = Properties.Resources.logo1;
            InitializeComponent();
            _autoScalingForm = AutoScalingForm.Init(this);
            this.Refresh();
            textBoxLogin_TextChanged(new object(), new EventArgs());
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _finsih = false;
            this.Close();
        }

        private void FormAddAccounts_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void FormAddAccounts_Load(object sender, EventArgs e)
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
            foreach (DataRow row in result.Rows)
            {
                comboBoxTypeAccounts.Items.Add(row[0]);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string command = $"INSERT INTO Accounts (_login,_password) VALUES ('{textBoxLogin.Text}','{textBoxPassword.Text}')";
            int result = _sqlModule.ExeChangeTable(command);
            if (result == -1)
            {
                MessageBox.Show("Ошибка! Не удалось добавить аккаунт!");
                return;
            }
            command = $"SELECT _id FROM Accounts WHERE _login = '{textBoxLogin.Text}'";
            string res = _sqlModule.ExeGetValue(command);
            _id = int.Parse(res);
            command = $"INSERT INTO Users (_account, _firstName, _secondName, _address, _phone,_pathImage,_type)" +
                $"VALUES ({_id},'{textBoxFirstName.Text}','{textBoxSecondName.Text}', '{textBoxAddress.Text}','{maskedTextBoxPhone.Text}','{_fileImagePath}',{comboBoxTypeAccounts.SelectedIndex})";
            result = _sqlModule.ExeChangeTable(command);
            if (result == -1)
            {
                MessageBox.Show("Ошибка! Не удалось добавить пользователя!");
                return;
            }
            MessageBox.Show("Успешно добавлен аккаунт!");
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
                buttonAdd.Enabled = false;
                return;
            }
            labelLogin.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxPassword.Text.Length < 3)
            {
                buttonAdd.Enabled = false;
                return;
            }
            labelPassword.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxFirstName.Text.Length < 3)
            {
                buttonAdd.Enabled = false;
                return;
            }
            labelFirstName.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxSecondName.Text.Length < 3)
            {
                buttonAdd.Enabled = false;
                return;
            }
            labelSecondName.ForeColor = Properties.Settings.Default.textColor;
            if (textBoxAddress.Text.Length < 3)
            {
                buttonAdd.Enabled = false;
                return;
            }
            labelAddress.ForeColor = Properties.Settings.Default.textColor;
            if (maskedTextBoxPhone.MaskCompleted == false)
            {
                buttonAdd.Enabled = false;
                return;
            }
            labelPhone.ForeColor = Properties.Settings.Default.textColor;
            if (labelNamePicture.Text == "(None)")
            {
                buttonAdd.Enabled = false;
                return;
            }
            labelImage.ForeColor = Properties.Settings.Default.textColor;
            if (comboBoxTypeAccounts.Text == "")
            {
                buttonAdd.Enabled = false;
                return;
            }
            labelType.ForeColor = Properties.Settings.Default.textColor;
            buttonAdd.Enabled = true;
        }
    }
}
