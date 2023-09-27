namespace Supply_control_system.Forms.Manager
{
    partial class FormOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customDateTimePickerTo = new Supply_control_system.Components.CustomDateTimePicker();
            this.customDateTimePickerFrom = new Supply_control_system.Components.CustomDateTimePicker();
            this.textBoxPriceTo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPriceFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxPrice = new System.Windows.Forms.CheckBox();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxProduct = new System.Windows.Forms.CheckBox();
            this.comboBoxShipment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxShipment = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customMenuStrip3 = new Supply_control_system.Components.CustomMenuStrip();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customMenuStrip2 = new Supply_control_system.Components.CustomMenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadowEffect1 = new ShadowEffect.ShadowEffect(this.components);
            this.shadowEffect2 = new ShadowEffect.ShadowEffect(this.components);
            this.shadowEffect3 = new ShadowEffect.ShadowEffect(this.components);
            this.labelCountRows = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.customMenuStrip3.SuspendLayout();
            this.customMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = global::Supply_control_system.Properties.Settings.Default.backgroundColor;
            this.panel1.Controls.Add(this.labelCountRows);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxSort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewOrders);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(110, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 900);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = global::Supply_control_system.Properties.Settings.Default.selectColor;
            this.panel2.Controls.Add(this.customDateTimePickerTo);
            this.panel2.Controls.Add(this.customDateTimePickerFrom);
            this.panel2.Controls.Add(this.textBoxPriceTo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxPriceFrom);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.checkBoxPrice);
            this.panel2.Controls.Add(this.textBoxProduct);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.checkBoxProduct);
            this.panel2.Controls.Add(this.comboBoxShipment);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.checkBoxShipment);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.checkBoxDate);
            this.panel2.Location = new System.Drawing.Point(1194, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 592);
            this.panel2.TabIndex = 30;
            // 
            // customDateTimePickerTo
            // 
            this.customDateTimePickerTo.BorderColor = global::Supply_control_system.Properties.Settings.Default.backgroundColor;
            this.customDateTimePickerTo.BorderSize = 1;
            this.customDateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.customDateTimePickerTo.Location = new System.Drawing.Point(199, 121);
            this.customDateTimePickerTo.Name = "customDateTimePickerTo";
            this.customDateTimePickerTo.Size = new System.Drawing.Size(271, 44);
            this.customDateTimePickerTo.SkinColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.customDateTimePickerTo.TabIndex = 44;
            this.customDateTimePickerTo.TextColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            // 
            // customDateTimePickerFrom
            // 
            this.customDateTimePickerFrom.BorderColor = global::Supply_control_system.Properties.Settings.Default.backgroundColor;
            this.customDateTimePickerFrom.BorderSize = 1;
            this.customDateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.customDateTimePickerFrom.Location = new System.Drawing.Point(199, 67);
            this.customDateTimePickerFrom.Name = "customDateTimePickerFrom";
            this.customDateTimePickerFrom.Size = new System.Drawing.Size(271, 44);
            this.customDateTimePickerFrom.SkinColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.customDateTimePickerFrom.TabIndex = 43;
            this.customDateTimePickerFrom.TextColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            // 
            // textBoxPriceTo
            // 
            this.textBoxPriceTo.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxPriceTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPriceTo.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxPriceTo.Location = new System.Drawing.Point(212, 527);
            this.textBoxPriceTo.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPriceTo.Name = "textBoxPriceTo";
            this.textBoxPriceTo.Size = new System.Drawing.Size(258, 44);
            this.textBoxPriceTo.TabIndex = 42;
            this.textBoxPriceTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriceFrom_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 529);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 37);
            this.label8.TabIndex = 41;
            this.label8.Text = "Price (to):";
            // 
            // textBoxPriceFrom
            // 
            this.textBoxPriceFrom.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxPriceFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPriceFrom.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxPriceFrom.Location = new System.Drawing.Point(212, 469);
            this.textBoxPriceFrom.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPriceFrom.Name = "textBoxPriceFrom";
            this.textBoxPriceFrom.Size = new System.Drawing.Size(258, 44);
            this.textBoxPriceFrom.TabIndex = 40;
            this.textBoxPriceFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPriceFrom_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 471);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 37);
            this.label7.TabIndex = 39;
            this.label7.Text = "Price (from):";
            // 
            // checkBoxPrice
            // 
            this.checkBoxPrice.AutoSize = true;
            this.checkBoxPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPrice.Location = new System.Drawing.Point(13, 414);
            this.checkBoxPrice.Name = "checkBoxPrice";
            this.checkBoxPrice.Size = new System.Drawing.Size(105, 41);
            this.checkBoxPrice.TabIndex = 38;
            this.checkBoxPrice.Text = "Price";
            this.checkBoxPrice.UseVisualStyleBackColor = true;
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProduct.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxProduct.Location = new System.Drawing.Point(124, 351);
            this.textBoxProduct.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(346, 44);
            this.textBoxProduct.TabIndex = 37;
            this.textBoxProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProduct_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 37);
            this.label6.TabIndex = 36;
            this.label6.Text = "name:";
            // 
            // checkBoxProduct
            // 
            this.checkBoxProduct.AutoSize = true;
            this.checkBoxProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxProduct.Location = new System.Drawing.Point(13, 299);
            this.checkBoxProduct.Name = "checkBoxProduct";
            this.checkBoxProduct.Size = new System.Drawing.Size(144, 41);
            this.checkBoxProduct.TabIndex = 35;
            this.checkBoxProduct.Text = "Product";
            this.checkBoxProduct.UseVisualStyleBackColor = true;
            // 
            // comboBoxShipment
            // 
            this.comboBoxShipment.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.comboBoxShipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxShipment.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.comboBoxShipment.FormattingEnabled = true;
            this.comboBoxShipment.Items.AddRange(new object[] {
            "cheaper",
            "more expensive"});
            this.comboBoxShipment.Location = new System.Drawing.Point(66, 237);
            this.comboBoxShipment.Name = "comboBoxShipment";
            this.comboBoxShipment.Size = new System.Drawing.Size(404, 45);
            this.comboBoxShipment.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 37);
            this.label5.TabIndex = 33;
            this.label5.Text = "id:";
            // 
            // checkBoxShipment
            // 
            this.checkBoxShipment.AutoSize = true;
            this.checkBoxShipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShipment.Location = new System.Drawing.Point(13, 182);
            this.checkBoxShipment.Name = "checkBoxShipment";
            this.checkBoxShipment.Size = new System.Drawing.Size(168, 41);
            this.checkBoxShipment.TabIndex = 32;
            this.checkBoxShipment.Text = "Shipment";
            this.checkBoxShipment.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 37);
            this.label4.TabIndex = 29;
            this.label4.Text = "date (to):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 37);
            this.label3.TabIndex = 28;
            this.label3.Text = "date (from):";
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDate.Location = new System.Drawing.Point(13, 15);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(100, 41);
            this.checkBoxDate.TabIndex = 0;
            this.checkBoxDate.Text = "Date";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1187, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "Filters:";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.comboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSort.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "cheaper",
            "more expensive"});
            this.comboBoxSort.Location = new System.Drawing.Point(1281, 99);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(402, 45);
            this.comboBoxSort.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1187, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sort:";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AllowUserToResizeColumns = false;
            this.dataGridViewOrders.AllowUserToResizeRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewOrders.BackgroundColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.EnableHeadersVisualStyles = false;
            this.dataGridViewOrders.GridColor = global::Supply_control_system.Properties.Settings.Default.backgroundColor;
            this.dataGridViewOrders.Location = new System.Drawing.Point(15, 99);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(158)))));
            this.dataGridViewOrders.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrders.RowTemplate.ReadOnly = true;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1155, 706);
            this.dataGridViewOrders.TabIndex = 20;
            this.dataGridViewOrders.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewOrders_ColumnAdded);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonUpdate.Location = new System.Drawing.Point(15, 814);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(1155, 70);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            // shadowEffect3
            // 
            this.shadowEffect3.Depth = 20;
            this.shadowEffect3.ShadowColor = System.Drawing.Color.Black;
            this.shadowEffect3.ShadowPadding = new System.Windows.Forms.Padding(8, 0, 8, 10);
            this.shadowEffect3.ShadowRadius = 10;
            this.shadowEffect3.SourceControl = this.panel2;
            this.shadowEffect3.UseShadowEffect = true;
            // 
            // labelCountRows
            // 
            this.labelCountRows.AutoSize = true;
            this.labelCountRows.Location = new System.Drawing.Point(1187, 166);
            this.labelCountRows.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCountRows.Name = "labelCountRows";
            this.labelCountRows.Size = new System.Drawing.Size(279, 37);
            this.labelCountRows.TabIndex = 56;
            this.labelCountRows.Text = "Count rows: 0 of 0";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormOrders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.Resize += new System.EventHandler(this.FormOrders_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
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
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private ShadowEffect.ShadowEffect shadowEffect3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxShipment;
        private System.Windows.Forms.ComboBox comboBoxShipment;
        private System.Windows.Forms.CheckBox checkBoxProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.CheckBox checkBoxPrice;
        private System.Windows.Forms.TextBox textBoxPriceTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPriceFrom;
        private System.Windows.Forms.Label label7;
        private Components.CustomDateTimePicker customDateTimePickerFrom;
        private Components.CustomDateTimePicker customDateTimePickerTo;
        private System.Windows.Forms.Label labelCountRows;
    }
}