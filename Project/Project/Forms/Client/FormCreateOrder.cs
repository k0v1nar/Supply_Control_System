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
    public partial class FormCreateOrder : SpecialForm
    {
        private float _price = 0;
        private bool _confirm = false;
        private SpecialForm _selectProduct, _selectShipment;

        public FormCreateOrder() : base(Properties.Settings.Default.connectionString)
        {
            this.Icon = Properties.Resources.logo1;
            InitializeComponent();
            _autoScalingForm = AutoScalingForm.Init(this);
            this.Refresh();
            labelShipment_TextChanged(new object(), new EventArgs());
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _finsih = false;
            this.Close();
        }

        private void FormCreateOrder_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            LoadData();
        }

        private void LoadData()
        {
            accountToolStripMenuItem.Text = Properties.Settings.Default.login;
        }

        private void buttonSelectProduct_Click(object sender, EventArgs e)
        {
            _selectProduct = new FormSelectProduct();
            this.Hide();
            _selectProduct.ShowDialog();
            this.Show();
            if (_selectProduct.Finish)
            {
                string product = ((FormSelectProduct)_selectProduct).Product;
                labelProduct.Text = product;
                string command = $"SELECT _price FROM Products WHERE _id = '{product.Split(new char[] { '(' })[0]}'";
                string price = _sqlModule.ExeGetValue(command);
                _price = float.Parse(price);
            }
        }

        private void buttonSelectShipment_Click(object sender, EventArgs e)
        {
            _selectShipment = new FormSelectShipment();
            this.Hide();
            _selectShipment.ShowDialog();
            this.Show();
            if (_selectShipment.Finish)
            {
                string shipment = ((FormSelectShipment)_selectShipment).Shipment;
                labelShipment.Text = shipment;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm order", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _confirm = true;
                labelShipment_TextChanged(new object(), new EventArgs());
            }
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            string command = $"SELECT Users._id FROM Users, Accounts WHERE Accounts._id = Users._account AND Accounts._login = '{Properties.Settings.Default.login}'";
            string user_id = _sqlModule.ExeGetValue(command);
            string product_id = labelProduct.Text.Split(new char[] { '(' })[0];
            command = $"INSERT INTO Orders(_customer, _num_contract, _date,_product,_count) " +
               $"VALUES ({user_id}, '{textBoxNumberOfContract.Text}', '{DateTime.Now}', {product_id}, {numericUpDown1.Value})";
            int result = _sqlModule.ExeChangeTable(command);
            if (result == -1)
            {
                MessageBox.Show("Ошибка! Не удалось сделать заказ!");
                return;
            }
            command = $"SELECT _id FROM Orders WHERE _customer = {user_id} AND _num_contract = '{textBoxNumberOfContract.Text}'";
            string order_id = _sqlModule.ExeGetValue(command);
            string shipment_id = labelShipment.Text.Split(new char[] { '(' })[0];
            command = $"INSERT INTO Shipment_Order(_shipment, _order, _count)" +
                $"VALUES ({shipment_id}, {order_id}, 0)";
            result = _sqlModule.ExeChangeTable(command);
            if (result == -1)
            {
                command = $"DELETE FROM Orders WHERE _id = {order_id}";
                _sqlModule.ExeChangeTable(command);
                MessageBox.Show("Ошибка! Не удалось сделать заказ!");
                return;
            }
            MessageBox.Show("Заказ успешно оставлен!");
            _finsih = false;
            this.Close();
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == (char)Keys.Back) return;
            e.Handled = true;
        }

        private void textBoxNumberOfContract_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == '-' && ((TextBox)sender).Text.IndexOf('-') == -1 && ((TextBox)sender).Text.Length > 0) return;
            e.Handled = true;
        }

        private void labelShipment_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNumberOfContract.Text.Length > 3 && labelProduct.Text != "(None)" && numericUpDown1.Value != 0 && labelShipment.Text != "(None)" && _confirm)
            {
                buttonCreateOrder.Enabled = true;
            }
            else
            {
                buttonCreateOrder.Enabled = false;
            }
            _confirm = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (labelProduct.Text != "(None)")
            {
                float count = float.Parse(numericUpDown1.Value.ToString());
                labelResultPrice.Text = (_price * count).ToString()+" rub.";
            }
        }
    }
}
