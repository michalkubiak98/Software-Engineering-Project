namespace EventSYS
{
    partial class frmVenueUpdate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenueUpdate));
            this.grdVenues = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtManagerMobile = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTown = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCounty = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtManagerEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtManagerName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMaxCapacity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStreet = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblMaxCapacity = new System.Windows.Forms.Label();
            this.lblManagerMobile = new System.Windows.Forms.Label();
            this.lblManagerEmail = new System.Windows.Forms.Label();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnReset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSelect = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdVenues)).BeginInit();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdVenues
            // 
            this.grdVenues.AllowUserToAddRows = false;
            this.grdVenues.AllowUserToDeleteRows = false;
            this.grdVenues.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdVenues.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdVenues.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdVenues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdVenues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVenues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdVenues.ColumnHeadersHeight = 20;
            this.grdVenues.DoubleBuffered = true;
            this.grdVenues.EnableHeadersVisualStyles = false;
            this.grdVenues.GridColor = System.Drawing.SystemColors.Control;
            this.grdVenues.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.grdVenues.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdVenues.Location = new System.Drawing.Point(460, 100);
            this.grdVenues.Name = "grdVenues";
            this.grdVenues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdVenues.Size = new System.Drawing.Size(590, 322);
            this.grdVenues.TabIndex = 114;
            this.grdVenues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVenues_CellClick);
            // 
            // txtManagerMobile
            // 
            this.txtManagerMobile.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtManagerMobile.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtManagerMobile.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtManagerMobile.BorderThickness = 1;
            this.txtManagerMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManagerMobile.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerMobile.ForeColor = System.Drawing.Color.DimGray;
            this.txtManagerMobile.isPassword = false;
            this.txtManagerMobile.Location = new System.Drawing.Point(167, 377);
            this.txtManagerMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerMobile.Name = "txtManagerMobile";
            this.txtManagerMobile.Size = new System.Drawing.Size(202, 26);
            this.txtManagerMobile.TabIndex = 161;
            this.txtManagerMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManagerMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManagerMobile_KeyPress);
            // 
            // txtTown
            // 
            this.txtTown.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtTown.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTown.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtTown.BorderThickness = 1;
            this.txtTown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTown.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.ForeColor = System.Drawing.Color.DimGray;
            this.txtTown.isPassword = false;
            this.txtTown.Location = new System.Drawing.Point(166, 179);
            this.txtTown.Margin = new System.Windows.Forms.Padding(4);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(202, 26);
            this.txtTown.TabIndex = 160;
            this.txtTown.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTown_KeyPress);
            // 
            // txtCounty
            // 
            this.txtCounty.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtCounty.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtCounty.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtCounty.BorderThickness = 1;
            this.txtCounty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCounty.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.ForeColor = System.Drawing.Color.DimGray;
            this.txtCounty.isPassword = false;
            this.txtCounty.Location = new System.Drawing.Point(166, 213);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(202, 26);
            this.txtCounty.TabIndex = 159;
            this.txtCounty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCounty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCounty_KeyPress);
            // 
            // txtManagerEmail
            // 
            this.txtManagerEmail.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtManagerEmail.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtManagerEmail.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtManagerEmail.BorderThickness = 1;
            this.txtManagerEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManagerEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtManagerEmail.isPassword = false;
            this.txtManagerEmail.Location = new System.Drawing.Point(167, 343);
            this.txtManagerEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerEmail.Name = "txtManagerEmail";
            this.txtManagerEmail.Size = new System.Drawing.Size(202, 26);
            this.txtManagerEmail.TabIndex = 158;
            this.txtManagerEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManagerEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManagerEmail_KeyPress);
            // 
            // txtManagerName
            // 
            this.txtManagerName.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtManagerName.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtManagerName.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtManagerName.BorderThickness = 1;
            this.txtManagerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManagerName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerName.ForeColor = System.Drawing.Color.DimGray;
            this.txtManagerName.isPassword = false;
            this.txtManagerName.Location = new System.Drawing.Point(167, 309);
            this.txtManagerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(202, 26);
            this.txtManagerName.TabIndex = 157;
            this.txtManagerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManagerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManagerName_KeyPress);
            // 
            // txtMaxCapacity
            // 
            this.txtMaxCapacity.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtMaxCapacity.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtMaxCapacity.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtMaxCapacity.BorderThickness = 1;
            this.txtMaxCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaxCapacity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxCapacity.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaxCapacity.isPassword = false;
            this.txtMaxCapacity.Location = new System.Drawing.Point(166, 247);
            this.txtMaxCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxCapacity.Name = "txtMaxCapacity";
            this.txtMaxCapacity.Size = new System.Drawing.Size(56, 26);
            this.txtMaxCapacity.TabIndex = 156;
            this.txtMaxCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaxCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxCapacity_KeyPress);
            // 
            // txtStreet
            // 
            this.txtStreet.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtStreet.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtStreet.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtStreet.BorderThickness = 1;
            this.txtStreet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.ForeColor = System.Drawing.Color.DimGray;
            this.txtStreet.isPassword = false;
            this.txtStreet.Location = new System.Drawing.Point(166, 145);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(202, 26);
            this.txtStreet.TabIndex = 155;
            this.txtStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStreet_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtName.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtName.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtName.BorderThickness = 1;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(167, 111);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 26);
            this.txtName.TabIndex = 154;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(27, 47);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(341, 10);
            this.bunifuSeparator1.TabIndex = 153;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(130, 23);
            this.bunifuCustomLabel1.TabIndex = 150;
            this.bunifuCustomLabel1.Text = "Update Venue";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(168, 81);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(54, 23);
            this.txtID.TabIndex = 149;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblID.Location = new System.Drawing.Point(26, 88);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 148;
            this.lblID.Text = "ID";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblCounty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCounty.Location = new System.Drawing.Point(25, 223);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(48, 16);
            this.lblCounty.TabIndex = 147;
            this.lblCounty.Text = "County";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTown.Location = new System.Drawing.Point(25, 189);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(39, 16);
            this.lblTown.TabIndex = 146;
            this.lblTown.Text = "Town";
            // 
            // lblMaxCapacity
            // 
            this.lblMaxCapacity.AutoSize = true;
            this.lblMaxCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaxCapacity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblMaxCapacity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMaxCapacity.Location = new System.Drawing.Point(25, 257);
            this.lblMaxCapacity.Name = "lblMaxCapacity";
            this.lblMaxCapacity.Size = new System.Drawing.Size(86, 16);
            this.lblMaxCapacity.TabIndex = 145;
            this.lblMaxCapacity.Text = "Max Capacity";
            // 
            // lblManagerMobile
            // 
            this.lblManagerMobile.AutoSize = true;
            this.lblManagerMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblManagerMobile.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblManagerMobile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblManagerMobile.Location = new System.Drawing.Point(26, 387);
            this.lblManagerMobile.Name = "lblManagerMobile";
            this.lblManagerMobile.Size = new System.Drawing.Size(106, 16);
            this.lblManagerMobile.TabIndex = 144;
            this.lblManagerMobile.Text = "Manager Mobile";
            // 
            // lblManagerEmail
            // 
            this.lblManagerEmail.AutoSize = true;
            this.lblManagerEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblManagerEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblManagerEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblManagerEmail.Location = new System.Drawing.Point(26, 353);
            this.lblManagerEmail.Name = "lblManagerEmail";
            this.lblManagerEmail.Size = new System.Drawing.Size(96, 16);
            this.lblManagerEmail.TabIndex = 143;
            this.lblManagerEmail.Text = "Manager Email";
            // 
            // lblManagerName
            // 
            this.lblManagerName.AutoSize = true;
            this.lblManagerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblManagerName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblManagerName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblManagerName.Location = new System.Drawing.Point(26, 319);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(100, 16);
            this.lblManagerName.TabIndex = 142;
            this.lblManagerName.Text = "Manager Name";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblStreet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStreet.Location = new System.Drawing.Point(25, 155);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 16);
            this.lblStreet.TabIndex = 141;
            this.lblStreet.Text = "Street";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.Location = new System.Drawing.Point(25, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 16);
            this.lblName.TabIndex = 140;
            this.lblName.Text = "Name";
            // 
            // grpBox
            // 
            this.grpBox.BackColor = System.Drawing.SystemColors.Control;
            this.grpBox.Controls.Add(this.btnConfirm);
            this.grpBox.Controls.Add(this.txtManagerMobile);
            this.grpBox.Controls.Add(this.lblName);
            this.grpBox.Controls.Add(this.txtTown);
            this.grpBox.Controls.Add(this.lblStreet);
            this.grpBox.Controls.Add(this.txtCounty);
            this.grpBox.Controls.Add(this.lblManagerName);
            this.grpBox.Controls.Add(this.txtManagerEmail);
            this.grpBox.Controls.Add(this.lblManagerEmail);
            this.grpBox.Controls.Add(this.txtManagerName);
            this.grpBox.Controls.Add(this.lblManagerMobile);
            this.grpBox.Controls.Add(this.txtMaxCapacity);
            this.grpBox.Controls.Add(this.lblMaxCapacity);
            this.grpBox.Controls.Add(this.txtStreet);
            this.grpBox.Controls.Add(this.lblTown);
            this.grpBox.Controls.Add(this.txtName);
            this.grpBox.Controls.Add(this.lblCounty);
            this.grpBox.Controls.Add(this.bunifuSeparator1);
            this.grpBox.Controls.Add(this.lblID);
            this.grpBox.Controls.Add(this.btnReset);
            this.grpBox.Controls.Add(this.txtID);
            this.grpBox.Controls.Add(this.bunifuCustomLabel1);
            this.grpBox.ForeColor = System.Drawing.SystemColors.Control;
            this.grpBox.Location = new System.Drawing.Point(45, 19);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(397, 479);
            this.grpBox.TabIndex = 162;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Details";
            // 
            // btnConfirm
            // 
            this.btnConfirm.ActiveBorderThickness = 1;
            this.btnConfirm.ActiveCornerRadius = 20;
            this.btnConfirm.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirm.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btnConfirm.ActiveLineColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.ButtonText = "Update";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.IdleBorderThickness = 1;
            this.btnConfirm.IdleCornerRadius = 20;
            this.btnConfirm.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnConfirm.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.Location = new System.Drawing.Point(235, 417);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 40);
            this.btnConfirm.TabIndex = 151;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReset
            // 
            this.btnReset.ActiveBorderThickness = 1;
            this.btnReset.ActiveCornerRadius = 20;
            this.btnReset.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.btnReset.ActiveForecolor = System.Drawing.Color.Gray;
            this.btnReset.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.ButtonText = "Reset";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnReset.IdleBorderThickness = 1;
            this.btnReset.IdleCornerRadius = 20;
            this.btnReset.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btnReset.IdleForecolor = System.Drawing.Color.DimGray;
            this.btnReset.IdleLineColor = System.Drawing.Color.DimGray;
            this.btnReset.Location = new System.Drawing.Point(167, 417);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 40);
            this.btnReset.TabIndex = 152;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::EventSYS.Properties.Resources.home__2_;
            this.btnBack.Location = new System.Drawing.Point(14, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 34);
            this.btnBack.TabIndex = 163;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EventSYS.Properties.Resources.icon__1___1_;
            this.btnExit.Location = new System.Drawing.Point(1064, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 164;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSelect.Location = new System.Drawing.Point(456, 46);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(218, 21);
            this.lblSelect.TabIndex = 162;
            this.lblSelect.Text = "Please select venue to update!";
            // 
            // frmVenueUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1110, 503);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.grdVenues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenueUpdate";
            this.Text = "frmVenueUpdt";
            this.Load += new System.EventHandler(this.frmVenueUpdt_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmVenueUpdate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmVenueUpdate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmVenueUpdate_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.grdVenues)).EndInit();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid grdVenues;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtManagerMobile;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTown;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCounty;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtManagerEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtManagerName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMaxCapacity;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStreet;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReset;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblMaxCapacity;
        private System.Windows.Forms.Label lblManagerMobile;
        private System.Windows.Forms.Label lblManagerEmail;
        private System.Windows.Forms.Label lblManagerName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSelect;
    }
}