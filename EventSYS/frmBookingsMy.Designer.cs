namespace EventSYS
{
    partial class frmBookingsMy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingsMy));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.grdBooking = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleFull = new System.Windows.Forms.Label();
            this.lblDateFull = new System.Windows.Forms.Label();
            this.lblIDFull = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(59, 71);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(341, 10);
            this.bunifuSeparator1.TabIndex = 205;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHeader.Location = new System.Drawing.Point(57, 49);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(118, 23);
            this.lblHeader.TabIndex = 204;
            this.lblHeader.Text = "My Bookings";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(59, 404);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(341, 10);
            this.bunifuSeparator3.TabIndex = 209;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // grdBooking
            // 
            this.grdBooking.AllowUserToAddRows = false;
            this.grdBooking.AllowUserToDeleteRows = false;
            this.grdBooking.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdBooking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdBooking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdBooking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdBooking.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBooking.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdBooking.DoubleBuffered = true;
            this.grdBooking.EnableHeadersVisualStyles = false;
            this.grdBooking.GridColor = System.Drawing.SystemColors.Control;
            this.grdBooking.HeaderBgColor = System.Drawing.Color.DimGray;
            this.grdBooking.HeaderForeColor = System.Drawing.Color.White;
            this.grdBooking.Location = new System.Drawing.Point(61, 106);
            this.grdBooking.Name = "grdBooking";
            this.grdBooking.ReadOnly = true;
            this.grdBooking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooking.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdBooking.RowHeadersVisible = false;
            this.grdBooking.RowTemplate.DividerHeight = 1;
            this.grdBooking.RowTemplate.Height = 30;
            this.grdBooking.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBooking.Size = new System.Drawing.Size(832, 275);
            this.grdBooking.TabIndex = 210;
            this.grdBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBooking_CellClick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDate.Location = new System.Drawing.Point(58, 475);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 16);
            this.lblDate.TabIndex = 214;
            this.lblDate.Text = "Date:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(59, 451);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 16);
            this.lblTitle.TabIndex = 212;
            this.lblTitle.Text = "Title:";
            // 
            // lblTitleFull
            // 
            this.lblTitleFull.AutoSize = true;
            this.lblTitleFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleFull.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblTitleFull.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitleFull.Location = new System.Drawing.Point(125, 451);
            this.lblTitleFull.Name = "lblTitleFull";
            this.lblTitleFull.Size = new System.Drawing.Size(32, 16);
            this.lblTitleFull.TabIndex = 215;
            this.lblTitleFull.Text = "Title";
            // 
            // lblDateFull
            // 
            this.lblDateFull.AutoSize = true;
            this.lblDateFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateFull.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblDateFull.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateFull.Location = new System.Drawing.Point(125, 475);
            this.lblDateFull.Name = "lblDateFull";
            this.lblDateFull.Size = new System.Drawing.Size(35, 16);
            this.lblDateFull.TabIndex = 216;
            this.lblDateFull.Text = "Date";
            // 
            // lblIDFull
            // 
            this.lblIDFull.AutoSize = true;
            this.lblIDFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIDFull.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblIDFull.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIDFull.Location = new System.Drawing.Point(125, 427);
            this.lblIDFull.Name = "lblIDFull";
            this.lblIDFull.Size = new System.Drawing.Size(20, 16);
            this.lblIDFull.TabIndex = 218;
            this.lblIDFull.Text = "ID";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblID.Location = new System.Drawing.Point(59, 427);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 217;
            this.lblID.Text = "ID";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Image = global::EventSYS.Properties.Resources.icon__1___1_1;
            this.btnExit.Location = new System.Drawing.Point(915, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 219;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.Coral;
            this.btnCancel.ActiveForecolor = System.Drawing.SystemColors.Control;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.Coral;
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel Booking";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnCancel.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Location = new System.Drawing.Point(59, 507);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 40);
            this.btnCancel.TabIndex = 211;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::EventSYS.Properties.Resources.home__2_;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 34);
            this.btnBack.TabIndex = 19;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBookingsMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblIDFull);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblDateFull);
            this.Controls.Add(this.lblTitleFull);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grdBooking);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookingsMy";
            this.Text = "frmBookingsUpdate";
            this.Load += new System.EventHandler(this.frmBookingsMy_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBookingsUpdate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBookingsUpdate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmBookingsUpdate_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grdBooking;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleFull;
        private System.Windows.Forms.Label lblDateFull;
        private System.Windows.Forms.Label lblIDFull;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnExit;
    }
}