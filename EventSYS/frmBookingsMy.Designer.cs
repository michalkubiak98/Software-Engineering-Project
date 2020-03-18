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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtEventID = new System.Windows.Forms.TextBox();
            this.lblEventID = new System.Windows.Forms.Label();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.lblTickets = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblAddBookngSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.grdUpdateBooking = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(204, 219);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(201, 23);
            this.txtMobile.TabIndex = 110;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMobile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMobile.Location = new System.Drawing.Point(31, 222);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(49, 16);
            this.lblMobile.TabIndex = 109;
            this.lblMobile.Text = "Mobile";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(204, 256);
            this.dtpDate.MinDate = new System.DateTime(2019, 10, 28, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(201, 20);
            this.dtpDate.TabIndex = 108;
            // 
            // txtEventID
            // 
            this.txtEventID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventID.Location = new System.Drawing.Point(204, 326);
            this.txtEventID.Name = "txtEventID";
            this.txtEventID.Size = new System.Drawing.Size(30, 23);
            this.txtEventID.TabIndex = 107;
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEventID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEventID.Location = new System.Drawing.Point(31, 329);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(63, 16);
            this.lblEventID.TabIndex = 106;
            this.lblEventID.Text = "Event ID";
            // 
            // txtTickets
            // 
            this.txtTickets.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTickets.Location = new System.Drawing.Point(204, 288);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(30, 23);
            this.txtTickets.TabIndex = 105;
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTickets.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTickets.Location = new System.Drawing.Point(31, 291);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(101, 16);
            this.lblTickets.TabIndex = 104;
            this.lblTickets.Text = "Ticket Amount";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(31, 257);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(123, 16);
            this.lblDate.TabIndex = 103;
            this.lblDate.Text = "Add Booking Date";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(204, 184);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(201, 23);
            this.txtSurname.TabIndex = 102;
            // 
            // lblAddBookngSurname
            // 
            this.lblAddBookngSurname.AutoSize = true;
            this.lblAddBookngSurname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddBookngSurname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBookngSurname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddBookngSurname.Location = new System.Drawing.Point(31, 187);
            this.lblAddBookngSurname.Name = "lblAddBookngSurname";
            this.lblAddBookngSurname.Size = new System.Drawing.Size(65, 16);
            this.lblAddBookngSurname.TabIndex = 101;
            this.lblAddBookngSurname.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(204, 149);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 23);
            this.txtName.TabIndex = 100;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(31, 152);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 16);
            this.lblName.TabIndex = 99;
            this.lblName.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.txtID.Location = new System.Drawing.Point(204, 115);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(30, 23);
            this.txtID.TabIndex = 98;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblID.Location = new System.Drawing.Point(31, 118);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(76, 16);
            this.lblID.TabIndex = 97;
            this.lblID.Text = "Booking ID";
            // 
            // grdUpdateBooking
            // 
            this.grdUpdateBooking.AllowUserToAddRows = false;
            this.grdUpdateBooking.AllowUserToDeleteRows = false;
            this.grdUpdateBooking.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdUpdateBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdUpdateBooking.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdUpdateBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdUpdateBooking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUpdateBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdUpdateBooking.ColumnHeadersHeight = 20;
            this.grdUpdateBooking.DoubleBuffered = true;
            this.grdUpdateBooking.EnableHeadersVisualStyles = false;
            this.grdUpdateBooking.GridColor = System.Drawing.SystemColors.Control;
            this.grdUpdateBooking.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.grdUpdateBooking.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdUpdateBooking.Location = new System.Drawing.Point(426, 118);
            this.grdUpdateBooking.Name = "grdUpdateBooking";
            this.grdUpdateBooking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdUpdateBooking.Size = new System.Drawing.Size(529, 306);
            this.grdUpdateBooking.TabIndex = 111;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(422, 22);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(177, 24);
            this.bunifuCustomLabel1.TabIndex = 112;
            this.bunifuCustomLabel1.Text = "UPDATE BOOKING";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Activecolor = System.Drawing.SystemColors.Control;
            this.btnConfirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.BorderRadius = 0;
            this.btnConfirm.ButtonText = "Confirm";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.DisabledColor = System.Drawing.Color.Goldenrod;
            this.btnConfirm.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfirm.Iconimage = null;
            this.btnConfirm.Iconimage_right = null;
            this.btnConfirm.Iconimage_right_Selected = null;
            this.btnConfirm.Iconimage_Selected = null;
            this.btnConfirm.IconMarginLeft = 0;
            this.btnConfirm.IconMarginRight = 0;
            this.btnConfirm.IconRightVisible = true;
            this.btnConfirm.IconRightZoom = 0D;
            this.btnConfirm.IconVisible = true;
            this.btnConfirm.IconZoom = 90D;
            this.btnConfirm.IsTab = false;
            this.btnConfirm.Location = new System.Drawing.Point(34, 389);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnConfirm.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirm.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.selected = false;
            this.btnConfirm.Size = new System.Drawing.Size(120, 35);
            this.btnConfirm.TabIndex = 113;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Textcolor = System.Drawing.SystemColors.Control;
            this.btnConfirm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EventSYS.Properties.Resources.home__3_;
            this.btnExit.Location = new System.Drawing.Point(921, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 20;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBookingsMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 465);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.grdUpdateBooking);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtEventID);
            this.Controls.Add(this.lblEventID);
            this.Controls.Add(this.txtTickets);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblAddBookngSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookingsMy";
            this.Text = "frmBookingsUpdate";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBookingsUpdate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBookingsUpdate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmBookingsUpdate_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.grdUpdateBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtEventID;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblAddBookngSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grdUpdateBooking;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfirm;
    }
}