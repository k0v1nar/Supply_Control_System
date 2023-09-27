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
using Supply_control_system.Forms.Logistician;
using SpecialFormLibrary;

namespace Supply_control_system.Forms.Logistician
{
    public partial class MenuLogistician : SpecialForm
    {
        private SpecialForm _manageShipments, _showingAllOrders, _settings;

        public MenuLogistician() : base(Properties.Settings.Default.connectionString)
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

        private void buttonManageShipments_Click(object sender, EventArgs e)
        {
            _manageShipments = new FormManageShipments();
            this.Hide();
            _manageShipments.ShowDialog();
            this.Show();
            if (_manageShipments.Finish)
            {
                this.Close();
            }
            _manageShipments.Dispose();
        }

        private void buttonShowAllOrders_Click(object sender, EventArgs e)
        {
            _showingAllOrders = new FormAllOrders();
            this.Hide();
            _showingAllOrders.ShowDialog();
            this.Show();
            if (_showingAllOrders.Finish)
            {
                this.Close();
            }
            _showingAllOrders.Dispose();
        }

        private void MenuManager_Load(object sender, EventArgs e)
        {
            this.Size = Properties.Settings.Default.formSize;
            LoadData();
        }

        private void MenuManager_Resize(object sender, EventArgs e)
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
