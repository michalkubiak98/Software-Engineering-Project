namespace EventSYS
{
    partial class frmEventDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventDelete));
            this.lblEventSelect = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboEvents = new System.Windows.Forms.ComboBox();
            this.lblEu = new System.Windows.Forms.Label();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEventSelect
            // 
            this.lblEventSelect.AutoSize = true;
            this.lblEventSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEventSelect.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblEventSelect.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEventSelect.Location = new System.Drawing.Point(57, 70);
            this.lblEventSelect.Name = "lblEventSelect";
            this.lblEventSelect.Size = new System.Drawing.Size(77, 16);
            this.lblEventSelect.TabIndex = 175;
            this.lblEventSelect.Text = "Select Event";
            // 
            // grpBox
            // 
            this.grpBox.BackColor = System.Drawing.SystemColors.Control;
            this.grpBox.Controls.Add(this.lblEu);
            this.grpBox.Controls.Add(this.txtPrice);
            this.grpBox.Controls.Add(this.txtTickets);
            this.grpBox.Controls.Add(this.txtTime);
            this.grpBox.Controls.Add(this.txtDate);
            this.grpBox.Controls.Add(this.txtDescription);
            this.grpBox.Controls.Add(this.txtTitle);
            this.grpBox.Controls.Add(this.txtVenue);
            this.grpBox.Controls.Add(this.btnConfirm);
            this.grpBox.Controls.Add(this.lblVenue);
            this.grpBox.Controls.Add(this.lblTitle);
            this.grpBox.Controls.Add(this.lblTickets);
            this.grpBox.Controls.Add(this.lblPrice);
            this.grpBox.Controls.Add(this.lblTime);
            this.grpBox.Controls.Add(this.lblDescription);
            this.grpBox.Controls.Add(this.lblDate);
            this.grpBox.Controls.Add(this.bunifuSeparator1);
            this.grpBox.Controls.Add(this.lblID);
            this.grpBox.Controls.Add(this.txtID);
            this.grpBox.Controls.Add(this.lblHeader);
            this.grpBox.ForeColor = System.Drawing.SystemColors.Control;
            this.grpBox.Location = new System.Drawing.Point(33, 114);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(397, 482);
            this.grpBox.TabIndex = 174;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Details";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPrice.Location = new System.Drawing.Point(168, 327);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(54, 23);
            this.txtPrice.TabIndex = 168;
            // 
            // txtTickets
            // 
            this.txtTickets.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTickets.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTickets.Location = new System.Drawing.Point(168, 291);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.ReadOnly = true;
            this.txtTickets.Size = new System.Drawing.Size(54, 23);
            this.txtTickets.TabIndex = 167;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTime.Location = new System.Drawing.Point(168, 254);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(54, 23);
            this.txtTime.TabIndex = 166;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDate.Location = new System.Drawing.Point(168, 216);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(200, 23);
            this.txtDate.TabIndex = 165;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescription.Location = new System.Drawing.Point(168, 185);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(200, 23);
            this.txtDescription.TabIndex = 164;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTitle.Location = new System.Drawing.Point(168, 147);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(200, 23);
            this.txtTitle.TabIndex = 163;
            // 
            // txtVenue
            // 
            this.txtVenue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtVenue.Location = new System.Drawing.Point(168, 113);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.ReadOnly = true;
            this.txtVenue.Size = new System.Drawing.Size(200, 23);
            this.txtVenue.TabIndex = 162;
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
            this.btnConfirm.ButtonText = "Delete";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.IdleBorderThickness = 1;
            this.btnConfirm.IdleCornerRadius = 20;
            this.btnConfirm.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnConfirm.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.Location = new System.Drawing.Point(234, 363);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 40);
            this.btnConfirm.TabIndex = 151;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVenue.Location = new System.Drawing.Point(25, 121);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(44, 16);
            this.lblVenue.TabIndex = 140;
            this.lblVenue.Text = "Venue";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(25, 155);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 16);
            this.lblTitle.TabIndex = 141;
            this.lblTitle.Text = "Title";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTickets.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTickets.Location = new System.Drawing.Point(26, 295);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(72, 16);
            this.lblTickets.TabIndex = 142;
            this.lblTickets.Text = "Tickets Left";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrice.Location = new System.Drawing.Point(26, 335);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 16);
            this.lblPrice.TabIndex = 143;
            this.lblPrice.Text = "Ticket Price";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTime.Location = new System.Drawing.Point(25, 259);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 16);
            this.lblTime.TabIndex = 145;
            this.lblTime.Text = "Time";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescription.Location = new System.Drawing.Point(25, 189);
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
            this.lblDate.Location = new System.Drawing.Point(25, 224);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 16);
            this.lblDate.TabIndex = 147;
            this.lblDate.Text = "Date";
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
            this.lblHeader.Size = new System.Drawing.Size(118, 23);
            this.lblHeader.TabIndex = 150;
            this.lblHeader.Text = "Event Details";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::EventSYS.Properties.Resources.home__2_;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 34);
            this.btnBack.TabIndex = 172;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EventSYS.Properties.Resources.icon__1___1_1;
            this.btnExit.Location = new System.Drawing.Point(434, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 173;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // cboEvents
            // 
            this.cboEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvents.FormattingEnabled = true;
            this.cboEvents.Location = new System.Drawing.Point(149, 68);
            this.cboEvents.Name = "cboEvents";
            this.cboEvents.Size = new System.Drawing.Size(260, 21);
            this.cboEvents.TabIndex = 171;
            this.cboEvents.SelectedIndexChanged += new System.EventHandler(this.cboEvents_SelectedIndexChanged_1);
            // 
            // lblEu
            // 
            this.lblEu.AutoSize = true;
            this.lblEu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEu.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblEu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEu.Location = new System.Drawing.Point(233, 335);
            this.lblEu.Name = "lblEu";
            this.lblEu.Size = new System.Drawing.Size(35, 16);
            this.lblEu.TabIndex = 183;
            this.lblEu.Text = "Euro";
            // 
            // frmEventDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 535);
            this.Controls.Add(this.lblEventSelect);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEventDelete";
            this.Text = "frmEventDelete";
            this.Load += new System.EventHandler(this.frmEventDelete_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEventDelete_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmEventDelete_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmEventDelete_MouseUp);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEventSelect;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtVenue;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDate;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboEvents;
        private System.Windows.Forms.Label lblEu;
    }
}