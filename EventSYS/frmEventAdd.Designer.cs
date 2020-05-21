namespace EventSYS
{
    partial class frmEventAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTicketsAvailable = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTime = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTitle = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnReset = new Bunifu.Framework.UI.BunifuThinButton2();
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
            this.dtpDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblEu = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grdAddEvent = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // cboVenue
            // 
            this.cboVenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.ItemHeight = 13;
            this.cboVenue.Location = new System.Drawing.Point(212, 133);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(201, 21);
            this.cboVenue.TabIndex = 59;
            this.cboVenue.SelectedIndexChanged += new System.EventHandler(this.cboVenue_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPrice.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtPrice.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtPrice.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtPrice.BorderThickness = 1;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrice.isPassword = false;
            this.txtPrice.Location = new System.Drawing.Point(212, 396);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(59, 26);
            this.txtPrice.TabIndex = 157;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.AutoScroll = true;
            this.txtDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDescription.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtDescription.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtDescription.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtDescription.BorderThickness = 1;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescription.isPassword = false;
            this.txtDescription.Location = new System.Drawing.Point(211, 198);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(202, 64);
            this.txtDescription.TabIndex = 154;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTicketsAvailable
            // 
            this.txtTicketsAvailable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTicketsAvailable.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtTicketsAvailable.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTicketsAvailable.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtTicketsAvailable.BorderThickness = 1;
            this.txtTicketsAvailable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTicketsAvailable.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketsAvailable.ForeColor = System.Drawing.Color.DimGray;
            this.txtTicketsAvailable.isPassword = false;
            this.txtTicketsAvailable.Location = new System.Drawing.Point(212, 362);
            this.txtTicketsAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.txtTicketsAvailable.Name = "txtTicketsAvailable";
            this.txtTicketsAvailable.Size = new System.Drawing.Size(59, 26);
            this.txtTicketsAvailable.TabIndex = 156;
            this.txtTicketsAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTicketsAvailable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicketsAvailable_KeyPress);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTime.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtTime.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTime.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtTime.BorderThickness = 1;
            this.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.DimGray;
            this.txtTime.isPassword = false;
            this.txtTime.Location = new System.Drawing.Point(212, 328);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(59, 26);
            this.txtTime.TabIndex = 155;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTitle.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtTitle.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtTitle.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtTitle.BorderThickness = 1;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitle.isPassword = false;
            this.txtTitle.Location = new System.Drawing.Point(211, 164);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(202, 26);
            this.txtTitle.TabIndex = 153;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnReset
            // 
            this.btnReset.ActiveBorderThickness = 1;
            this.btnReset.ActiveCornerRadius = 20;
            this.btnReset.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.btnReset.ActiveForecolor = System.Drawing.Color.DimGray;
            this.btnReset.ActiveLineColor = System.Drawing.Color.DimGray;
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.ButtonText = "Reset";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnReset.IdleBorderThickness = 1;
            this.btnReset.IdleCornerRadius = 20;
            this.btnReset.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btnReset.IdleForecolor = System.Drawing.Color.DimGray;
            this.btnReset.IdleLineColor = System.Drawing.Color.Empty;
            this.btnReset.Location = new System.Drawing.Point(196, 431);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 40);
            this.btnReset.TabIndex = 151;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnConfirm
            // 
            this.btnConfirm.ActiveBorderThickness = 1;
            this.btnConfirm.ActiveCornerRadius = 20;
            this.btnConfirm.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirm.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btnConfirm.ActiveLineColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.ButtonText = "Confirm";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.IdleBorderThickness = 1;
            this.btnConfirm.IdleCornerRadius = 20;
            this.btnConfirm.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnConfirm.IdleLineColor = System.Drawing.Color.Empty;
            this.btnConfirm.Location = new System.Drawing.Point(280, 436);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 40);
            this.btnConfirm.TabIndex = 150;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(213, 100);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(58, 23);
            this.txtID.TabIndex = 149;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblID.Location = new System.Drawing.Point(71, 107);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 148;
            this.lblID.Text = "ID";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescription.Location = new System.Drawing.Point(70, 208);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(74, 16);
            this.lblDescription.TabIndex = 146;
            this.lblDescription.Text = "Description";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDate.Location = new System.Drawing.Point(74, 285);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 16);
            this.lblDate.TabIndex = 145;
            this.lblDate.Text = "Date";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrice.Location = new System.Drawing.Point(71, 406);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 16);
            this.lblPrice.TabIndex = 144;
            this.lblPrice.Text = "Ticket Price";
            // 
            // lblTicketsAvailable
            // 
            this.lblTicketsAvailable.AutoSize = true;
            this.lblTicketsAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTicketsAvailable.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTicketsAvailable.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTicketsAvailable.Location = new System.Drawing.Point(71, 372);
            this.lblTicketsAvailable.Name = "lblTicketsAvailable";
            this.lblTicketsAvailable.Size = new System.Drawing.Size(103, 16);
            this.lblTicketsAvailable.TabIndex = 143;
            this.lblTicketsAvailable.Text = "Tickets Available";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTime.Location = new System.Drawing.Point(71, 338);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 16);
            this.lblTime.TabIndex = 142;
            this.lblTime.Text = "Time (24:00)";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(70, 174);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(67, 16);
            this.lblTitle.TabIndex = 141;
            this.lblTitle.Text = "Event Title";
            // 
            // lblVenueName
            // 
            this.lblVenueName.AutoSize = true;
            this.lblVenueName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVenueName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVenueName.Location = new System.Drawing.Point(70, 140);
            this.lblVenueName.Name = "lblVenueName";
            this.lblVenueName.Size = new System.Drawing.Size(44, 16);
            this.lblVenueName.TabIndex = 140;
            this.lblVenueName.Text = "Venue";
            // 
            // dtpDate
            // 
            this.dtpDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpDate.BorderRadius = 0;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.dtpDate.ForeColor = System.Drawing.Color.DimGray;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.FormatCustom = null;
            this.dtpDate.Location = new System.Drawing.Point(212, 275);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(232, 40);
            this.dtpDate.TabIndex = 160;
            this.dtpDate.Value = new System.DateTime(2020, 3, 9, 21, 55, 39, 342);
            // 
            // lblEu
            // 
            this.lblEu.AutoSize = true;
            this.lblEu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEu.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblEu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEu.Location = new System.Drawing.Point(278, 406);
            this.lblEu.Name = "lblEu";
            this.lblEu.Size = new System.Drawing.Size(35, 16);
            this.lblEu.TabIndex = 161;
            this.lblEu.Text = "Euro";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(71, 66);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(341, 10);
            this.bunifuSeparator1.TabIndex = 163;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeader.Location = new System.Drawing.Point(69, 44);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(116, 23);
            this.lblHeader.TabIndex = 162;
            this.lblHeader.Text = "Create Event";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::EventSYS.Properties.Resources.home__2_;
            this.btnBack.Location = new System.Drawing.Point(14, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 34);
            this.btnBack.TabIndex = 164;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EventSYS.Properties.Resources.icon__1___1_1;
            this.btnExit.Location = new System.Drawing.Point(1064, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 165;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grdAddEvent
            // 
            this.grdAddEvent.AllowUserToAddRows = false;
            this.grdAddEvent.AllowUserToDeleteRows = false;
            this.grdAddEvent.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAddEvent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAddEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAddEvent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdAddEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAddEvent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdAddEvent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAddEvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAddEvent.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAddEvent.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdAddEvent.DoubleBuffered = true;
            this.grdAddEvent.EnableHeadersVisualStyles = false;
            this.grdAddEvent.GridColor = System.Drawing.SystemColors.Control;
            this.grdAddEvent.HeaderBgColor = System.Drawing.Color.DimGray;
            this.grdAddEvent.HeaderForeColor = System.Drawing.Color.White;
            this.grdAddEvent.Location = new System.Drawing.Point(450, 66);
            this.grdAddEvent.Name = "grdAddEvent";
            this.grdAddEvent.ReadOnly = true;
            this.grdAddEvent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAddEvent.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAddEvent.RowHeadersVisible = false;
            this.grdAddEvent.RowTemplate.DividerHeight = 1;
            this.grdAddEvent.RowTemplate.Height = 30;
            this.grdAddEvent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAddEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAddEvent.Size = new System.Drawing.Size(607, 359);
            this.grdAddEvent.TabIndex = 167;
            // 
            // frmEventAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1110, 503);
            this.Controls.Add(this.grdAddEvent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblEu);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTicketsAvailable);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTicketsAvailable);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVenueName);
            this.Controls.Add(this.cboVenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEventAdd";
            this.Text = "EventSYS - Add Event";
            this.Load += new System.EventHandler(this.frmEventAdd_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEventAdd_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmEventAdd_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmEventAdd_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.grdAddEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboVenue;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDescription;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTicketsAvailable;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTime;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReset;
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
        private Bunifu.Framework.UI.BunifuDatepicker dtpDate;
        private System.Windows.Forms.Label lblEu;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grdAddEvent;
    }
}