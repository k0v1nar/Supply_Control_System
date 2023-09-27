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
using Supply_control_system.Forms.Client;
using SpecialFormLibrary;

namespace Supply_control_system.Forms.Client
{
    public partial class MenuClient : SpecialForm
    {
        private SpecialForm _myOrders, _creatingOrder, _settings;

        public MenuClient() : base(Properties.Settings.Default.connectionString)
        {
            this.Icon = Properties.Resources.logo1;
            InitializeComponent();
            _autoScalingForm = AutoScalingForm.Init(this);
            this.Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _finsih = false;
            this.Close();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            _creatingOrder = new FormCreateOrder();
            this.Hide();
            _creatingOrder.ShowDialog();
            this.Show();
            if (_creatingOrder.Finish)
            {
                this.Close();
            }
            _creatingOrder.Dispose();
        }

        private void buttonMyOrders_Click(object sender, EventArgs e)
        {
            _myOrders = new FormOrdersClient();
            this.Hide();
            _myOrders.ShowDialog();
            this.Show();
            if (_myOrders.Finish)
            {
                this.Close();
            }
            _myOrders.Dispose();
        }

        private void MenuClient_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            LoadData();
        }

        private void MenuClient_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _settings = new FormSettings();
            this.Hide();
            _settings.ShowDialog();
            this.Show();
            if (_settings.Finish)
            {
                this.Close();
            }
            _settings.Dispose();
        }

        private void LoadData()
        {
            accountsToolStripMenuItem.Text = Properties.Settings.Default.login;
        }
    }
}
