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

namespace Supply_control_system.Forms.Manager
{
    public partial class FormOrders : SpecialForm
    {
        private int _allRows, _nowRows;

        public FormOrders() : base(Properties.Settings.Default.connectionString)
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

        private void FormOrders_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            LoadData();
            buttonUpdate_Click(new object(), new EventArgs());
        }

        private void dataGridViewOrders_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridViewOrders.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string sort = "";
            if (comboBoxSort.Text != "")
            {
                sort += $" ORDER BY {comboBoxSort.Text}";
            }
            string dateFilter = "";
            if (checkBoxDate.Checked)
            {
                dateFilter += $"AND Shipments._date >= '{customDateTimePickerFrom.Text}' AND Shipments._date <= '{customDateTimePickerTo.Text}' ";
            }
            string shipmentFilter = "";
            if (checkBoxShipment.Checked)
            {
                shipmentFilter += $"AND Shipments._id = {comboBoxShipment.Text} ";
            }
            string productFilter = "";
            if (checkBoxProduct.Checked)
            {
                productFilter += $"AND Products._name LIKE '%{textBoxProduct.Text}%' ";
            }
            string priceFilter = "";
            if (checkBoxPrice.Checked)
            {
                priceFilter += $" AND Products._price >= {textBoxPriceFrom.Text} AND Products._price <= {textBoxPriceTo.Text} ";
            }
            string textCommand = $"SELECT Shipments._id AS 'Shipments._id', " +
                $"Shipments._date AS 'Shipments._date', " +
                $"Orders._id AS 'Orders._id', " +
                $"Products._name AS 'Products._name', " +
                $"Orders._count AS 'Orders._count' , " +
                $"Products._price AS 'Products._price' " +
                $"FROM Orders, Shipment_Order, Shipments, Products " +
                $"WHERE Products._id = Orders._product AND " +
                $"Shipment_Order._order = Orders._id AND " +
                $"Shipment_Order._shipment = Shipments._id " + dateFilter + shipmentFilter + productFilter + priceFilter + sort;
            DataTable result = _sqlModule.ExeGetTable(textCommand);
            if (result == null)
            {
                MessageBox.Show($"Ошибка! Загрузка заказов не удалась!"); 
                return;
            }
            dataGridViewOrders.DataSource = result;
            comboBoxSort.Items.Clear();
            foreach (DataColumn column in result.Columns)
            {
                comboBoxSort.Items.Add(column.ColumnName);
            }
            comboBoxShipment.Items.Clear();
            foreach (DataRow row in result.Rows)
            {
                string shipment = row[0].ToString();
                if (comboBoxShipment.Items.IndexOf(shipment) == -1)
                {
                    comboBoxShipment.Items.Add(shipment);
                }
            }
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

        private void textBoxPriceFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') == -1 && ((TextBox)sender).Text.Length > 0) return;
            e.Handled = true;
        }

        private void textBoxProduct_KeyPress(object sender, KeyPressEventArgs e)
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
