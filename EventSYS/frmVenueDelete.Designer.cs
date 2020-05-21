namespace EventSYS
{
    partial class frmVenueDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenueDelete));
            this.cboVenues = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.txtManagerMobile = new System.Windows.Forms.TextBox();
            this.txtManagerEmail = new System.Windows.Forms.TextBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.txtMaxCapacity = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.lblManagerEmail = new System.Windows.Forms.Label();
            this.lblManagerMobile = new System.Windows.Forms.Label();
            this.lblMaxCapacity = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboVenues
            // 
            this.cboVenues.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboVenues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVenues.FormattingEnabled = true;
            this.cboVenues.Location = new System.Drawing.Point(149, 68);
            this.cboVenues.Name = "cboVenues";
            this.cboVenues.Size = new System.Drawing.Size(260, 21);
            this.cboVenues.TabIndex = 29;
            this.cboVenues.SelectedIndexChanged += new System.EventHandler(this.cboVenues_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::EventSYS.Properties.Resources.home__2_;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 34);
            this.btnBack.TabIndex = 115;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EventSYS.Properties.Resources.icon__1___1_1;
            this.btnExit.Location = new System.Drawing.Point(434, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 116;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBox
            // 
            this.grpBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBox.Controls.Add(this.txtManagerMobile);
            this.grpBox.Controls.Add(this.txtManagerEmail);
            this.grpBox.Controls.Add(this.txtManagerName);
            this.grpBox.Controls.Add(this.txtMaxCapacity);
            this.grpBox.Controls.Add(this.txtCounty);
            this.grpBox.Controls.Add(this.txtTown);
            this.grpBox.Controls.Add(this.txtStreet);
            this.grpBox.Controls.Add(this.txtName);
            this.grpBox.Controls.Add(this.btnConfirm);
            this.grpBox.Controls.Add(this.lblName);
            this.grpBox.Controls.Add(this.lblStreet);
            this.grpBox.Controls.Add(this.lblManagerName);
            this.grpBox.Controls.Add(this.lblManagerEmail);
            this.grpBox.Controls.Add(this.lblManagerMobile);
            this.grpBox.Controls.Add(this.lblMaxCapacity);
            this.grpBox.Controls.Add(this.lblTown);
            this.grpBox.Controls.Add(this.lblCounty);
            this.grpBox.Controls.Add(this.bunifuSeparator1);
            this.grpBox.Controls.Add(this.lblID);
            this.grpBox.Controls.Add(this.txtID);
            this.grpBox.Controls.Add(this.lblHeader);
            this.grpBox.ForeColor = System.Drawing.SystemColors.Control;
            this.grpBox.Location = new System.Drawing.Point(33, 114);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(397, 482);
            this.grpBox.TabIndex = 163;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Details";
            // 
            // txtManagerMobile
            // 
            this.txtManagerMobile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtManagerMobile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerMobile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtManagerMobile.Location = new System.Drawing.Point(168, 379);
            this.txtManagerMobile.Name = "txtManagerMobile";
            this.txtManagerMobile.ReadOnly = true;
            this.txtManagerMobile.Size = new System.Drawing.Size(200, 23);
            this.txtManagerMobile.TabIndex = 169;
            // 
            // txtManagerEmail
            // 
            this.txtManagerEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtManagerEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtManagerEmail.Location = new System.Drawing.Point(168, 345);
            this.txtManagerEmail.Name = "txtManagerEmail";
            this.txtManagerEmail.ReadOnly = true;
            this.txtManagerEmail.Size = new System.Drawing.Size(200, 23);
            this.txtManagerEmail.TabIndex = 168;
            // 
            // txtManagerName
            // 
            this.txtManagerName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtManagerName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtManagerName.Location = new System.Drawing.Point(168, 315);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.ReadOnly = true;
            this.txtManagerName.Size = new System.Drawing.Size(200, 23);
            this.txtManagerName.TabIndex = 167;
            // 
            // txtMaxCapacity
            // 
            this.txtMaxCapacity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaxCapacity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxCapacity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMaxCapacity.Location = new System.Drawing.Point(168, 252);
            this.txtMaxCapacity.Name = "txtMaxCapacity";
            this.txtMaxCapacity.ReadOnly = true;
            this.txtMaxCapacity.Size = new System.Drawing.Size(58, 23);
            this.txtMaxCapacity.TabIndex = 166;
            // 
            // txtCounty
            // 
            this.txtCounty.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCounty.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCounty.Location = new System.Drawing.Point(168, 215);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.ReadOnly = true;
            this.txtCounty.Size = new System.Drawing.Size(200, 23);
            this.txtCounty.TabIndex = 165;
            // 
            // txtTown
            // 
            this.txtTown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTown.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTown.Location = new System.Drawing.Point(168, 185);
            this.txtTown.Name = "txtTown";
            this.txtTown.ReadOnly = true;
            this.txtTown.Size = new System.Drawing.Size(200, 23);
            this.txtTown.TabIndex = 164;
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtStreet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtStreet.Location = new System.Drawing.Point(168, 147);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(200, 23);
            this.txtStreet.TabIndex = 163;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtName.Location = new System.Drawing.Point(168, 113);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 162;
            // 
            // btnConfirm
            // 
            this.btnConfirm.ActiveBorderThickness = 1;
            this.btnConfirm.ActiveCornerRadius = 20;
            this.btnConfirm.ActiveFillColor = System.Drawing.Color.IndianRed;
            this.btnConfirm.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btnConfirm.ActiveLineColor = System.Drawing.Color.IndianRed;
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.ButtonText = "Cancel";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.IdleBorderThickness = 1;
            this.btnConfirm.IdleCornerRadius = 20;
            this.btnConfirm.IdleFillColor = System.Drawing.Color.Firebrick;
            this.btnConfirm.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnConfirm.IdleLineColor = System.Drawing.Color.Empty;
            this.btnConfirm.Location = new System.Drawing.Point(235, 417);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 40);
            this.btnConfirm.TabIndex = 151;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtID.Location = new System.Drawing.Point(168, 81);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(54, 23);
            this.txtID.TabIndex = 149;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeader.Location = new System.Drawing.Point(25, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(126, 23);
            this.lblHeader.TabIndex = 150;
            this.lblHeader.Text = "Venue Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(57, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 170;
            this.label1.Text = "Select Venue";
            // 
            // frmVenueDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(480, 598);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboVenues);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenueDelete";
            this.Text = "frmVenueDelete";
            this.Load += new System.EventHandler(this.frmVenueDelete_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmVenueDelete_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmVenueDelete_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmVenueDelete_MouseUp);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboVenues;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBox;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblManagerName;
        private System.Windows.Forms.Label lblManagerEmail;
        private System.Windows.Forms.Label lblManagerMobile;
        private System.Windows.Forms.Label lblMaxCapacity;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCounty;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private System.Windows.Forms.TextBox txtManagerMobile;
        private System.Windows.Forms.TextBox txtManagerEmail;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.TextBox txtMaxCapacity;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}