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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.lblTermsAccept = new System.Windows.Forms.Label();
            this.chkTerms = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSignUp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtContact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPasswordConfirm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTermsAccept
            // 
            this.lblTermsAccept.AutoSize = true;
            this.lblTermsAccept.BackColor = System.Drawing.Color.Black;
            this.lblTermsAccept.ForeColor = System.Drawing.Color.White;
            this.lblTermsAccept.Location = new System.Drawing.Point(263, 544);
            this.lblTermsAccept.Name = "lblTermsAccept";
            this.lblTermsAccept.Size = new System.Drawing.Size(153, 13);
            this.lblTermsAccept.TabIndex = 67;
            this.lblTermsAccept.Text = "Accept Terms and Agreements";
            // 
            // chkTerms
            // 
            this.chkTerms.AutoSize = true;
            this.chkTerms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkTerms.Location = new System.Drawing.Point(244, 544);
            this.chkTerms.Name = "chkTerms";
            this.chkTerms.Size = new System.Drawing.Size(13, 12);
            this.chkTerms.TabIndex = 199;
            this.chkTerms.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EventSYS.Properties.Resources.icon__1__1_;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 43;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::EventSYS.Properties.Resources.firework2;
            this.pictureBox1.Location = new System.Drawing.Point(287, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 176;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.ActiveBorderThickness = 1;
            this.btnLogIn.ActiveCornerRadius = 36;
            this.btnLogIn.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(138)))));
            this.btnLogIn.ActiveLineColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogIn.BackgroundImage")));
            this.btnLogIn.ButtonText = "Sign In";
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.IdleBorderThickness = 3;
            this.btnLogIn.IdleCornerRadius = 36;
            this.btnLogIn.IdleFillColor = System.Drawing.Color.Black;
            this.btnLogIn.IdleForecolor = System.Drawing.Color.White;
            this.btnLogIn.IdleLineColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(378, 589);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(98, 52);
            this.btnLogIn.TabIndex = 177;
            this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click_1);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 20F);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(199, 142);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(256, 34);
            this.lblHeader.TabIndex = 178;
            this.lblHeader.Text = "Create New Account";
            // 
            // btnSignUp
            // 
            this.btnSignUp.ActiveBorderThickness = 1;
            this.btnSignUp.ActiveCornerRadius = 36;
            this.btnSignUp.ActiveFillColor = System.Drawing.SystemColors.Control;
            this.btnSignUp.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnSignUp.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignUp.BackgroundImage")));
            this.btnSignUp.ButtonText = "Create Account";
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignUp.IdleBorderThickness = 3;
            this.btnSignUp.IdleCornerRadius = 36;
            this.btnSignUp.IdleFillColor = System.Drawing.Color.White;
            this.btnSignUp.IdleForecolor = System.Drawing.Color.Black;
            this.btnSignUp.IdleLineColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(173, 589);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(197, 52);
            this.btnSignUp.TabIndex = 200;
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click_1);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Black;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.HintForeColor = System.Drawing.Color.White;
            this.txtName.HintText = "Forename";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtName.LineIdleColor = System.Drawing.Color.Black;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(173, 237);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(303, 37);
            this.txtName.TabIndex = 192;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.Black;
            this.txtSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.White;
            this.txtSurname.HintForeColor = System.Drawing.Color.White;
            this.txtSurname.HintText = "Surname";
            this.txtSurname.isPassword = false;
            this.txtSurname.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtSurname.LineIdleColor = System.Drawing.Color.Black;
            this.txtSurname.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtSurname.LineThickness = 3;
            this.txtSurname.Location = new System.Drawing.Point(173, 282);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(303, 37);
            this.txtSurname.TabIndex = 194;
            this.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Black;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HintForeColor = System.Drawing.Color.White;
            this.txtEmail.HintText = "Email";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Black;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(173, 327);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(303, 37);
            this.txtEmail.TabIndex = 195;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.Black;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.White;
            this.txtContact.HintForeColor = System.Drawing.Color.White;
            this.txtContact.HintText = "Mobile";
            this.txtContact.isPassword = false;
            this.txtContact.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtContact.LineIdleColor = System.Drawing.Color.Black;
            this.txtContact.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtContact.LineThickness = 3;
            this.txtContact.Location = new System.Drawing.Point(173, 464);
            this.txtContact.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(303, 37);
            this.txtContact.TabIndex = 198;
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.BackColor = System.Drawing.Color.Black;
            this.txtPasswordConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirm.ForeColor = System.Drawing.Color.White;
            this.txtPasswordConfirm.HintForeColor = System.Drawing.Color.White;
            this.txtPasswordConfirm.HintText = "Confirm Password";
            this.txtPasswordConfirm.isPassword = true;
            this.txtPasswordConfirm.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtPasswordConfirm.LineIdleColor = System.Drawing.Color.Black;
            this.txtPasswordConfirm.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtPasswordConfirm.LineThickness = 3;
            this.txtPasswordConfirm.Location = new System.Drawing.Point(173, 419);
            this.txtPasswordConfirm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(303, 37);
            this.txtPasswordConfirm.TabIndex = 197;
            this.txtPasswordConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HintForeColor = System.Drawing.Color.White;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Black;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(173, 374);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(303, 37);
            this.txtPassword.TabIndex = 196;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EventSYS.Properties.Resources.New_Project1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 693);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.chkTerms);
            this.Controls.Add(this.lblTermsAccept);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignUp";
            this.Text = "SignUp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSignUp_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSignUp_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmSignUp_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTermsAccept;
        private System.Windows.Forms.CheckBox chkTerms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogIn;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignUp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSurname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContact;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPasswordConfirm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
    }
}