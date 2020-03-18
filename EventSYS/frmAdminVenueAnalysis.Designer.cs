namespace EventSYS
{
    partial class frmAdminVenueAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminVenueAnalysis));
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.txtNoTicketsSold = new System.Windows.Forms.TextBox();
            this.txtNoEvents = new System.Windows.Forms.TextBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboVenue = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEvents = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblSold = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(402, 383);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.ReadOnly = true;
            this.txtRevenue.Size = new System.Drawing.Size(121, 20);
            this.txtRevenue.TabIndex = 118;
            // 
            // txtNoTicketsSold
            // 
            this.txtNoTicketsSold.Location = new System.Drawing.Point(402, 347);
            this.txtNoTicketsSold.Name = "txtNoTicketsSold";
            this.txtNoTicketsSold.ReadOnly = true;
            this.txtNoTicketsSold.Size = new System.Drawing.Size(121, 20);
            this.txtNoTicketsSold.TabIndex = 117;
            // 
            // txtNoEvents
            // 
            this.txtNoEvents.Location = new System.Drawing.Point(402, 312);
            this.txtNoEvents.Name = "txtNoEvents";
            this.txtNoEvents.ReadOnly = true;
            this.txtNoEvents.Size = new System.Drawing.Size(121, 20);
            this.txtNoEvents.TabIndex = 116;
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "01 Jan",
            "02 Feb",
            "03 Mar",
            "04 Apr",
            "05 May",
            "06 Jun",
            "07 Jul",
            "08 Aug",
            "09 Sep",
            "10 Oct",
            "11 Nov",
            "12 Dec"});
            this.cboMonth.Location = new System.Drawing.Point(402, 190);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(121, 21);
            this.cboMonth.TabIndex = 114;
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(402, 152);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 21);
            this.cboYear.TabIndex = 112;
            // 
            // cboVenue
            // 
            this.cboVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVenue.FormattingEnabled = true;
            this.cboVenue.Location = new System.Drawing.Point(292, 116);
            this.cboVenue.Name = "cboVenue";
            this.cboVenue.Size = new System.Drawing.Size(231, 21);
            this.cboVenue.TabIndex = 110;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblID.Location = new System.Drawing.Point(64, 119);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(203, 16);
            this.lblID.TabIndex = 187;
            this.lblID.Text = "Please choose a venue to analyse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(64, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 188;
            this.label1.Text = "Year of analysis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(64, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 189;
            this.label2.Text = "Month of analysis";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(66, 73);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(457, 11);
            this.bunifuSeparator1.TabIndex = 191;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeader.Location = new System.Drawing.Point(64, 52);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(137, 23);
            this.lblHeader.TabIndex = 190;
            this.lblHeader.Text = "Venue Analysis";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblEvents.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEvents.Location = new System.Drawing.Point(65, 316);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(86, 16);
            this.lblEvents.TabIndex = 192;
            this.lblEvents.Text = "No. of Events";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(67, 284);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(456, 11);
            this.bunifuSeparator2.TabIndex = 193;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSold.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblSold.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSold.Location = new System.Drawing.Point(65, 350);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(77, 16);
            this.lblSold.TabIndex = 194;
            this.lblSold.Text = "Tickets Sold";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblRevenue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRevenue.Location = new System.Drawing.Point(66, 383);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(98, 16);
            this.lblRevenue.TabIndex = 195;
            this.lblRevenue.Text = "Totoal Revenue";
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
            this.btnConfirm.Location = new System.Drawing.Point(402, 236);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(121, 40);
            this.btnConfirm.TabIndex = 196;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::EventSYS.Properties.Resources.home__2_;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 34);
            this.btnBack.TabIndex = 197;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EventSYS.Properties.Resources.icon__1___1_1;
            this.btnExit.Location = new System.Drawing.Point(540, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 198;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // frmAdminVenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 445);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.lblSold);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.txtNoTicketsSold);
            this.Controls.Add(this.txtNoEvents);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboVenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminVenueAnalysis";
            this.Text = "frmAdminVenueAnalysis";
            this.Load += new System.EventHandler(this.frmAdminVenueAnalysis_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAdminVenueAnalysis_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAdminVenueAnalysis_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmAdminVenueAnalysis_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.TextBox txtNoTicketsSold;
        private System.Windows.Forms.TextBox txtNoEvents;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboVenue;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private System.Windows.Forms.Label lblEvents;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.Label lblRevenue;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}