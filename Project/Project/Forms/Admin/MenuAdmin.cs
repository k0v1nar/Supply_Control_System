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
using Supply_control_system.Forms.Admin;
using SpecialFormLibrary;

namespace Supply_control_system.Forms.Admin
{
    public partial class MenuAdmin : SpecialForm
    {
        private SpecialForm _managingAccounts, _managingProducts, _showingHistory, _settings;

        public MenuAdmin() : base(Properties.Settings.Default.connectionString)
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

        private void buttonManageAccounts_Click(object sender, EventArgs e)
        {
            _managingAccounts = new FormManageAccounts();
            this.Hide();
            _managingAccounts.ShowDialog();
            this.Show();
            if (_managingAccounts.Finish)
            {
                this.Close();
            }
            _managingAccounts.Dispose();
        }

        private void buttonManageProducts_Click(object sender, EventArgs e)
        {
            _managingProducts = new FormManageProducts();
            this.Hide();
            _managingProducts.ShowDialog();
            this.Show();
            if (_managingProducts.Finish)
            {
                this.Close();
            }
            _managingProducts.Dispose();
        }

        private void buttonShowHistory_Click(object sender, EventArgs e)
        {
            _showingHistory = new FormHistoryAuthentication();
            this.Hide();
            _showingHistory.ShowDialog();
            this.Show();
            if (_showingHistory.Finish)
            {
                this.Close();
            }
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            this.Size = Properties.Settings.Default.formSize;
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

        private void MenuAdmin_Resize(object sender, EventArgs e)
        {
            Properties.Settings.Default.formSize = this.Size;
            Properties.Settings.Default.Save();
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void LoadData()
        {
            accountsToolStripMenuItem.Text = Properties.Settings.Default.login;
        }
    }
}
