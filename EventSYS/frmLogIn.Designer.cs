namespace EventSYS
{
    partial class frmLogIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblHead = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(129, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 27);
            this.txtEmail.TabIndex = 179;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(129, 199);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(196, 27);
            this.txtPassword.TabIndex = 180;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.BackColor = System.Drawing.Color.Black;
            this.lblHead.Font = new System.Drawing.Font("Tahoma", 53F, System.Drawing.FontStyle.Bold);
            this.lblHead.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHead.Location = new System.Drawing.Point(-4, 140);
            this.lblHead.Margin = new System.Windows.Forms.Padding(0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(404, 86);
            this.lblHead.TabIndex = 181;
            this.lblHead.Text = "WELCOME";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSide.Controls.Add(this.bunifuCustomLabel2);
            this.pnlSide.Controls.Add(this.lblEmail);
            this.pnlSide.Controls.Add(this.btnSignUp);
            this.pnlSide.Controls.Add(this.btnLogIn);
            this.pnlSide.Controls.Add(this.button1);
            this.pnlSide.Controls.Add(this.txtEmail);
            this.pnlSide.Controls.Add(this.txtPassword);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSide.Location = new System.Drawing.Point(393, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(357, 488);
            this.pnlSide.TabIndex = 186;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(48, 206);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(69, 14);
            this.bunifuCustomLabel2.TabIndex = 190;
            this.bunifuCustomLabel2.Text = "Password";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(48, 166);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 14);
            this.lblEmail.TabIndex = 189;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUp.BorderRadius = 7;
            this.btnSignUp.ButtonText = "Sign Up";
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.DisabledColor = System.Drawing.Color.Gray;
            this.btnSignUp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSignUp.Iconimage = null;
            this.btnSignUp.Iconimage_right = null;
            this.btnSignUp.Iconimage_right_Selected = null;
            this.btnSignUp.Iconimage_Selected = null;
            this.btnSignUp.IconMarginLeft = 0;
            this.btnSignUp.IconMarginRight = 0;
            this.btnSignUp.IconRightVisible = true;
            this.btnSignUp.IconRightZoom = 0D;
            this.btnSignUp.IconVisible = true;
            this.btnSignUp.IconZoom = 90D;
            this.btnSignUp.IsTab = false;
            this.btnSignUp.Location = new System.Drawing.Point(51, 424);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSignUp.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btnSignUp.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSignUp.selected = false;
            this.btnSignUp.Size = new System.Drawing.Size(274, 30);
            this.btnSignUp.TabIndex = 188;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.Textcolor = System.Drawing.Color.DimGray;
            this.btnSignUp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogIn.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogIn.BorderRadius = 7;
            this.btnLogIn.ButtonText = "Log In";
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogIn.Iconimage = null;
            this.btnLogIn.Iconimage_right = null;
            this.btnLogIn.Iconimage_right_Selected = null;
            this.btnLogIn.Iconimage_Selected = null;
            this.btnLogIn.IconMarginLeft = 0;
            this.btnLogIn.IconMarginRight = 0;
            this.btnLogIn.IconRightVisible = true;
            this.btnLogIn.IconRightZoom = 0D;
            this.btnLogIn.IconVisible = true;
            this.btnLogIn.IconZoom = 90D;
            this.btnLogIn.IsTab = false;
            this.btnLogIn.Location = new System.Drawing.Point(51, 386);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLogIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogIn.selected = false;
            this.btnLogIn.Size = new System.Drawing.Size(274, 32);
            this.btnLogIn.TabIndex = 187;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogIn.Textcolor = System.Drawing.Color.White;
            this.btnLogIn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::EventSYS.Properties.Resources.icon__1_;
            this.button1.Location = new System.Drawing.Point(320, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 177;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctBox
            // 
            this.pctBox.Image = ((System.Drawing.Image)(resources.GetObject("pctBox.Image")));
            this.pctBox.Location = new System.Drawing.Point(0, 0);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(400, 516);
            this.pctBox.TabIndex = 187;
            this.pctBox.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(8, 142);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 16);
            this.bunifuCustomLabel1.TabIndex = 188;
            this.bunifuCustomLabel1.Text = "EVENTER";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.pctBox);
            this.Controls.Add(this.pnlSide);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogIn";
            this.Text = "frmLogIn";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogIn_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogIn_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLogIn_MouseUp);
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHead;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlSide;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogIn;
        private System.Windows.Forms.PictureBox pctBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignUp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}