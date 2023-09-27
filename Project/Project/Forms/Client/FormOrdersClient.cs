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
    public partial class FormOrdersClient : SpecialForm
    {
        private int _allRows;

        public FormOrdersClient() : base(Properties.Settings.Default.connectionString)
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
            dataGridViewMyOrders.Columns[e.Column.Index].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string textCommand = $"SELECT _num_contract AS 'Num contract', " +
                $"Orders._date AS 'Date', " +
                $"Products._name AS 'Product', " +
                $"_price AS 'Price', " +
                $"Orders._count AS 'Count', " +
                $"Orders._count*_price AS 'Result', " +
                $"Shipments._date AS 'Shipment date' " +
                $"FROM Orders, Users, Accounts, Products, Shipment_Order, Shipments " +
                $"WHERE Orders._product = Products._id AND " +
                $"Orders._id = Shipment_Order._order AND " +
                $"Shipments._id = Shipment_Order._shipment AND " +
                $"Users._id = Orders._customer AND " +
                $"Accounts._id = Users._account AND " +
                $"Accounts._login = '{accountToolStripMenuItem.Text}'";
            DataTable result = _sqlModule.ExeGetTable(textCommand);
            if (result == null)
            {
                MessageBox.Show($"Ошибка! Загрузка заказов клиента \"{accountToolStripMenuItem.Text}\" не удалась!"); 
                return;
            }
            dataGridViewMyOrders.DataSource = result;
            _allRows = result.Rows.Count;
            labelCountRows.Text = $"Count rows: {_allRows}";
        }

        private void LoadData()
        {
            accountToolStripMenuItem.Text = Properties.Settings.Default.login;
        }
    }
}
