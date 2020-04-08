namespace EventSYS
{
    partial class frmEventUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventUpdate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEu = new System.Windows.Forms.Label();
            this.dtpDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTicketsAvailable = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTime = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTitle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTicketsAvailable = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVenueName = new System.Windows.Forms.Label();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.btnReset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSelect = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grdUpdateEvent = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(20, 54);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(341, 10);
            this.bunifuSeparator1.TabIndex = 184;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeader.Location = new System.Drawing.Point(18, 32);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(122, 23);
            this.lblHeader.TabIndex = 183;
            this.lblHeader.Text = "Update Event";
            // 
            // lblEu
            // 
            this.lblEu.AutoSize = true;
            this.lblEu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEu.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblEu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEu.Location = new System.Drawing.Point(227, 394);
            this.lblEu.Name = "lblEu";
            this.lblEu.Size = new System.Drawing.Size(35, 16);
            this.lblEu.TabIndex = 182;
            this.lblEu.Text = "Euro";
            // 
            // dtpDate
            // 
            this.dtpDate.BackColor = System.Drawing.SystemColors.Control;
            this.dtpDate.BorderRadius = 0;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.dtpDate.ForeColor = System.Drawing.Color.DimGray;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.FormatCustom = null;
            this.dtpDate.Location = new System.Drawing.Point(161, 263);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(232, 40);
            this.dtpDate.TabIndex = 181;
            this.dtpDate.Value = new System.DateTime(2020, 3, 9, 21, 55, 39, 342);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtPrice.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtPrice.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtPrice.BorderThickness = 1;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrice.isPassword = false;
            this.txtPrice.Location = new System.Drawing.Point(161, 384);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(59, 26);
            this.txtPrice.TabIndex = 180;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.AutoScroll = true;
            this.txtDescription.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtDescription.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtDescription.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtDescription.BorderThickness = 1;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescription.isPassword = false;
            this.txtDescription.Location = new System.Drawing.Point(160, 186);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(202, 64);
            this.txtDescription.TabIndex = 179;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTicketsAvailable
            // 
            this.txtTicketsAvailable.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtTicketsAvailable.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTicketsAvailable.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtTicketsAvailable.BorderThickness = 1;
            this.txtTicketsAvailable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTicketsAvailable.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketsAvailable.ForeColor = System.Drawing.Color.DimGray;
            this.txtTicketsAvailable.isPassword = false;
            this.txtTicketsAvailable.Location = new System.Drawing.Point(161, 350);
            this.txtTicketsAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.txtTicketsAvailable.Name = "txtTicketsAvailable";
            this.txtTicketsAvailable.Size = new System.Drawing.Size(59, 26);
            this.txtTicketsAvailable.TabIndex = 178;
            this.txtTicketsAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTicketsAvailable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicketsAvailable_KeyPress);
            // 
            // txtTime
            // 
            this.txtTime.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtTime.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTime.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtTime.BorderThickness = 1;
            this.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.DimGray;
            this.txtTime.isPassword = false;
            this.txtTime.Location = new System.Drawing.Point(161, 316);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(59, 26);
            this.txtTime.TabIndex = 177;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // txtTitle
            // 
            this.txtTitle.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtTitle.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTitle.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtTitle.BorderThickness = 1;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitle.isPassword = false;
            this.txtTitle.Location = new System.Drawing.Point(160, 152);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(202, 26);
            this.txtTitle.TabIndex = 176;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnConfirm.Location = new System.Drawing.Point(229, 424);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 40);
            this.btnConfirm.TabIndex = 174;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(162, 88);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(58, 23);
            this.txtID.TabIndex = 173;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblID.Location = new System.Drawing.Point(20, 95);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 172;
            this.lblID.Text = "ID";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescription.Location = new System.Drawing.Point(19, 196);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(74, 16);
            this.lblDescription.TabIndex = 171;
            this.lblDescription.Text = "Description";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDate.Location = new System.Drawing.Point(23, 273);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 16);
            this.lblDate.TabIndex = 170;
            this.lblDate.Text = "Date";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrice.Location = new System.Drawing.Point(20, 394);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 16);
            this.lblPrice.TabIndex = 169;
            this.lblPrice.Text = "Ticket Price";
            // 
            // lblTicketsAvailable
            // 
            this.lblTicketsAvailable.AutoSize = true;
            this.lblTicketsAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTicketsAvailable.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTicketsAvailable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTicketsAvailable.Location = new System.Drawing.Point(20, 360);
            this.lblTicketsAvailable.Name = "lblTicketsAvailable";
            this.lblTicketsAvailable.Size = new System.Drawing.Size(103, 16);
            this.lblTicketsAvailable.TabIndex = 168;
            this.lblTicketsAvailable.Text = "Tickets Available";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTime.Location = new System.Drawing.Point(20, 326);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 16);
            this.lblTime.TabIndex = 167;
            this.lblTime.Text = "Time (24:00)";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(19, 162);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(67, 16);
            this.lblTitle.TabIndex = 166;
            this.lblTitle.Text = "Event Title";
            // 
            // lblVenueName
            // 
            this.lblVenueName.AutoSize = true;
            this.lblVenueName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVenueName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVenueName.Location = new System.Drawing.Point(19, 128);
            this.lblVenueName.Name = "lblVenueName";
            this.lblVenueName.Size = new System.Drawing.Size(44, 16);
            this.lblVenueName.TabIndex = 165;
            this.lblVenueName.Text = "Venue";
            // 
            // cboVenue
            // 
            this.cboVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.ItemHeight = 13;
            this.cboVenue.Location = new System.Drawing.Point(161, 121);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(201, 21);
            this.cboVenue.TabIndex = 164;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.btnConfirm);
            this.grpBox.Controls.Add(this.lblHeader);
            this.grpBox.Controls.Add(this.bunifuSeparator1);
            this.grpBox.Controls.Add(this.txtTicketsAvailable);
            this.grpBox.Controls.Add(this.lblDate);
            this.grpBox.Controls.Add(this.cboVenue);
            this.grpBox.Controls.Add(this.lblPrice);
            this.grpBox.Controls.Add(this.txtTime);
            this.grpBox.Controls.Add(this.txtDescription);
            this.grpBox.Controls.Add(this.lblDescription);
            this.grpBox.Controls.Add(this.lblVenueName);
            this.grpBox.Controls.Add(this.lblTicketsAvailable);
            this.grpBox.Controls.Add(this.txtTitle);
            this.grpBox.Controls.Add(this.lblEu);
            this.grpBox.Controls.Add(this.txtPrice);
            this.grpBox.Controls.Add(this.lblID);
            this.grpBox.Controls.Add(this.lblTitle);
            this.grpBox.Controls.Add(this.lblTime);
            this.grpBox.Controls.Add(this.txtID);
            this.grpBox.Controls.Add(this.btnReset);
            this.grpBox.Controls.Add(this.dtpDate);
            this.grpBox.Location = new System.Drawing.Point(51, 12);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(405, 479);
            this.grpBox.TabIndex = 185;
            this.grpBox.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.ActiveBorderThickness = 1;
            this.btnReset.ActiveCornerRadius = 20;
            this.btnReset.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.btnReset.ActiveForecolor = System.Drawing.Color.DimGray;
            this.btnReset.ActiveLineColor = System.Drawing.Color.DimGray;
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
            this.btnReset.Location = new System.Drawing.Point(161, 424);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 40);
            this.btnReset.TabIndex = 175;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::EventSYS.Properties.Resources.home__2_;
            this.btnBack.Location = new System.Drawing.Point(14, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 34);
            this.btnBack.TabIndex = 186;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EventSYS.Properties.Resources.icon__1___1_;
            this.btnExit.Location = new System.Drawing.Point(1064, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 187;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSelect.Location = new System.Drawing.Point(473, 46);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(205, 21);
            this.lblSelect.TabIndex = 188;
            this.lblSelect.Text = "Please click event to update!";
            // 
            // grdUpdateEvent
            // 
            this.grdUpdateEvent.AllowUserToAddRows = false;
            this.grdUpdateEvent.AllowUserToDeleteRows = false;
            this.grdUpdateEvent.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUpdateEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdUpdateEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUpdateEvent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdUpdateEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdUpdateEvent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdUpdateEvent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUpdateEvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdUpdateEvent.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdUpdateEvent.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdUpdateEvent.DoubleBuffered = true;
            this.grdUpdateEvent.EnableHeadersVisualStyles = false;
            this.grdUpdateEvent.GridColor = System.Drawing.SystemColors.Control;
            this.grdUpdateEvent.HeaderBgColor = System.Drawing.Color.DimGray;
            this.grdUpdateEvent.HeaderForeColor = System.Drawing.Color.White;
            this.grdUpdateEvent.Location = new System.Drawing.Point(462, 86);
            this.grdUpdateEvent.Name = "grdUpdateEvent";
            this.grdUpdateEvent.ReadOnly = true;
            this.grdUpdateEvent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUpdateEvent.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdUpdateEvent.RowHeadersVisible = false;
            this.grdUpdateEvent.RowTemplate.DividerHeight = 1;
            this.grdUpdateEvent.RowTemplate.Height = 30;
            this.grdUpdateEvent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdUpdateEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUpdateEvent.Size = new System.Drawing.Size(607, 359);
            this.grdUpdateEvent.TabIndex = 190;
            this.grdUpdateEvent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUpdateEvent_CellClick_1);
            // 
            // frmEventUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 503);
            this.Controls.Add(this.grdUpdateEvent);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEventUpdate";
            this.Text = "frmEventUpdate";
            this.Load += new System.EventHandler(this.frmEventUpdate_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEventUpdate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmEventUpdate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmEventUpdate_MouseUp);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private System.Windows.Forms.Label lblEu;
        private Bunifu.Framework.UI.BunifuDatepicker dtpDate;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDescription;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTicketsAvailable;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTime;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTicketsAvailable;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVenueName;
        private System.Windows.Forms.ComboBox cboVenue;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSelect;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReset;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grdUpdateEvent;
    }
}