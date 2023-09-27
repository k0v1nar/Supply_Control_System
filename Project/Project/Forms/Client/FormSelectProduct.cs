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

namespace Supply_control_system.Forms.Client
{
    public partial class FormSelectProduct : SpecialForm
    {
        private int _nowRows, _allRows;

        public FormSelectProduct() : base(Properties.Settings.Default.connectionString)
        {
            this.Icon = Properties.Resources.logo1;
            InitializeComponent();
            _autoScalingForm = AutoScalingForm.Init(this);
            this.Refresh();
            labelSelecredProduct_TextChanged(new object(), new EventArgs());
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _finsih = false;
            this.Close();
        }

        private void FormOrdersClient_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void FormOrdersClient_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            LoadData();
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void dataGridViewMyOrders_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridViewProducts.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string sort = "";
            if (comboBoxSort.Text != "")
            {
                sort += " ORDER BY _price ";
                if (comboBoxSort.SelectedIndex == 0)
                {
                    sort += "ASC";
                }
                else
                {
                    sort += "DESC";
                }
            }
            string filter = "_name LIKE ";
            if (textBoxSearch.Text != "")
            {
                filter += $"'%{textBoxSearch.Text}%'";
            }
            else
            {
                filter += "'%'";
            }
            string textCommand = $"SELECT _id AS 'ID', _name AS 'Name', _price AS 'Price' FROM Products WHERE " + filter + sort;
            DataTable result = _sqlModule.ExeGetTable(textCommand);
            if (result == null)
            {
                MessageBox.Show("Ошибка! Загрузки таблицы!");
                return;
            }
            dataGridViewProducts.DataSource = result;
            _nowRows = result.Rows.Count;
            UpdateAllRows();
            UpdateCountRows();
        }

        private void UpdateAllRows()
        {
            string textCommand = $"SELECT COUNT(_id) FROM Products";
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

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewProducts.CurrentCell.RowIndex;
                labelSelecredProduct.Text = $"{dataGridViewProducts.Rows[index].Cells[0].Value}({dataGridViewProducts.Rows[index].Cells[1].Value})";
            }
            catch
            {
                labelSelecredProduct.Text = "(None)";
            }
        }

        public string Product
        {
            get 
            { 
                return labelSelecredProduct.Text; 
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            _finsih = true;
            this.Close();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z') return;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z') return;
            if (e.KeyChar >= 'а' && e.KeyChar <= 'я') return;
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я') return;
            if (e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == ' ') return;
            e.Handled = true;
        }

        private void labelSelecredProduct_TextChanged(object sender, EventArgs e)
        {
            if (labelSelecredProduct.Text != "(None)")
            {
                buttonSelect.Enabled = true;
            }
            else
            {
                buttonSelect.Enabled = false;
            }
        }
    }
}
