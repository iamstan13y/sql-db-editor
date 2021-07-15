namespace SQL_DB_editor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.btnExit = new ns1.BunifuImageButton();
            this.btnBrowse = new ns1.BunifuImageButton();
            this.btnMinimize = new ns1.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDatabases = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateLite = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModify = new System.Windows.Forms.ToolStripMenuItem();
            this.mySQLDatabaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLiteDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSecurity = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnMysql = new System.Windows.Forms.TabPage();
            this.btnOpen = new ns1.BunifuThinButton2();
            this.btnTables = new ns1.BunifuThinButton2();
            this.btnConn = new ns1.BunifuThinButton2();
            this.bunifuMetroTextbox3 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.txtAddress = new ns1.BunifuMetroTextbox();
            this.bunifuMetroTextbox2 = new ns1.BunifuMetroTextbox();
            this.btnSqlite = new System.Windows.Forms.TabPage();
            this.cmbTablesLite = new System.Windows.Forms.ComboBox();
            this.bunifuMetroTextbox4 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.txtBrowsePath = new ns1.BunifuMetroTextbox();
            this.btnConnLite = new ns1.BunifuThinButton2();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMsSql = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.btnMysql.SuspendLayout();
            this.btnSqlite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.btnMsSql.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTables
            // 
            this.cmbTables.BackColor = System.Drawing.Color.LightCyan;
            this.cmbTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTables.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTables.ForeColor = System.Drawing.Color.Black;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(146, 214);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(182, 26);
            this.cmbTables.Sorted = true;
            this.cmbTables.TabIndex = 57;
            this.toolTip.SetToolTip(this.cmbTables, "Select Table");
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.BackColor = System.Drawing.Color.LightCyan;
            this.cmbDatabases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDatabases.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatabases.ForeColor = System.Drawing.Color.Black;
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(146, 143);
            this.cmbDatabases.MaxDropDownItems = 30;
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(182, 26);
            this.cmbDatabases.Sorted = true;
            this.cmbDatabases.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmbDatabases, "Select Database");
            this.cmbDatabases.SelectedIndexChanged += new System.EventHandler(this.cmbDatabases_SelectedIndexChanged);
            this.cmbDatabases.SelectionChangeCommitted += new System.EventHandler(this.cmbDatabases_SelectionChangeCommitted);
            this.cmbDatabases.SelectedValueChanged += new System.EventHandler(this.cmbDatabases_SelectedValueChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(591, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 26);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.toolTip.SetToolTip(this.btnExit, "Exit");
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageActive = null;
            this.btnBrowse.Location = new System.Drawing.Point(513, 68);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(31, 26);
            this.btnBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBrowse.TabIndex = 70;
            this.btnBrowse.TabStop = false;
            this.toolTip.SetToolTip(this.btnBrowse, "Select Database");
            this.btnBrowse.Zoom = 10;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            this.btnBrowse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuImageButton1_MouseClick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(556, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 26);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.toolTip.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 369);
            this.panel1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDatabases,
            this.btnSecurity,
            this.toolStripSeparator1,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(354, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(264, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDatabases
            // 
            this.btnDatabases.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnModify});
            this.btnDatabases.Image = ((System.Drawing.Image)(resources.GetObject("btnDatabases.Image")));
            this.btnDatabases.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDatabases.Name = "btnDatabases";
            this.btnDatabases.Size = new System.Drawing.Size(107, 22);
            this.btnDatabases.Text = "Database";
            // 
            // btnCreate
            // 
            this.btnCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateSQL,
            this.btnCreateLite});
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 22);
            this.btnCreate.Text = "Create New";
            // 
            // btnCreateSQL
            // 
            this.btnCreateSQL.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCreateSQL.Name = "btnCreateSQL";
            this.btnCreateSQL.Size = new System.Drawing.Size(129, 22);
            this.btnCreateSQL.Text = "MySQL";
            this.btnCreateSQL.Click += new System.EventHandler(this.btnCreateSQL_Click);
            // 
            // btnCreateLite
            // 
            this.btnCreateLite.Name = "btnCreateLite";
            this.btnCreateLite.Size = new System.Drawing.Size(129, 22);
            this.btnCreateLite.Text = "SQLite ";
            this.btnCreateLite.Click += new System.EventHandler(this.btnCreateLite_Click);
            // 
            // btnModify
            // 
            this.btnModify.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mySQLDatabaseToolStripMenuItem1,
            this.sQLiteDatabaseToolStripMenuItem});
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(180, 22);
            this.btnModify.Text = "Modify";
            // 
            // mySQLDatabaseToolStripMenuItem1
            // 
            this.mySQLDatabaseToolStripMenuItem1.Name = "mySQLDatabaseToolStripMenuItem1";
            this.mySQLDatabaseToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.mySQLDatabaseToolStripMenuItem1.Text = "MySQL";
            // 
            // sQLiteDatabaseToolStripMenuItem
            // 
            this.sQLiteDatabaseToolStripMenuItem.Name = "sQLiteDatabaseToolStripMenuItem";
            this.sQLiteDatabaseToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sQLiteDatabaseToolStripMenuItem.Text = "SQLite";
            // 
            // btnSecurity
            // 
            this.btnSecurity.Image = ((System.Drawing.Image)(resources.GetObject("btnSecurity.Image")));
            this.btnSecurity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Size = new System.Drawing.Size(88, 22);
            this.btnSecurity.Text = "Security";
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHelp
            // 
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(60, 22);
            this.btnHelp.Text = "Help";
            this.btnHelp.ToolTipText = "Visit Website";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.btnMysql);
            this.tabControl1.Controls.Add(this.btnSqlite);
            this.tabControl1.Controls.Add(this.btnMsSql);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 352);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 2;
            // 
            // btnMysql
            // 
            this.btnMysql.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMysql.Controls.Add(this.btnOpen);
            this.btnMysql.Controls.Add(this.btnTables);
            this.btnMysql.Controls.Add(this.btnConn);
            this.btnMysql.Controls.Add(this.cmbTables);
            this.btnMysql.Controls.Add(this.bunifuMetroTextbox3);
            this.btnMysql.Controls.Add(this.bunifuCustomLabel3);
            this.btnMysql.Controls.Add(this.bunifuCustomLabel2);
            this.btnMysql.Controls.Add(this.bunifuCustomLabel1);
            this.btnMysql.Controls.Add(this.txtAddress);
            this.btnMysql.Controls.Add(this.cmbDatabases);
            this.btnMysql.Controls.Add(this.bunifuMetroTextbox2);
            this.btnMysql.Location = new System.Drawing.Point(4, 27);
            this.btnMysql.Name = "btnMysql";
            this.btnMysql.Padding = new System.Windows.Forms.Padding(3);
            this.btnMysql.Size = new System.Drawing.Size(624, 321);
            this.btnMysql.TabIndex = 0;
            this.btnMysql.Text = "MySQL";
            // 
            // btnOpen
            // 
            this.btnOpen.ActiveBorderThickness = 1;
            this.btnOpen.ActiveCornerRadius = 20;
            this.btnOpen.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpen.ActiveForecolor = System.Drawing.Color.White;
            this.btnOpen.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpen.BackColor = System.Drawing.Color.AliceBlue;
            this.btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpen.BackgroundImage")));
            this.btnOpen.ButtonText = "Open";
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpen.IdleBorderThickness = 1;
            this.btnOpen.IdleCornerRadius = 20;
            this.btnOpen.IdleFillColor = System.Drawing.Color.White;
            this.btnOpen.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnOpen.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnOpen.Location = new System.Drawing.Point(339, 208);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(138, 37);
            this.btnOpen.TabIndex = 62;
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnTables
            // 
            this.btnTables.ActiveBorderThickness = 1;
            this.btnTables.ActiveCornerRadius = 20;
            this.btnTables.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTables.ActiveForecolor = System.Drawing.Color.White;
            this.btnTables.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnTables.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTables.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTables.BackgroundImage")));
            this.btnTables.ButtonText = "Retrieve Tables";
            this.btnTables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTables.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTables.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTables.IdleBorderThickness = 1;
            this.btnTables.IdleCornerRadius = 20;
            this.btnTables.IdleFillColor = System.Drawing.Color.White;
            this.btnTables.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnTables.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnTables.Location = new System.Drawing.Point(337, 136);
            this.btnTables.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(138, 37);
            this.btnTables.TabIndex = 61;
            this.btnTables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnConn
            // 
            this.btnConn.ActiveBorderThickness = 1;
            this.btnConn.ActiveCornerRadius = 20;
            this.btnConn.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnConn.ActiveForecolor = System.Drawing.Color.White;
            this.btnConn.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnConn.BackColor = System.Drawing.Color.AliceBlue;
            this.btnConn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConn.BackgroundImage")));
            this.btnConn.ButtonText = "Connect";
            this.btnConn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnConn.IdleBorderThickness = 1;
            this.btnConn.IdleCornerRadius = 20;
            this.btnConn.IdleFillColor = System.Drawing.Color.White;
            this.btnConn.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnConn.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnConn.Location = new System.Drawing.Point(337, 62);
            this.btnConn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(138, 37);
            this.btnConn.TabIndex = 59;
            this.btnConn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // bunifuMetroTextbox3
            // 
            this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox3.BorderThickness = 2;
            this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.isPassword = false;
            this.bunifuMetroTextbox3.Location = new System.Drawing.Point(143, 211);
            this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.Size = new System.Drawing.Size(188, 32);
            this.bunifuMetroTextbox3.TabIndex = 58;
            this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(74, 221);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(67, 18);
            this.bunifuCustomLabel3.TabIndex = 56;
            this.bunifuCustomLabel3.Text = "Tables:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(39, 147);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(102, 18);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Databases:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(4, 73);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(137, 18);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Server Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.LightCyan;
            this.txtAddress.BorderColorFocused = System.Drawing.SystemColors.HotTrack;
            this.txtAddress.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtAddress.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack;
            this.txtAddress.BorderThickness = 2;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.isPassword = false;
            this.txtAddress.Location = new System.Drawing.Point(141, 64);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(188, 34);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BackColor = System.Drawing.Color.SlateGray;
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderThickness = 2;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(143, 140);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(188, 32);
            this.bunifuMetroTextbox2.TabIndex = 54;
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSqlite
            // 
            this.btnSqlite.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSqlite.Controls.Add(this.cmbTablesLite);
            this.btnSqlite.Controls.Add(this.bunifuMetroTextbox4);
            this.btnSqlite.Controls.Add(this.bunifuCustomLabel4);
            this.btnSqlite.Controls.Add(this.bunifuCustomLabel6);
            this.btnSqlite.Controls.Add(this.txtBrowsePath);
            this.btnSqlite.Controls.Add(this.btnConnLite);
            this.btnSqlite.Controls.Add(this.btnBrowse);
            this.btnSqlite.Location = new System.Drawing.Point(4, 27);
            this.btnSqlite.Name = "btnSqlite";
            this.btnSqlite.Padding = new System.Windows.Forms.Padding(3);
            this.btnSqlite.Size = new System.Drawing.Size(624, 321);
            this.btnSqlite.TabIndex = 1;
            this.btnSqlite.Text = "SQLite";
            // 
            // cmbTablesLite
            // 
            this.cmbTablesLite.BackColor = System.Drawing.Color.LightCyan;
            this.cmbTablesLite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablesLite.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTablesLite.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTablesLite.ForeColor = System.Drawing.Color.Black;
            this.cmbTablesLite.FormattingEnabled = true;
            this.cmbTablesLite.Location = new System.Drawing.Point(141, 178);
            this.cmbTablesLite.Name = "cmbTablesLite";
            this.cmbTablesLite.Size = new System.Drawing.Size(182, 26);
            this.cmbTablesLite.Sorted = true;
            this.cmbTablesLite.TabIndex = 73;
            // 
            // bunifuMetroTextbox4
            // 
            this.bunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.bunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox4.BorderThickness = 2;
            this.bunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox4.isPassword = false;
            this.bunifuMetroTextbox4.Location = new System.Drawing.Point(138, 175);
            this.bunifuMetroTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox4.Name = "bunifuMetroTextbox4";
            this.bunifuMetroTextbox4.Size = new System.Drawing.Size(188, 32);
            this.bunifuMetroTextbox4.TabIndex = 74;
            this.bunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(69, 184);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(67, 18);
            this.bunifuCustomLabel4.TabIndex = 65;
            this.bunifuCustomLabel4.Text = "Tables:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(21, 73);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(117, 18);
            this.bunifuCustomLabel6.TabIndex = 61;
            this.bunifuCustomLabel6.Text = "Browse Path:";
            // 
            // txtBrowsePath
            // 
            this.txtBrowsePath.BackColor = System.Drawing.Color.LightCyan;
            this.txtBrowsePath.BorderColorFocused = System.Drawing.SystemColors.HotTrack;
            this.txtBrowsePath.BorderColorIdle = System.Drawing.Color.SlateGray;
            this.txtBrowsePath.BorderColorMouseHover = System.Drawing.SystemColors.HotTrack;
            this.txtBrowsePath.BorderThickness = 2;
            this.txtBrowsePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrowsePath.Enabled = false;
            this.txtBrowsePath.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrowsePath.ForeColor = System.Drawing.Color.Black;
            this.txtBrowsePath.isPassword = false;
            this.txtBrowsePath.Location = new System.Drawing.Point(138, 64);
            this.txtBrowsePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrowsePath.Name = "txtBrowsePath";
            this.txtBrowsePath.Size = new System.Drawing.Size(411, 34);
            this.txtBrowsePath.TabIndex = 71;
            this.txtBrowsePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnConnLite
            // 
            this.btnConnLite.ActiveBorderThickness = 1;
            this.btnConnLite.ActiveCornerRadius = 20;
            this.btnConnLite.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnConnLite.ActiveForecolor = System.Drawing.Color.White;
            this.btnConnLite.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnConnLite.BackColor = System.Drawing.Color.AliceBlue;
            this.btnConnLite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnLite.BackgroundImage")));
            this.btnConnLite.ButtonText = "Connect";
            this.btnConnLite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnLite.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnLite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnConnLite.IdleBorderThickness = 1;
            this.btnConnLite.IdleCornerRadius = 20;
            this.btnConnLite.IdleFillColor = System.Drawing.Color.White;
            this.btnConnLite.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btnConnLite.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnConnLite.Location = new System.Drawing.Point(463, 106);
            this.btnConnLite.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConnLite.Name = "btnConnLite";
            this.btnConnLite.Size = new System.Drawing.Size(86, 37);
            this.btnConnLite.TabIndex = 72;
            this.btnConnLite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConnLite.Click += new System.EventHandler(this.btnConnLite_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.AliceBlue;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(36, 3);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(163, 23);
            this.bunifuCustomLabel5.TabIndex = 5;
            this.bunifuCustomLabel5.Text = "SQL DB-editor ";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.IndianRed;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(193, 8);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(34, 17);
            this.bunifuCustomLabel7.TabIndex = 6;
            this.bunifuCustomLabel7.Text = "v1.1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnMsSql
            // 
            this.btnMsSql.Controls.Add(this.listBox1);
            this.btnMsSql.Controls.Add(this.button1);
            this.btnMsSql.Location = new System.Drawing.Point(4, 27);
            this.btnMsSql.Name = "btnMsSql";
            this.btnMsSql.Padding = new System.Windows.Forms.Padding(3);
            this.btnMsSql.Size = new System.Drawing.Size(624, 321);
            this.btnMsSql.TabIndex = 2;
            this.btnMsSql.Text = "MS SQL Server";
            this.btnMsSql.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(328, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 112);
            this.listBox1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(632, 408);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL DB-editor";
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.btnMysql.ResumeLayout(false);
            this.btnMysql.PerformLayout();
            this.btnSqlite.ResumeLayout(false);
            this.btnSqlite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.btnMsSql.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private ns1.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnDatabases;
        private System.Windows.Forms.ToolStripMenuItem btnCreate;
        private System.Windows.Forms.ToolStripMenuItem btnCreateSQL;
        private System.Windows.Forms.ToolStripMenuItem btnCreateLite;
        private System.Windows.Forms.ToolStripMenuItem btnModify;
        private System.Windows.Forms.ToolStripMenuItem mySQLDatabaseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sQLiteDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnSecurity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage btnMysql;
        private ns1.BunifuThinButton2 btnConn;
        private System.Windows.Forms.ComboBox cmbTables;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox3;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuMetroTextbox txtAddress;
        private System.Windows.Forms.ComboBox cmbDatabases;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox2;
        private System.Windows.Forms.TabPage btnSqlite;
        private ns1.BunifuImageButton btnBrowse;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuMetroTextbox txtBrowsePath;
        private System.Windows.Forms.ComboBox cmbTablesLite;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox4;
        private ns1.BunifuThinButton2 btnConnLite;
        private System.Windows.Forms.OpenFileDialog openFile;
        private ns1.BunifuThinButton2 btnTables;
        private ns1.BunifuThinButton2 btnOpen;
        private ns1.BunifuImageButton btnExit;
        private System.Windows.Forms.TabPage btnMsSql;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

