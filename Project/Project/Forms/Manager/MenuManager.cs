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
using Supply_control_system.Forms.Manager;
using SpecialFormLibrary;

namespace Supply_control_system.Forms.Manager
{
    public partial class MenuManager : SpecialForm
    {
        private SpecialForm _orders, _supplyPlane, _settings;

        public MenuManager() : base(Properties.Settings.Default.connectionString)
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

        private void buttonShowAllOrders_Click(object sender, EventArgs e)
        {
            _orders = new FormOrders();
            this.Hide();
            _orders.ShowDialog();
            this.Show();
            if (_orders.Finish)
            {
                this.Close();
            }
            _orders.Dispose();
        }

        private void buttonMyOrders_Click(object sender, EventArgs e)
        {
            _supplyPlane = new FormSupplyPlane();
            this.Hide();
            _supplyPlane.ShowDialog();
            this.Show();
            if (_supplyPlane.Finish)
            {
                this.Close();
            }
            _supplyPlane.Dispose();
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
