namespace Supply_control_system.Forms.Client
{
    partial class FormCreateOrder
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
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonSelectShipment = new System.Windows.Forms.Button();
            this.labelShipment = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelResultPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSelectProduct = new System.Windows.Forms.Button();
            this.labelProduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberOfContract = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customMenuStrip3 = new Supply_control_system.Components.CustomMenuStrip();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customMenuStrip2 = new Supply_control_system.Components.CustomMenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadowEffect1 = new ShadowEffect.ShadowEffect(this.components);
            this.shadowEffect2 = new ShadowEffect.ShadowEffect(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.customMenuStrip3.SuspendLayout();
            this.customMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = global::Supply_control_system.Properties.Settings.Default.backgroundColor;
            this.panel1.Controls.Add(this.buttonCreateOrder);
            this.panel1.Controls.Add(this.buttonConfirm);
            this.panel1.Controls.Add(this.buttonSelectShipment);
            this.panel1.Controls.Add(this.labelShipment);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelResultPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonSelectProduct);
            this.panel1.Controls.Add(this.labelProduct);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxNumberOfContract);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(110, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 900);
            this.panel1.TabIndex = 1;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateOrder.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonCreateOrder.Location = new System.Drawing.Point(482, 622);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(786, 57);
            this.buttonCreateOrder.TabIndex = 38;
            this.buttonCreateOrder.Text = "Create";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonConfirm.Location = new System.Drawing.Point(482, 522);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(786, 57);
            this.buttonConfirm.TabIndex = 37;
            this.buttonConfirm.Text = "Comfirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonSelectShipment
            // 
            this.buttonSelectShipment.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonSelectShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectShipment.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonSelectShipment.Location = new System.Drawing.Point(1115, 435);
            this.buttonSelectShipment.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSelectShipment.Name = "buttonSelectShipment";
            this.buttonSelectShipment.Size = new System.Drawing.Size(153, 45);
            this.buttonSelectShipment.TabIndex = 36;
            this.buttonSelectShipment.Text = "Select";
            this.buttonSelectShipment.UseVisualStyleBackColor = true;
            this.buttonSelectShipment.Click += new System.EventHandler(this.buttonSelectShipment_Click);
            // 
            // labelShipment
            // 
            this.labelShipment.AutoSize = true;
            this.labelShipment.Location = new System.Drawing.Point(809, 443);
            this.labelShipment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelShipment.Name = "labelShipment";
            this.labelShipment.Size = new System.Drawing.Size(116, 37);
            this.labelShipment.TabIndex = 35;
            this.labelShipment.Text = "(None)";
            this.labelShipment.TextChanged += new System.EventHandler(this.labelShipment_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 443);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 37);
            this.label7.TabIndex = 34;
            this.label7.Text = "Shipment:";
            // 
            // labelResultPrice
            // 
            this.labelResultPrice.AutoSize = true;
            this.labelResultPrice.Location = new System.Drawing.Point(809, 365);
            this.labelResultPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelResultPrice.Name = "labelResultPrice";
            this.labelResultPrice.Size = new System.Drawing.Size(100, 37);
            this.labelResultPrice.TabIndex = 33;
            this.labelResultPrice.Text = "0 rub.";
            this.labelResultPrice.TextChanged += new System.EventHandler(this.labelShipment_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 37);
            this.label5.TabIndex = 32;
            this.label5.Text = "Price:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.numericUpDown1.Location = new System.Drawing.Point(816, 278);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(452, 44);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 37);
            this.label4.TabIndex = 30;
            this.label4.Text = "Count:";
            // 
            // buttonSelectProduct
            // 
            this.buttonSelectProduct.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonSelectProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectProduct.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonSelectProduct.Location = new System.Drawing.Point(1115, 201);
            this.buttonSelectProduct.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSelectProduct.Name = "buttonSelectProduct";
            this.buttonSelectProduct.Size = new System.Drawing.Size(153, 45);
            this.buttonSelectProduct.TabIndex = 29;
            this.buttonSelectProduct.Text = "Select";
            this.buttonSelectProduct.UseVisualStyleBackColor = true;
            this.buttonSelectProduct.Click += new System.EventHandler(this.buttonSelectProduct_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(809, 205);
            this.labelProduct.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(116, 37);
            this.labelProduct.TabIndex = 21;
            this.labelProduct.Text = "(None)";
            this.labelProduct.TextChanged += new System.EventHandler(this.labelShipment_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Products:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Number of contract:";
            // 
            // textBoxNumberOfContract
            // 
            this.textBoxNumberOfContract.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxNumberOfContract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumberOfContract.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxNumberOfContract.Location = new System.Drawing.Point(816, 127);
            this.textBoxNumberOfContract.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNumberOfContract.Name = "textBoxNumberOfContract";
            this.textBoxNumberOfContract.Size = new System.Drawing.Size(452, 44);
            this.textBoxNumberOfContract.TabIndex = 18;
            this.textBoxNumberOfContract.TextChanged += new System.EventHandler(this.labelShipment_TextChanged);
            this.textBoxNumberOfContract.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberOfContract_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.customMenuStrip3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.customMenuStrip2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1700, 24);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // customMenuStrip3
            // 
            this.customMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem});
            this.customMenuStrip3.Location = new System.Drawing.Point(0, 0);
            this.customMenuStrip3.Name = "customMenuStrip3";
            this.customMenuStrip3.Size = new System.Drawing.Size(850, 24);
            this.customMenuStrip3.TabIndex = 1;
            this.customMenuStrip3.Text = "customMenuStrip3";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.cancelToolStripMenuItem.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // customMenuStrip2
            // 
            this.customMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.customMenuStrip2.Location = new System.Drawing.Point(850, 0);
            this.customMenuStrip2.Name = "customMenuStrip2";
            this.customMenuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customMenuStrip2.Size = new System.Drawing.Size(850, 24);
            this.customMenuStrip2.TabIndex = 0;
            this.customMenuStrip2.Text = "customMenuStrip2";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
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
            this.shadowEffect2.SourceControl = this.tableLayoutPanel1;
            this.shadowEffect2.UseShadowEffect = true;
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormCreateOrder";
            this.Text = "Creating order";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.Resize += new System.EventHandler(this.FormCreateOrder_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.customMenuStrip3.ResumeLayout(false);
            this.customMenuStrip3.PerformLayout();
            this.customMenuStrip2.ResumeLayout(false);
            this.customMenuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ShadowEffect.ShadowEffect shadowEffect1;
        private ShadowEffect.ShadowEffect shadowEffect2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Components.CustomMenuStrip customMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private Components.CustomMenuStrip customMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxNumberOfContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Button buttonSelectProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelResultPrice;
        private System.Windows.Forms.Label labelShipment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSelectShipment;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCreateOrder;
    }
}