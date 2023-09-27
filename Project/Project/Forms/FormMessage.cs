using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supply_control_system.Scripts;
using Supply_control_system.Forms;
using Supply_control_system.Components;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using Supply_control_system.Forms.Client;
using Supply_control_system.Forms.Admin;
using SpecialFormLibrary;

namespace Supply_control_system
{
    public partial class FormMessage : Form
    {
        private AutoScalingForm _autoScalingForm;

        public FormMessage(MessageData data)
        {
            this.Icon = Properties.Resources.logo1;
            InitializeComponent();
            DoubleBuffered = true;
            _autoScalingForm = AutoScalingForm.Init(this);
            this.Refresh();
            labelFirstName.Text = $"First name:\n{data.FirstName}";
            labelSecondName.Text = $"Second name:\n{data.SecondName}";
            labelRole.Text = $"Role: {data.MyRole}";
            pictureBox1.BackgroundImage = data.Image;
        }

        private void FormMessage_Resize(object sender, EventArgs e)
        {
            _autoScalingForm.ResizeAll();
            this.Refresh();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
