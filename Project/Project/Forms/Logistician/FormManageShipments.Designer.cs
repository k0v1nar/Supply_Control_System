namespace Supply_control_system.Forms.Logistician
{
    partial class FormManageShipments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.customDateTimePickerDateShipment = new Supply_control_system.Components.CustomDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxDateShipments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewShipments = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customMenuStrip3 = new Supply_control_system.Components.CustomMenuStrip();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customMenuStrip2 = new Supply_control_system.Components.CustomMenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadowEffect1 = new ShadowEffect.ShadowEffect(this.components);
            this.shadowEffect2 = new ShadowEffect.ShadowEffect(this.components);
            this.labelCountRows = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShipments)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.customMenuStrip3.SuspendLayout();
            this.customMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = global::Supply_control_system.Properties.Settings.Default.backgroundColor;
            this.panel1.Controls.Add(this.labelCountRows);
            this.panel1.Controls.Add(this.buttonChange);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.customDateTimePickerDateShipment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.textBoxDateShipments);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridViewShipments);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(110, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 900);
            this.panel1.TabIndex = 1;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonChange.Location = new System.Drawing.Point(1117, 336);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(6);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(566, 53);
            this.buttonChange.TabIndex = 46;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonAdd.Location = new System.Drawing.Point(1117, 271);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(566, 53);
            this.buttonAdd.TabIndex = 45;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // customDateTimePickerDateShipment
            // 
            this.customDateTimePickerDateShipment.BorderColor = global::Supply_control_system.Properties.Settings.Default.backgroundColor;
            this.customDateTimePickerDateShipment.BorderSize = 1;
            this.customDateTimePickerDateShipment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.customDateTimePickerDateShipment.Location = new System.Drawing.Point(1212, 214);
            this.customDateTimePickerDateShipment.Name = "customDateTimePickerDateShipment";
            this.customDateTimePickerDateShipment.Size = new System.Drawing.Size(471, 44);
            this.customDateTimePickerDateShipment.SkinColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.customDateTimePickerDateShipment.TabIndex = 44;
            this.customDateTimePickerDateShipment.TextColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1110, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 37);
            this.label1.TabIndex = 40;
            this.label1.Text = "Date:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(1110, 157);
            this.labelID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(51, 37);
            this.labelID.TabIndex = 39;
            this.labelID.Text = "id:";
            this.labelID.TextChanged += new System.EventHandler(this.labelID_TextChanged);
            // 
            // textBoxDateShipments
            // 
            this.textBoxDateShipments.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.textBoxDateShipments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDateShipments.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.textBoxDateShipments.Location = new System.Drawing.Point(286, 100);
            this.textBoxDateShipments.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDateShipments.Name = "textBoxDateShipments";
            this.textBoxDateShipments.Size = new System.Drawing.Size(799, 44);
            this.textBoxDateShipments.TabIndex = 38;
            this.textBoxDateShipments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDateShipments_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "Search shipment:";
            // 
            // dataGridViewShipments
            // 
            this.dataGridViewShipments.AllowUserToDeleteRows = false;
            this.dataGridViewShipments.AllowUserToResizeColumns = false;
            this.dataGridViewShipments.AllowUserToResizeRows = false;
            this.dataGridViewShipments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShipments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewShipments.BackgroundColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShipments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShipments.EnableHeadersVisualStyles = false;
            this.dataGridViewShipments.GridColor = global::Supply_control_system.Properties.Settings.Default.backgroundColor;
            this.dataGridViewShipments.Location = new System.Drawing.Point(15, 157);
            this.dataGridViewShipments.Name = "dataGridViewShipments";
            this.dataGridViewShipments.ReadOnly = true;
            this.dataGridViewShipments.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(65)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(158)))));
            this.dataGridViewShipments.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewShipments.RowTemplate.ReadOnly = true;
            this.dataGridViewShipments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewShipments.Size = new System.Drawing.Size(1070, 648);
            this.dataGridViewShipments.TabIndex = 20;
            this.dataGridViewShipments.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewShipments_ColumnAdded);
            this.dataGridViewShipments.SelectionChanged += new System.EventHandler(this.dataGridViewShipments_SelectionChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = global::Supply_control_system.Properties.Settings.Default.labelColor;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = global::Supply_control_system.Properties.Settings.Default.textColor;
            this.buttonUpdate.Location = new System.Drawing.Point(15, 814);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(1070, 70);
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
            // labelCountRows
            // 
            this.labelCountRows.AutoSize = true;
            this.labelCountRows.Location = new System.Drawing.Point(1097, 103);
            this.labelCountRows.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCountRows.Name = "labelCountRows";
            this.labelCountRows.Size = new System.Drawing.Size(279, 37);
            this.labelCountRows.TabIndex = 56;
            this.labelCountRows.Text = "Count rows: 0 of 0";
            // 
            // FormManageShipments
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
            this.Name = "FormManageShipments";
            this.Text = "Managing shipments";
            this.Load += new System.EventHandler(this.FormManageShipments_Load);
            this.Resize += new System.EventHandler(this.FormManageShipments_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShipments)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewShipments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDateShipments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID;
        private Components.CustomDateTimePicker customDateTimePickerDateShipment;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCountRows;
    }
}