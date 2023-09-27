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
    public partial class FormSelectShipment : SpecialForm
    {
        private int _allRows;
        public FormSelectShipment() : base(Properties.Settings.Default.connectionString)
        {
            this.Icon = Properties.Resources.logo1;
            InitializeComponent();
            _autoScalingForm = AutoScalingForm.Init(this);
            this.Refresh();
            labelSelectedShipment_TextChanged(new object(), new EventArgs());
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
            dataGridViewShipments.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
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
            string textCommand = $"SELECT Shipments._id AS 'ID', _date AS 'Date', _firstName+' '+_secondName AS 'Name' FROM Shipments, Users WHERE Shipments._employee = Users._id AND _date >= '{DateTime.Now}'" + sort;
            DataTable result = _sqlModule.ExeGetTable(textCommand);
            if (result == null)
            {
                MessageBox.Show("Ошибка! Загрузки таблицы!");
                return;
            }
            dataGridViewShipments.DataSource = result;
            _allRows = result.Rows.Count;
            labelCountRows.Text = $"Count rows: {_allRows}";
        }

        private void LoadData()
        {
            accountToolStripMenuItem.Text = Properties.Settings.Default.login;
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewShipments.CurrentCell.RowIndex;
                DateTime date = Convert.ToDateTime(dataGridViewShipments.Rows[index].Cells[1].Value.ToString());
                labelSelectedShipment.Text = $"{dataGridViewShipments.Rows[index].Cells[0].Value}({date.Day}.{date.Month}.{date.Year})";
            }
            catch
            {
                labelSelectedShipment.Text = "(None)";
            }
        }

        public string Shipment
        {
            get 
            { 
                return labelSelectedShipment.Text; 
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            _finsih = true;
            this.Close();
        }

        private void labelSelectedShipment_TextChanged(object sender, EventArgs e)
        {
            if (labelSelectedShipment.Text != "(None)")
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
