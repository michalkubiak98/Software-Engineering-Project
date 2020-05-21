using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers

namespace EventSYS
{
    partial class frmAdminRevenueAnalysis
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblSold = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblEvents = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.txtNoTicketsSold = new System.Windows.Forms.TextBox();
            this.txtNoEvents = new System.Windows.Forms.TextBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::EventSYS.Properties.Resources.home__2_;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(34, 34);
            this.btnHome.TabIndex = 215;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EventSYS.Properties.Resources.icon__1___1_1;
            this.btnExit.Location = new System.Drawing.Point(709, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 216;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblRevenue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRevenue.Location = new System.Drawing.Point(443, 129);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(98, 16);
            this.lblRevenue.TabIndex = 213;
            this.lblRevenue.Text = "Totoal Revenue";
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSold.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblSold.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSold.Location = new System.Drawing.Point(442, 106);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(77, 16);
            this.lblSold.TabIndex = 212;
            this.lblSold.Text = "Tickets Sold";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(64, 144);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(240, 11);
            this.bunifuSeparator2.TabIndex = 211;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.lblEvents.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEvents.Location = new System.Drawing.Point(442, 81);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(86, 16);
            this.lblEvents.TabIndex = 210;
            this.lblEvents.Text = "No. of Events";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(62, 73);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(242, 11);
            this.bunifuSeparator1.TabIndex = 209;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(60, 52);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(155, 23);
            this.bunifuCustomLabel1.TabIndex = 208;
            this.bunifuCustomLabel1.Text = "Revenue Analysis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(61, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 206;
            this.label1.Text = "Year of analysis";
            // 
            // txtRevenue
            // 
            this.txtRevenue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRevenue.Location = new System.Drawing.Point(600, 125);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.ReadOnly = true;
            this.txtRevenue.Size = new System.Drawing.Size(46, 20);
            this.txtRevenue.TabIndex = 204;
            // 
            // txtNoTicketsSold
            // 
            this.txtNoTicketsSold.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNoTicketsSold.Location = new System.Drawing.Point(600, 99);
            this.txtNoTicketsSold.Name = "txtNoTicketsSold";
            this.txtNoTicketsSold.ReadOnly = true;
            this.txtNoTicketsSold.Size = new System.Drawing.Size(46, 20);
            this.txtNoTicketsSold.TabIndex = 203;
            // 
            // txtNoEvents
            // 
            this.txtNoEvents.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNoEvents.Location = new System.Drawing.Point(600, 73);
            this.txtNoEvents.Name = "txtNoEvents";
            this.txtNoEvents.ReadOnly = true;
            this.txtNoEvents.Size = new System.Drawing.Size(46, 20);
            this.txtNoEvents.TabIndex = 202;
            // 
            // cboYear
            // 
            this.cboYear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2019",
            "2020"});
            this.cboYear.Location = new System.Drawing.Point(205, 103);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(99, 21);
            this.cboYear.TabIndex = 200;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartesianChart1.Location = new System.Drawing.Point(68, 188);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(588, 452);
            this.cartesianChart1.TabIndex = 217;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // frmAdminRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(755, 687);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.lblSold);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.txtNoTicketsSold);
            this.Controls.Add(this.txtNoEvents);
            this.Controls.Add(this.cboYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminRevenueAnalysis";
            this.Text = "frmAdminRevenueAnalysis";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAdminRevenueAnalysis_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAdminRevenueAnalysis_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmAdminRevenueAnalysis_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblSold;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label lblEvents;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.TextBox txtNoTicketsSold;
        private System.Windows.Forms.TextBox txtNoEvents;
        private System.Windows.Forms.ComboBox cboYear;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}