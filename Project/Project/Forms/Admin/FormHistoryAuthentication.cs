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
    public partial class FormHistoryAuthentication : SpecialForm
    {
        private int _allRows;
        private int _nowRows;

        public FormHistoryAuthentication() : base(Properties.Settings.Default.connectionString)
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

        private void FormHistoryAuthentication_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void FormHistoryAuthentication_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            LoadData();
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string sort = "";
            if (comboBoxSort.Text != "")
            {
                sort += " ORDER BY _date ";
                if (comboBoxSort.SelectedIndex == 0)
                {
                    sort += "ASC";
                }
                else
                {
                    sort += "DESC";
                }
            }
            string filter = "";
            if (textBoxSearch.Text != "")
            {
                filter += $" AND _login LIKE '%{textBoxSearch.Text}%'";
            }
            string textCommand = $"SELECT _date AS 'Date', _login AS 'Login', _result AS 'Result' FROM Accounts, HistoryAuthentication WHERE Accounts._id = HistoryAuthentication._id_account" + filter + sort;
            DataTable result = _sqlModule.ExeGetTable(textCommand);
            if (result == null)
            {
                MessageBox.Show("Ошибка! Загрузки таблицы!");
                return;
            }
            dataGridViewHistory.DataSource = result;
            _nowRows = result.Rows.Count;
            UpdateAllRows();
            UpdateCountRows();
        }

        private void UpdateAllRows()
        {
            string textCommand = $"SELECT COUNT(_date) FROM FROM Accounts, HistoryAuthentication WHERE Accounts._id = HistoryAuthentication._id_account";
            string result = _sqlModule.ExeGetValue(textCommand);
            _allRows = int.Parse(result);
        }

        private void UpdateCountRows()
        {
            labelCountRows.Text = $"Count rows: {_nowRows} of {_allRows}";
        }

        private void dataGridViewHistory_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridViewHistory.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void LoadData()
        {
            accountToolStripMenuItem.Text = Properties.Settings.Default.login;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == '.') return;
            e.Handled = true;
        }
    }
}
