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

namespace Supply_control_system.Forms.Logistician
{
    public partial class FormManageShipments : SpecialForm
    {
        private int _allRows, _nowRows;

        public FormManageShipments() : base(Properties.Settings.Default.connectionString)
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

        private void FormManageShipments_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void FormManageShipments_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            LoadData();
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void dataGridViewShipments_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridViewShipments.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string productFilter = "";
            if (textBoxDateShipments.Text != "")
            {
                productFilter += $"AND Shipments._date LIKE '%{textBoxDateShipments.Text}%' ";
            }
            string textCommand = $"SELECT Shipments._id AS 'ID Shipment', " +
                $"Shipments._date AS 'Shipment date' " +
                $"FROM Shipments, Users, Accounts " +
                $"WHERE Shipments._employee = Users._id AND " +
                $"Users._account = Accounts._id AND " +
                $"Accounts._login = '{Properties.Settings.Default.login}' " + productFilter;
            DataTable result = _sqlModule.ExeGetTable(textCommand);
            if (result == null)
            {
                MessageBox.Show($"Ошибка! Загрузка заказов не удалась!"); 
                return;
            }
            dataGridViewShipments.DataSource = result;
            _nowRows = result.Rows.Count;
            UpdateAllRows();
            UpdateCountRows();
        }

        private void UpdateAllRows()
        {
            string textCommand = $"SELECT COUNT(Shipments._id) FROM Users, Accounts, Shipments WHERE Shipments._employee = Users._id AND Users._account = Accounts._id AND Accounts._login = '{Properties.Settings.Default.login}";
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

        private void dataGridViewShipments_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewShipments.CurrentCell.RowIndex;
                labelID.Text = $"id: {dataGridViewShipments.Rows[index].Cells[0].Value}";
                customDateTimePickerDateShipment.Text = $"{dataGridViewShipments.Rows[index].Cells[1].Value}";
            }
            catch
            {
                labelID.Text = "id: ";
                customDateTimePickerDateShipment.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string command = $"SELECT Users._id FROM Users, Accounts WHERE Users._account = Accounts._id AND Accounts._login = '{Properties.Settings.Default.login}'";
            string _id_user = _sqlModule.ExeGetValue(command);
            command = $"INSERT INTO Shipments(_date,_employee) VALUES('{customDateTimePickerDateShipment.Text}',{_id_user})";
            int result = _sqlModule.ExeChangeTable(command);
            if (result == -1)
            {
                MessageBox.Show("Ошибка! Не удалось добавить отгрузку!");
                return;
            }
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string id = labelID.Text.Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];
            string command = $"UPDATE Shipments SET _date = '{customDateTimePickerDateShipment.Text}' WHERE _id = {id}";
            int result = _sqlModule.ExeChangeTable(command);
            if (result == -1)
            {
                MessageBox.Show("Ошибка! Не удалось обновить отгрузку!");
                return;
            }
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void textBoxDateShipments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == '.') return;
            e.Handled = true;
        }

        private void labelID_TextChanged(object sender, EventArgs e)
        {
            if (labelID.Text.Split(new char[] { ':',' '}, StringSplitOptions.RemoveEmptyEntries).Length == 1)
            {
                buttonAdd.Enabled = true;
                buttonChange.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonChange.Enabled = true;
            }
        }
    }
}
