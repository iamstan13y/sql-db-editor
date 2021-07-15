namespace SQL_DB_editor
{
    partial class NewDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLength = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.bun = new ns1.BunifuMetroTextbox();
            this.cmbDatatype = new System.Windows.Forms.ComboBox();
            this.bunifuMetroTextbox4 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.txtColumn = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.btnaddCoumn = new ns1.BunifuThinButton2();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.bunifuMetroTextbox2 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.btnCreate = new ns1.BunifuThinButton2();
            this.txtdbName = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddTable = new ns1.BunifuThinButton2();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.txtableName = new ns1.BunifuMetroTextbox();
            this.btnClose = new ns1.BunifuImageButton();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.txtdbName);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 385);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLength);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox2.Controls.Add(this.bun);
            this.groupBox2.Controls.Add(this.cmbDatatype);
            this.groupBox2.Controls.Add(this.bunifuMetroTextbox4);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox2.Controls.Add(this.txtColumn);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox2.Controls.Add(this.btnaddCoumn);
            this.groupBox2.Controls.Add(this.cmbTables);
            this.groupBox2.Controls.Add(this.bunifuMetroTextbox2);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F);
            this.groupBox2.Location = new System.Drawing.Point(393, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 224);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns";
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.Color.LightCyan;
            this.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLength.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtLength.Location = new System.Drawing.Point(334, 146);
            this.txtLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(45, 23);
            this.txtLength.TabIndex = 72;
            this.txtLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Verdana", 12F);
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(259, 148);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(71, 18);
            this.bunifuCustomLabel6.TabIndex = 71;
            this.bunifuCustomLabel6.Text = "Length:";
            // 
            // bun
            // 
            this.bun.BackColor = System.Drawing.Color.LightCyan;
            this.bun.BorderColorFocused = System.Drawing.SystemColors.HotTrack;
            this.bun.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.bun.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack;
            this.bun.BorderThickness = 2;
            this.bun.Cursor = System.Windows.Forms.Cursors.Default;
            this.bun.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bun.ForeColor = System.Drawing.Color.Black;
            this.bun.isPassword = false;
            this.bun.Location = new System.Drawing.Point(329, 141);
            this.bun.Margin = new System.Windows.Forms.Padding(4);
            this.bun.Name = "bun";
            this.bun.Size = new System.Drawing.Size(54, 32);
            this.bun.TabIndex = 70;
            this.bun.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbDatatype
            // 
            this.cmbDatatype.AutoCompleteCustomSource.AddRange(new string[] {
            "BIGINT",
            "BLOB",
            "BOOLEAN",
            "CHAR",
            "DATE",
            "DATETIME",
            "DECIMAL",
            "DOUBLE",
            "FLOAT",
            "INT",
            "LONGBLOB",
            "LONGTEXT",
            "TEXT",
            "VARCHAR"});
            this.cmbDatatype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDatatype.BackColor = System.Drawing.Color.LightCyan;
            this.cmbDatatype.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbDatatype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDatatype.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatatype.ForeColor = System.Drawing.Color.Black;
            this.cmbDatatype.FormattingEnabled = true;
            this.cmbDatatype.Items.AddRange(new object[] {
            "Blob",
            "Boolean",
            "Char",
            "Date",
            "DateTime",
            "Decimal",
            "Double",
            "Float",
            "Int",
            "Text",
            "VarChar"});
            this.cmbDatatype.Location = new System.Drawing.Point(152, 144);
            this.cmbDatatype.MaxDropDownItems = 30;
            this.cmbDatatype.Name = "cmbDatatype";
            this.cmbDatatype.Size = new System.Drawing.Size(100, 26);
            this.cmbDatatype.Sorted = true;
            this.cmbDatatype.TabIndex = 68;
            // 
            // bunifuMetroTextbox4
            // 
            this.bunifuMetroTextbox4.BackColor = System.Drawing.Color.SlateGray;
            this.bunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.bunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox4.BorderThickness = 2;
            this.bunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuMetroTextbox4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox4.isPassword = false;
            this.bunifuMetroTextbox4.Location = new System.Drawing.Point(149, 141);
            this.bunifuMetroTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox4.Name = "bunifuMetroTextbox4";
            this.bunifuMetroTextbox4.Size = new System.Drawing.Size(106, 32);
            this.bunifuMetroTextbox4.TabIndex = 69;
            this.bunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Verdana", 12F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(56, 148);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(90, 18);
            this.bunifuCustomLabel5.TabIndex = 67;
            this.bunifuCustomLabel5.Text = "Datatype:";
            // 
            // txtColumn
            // 
            this.txtColumn.BackColor = System.Drawing.Color.LightCyan;
            this.txtColumn.BorderColorFocused = System.Drawing.SystemColors.HotTrack;
            this.txtColumn.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtColumn.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack;
            this.txtColumn.BorderThickness = 2;
            this.txtColumn.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtColumn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumn.ForeColor = System.Drawing.Color.Black;
            this.txtColumn.isPassword = false;
            this.txtColumn.Location = new System.Drawing.Point(148, 101);
            this.txtColumn.Margin = new System.Windows.Forms.Padding(4);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(116, 31);
            this.txtColumn.TabIndex = 66;
            this.txtColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Verdana", 12F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(28, 110);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(119, 18);
            this.bunifuCustomLabel4.TabIndex = 65;
            this.bunifuCustomLabel4.Text = "Column Title:";
            // 
            // btnaddCoumn
            // 
            this.btnaddCoumn.ActiveBorderThickness = 1;
            this.btnaddCoumn.ActiveCornerRadius = 20;
            this.btnaddCoumn.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnaddCoumn.ActiveForecolor = System.Drawing.Color.White;
            this.btnaddCoumn.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnaddCoumn.BackColor = System.Drawing.Color.AliceBlue;
            this.btnaddCoumn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaddCoumn.BackgroundImage")));
            this.btnaddCoumn.ButtonText = "Add Column";
            this.btnaddCoumn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnaddCoumn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddCoumn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnaddCoumn.IdleBorderThickness = 1;
            this.btnaddCoumn.IdleCornerRadius = 20;
            this.btnaddCoumn.IdleFillColor = System.Drawing.Color.White;
            this.btnaddCoumn.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnaddCoumn.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnaddCoumn.Location = new System.Drawing.Point(228, 183);
            this.btnaddCoumn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnaddCoumn.Name = "btnaddCoumn";
            this.btnaddCoumn.Size = new System.Drawing.Size(138, 37);
            this.btnaddCoumn.TabIndex = 64;
            this.btnaddCoumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnaddCoumn.Click += new System.EventHandler(this.btnaddCoumn_Click);
            // 
            // cmbTables
            // 
            this.cmbTables.BackColor = System.Drawing.Color.LightCyan;
            this.cmbTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTables.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTables.ForeColor = System.Drawing.Color.Black;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(148, 54);
            this.cmbTables.MaxDropDownItems = 30;
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(218, 26);
            this.cmbTables.Sorted = true;
            this.cmbTables.TabIndex = 62;
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BackColor = System.Drawing.Color.SlateGray;
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderThickness = 2;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(145, 51);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(224, 32);
            this.bunifuMetroTextbox2.TabIndex = 63;
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Verdana", 12F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(28, 59);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(114, 18);
            this.bunifuCustomLabel3.TabIndex = 61;
            this.bunifuCustomLabel3.Text = "Select Table:";
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveBorderThickness = 1;
            this.btnCreate.ActiveCornerRadius = 20;
            this.btnCreate.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreate.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreate.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreate.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.BackgroundImage")));
            this.btnCreate.ButtonText = "Create";
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCreate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreate.IdleBorderThickness = 1;
            this.btnCreate.IdleCornerRadius = 20;
            this.btnCreate.IdleFillColor = System.Drawing.Color.White;
            this.btnCreate.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnCreate.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreate.Location = new System.Drawing.Point(438, 55);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(117, 37);
            this.btnCreate.TabIndex = 60;
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtdbName
            // 
            this.txtdbName.BackColor = System.Drawing.Color.LightCyan;
            this.txtdbName.BorderColorFocused = System.Drawing.SystemColors.HotTrack;
            this.txtdbName.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtdbName.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack;
            this.txtdbName.BorderThickness = 2;
            this.txtdbName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtdbName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdbName.ForeColor = System.Drawing.Color.Black;
            this.txtdbName.isPassword = false;
            this.txtdbName.Location = new System.Drawing.Point(192, 57);
            this.txtdbName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtdbName.Name = "txtdbName";
            this.txtdbName.Size = new System.Drawing.Size(224, 32);
            this.txtdbName.TabIndex = 59;
            this.txtdbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Verdana", 12F);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(45, 65);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(146, 18);
            this.bunifuCustomLabel1.TabIndex = 58;
            this.bunifuCustomLabel1.Text = "Database Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddTable);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.txtableName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F);
            this.groupBox1.Location = new System.Drawing.Point(28, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 221);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Details";
            // 
            // btnAddTable
            // 
            this.btnAddTable.ActiveBorderThickness = 1;
            this.btnAddTable.ActiveCornerRadius = 20;
            this.btnAddTable.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddTable.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddTable.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddTable.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAddTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddTable.BackgroundImage")));
            this.btnAddTable.ButtonText = "Add Table";
            this.btnAddTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddTable.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddTable.IdleBorderThickness = 1;
            this.btnAddTable.IdleCornerRadius = 20;
            this.btnAddTable.IdleFillColor = System.Drawing.Color.White;
            this.btnAddTable.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnAddTable.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddTable.Location = new System.Drawing.Point(196, 104);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(138, 37);
            this.btnAddTable.TabIndex = 62;
            this.btnAddTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Enabled = false;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Verdana", 12F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(24, 58);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(111, 18);
            this.bunifuCustomLabel2.TabIndex = 61;
            this.bunifuCustomLabel2.Text = "Table Name:";
            // 
            // txtableName
            // 
            this.txtableName.BackColor = System.Drawing.Color.LightCyan;
            this.txtableName.BorderColorFocused = System.Drawing.SystemColors.HotTrack;
            this.txtableName.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtableName.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack;
            this.txtableName.BorderThickness = 2;
            this.txtableName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtableName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtableName.ForeColor = System.Drawing.Color.Black;
            this.txtableName.isPassword = false;
            this.txtableName.Location = new System.Drawing.Point(135, 51);
            this.txtableName.Margin = new System.Windows.Forms.Padding(4);
            this.txtableName.Name = "txtableName";
            this.txtableName.Size = new System.Drawing.Size(199, 32);
            this.txtableName.TabIndex = 60;
            this.txtableName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(756, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.AliceBlue;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(25, 9);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(164, 22);
            this.bunifuCustomLabel7.TabIndex = 8;
            this.bunifuCustomLabel7.Text = "Create Database";
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "sqlite";
            // 
            // NewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(595, 170);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewDB";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewDB";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ns1.BunifuMetroTextbox txtdbName;
        private ns1.BunifuThinButton2 btnCreate;
        private System.Windows.Forms.GroupBox groupBox2;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuMetroTextbox txtableName;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuMetroTextbox bun;
        private System.Windows.Forms.ComboBox cmbDatatype;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox4;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuMetroTextbox txtColumn;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuThinButton2 btnaddCoumn;
        private System.Windows.Forms.ComboBox cmbTables;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox2;
        private ns1.BunifuThinButton2 btnAddTable;
        private System.Windows.Forms.NumericUpDown txtLength;
        private ns1.BunifuImageButton btnClose;
        public ns1.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}