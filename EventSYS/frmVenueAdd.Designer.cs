using System;
using System.Windows.Forms;

namespace EventSYS
{
    partial class frmVenueAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenueAdd));
            this.grdAddVenue = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnReset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTown = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCounty = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtManagerEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtManagerName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMaxCapacity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStreet = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblMaxCapacity = new System.Windows.Forms.Label();
            this.lblManagerMobile = new System.Windows.Forms.Label();
            this.lblManagerEmail = new System.Windows.Forms.Label();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtManagerMobile = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddVenue)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAddVenue
            // 
            this.grdAddVenue.AllowUserToAddRows = false;
            this.grdAddVenue.AllowUserToDeleteRows = false;
            this.grdAddVenue.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdAddVenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAddVenue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdAddVenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAddVenue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAddVenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAddVenue.ColumnHeadersHeight = 20;
            this.grdAddVenue.DoubleBuffered = true;
            this.grdAddVenue.EnableHeadersVisualStyles = false;
            this.grdAddVenue.GridColor = System.Drawing.SystemColors.Control;
            this.grdAddVenue.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.grdAddVenue.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdAddVenue.Location = new System.Drawing.Point(458, 66);
            this.grdAddVenue.Name = "grdAddVenue";
            this.grdAddVenue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdAddVenue.Size = new System.Drawing.Size(601, 356);
            this.grdAddVenue.TabIndex = 33;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeader.Location = new System.Drawing.Point(70, 44);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(103, 23);
            this.lblHeader.TabIndex = 115;
            this.lblHeader.Text = "Add Venue";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(72, 66);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(341, 10);
            this.bunifuSeparator1.TabIndex = 130;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
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
            this.btnReset.Location = new System.Drawing.Point(212, 436);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 40);
            this.btnReset.TabIndex = 123;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnConfirm.ButtonText = "Confirm";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.IdleBorderThickness = 1;
            this.btnConfirm.IdleCornerRadius = 20;
            this.btnConfirm.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnConfirm.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.Location = new System.Drawing.Point(280, 436);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 40);
            this.btnConfirm.TabIndex = 122;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::EventSYS.Properties.Resources.home__2_;
            this.btnBack.Location = new System.Drawing.Point(14, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 34);
            this.btnBack.TabIndex = 7;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EventSYS.Properties.Resources.icon__1___1_1;
            this.btnExit.Location = new System.Drawing.Point(1064, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 8;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
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
            this.txtTown.Location = new System.Drawing.Point(211, 198);
            this.txtTown.Margin = new System.Windows.Forms.Padding(4);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(202, 26);
            this.txtTown.TabIndex = 138;
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
            this.txtCounty.Location = new System.Drawing.Point(211, 232);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(202, 26);
            this.txtCounty.TabIndex = 137;
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
            this.txtManagerEmail.Location = new System.Drawing.Point(212, 362);
            this.txtManagerEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerEmail.Name = "txtManagerEmail";
            this.txtManagerEmail.Size = new System.Drawing.Size(202, 26);
            this.txtManagerEmail.TabIndex = 136;
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
            this.txtManagerName.Location = new System.Drawing.Point(212, 328);
            this.txtManagerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(202, 26);
            this.txtManagerName.TabIndex = 135;
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
            this.txtMaxCapacity.Location = new System.Drawing.Point(211, 266);
            this.txtMaxCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxCapacity.Name = "txtMaxCapacity";
            this.txtMaxCapacity.Size = new System.Drawing.Size(56, 26);
            this.txtMaxCapacity.TabIndex = 134;
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
            this.txtStreet.Location = new System.Drawing.Point(211, 164);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(202, 26);
            this.txtStreet.TabIndex = 133;
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
            this.txtName.Location = new System.Drawing.Point(212, 130);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 26);
            this.txtName.TabIndex = 132;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(213, 100);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(54, 23);
            this.txtID.TabIndex = 31;
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
            this.lblID.TabIndex = 30;
            this.lblID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(70, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "County";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTown.Location = new System.Drawing.Point(70, 208);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(39, 16);
            this.lblTown.TabIndex = 26;
            this.lblTown.Text = "Town";
            // 
            // lblMaxCapacity
            // 
            this.lblMaxCapacity.AutoSize = true;
            this.lblMaxCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaxCapacity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblMaxCapacity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMaxCapacity.Location = new System.Drawing.Point(70, 276);
            this.lblMaxCapacity.Name = "lblMaxCapacity";
            this.lblMaxCapacity.Size = new System.Drawing.Size(86, 16);
            this.lblMaxCapacity.TabIndex = 23;
            this.lblMaxCapacity.Text = "Max Capacity";
            // 
            // lblManagerMobile
            // 
            this.lblManagerMobile.AutoSize = true;
            this.lblManagerMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblManagerMobile.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblManagerMobile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblManagerMobile.Location = new System.Drawing.Point(71, 406);
            this.lblManagerMobile.Name = "lblManagerMobile";
            this.lblManagerMobile.Size = new System.Drawing.Size(106, 16);
            this.lblManagerMobile.TabIndex = 21;
            this.lblManagerMobile.Text = "Manager Mobile";
            // 
            // lblManagerEmail
            // 
            this.lblManagerEmail.AutoSize = true;
            this.lblManagerEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblManagerEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblManagerEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblManagerEmail.Location = new System.Drawing.Point(71, 372);
            this.lblManagerEmail.Name = "lblManagerEmail";
            this.lblManagerEmail.Size = new System.Drawing.Size(96, 16);
            this.lblManagerEmail.TabIndex = 19;
            this.lblManagerEmail.Text = "Manager Email";
            // 
            // lblManagerName
            // 
            this.lblManagerName.AutoSize = true;
            this.lblManagerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblManagerName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblManagerName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblManagerName.Location = new System.Drawing.Point(71, 338);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(100, 16);
            this.lblManagerName.TabIndex = 17;
            this.lblManagerName.Text = "Manager Name";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblStreet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStreet.Location = new System.Drawing.Point(70, 174);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 16);
            this.lblStreet.TabIndex = 15;
            this.lblStreet.Text = "Street";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.Location = new System.Drawing.Point(70, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 16);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
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
            this.txtManagerMobile.Location = new System.Drawing.Point(212, 396);
            this.txtManagerMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtManagerMobile.Name = "txtManagerMobile";
            this.txtManagerMobile.Size = new System.Drawing.Size(202, 26);
            this.txtManagerMobile.TabIndex = 139;
            this.txtManagerMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtManagerMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManagerMobile_KeyPress);
            // 
            // frmVenueAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1110, 503);
            this.Controls.Add(this.txtManagerMobile);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.txtManagerEmail);
            this.Controls.Add(this.txtManagerName);
            this.Controls.Add(this.txtMaxCapacity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grdAddVenue);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblMaxCapacity);
            this.Controls.Add(this.lblManagerMobile);
            this.Controls.Add(this.lblManagerEmail);
            this.Controls.Add(this.lblManagerName);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenueAdd";
            this.Text = "EventSYS - Add Venue";
            this.Load += new System.EventHandler(this.frmVenueAdd_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmVenueAdd_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmVenueAdd_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmVenueAdd_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.grdAddVenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmVenueAdd_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnBack;
        private Button btnExit;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grdAddVenue;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReset;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTown;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCounty;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtManagerEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtManagerName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMaxCapacity;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStreet;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private TextBox txtID;
        private Label lblID;
        private Label label2;
        private Label lblTown;
        private Label lblMaxCapacity;
        private Label lblManagerMobile;
        private Label lblManagerEmail;
        private Label lblManagerName;
        private Label lblStreet;
        private Label lblName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtManagerMobile;
    }
}