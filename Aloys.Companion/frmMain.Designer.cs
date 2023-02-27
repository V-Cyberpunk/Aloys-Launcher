namespace Aloys.Companion
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tblCDN = new System.Windows.Forms.TableLayoutPanel();
            this.lblPortal = new System.Windows.Forms.Label();
            this.txtCDNS = new System.Windows.Forms.TextBox();
            this.lblVersions = new System.Windows.Forms.Label();
            this.lblCDNS = new System.Windows.Forms.Label();
            this.txtVersions = new System.Windows.Forms.TextBox();
            this.txtPortal = new System.Windows.Forms.TextBox();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCerts = new System.Windows.Forms.Label();
            this.tblCmb = new System.Windows.Forms.TableLayoutPanel();
            this.cmbVersion = new System.Windows.Forms.ComboBox();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCerts = new System.Windows.Forms.TextBox();
            this.tblCDN.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.menu.SuspendLayout();
            this.tblCmb.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCDN
            // 
            this.tblCDN.BackColor = System.Drawing.Color.Transparent;
            this.tblCDN.ColumnCount = 2;
            this.tblCDN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCDN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCDN.Controls.Add(this.lblPortal, 0, 2);
            this.tblCDN.Controls.Add(this.txtCDNS, 1, 1);
            this.tblCDN.Controls.Add(this.lblVersions, 0, 0);
            this.tblCDN.Controls.Add(this.lblCDNS, 0, 1);
            this.tblCDN.Controls.Add(this.txtVersions, 1, 0);
            this.tblCDN.Controls.Add(this.txtPortal, 1, 2);
            this.tblCDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCDN.Location = new System.Drawing.Point(4, 95);
            this.tblCDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblCDN.Name = "tblCDN";
            this.tblCDN.RowCount = 3;
            this.tblCDN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tblCDN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tblCDN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tblCDN.Size = new System.Drawing.Size(1089, 240);
            this.tblCDN.TabIndex = 0;
            // 
            // lblPortal
            // 
            this.lblPortal.AutoSize = true;
            this.lblPortal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPortal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPortal.ForeColor = System.Drawing.Color.Gold;
            this.lblPortal.Location = new System.Drawing.Point(4, 166);
            this.lblPortal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortal.Name = "lblPortal";
            this.lblPortal.Size = new System.Drawing.Size(536, 83);
            this.lblPortal.TabIndex = 4;
            this.lblPortal.Text = "portal link:";
            this.lblPortal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCDNS
            // 
            this.txtCDNS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCDNS.BackColor = System.Drawing.Color.Tomato;
            this.txtCDNS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCDNS.Location = new System.Drawing.Point(548, 105);
            this.txtCDNS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCDNS.Name = "txtCDNS";
            this.txtCDNS.Size = new System.Drawing.Size(537, 39);
            this.txtCDNS.TabIndex = 3;
            this.txtCDNS.TextChanged += new System.EventHandler(this.txtCDNS_TextChanged);
            // 
            // lblVersions
            // 
            this.lblVersions.AutoSize = true;
            this.lblVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersions.ForeColor = System.Drawing.Color.Gold;
            this.lblVersions.Location = new System.Drawing.Point(4, 0);
            this.lblVersions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersions.Name = "lblVersions";
            this.lblVersions.Size = new System.Drawing.Size(536, 83);
            this.lblVersions.TabIndex = 0;
            this.lblVersions.Text = "versions-file link:";
            this.lblVersions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCDNS
            // 
            this.lblCDNS.AutoSize = true;
            this.lblCDNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCDNS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCDNS.ForeColor = System.Drawing.Color.Gold;
            this.lblCDNS.Location = new System.Drawing.Point(4, 83);
            this.lblCDNS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCDNS.Name = "lblCDNS";
            this.lblCDNS.Size = new System.Drawing.Size(536, 83);
            this.lblCDNS.TabIndex = 1;
            this.lblCDNS.Text = "cdns-file link:";
            this.lblCDNS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVersions
            // 
            this.txtVersions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersions.BackColor = System.Drawing.Color.Tomato;
            this.txtVersions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVersions.Location = new System.Drawing.Point(548, 22);
            this.txtVersions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVersions.Name = "txtVersions";
            this.txtVersions.Size = new System.Drawing.Size(537, 39);
            this.txtVersions.TabIndex = 2;
            this.txtVersions.TextChanged += new System.EventHandler(this.txtVersions_TextChanged);
            // 
            // txtPortal
            // 
            this.txtPortal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPortal.BackColor = System.Drawing.Color.Tomato;
            this.txtPortal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPortal.Location = new System.Drawing.Point(548, 188);
            this.txtPortal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPortal.Name = "txtPortal";
            this.txtPortal.Size = new System.Drawing.Size(537, 39);
            this.txtPortal.TabIndex = 5;
            this.txtPortal.TextChanged += new System.EventHandler(this.txtPortal_TextChanged);
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblCDN, 0, 2);
            this.tblMain.Controls.Add(this.menu, 0, 0);
            this.tblMain.Controls.Add(this.lblCerts, 0, 3);
            this.tblMain.Controls.Add(this.tblCmb, 0, 1);
            this.tblMain.Controls.Add(this.tblButtons, 0, 4);
            this.tblMain.Controls.Add(this.txtCerts, 0, 4);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 6;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tblMain.Size = new System.Drawing.Size(1097, 1148);
            this.tblMain.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1097, 40);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 36);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblCerts
            // 
            this.lblCerts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerts.AutoSize = true;
            this.lblCerts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCerts.ForeColor = System.Drawing.Color.Gold;
            this.lblCerts.Location = new System.Drawing.Point(4, 361);
            this.lblCerts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerts.Name = "lblCerts";
            this.lblCerts.Size = new System.Drawing.Size(1089, 40);
            this.lblCerts.TabIndex = 2;
            this.lblCerts.Text = "Certificates:";
            this.lblCerts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblCmb
            // 
            this.tblCmb.ColumnCount = 2;
            this.tblCmb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCmb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCmb.Controls.Add(this.cmbVersion, 0, 0);
            this.tblCmb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCmb.Location = new System.Drawing.Point(3, 43);
            this.tblCmb.Name = "tblCmb";
            this.tblCmb.RowCount = 1;
            this.tblCmb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCmb.Size = new System.Drawing.Size(1091, 44);
            this.tblCmb.TabIndex = 4;
            // 
            // cmbVersion
            // 
            this.cmbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVersion.BackColor = System.Drawing.Color.Black;
            this.cmbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbVersion.ForeColor = System.Drawing.Color.LightGreen;
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.Items.AddRange(new object[] {
            "Retail 9.x, 10.0.x",
            "Classic 2.5.x, 3.4.x",
            "Classic Era 1.14.x"});
            this.cmbVersion.Location = new System.Drawing.Point(3, 3);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(539, 40);
            this.cmbVersion.TabIndex = 0;
            this.cmbVersion.SelectedIndexChanged += new System.EventHandler(this.cmbVersion_SelectedIndexChanged);
            // 
            // tblButtons
            // 
            this.tblButtons.BackColor = System.Drawing.Color.Transparent;
            this.tblButtons.ColumnCount = 3;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.Controls.Add(this.btnStart, 0, 0);
            this.tblButtons.Controls.Add(this.btnClose, 1, 0);
            this.tblButtons.Controls.Add(this.btnSave, 0, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(4, 1070);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.Size = new System.Drawing.Size(1089, 73);
            this.tblButtons.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::Aloys.Companion.Properties.Resources.button;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.Gold;
            this.btnStart.Location = new System.Drawing.Point(367, 5);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(355, 63);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start WoW";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Aloys.Companion.Properties.Resources.button;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Gold;
            this.btnClose.Location = new System.Drawing.Point(730, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(355, 63);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::Aloys.Companion.Properties.Resources.button;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Gold;
            this.btnSave.Location = new System.Drawing.Point(4, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(355, 63);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCerts
            // 
            this.txtCerts.BackColor = System.Drawing.Color.Black;
            this.txtCerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCerts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCerts.ForeColor = System.Drawing.Color.LightGreen;
            this.txtCerts.Location = new System.Drawing.Point(3, 426);
            this.txtCerts.Multiline = true;
            this.txtCerts.Name = "txtCerts";
            this.txtCerts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCerts.Size = new System.Drawing.Size(1091, 636);
            this.txtCerts.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aloys.Companion.Properties.Resources.wall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1097, 1148);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aloys Companion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.tblCDN.ResumeLayout(false);
            this.tblCDN.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tblCmb.ResumeLayout(false);
            this.tblButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblCDN;
        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblButtons;
        private Button btnClose;
        private Button btnSave;
        private TextBox txtCDNS;
        private Label lblVersions;
        private Label lblCDNS;
        private TextBox txtVersions;
        private Label lblCerts;
        private Label lblPortal;
        private TextBox txtPortal;
        private TextBox txtCerts;
        private Button btnStart;
        private TableLayoutPanel tblCmb;
        private ComboBox cmbVersion;
        private MenuStrip menu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}