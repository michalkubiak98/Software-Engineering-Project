namespace EventSYS
{
    partial class frmSignUp
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
            this.lblTermsAccept = new System.Windows.Forms.Label();
            this.chkTerms = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblContact = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSurname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblForename = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblHead = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTermsAccept
            // 
            this.lblTermsAccept.AutoSize = true;
            this.lblTermsAccept.BackColor = System.Drawing.Color.Transparent;
            this.lblTermsAccept.ForeColor = System.Drawing.Color.DimGray;
            this.lblTermsAccept.Location = new System.Drawing.Point(203, 378);
            this.lblTermsAccept.Name = "lblTermsAccept";
            this.lblTermsAccept.Size = new System.Drawing.Size(153, 13);
            this.lblTermsAccept.TabIndex = 67;
            this.lblTermsAccept.Text = "Accept Terms and Agreements";
            // 
            // chkTerms
            // 
            this.chkTerms.AutoSize = true;
            this.chkTerms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkTerms.Location = new System.Drawing.Point(385, 379);
            this.chkTerms.Name = "chkTerms";
            this.chkTerms.Size = new System.Drawing.Size(13, 12);
            this.chkTerms.TabIndex = 199;
            this.chkTerms.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::EventSYS.Properties.Resources.icon__1_;
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 43;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.lblConfirmPassword);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Controls.Add(this.lblForename);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.btnLogIn);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.chkTerms);
            this.panel1.Controls.Add(this.lblTermsAccept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 534);
            this.panel1.TabIndex = 200;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.Transparent;
            this.lblContact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContact.Location = new System.Drawing.Point(34, 343);
            this.lblContact.Margin = new System.Windows.Forms.Padding(0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(69, 14);
            this.lblContact.TabIndex = 213;
            this.lblContact.Text = "Password";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.SystemColors.Menu;
            this.txtContact.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(202, 337);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '*';
            this.txtContact.Size = new System.Drawing.Size(196, 27);
            this.txtContact.TabIndex = 212;
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblConfirmPassword.Location = new System.Drawing.Point(34, 301);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(121, 14);
            this.lblConfirmPassword.TabIndex = 211;
            this.lblConfirmPassword.Text = "Confirm Password";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(34, 258);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(69, 14);
            this.bunifuCustomLabel1.TabIndex = 210;
            this.bunifuCustomLabel1.Text = "Password";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(34, 217);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 14);
            this.lblEmail.TabIndex = 209;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(202, 293);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(196, 27);
            this.txtConfirmPassword.TabIndex = 208;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(202, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 27);
            this.txtEmail.TabIndex = 206;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(202, 249);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(196, 27);
            this.txtPassword.TabIndex = 207;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSurname.Location = new System.Drawing.Point(34, 174);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(63, 14);
            this.lblSurname.TabIndex = 205;
            this.lblSurname.Text = "Surname";
            this.lblSurname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.BackColor = System.Drawing.Color.Transparent;
            this.lblForename.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblForename.Location = new System.Drawing.Point(34, 131);
            this.lblForename.Margin = new System.Windows.Forms.Padding(0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(70, 14);
            this.lblForename.TabIndex = 204;
            this.lblForename.Text = "Forename";
            this.lblForename.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUp.BorderRadius = 7;
            this.btnSignUp.ButtonText = "Log In";
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
            this.btnSignUp.Location = new System.Drawing.Point(37, 479);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSignUp.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btnSignUp.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSignUp.selected = false;
            this.btnSignUp.Size = new System.Drawing.Size(361, 30);
            this.btnSignUp.TabIndex = 203;
            this.btnSignUp.Text = "Log In";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.Textcolor = System.Drawing.Color.DimGray;
            this.btnSignUp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnLogIn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogIn.BorderRadius = 7;
            this.btnLogIn.ButtonText = "Sign Up";
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
            this.btnLogIn.Location = new System.Drawing.Point(37, 441);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Normalcolor = System.Drawing.Color.SteelBlue;
            this.btnLogIn.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnLogIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogIn.selected = false;
            this.btnLogIn.Size = new System.Drawing.Size(361, 32);
            this.btnLogIn.TabIndex = 202;
            this.btnLogIn.Text = "Sign Up";
            this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogIn.Textcolor = System.Drawing.Color.White;
            this.btnLogIn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(202, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 27);
            this.txtName.TabIndex = 200;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSurname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(202, 165);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '*';
            this.txtSurname.Size = new System.Drawing.Size(196, 27);
            this.txtSurname.TabIndex = 201;
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.BackColor = System.Drawing.SystemColors.Control;
            this.lblHead.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold);
            this.lblHead.ForeColor = System.Drawing.Color.Black;
            this.lblHead.Location = new System.Drawing.Point(273, 31);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(425, 58);
            this.lblHead.TabIndex = 201;
            this.lblHead.Text = "JOIN    EVENTER";
            // 
            // pctBox
            // 
            this.pctBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pctBox.Image = global::EventSYS.Properties.Resources._31;
            this.pctBox.InitialImage = null;
            this.pctBox.Location = new System.Drawing.Point(432, 0);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(381, 534);
            this.pctBox.TabIndex = 202;
            this.pctBox.TabStop = false;
            this.pctBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctBox_MouseDown);
            this.pctBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctBox_MouseMove);
            this.pctBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctBox_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(202, 56);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(61, 13);
            this.bunifuSeparator1.TabIndex = 214;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EventSYS.Properties.Resources.New_Project1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 534);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.pctBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignUp";
            this.Text = "SignUp";

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTermsAccept;
        private System.Windows.Forms.CheckBox chkTerms;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private Bunifu.Framework.UI.BunifuCustomLabel lblConfirmPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSurname;
        private Bunifu.Framework.UI.BunifuCustomLabel lblForename;
        private Bunifu.Framework.UI.BunifuFlatButton btnSignUp;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogIn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHead;
        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}