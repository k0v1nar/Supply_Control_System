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
    public partial class FormAllOrders : SpecialForm
    {
        private int _allRows, _nowRows;

        public FormAllOrders() : base(Properties.Settings.Default.connectionString)
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

        private void FormAllOrders_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void FormAllOrders_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            LoadData();
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void dataGridViewPlans_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridViewPlans.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string productFilter = "";
            if (textBoxDateShipments.Text != "")
            {
                productFilter += $"AND Shipments._date LIKE '%{textBoxDateShipments.Text}%' ";
            }
            string textCommand = $"SELECT Shipments._id AS 'ID Shipment', " +
                $"Shipments._date AS 'Shipment date', " +
                $"Orders._id AS 'ID Order', " +
                $"Products._name AS 'Product', " +
                $"Orders._count AS 'Count' " +
                $"FROM Orders, Shipment_Order, Shipments, Products " +
                $"WHERE Products._id = Orders._product AND " +
                $"Shipment_Order._order = Orders._id AND " +
                $"Shipment_Order._shipment = Shipments._id " + productFilter;
            DataTable result = _sqlModule.ExeGetTable(textCommand);
            if (result == null)
            {
                MessageBox.Show($"Ошибка! Загрузка заказов не удалась!"); 
                return;
            }
            dataGridViewPlans.DataSource = result;
            _nowRows = result.Rows.Count;
            UpdateAllRows();
            UpdateCountRows();
        }

        private void UpdateAllRows()
        {
            string textCommand = $"SELECT COUNT(Shipments._id) FROM Orders, Shipment_Order, Shipments, Products WHERE Products._id = Orders._product AND Shipment_Order._order = Orders._id AND Shipment_Order._shipment = Shipments._id";
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

        private void textBoxDateShipments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z') return;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z') return;
            if (e.KeyChar >= 'а' && e.KeyChar <= 'я') return;
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я') return;
            if (e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == ' ') return;
            e.Handled = true;
        }
    }
}
