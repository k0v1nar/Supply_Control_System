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
using SpecialFormLibrary;

namespace Supply_control_system.Forms.Admin
{
    public partial class FormManageAccounts : SpecialForm
    {
        private int _id, _allRows, _nowRows;
        private SpecialForm _addAccounts, _changeAccounts;

        public FormManageAccounts() : base(Properties.Settings.Default.connectionString)
        {
            this.Icon = Properties.Resources.logo1;
            InitializeComponent();
            _autoScalingForm = AutoScalingForm.Init(this);
            this.Refresh();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _finsih = false;
            this.Close();
        }

        private void FormManageAccounts_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void FormManageAccounts_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            LoadData();
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void dataGridViewShipments_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridViewAccounts.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string loginFilter = "";
            if (textBoxLogin.Text != "")
            {
                loginFilter += $"AND _login LIKE '%{textBoxLogin.Text}%' ";
            }
            string textCommand = $"SELECT Accounts._id AS 'ID', " +
                $"Accounts._login AS 'Login', " +
                $"Accounts._password AS 'Password', " +
                $"Type_Accounts._type AS 'Type' " +
                $"FROM Type_Accounts, Accounts, Users " +
                $"WHERE Type_Accounts._id = Users._type  AND " +
                $"Accounts._id = Users._account" + loginFilter;
            DataTable result = _sqlModule.ExeGetTable(textCommand);
            if (result == null)
            {
                MessageBox.Show($"Ошибка! Загрузка заказов не удалась!"); 
                return;
            }
            dataGridViewAccounts.DataSource = result;
            _nowRows = result.Rows.Count;
            UpdateAllRows();
            UpdateCountRows();
        }

        private void UpdateAllRows()
        {
            string textCommand = $"SELECT COUNT(Accounts._id) FROM FROM Accounts, Users, Type_Accounts WHERE Type_Accounts._id = Users._type AND Accounts._id = Users._account";
            string result = _sqlModule.ExeGetValue(textCommand);
            _allRows = int.Parse(result);
        }

        private void UpdateCountRows()
        {
            labelCountRows.Text = $"Count rows: {_nowRows} of {_allRows}";
        }

        private void LoadData()
        {
            accountToolStripMenuItem.Text = Properties.Settings.Default.login;
        }

        private void dataGridViewAccounts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewAccounts.CurrentCell.RowIndex;
                _id = (int)dataGridViewAccounts.Rows[index].Cells[0].Value;
                buttonAdd.Enabled = false;
                buttonChange.Enabled = true;
                buttonDelete.Enabled = true;
            }
            catch
            {
                _id = -1;
                buttonAdd.Enabled = true;
                buttonChange.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addAccounts = new FormAddAccounts();
            this.Hide();
            _addAccounts.ShowDialog();
            this.Show();
            if (_addAccounts.Finish)
            {
                this.Close();
                return;
            }
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            _changeAccounts = new FormChangeAccounts(_id);
            this.Hide();
            _changeAccounts.ShowDialog();
            this.Show();
            if (_changeAccounts.Finish)
            {
                this.Close();
                return;
            }
            buttonUpdate_Click(new object(), new EventArgs());
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string command = $"DELETE FROM Accounts WHERE _id = {_id}";
            int result = _sqlModule.ExeChangeTable(command);
            if (result == -1)
            {
                MessageBox.Show("Ошибка! Не удалось удалить аккаунт!");
                return;
            }
            buttonUpdate_Click(new object(), new EventArgs());
        }
    }
}
