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
    public partial class FormManageProducts : SpecialForm
    {
        private int _allRows, _nowRows;

        public FormManageProducts() : base(Properties.Settings.Default.connectionString)
        {
            this.Icon = Properties.Resources.logo1;
            InitializeComponent();
            _autoScalingForm = AutoScalingForm.Init(this);
            this.Refresh();
            textBoxName_TextChanged(new object(), new EventArgs());
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _finsih = false;
            this.Close();
        }

        private void FormManageProducts_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void FormManageProducts_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            LoadData();
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void dataGridViewShipments_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridViewProducts.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string nameFilter = "";
            if (textBoxNameSearch.Text != "")
            {
                nameFilter += $"WHERE _name LIKE '%{textBoxNameSearch.Text}%' ";
            }
            string textCommand = $"SELECT _id AS 'ID', " +
                $"_name AS 'Name', " +
                $"_price AS 'Price' " +
                $"FROM Products " + nameFilter;
            DataTable result = _sqlModule.ExeGetTable(textCommand);
            if (result == null)
            {
                MessageBox.Show($"Ошибка! Загрузка заказов не удалась!"); 
                return;
            }
            dataGridViewProducts.DataSource = result;
            _nowRows = result.Rows.Count;
            UpdateAllRows();
            UpdateCountRows();
        }

        private void UpdateAllRows()
        {
            string textCommand = $"SELECT COUNT(_id) FROM FROM Products";
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
                int index = dataGridViewProducts.CurrentCell.RowIndex;
                labelID.Text = $"id: {dataGridViewProducts.Rows[index].Cells[0].Value}";
                textBoxName.Text = dataGridViewProducts.Rows[index].Cells[1].Value.ToString();
                textBoxPrice.Text = dataGridViewProducts.Rows[index].Cells[2].Value.ToString();
            }
            catch
            {
                labelID.Text = $"id: ";
                textBoxName.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string command = $"INSERT INTO Products(_name,_price) VALUES ('{textBoxName.Text}', {textBoxPrice.Text})";
            int result = _sqlModule.ExeChangeTable(command);
            if (result == -1 || result == 0)
            {
                MessageBox.Show("Ошибка! Не удалось добавить товар!");
                return;
            }
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string command = $"UPDATE Products SET _name = '{textBoxName.Text}',_price = {textBoxPrice.Text} WHERE _id = {labelID.Text.Split(new char[] { ':', ' ' })[2]}";
            int result = _sqlModule.ExeChangeTable(command);
            if (result == -1 || result == 0)
            {
                MessageBox.Show("Ошибка! Не удалось изменить товар!");
                return;
            }
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string command = $"DELETE FROM Products WHERE _id = {labelID.Text.Split(new char[] { ':',' '})[2]}";
            int result = _sqlModule.ExeChangeTable(command);
            if (result == -1)
            {
                MessageBox.Show("Ошибка! Не удалось удалить товар!");
                return;
            }
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void textBoxNameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z') return;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z') return;
            if (e.KeyChar >= 'а' && e.KeyChar <= 'я') return;
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я') return;
            if (e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == ' ') return;
            e.Handled = true;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == '.' && textBoxPrice.Text.IndexOf('.') == -1 && textBoxPrice.Text.Length > 0) return;
            e.Handled = true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (labelID.Text == "id: ")
            {
                buttonChange.Enabled = false;
                buttonDelete.Enabled = false;
                if (textBoxName.Text.Length > 3 && textBoxPrice.Text != "" && textBoxPrice.Text != "0")
                {
                    buttonAdd.Enabled = true;
                }
                else
                {
                    buttonAdd.Enabled = false;
                }
            }
            else
            {
                buttonAdd.Enabled = false;
                if (textBoxName.Text.Length > 3 && textBoxPrice.Text != "" && textBoxPrice.Text != "0")
                {
                    buttonChange.Enabled = true;
                    buttonDelete.Enabled = true;
                }
                else
                {
                    buttonChange.Enabled = false;
                    buttonDelete.Enabled = false;
                }
            }
        }
    }
}
