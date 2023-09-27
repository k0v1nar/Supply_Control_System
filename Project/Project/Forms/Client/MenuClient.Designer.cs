namespace Supply_control_system.Forms.Client
{
    partial class MenuClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMyOrders = new System.Windows.Forms.Button();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.customMenuStrip1 = new Supply_control_system.Components.CustomMenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadowEffect1 = new ShadowEffect.ShadowEffect(this.components);
            this.shadowEffect2 = new ShadowEffect.ShadowEffect(this.components);
            this.panel1.SuspendLayout();
            this.customMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = global::Supply_control_system.Properties.Settings.Default.backgroundColor;
            this.panel1.Controls.Add(this.buttonMyOrders);
            this.panel1.Controls.Add(this.buttonCreateOrder);
            this.panel1.Controls.Add(this.customMenuStrip1);
            this.panel1.Location = new System.Drawing.Point(110, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 900);
            this.panel1.TabIndex = 1;
            // 
            // buttonMyOrders
            // 
            this.buttonMyOrders.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyOrders.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonMyOrders.Location = new System.Drawing.Point(653, 549);
            this.buttonMyOrders.Margin = new System.Windows.Forms.Padding(6);
            this.buttonMyOrders.Name = "buttonMyOrders";
            this.buttonMyOrders.Size = new System.Drawing.Size(500, 250);
            this.buttonMyOrders.TabIndex = 16;
            this.buttonMyOrders.Text = "My orders";
            this.buttonMyOrders.UseVisualStyleBackColor = true;
            this.buttonMyOrders.Click += new System.EventHandler(this.buttonMyOrders_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateOrder.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonCreateOrder.Location = new System.Drawing.Point(653, 153);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(500, 250);
            this.buttonCreateOrder.TabIndex = 15;
            this.buttonCreateOrder.Text = "Create order";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // customMenuStrip1
            // 
            this.customMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.customMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.customMenuStrip1.Name = "customMenuStrip1";
            this.customMenuStrip1.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.customMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customMenuStrip1.Size = new System.Drawing.Size(1700, 27);
            this.customMenuStrip1.TabIndex = 14;
            this.customMenuStrip1.Text = "customMenuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.exitToolStripMenuItem.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 19);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.settingsToolStripMenuItem.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // shadowEffect1
            // 
            this.shadowEffect1.Depth = 20;
            this.shadowEffect1.ShadowColor = System.Drawing.Color.Black;
            this.shadowEffect1.ShadowPadding = new System.Windows.Forms.Padding(8, 0, 8, 10);
            this.shadowEffect1.ShadowRadius = 10;
            this.shadowEffect1.SourceControl = this.panel1;
            this.shadowEffect1.UseShadowEffect = true;
            // 
            // shadowEffect2
            // 
            this.shadowEffect2.Depth = 20;
            this.shadowEffect2.ShadowColor = System.Drawing.Color.Black;
            this.shadowEffect2.ShadowPadding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.shadowEffect2.ShadowRadius = 10;
            this.shadowEffect2.SourceControl = this.customMenuStrip1;
            this.shadowEffect2.UseShadowEffect = true;
            // 
            // MenuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.MainMenuStrip = this.customMenuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MenuClient";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuClient_Load);
            this.Resize += new System.EventHandler(this.MenuClient_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customMenuStrip1.ResumeLayout(false);
            this.customMenuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Components.CustomMenuStrip customMenuStrip1;
        private ShadowEffect.ShadowEffect shadowEffect1;
        private ShadowEffect.ShadowEffect shadowEffect2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonMyOrders;
    }
}