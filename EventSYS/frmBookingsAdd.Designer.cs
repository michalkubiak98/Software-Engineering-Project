namespace EventSYS
{
    partial class frmBookingsAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingsAdd));
            this.cboTickets = new System.Windows.Forms.ComboBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.grdEvents = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTickets = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEventID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.lblEu = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTickets
            // 
            this.cboTickets.FormattingEnabled = true;
            this.cboTickets.Location = new System.Drawing.Point(212, 203);
            this.cboTickets.Name = "cboTickets";
            this.cboTickets.Size = new System.Drawing.Size(53, 21);
            this.cboTickets.TabIndex = 2;
            this.cboTickets.SelectedIndexChanged += new System.EventHandler(this.cboTickets_SelectedIndexChanged);
            // 
            // txtVenue
            // 
            this.txtVenue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenue.Location = new System.Drawing.Point(213, 288);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.ReadOnly = true;
            this.txtVenue.Size = new System.Drawing.Size(201, 23);
            this.txtVenue.TabIndex = 83;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(213, 317);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(201, 23);
            this.txtDate.TabIndex = 85;
            // 
            // txtEvent
            // 
            this.txtEvent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvent.Location = new System.Drawing.Point(213, 259);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.ReadOnly = true;
            this.txtEvent.Size = new System.Drawing.Size(201, 23);
            this.txtEvent.TabIndex = 87;
            // 
            // grdEvents
            // 
            this.grdEvents.AllowUserToAddRows = false;
            this.grdEvents.AllowUserToDeleteRows = false;
            this.grdEvents.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEvents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdEvents.ColumnHeadersHeight = 20;
            this.grdEvents.DoubleBuffered = true;
            this.grdEvents.EnableHeadersVisualStyles = false;
            this.grdEvents.GridColor = System.Drawing.SystemColors.Control;
            this.grdEvents.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.grdEvents.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdEvents.Location = new System.Drawing.Point(454, 66);
            this.grdEvents.Name = "grdEvents";
            this.grdEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdEvents.Size = new System.Drawing.Size(615, 332);
            this.grdEvents.TabIndex = 88;
            this.grdEvents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEvents_CellClick);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(70, 66);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(341, 10);
            this.bunifuSeparator1.TabIndex = 183;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeader.Location = new System.Drawing.Point(68, 44);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(145, 23);
            this.lblHeader.TabIndex = 182;
            this.lblHeader.Text = "Make a Booking";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtEmail.BorderThickness = 1;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(212, 163);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 26);
            this.txtEmail.TabIndex = 175;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnConfirm.Location = new System.Drawing.Point(281, 424);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 40);
            this.btnConfirm.TabIndex = 173;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(212, 100);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(58, 23);
            this.txtID.TabIndex = 172;
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTickets.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTickets.Location = new System.Drawing.Point(69, 208);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(88, 16);
            this.lblTickets.TabIndex = 171;
            this.lblTickets.Text = "No. of Tickets";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotal.Location = new System.Drawing.Point(70, 382);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 16);
            this.lblTotal.TabIndex = 169;
            this.lblTotal.Text = "Total";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(69, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 16);
            this.lblEmail.TabIndex = 166;
            this.lblEmail.Text = "Your Email";
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEventID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEventID.Location = new System.Drawing.Point(69, 140);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(55, 16);
            this.lblEventID.TabIndex = 165;
            this.lblEventID.Text = "Event ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(70, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 184;
            this.label2.Text = "ID";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblID.Location = new System.Drawing.Point(70, 107);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 186;
            this.lblID.Text = "ID";
            // 
            // txtEventID
            // 
            this.txtEventID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventID.Location = new System.Drawing.Point(212, 133);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.ReadOnly = true;
            this.txtEventID.Size = new System.Drawing.Size(58, 23);
            this.txtEventID.TabIndex = 187;
            // 
            // lblEu
            // 
            this.lblEu.AutoSize = true;
            this.lblEu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEu.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblEu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEu.Location = new System.Drawing.Point(278, 382);
            this.lblEu.Name = "lblEu";
            this.lblEu.Size = new System.Drawing.Size(35, 16);
            this.lblEu.TabIndex = 181;
            this.lblEu.Text = "Euro";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDate.Location = new System.Drawing.Point(69, 321);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 16);
            this.lblDate.TabIndex = 188;
            this.lblDate.Text = "Date";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblVenue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVenue.Location = new System.Drawing.Point(69, 292);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(44, 16);
            this.lblVenue.TabIndex = 189;
            this.lblVenue.Text = "Venue";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEvent.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblEvent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEvent.Location = new System.Drawing.Point(69, 263);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(45, 16);
            this.lblEvent.TabIndex = 190;
            this.lblEvent.Text = "Events";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(212, 378);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(58, 23);
            this.txtTotal.TabIndex = 191;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::EventSYS.Properties.Resources.home__2_;
            this.btnBack.Location = new System.Drawing.Point(14, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 34);
            this.btnBack.TabIndex = 192;
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
            this.btnExit.TabIndex = 193;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBookingsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 503);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblEu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEventID);
            this.Controls.Add(this.grdEvents);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.cboTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookingsAdd";
            this.Text = "frmBookingsAdd";
            this.Load += new System.EventHandler(this.frmBookingsAdd_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBookingsAdd_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBookingsAdd_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmBookingsAdd_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.grdEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboTickets;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtEvent;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grdEvents;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Label lblEu;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
    }
}