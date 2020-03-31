namespace EventSYS
{
    partial class frmMenu
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.tab5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.subMenu1 = new EventSYS.subMenu();
            this.pnlMainMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnSignOut, BunifuAnimatorNS.DecorationType.None);
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.Gray;
            this.btnSignOut.Location = new System.Drawing.Point(1020, 12);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(80, 29);
            this.btnSignOut.TabIndex = 32;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            this.btnSignOut.MouseHover += new System.EventHandler(this.btnSignOut_MouseHover);
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMainMenu.Controls.Add(this.tab5);
            this.pnlMainMenu.Controls.Add(this.tab6);
            this.pnlMainMenu.Controls.Add(this.tab4);
            this.pnlMainMenu.Controls.Add(this.tab3);
            this.pnlMainMenu.Controls.Add(this.tab2);
            this.pnlMainMenu.Controls.Add(this.tab1);
            this.pnlMainMenu.Controls.Add(this.panel2);
            this.bunifuTransition1.SetDecoration(this.pnlMainMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(200, 633);
            this.pnlMainMenu.TabIndex = 33;
            // 
            // tab5
            // 
            this.tab5.Activecolor = System.Drawing.Color.MidnightBlue;
            this.tab5.BackColor = System.Drawing.Color.MidnightBlue;
            this.tab5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab5.BorderRadius = 0;
            this.tab5.ButtonText = "        Admin";
            this.tab5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab5, BunifuAnimatorNS.DecorationType.None);
            this.tab5.DisabledColor = System.Drawing.Color.Gray;
            this.tab5.Iconcolor = System.Drawing.Color.Transparent;
            this.tab5.Iconimage = global::EventSYS.Properties.Resources.money__1_;
            this.tab5.Iconimage_right = null;
            this.tab5.Iconimage_right_Selected = null;
            this.tab5.Iconimage_Selected = null;
            this.tab5.IconMarginLeft = 40;
            this.tab5.IconMarginRight = 0;
            this.tab5.IconRightVisible = true;
            this.tab5.IconRightZoom = 0D;
            this.tab5.IconVisible = true;
            this.tab5.IconZoom = 45D;
            this.tab5.IsTab = false;
            this.tab5.Location = new System.Drawing.Point(-22, 424);
            this.tab5.Name = "tab5";
            this.tab5.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.tab5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tab5.OnHoverTextColor = System.Drawing.Color.White;
            this.tab5.selected = true;
            this.tab5.Size = new System.Drawing.Size(222, 72);
            this.tab5.TabIndex = 47;
            this.tab5.Tag = "4";
            this.tab5.Text = "        Admin";
            this.tab5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab5.Textcolor = System.Drawing.Color.White;
            this.tab5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab5.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab6
            // 
            this.tab6.Activecolor = System.Drawing.Color.MidnightBlue;
            this.tab6.BackColor = System.Drawing.Color.MidnightBlue;
            this.tab6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab6.BorderRadius = 0;
            this.tab6.ButtonText = "        Account";
            this.tab6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab6, BunifuAnimatorNS.DecorationType.None);
            this.tab6.DisabledColor = System.Drawing.Color.Gray;
            this.tab6.Iconcolor = System.Drawing.Color.Transparent;
            this.tab6.Iconimage = global::EventSYS.Properties.Resources.settings__1_;
            this.tab6.Iconimage_right = null;
            this.tab6.Iconimage_right_Selected = null;
            this.tab6.Iconimage_Selected = null;
            this.tab6.IconMarginLeft = 40;
            this.tab6.IconMarginRight = 0;
            this.tab6.IconRightVisible = true;
            this.tab6.IconRightZoom = 0D;
            this.tab6.IconVisible = true;
            this.tab6.IconZoom = 45D;
            this.tab6.IsTab = false;
            this.tab6.Location = new System.Drawing.Point(-22, 495);
            this.tab6.Name = "tab6";
            this.tab6.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.tab6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tab6.OnHoverTextColor = System.Drawing.Color.White;
            this.tab6.selected = true;
            this.tab6.Size = new System.Drawing.Size(222, 72);
            this.tab6.TabIndex = 46;
            this.tab6.Tag = "5";
            this.tab6.Text = "        Account";
            this.tab6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab6.Textcolor = System.Drawing.Color.White;
            this.tab6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab6.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab4
            // 
            this.tab4.Activecolor = System.Drawing.Color.MidnightBlue;
            this.tab4.BackColor = System.Drawing.Color.MidnightBlue;
            this.tab4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab4.BorderRadius = 0;
            this.tab4.ButtonText = "        Bookings";
            this.tab4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab4, BunifuAnimatorNS.DecorationType.None);
            this.tab4.DisabledColor = System.Drawing.Color.Gray;
            this.tab4.Iconcolor = System.Drawing.Color.Transparent;
            this.tab4.Iconimage = global::EventSYS.Properties.Resources.open_book__1_;
            this.tab4.Iconimage_right = null;
            this.tab4.Iconimage_right_Selected = null;
            this.tab4.Iconimage_Selected = null;
            this.tab4.IconMarginLeft = 40;
            this.tab4.IconMarginRight = 0;
            this.tab4.IconRightVisible = true;
            this.tab4.IconRightZoom = 0D;
            this.tab4.IconVisible = true;
            this.tab4.IconZoom = 45D;
            this.tab4.IsTab = false;
            this.tab4.Location = new System.Drawing.Point(-21, 353);
            this.tab4.Name = "tab4";
            this.tab4.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.tab4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tab4.OnHoverTextColor = System.Drawing.Color.White;
            this.tab4.selected = true;
            this.tab4.Size = new System.Drawing.Size(222, 72);
            this.tab4.TabIndex = 45;
            this.tab4.Tag = "3";
            this.tab4.Text = "        Bookings";
            this.tab4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab4.Textcolor = System.Drawing.Color.White;
            this.tab4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab4.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab3
            // 
            this.tab3.Activecolor = System.Drawing.Color.MidnightBlue;
            this.tab3.BackColor = System.Drawing.Color.MidnightBlue;
            this.tab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab3.BorderRadius = 0;
            this.tab3.ButtonText = "        Events";
            this.tab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab3, BunifuAnimatorNS.DecorationType.None);
            this.tab3.DisabledColor = System.Drawing.Color.Gray;
            this.tab3.Iconcolor = System.Drawing.Color.Transparent;
            this.tab3.Iconimage = global::EventSYS.Properties.Resources.home_run__5_;
            this.tab3.Iconimage_right = null;
            this.tab3.Iconimage_right_Selected = null;
            this.tab3.Iconimage_Selected = null;
            this.tab3.IconMarginLeft = 40;
            this.tab3.IconMarginRight = 0;
            this.tab3.IconRightVisible = true;
            this.tab3.IconRightZoom = 0D;
            this.tab3.IconVisible = true;
            this.tab3.IconZoom = 45D;
            this.tab3.IsTab = false;
            this.tab3.Location = new System.Drawing.Point(-21, 282);
            this.tab3.Name = "tab3";
            this.tab3.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.tab3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tab3.OnHoverTextColor = System.Drawing.Color.White;
            this.tab3.selected = true;
            this.tab3.Size = new System.Drawing.Size(222, 72);
            this.tab3.TabIndex = 44;
            this.tab3.Tag = "2";
            this.tab3.Text = "        Events";
            this.tab3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab3.Textcolor = System.Drawing.Color.White;
            this.tab3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab3.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab2
            // 
            this.tab2.Activecolor = System.Drawing.Color.MidnightBlue;
            this.tab2.BackColor = System.Drawing.Color.MidnightBlue;
            this.tab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab2.BorderRadius = 0;
            this.tab2.ButtonText = "        Venues";
            this.tab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab2, BunifuAnimatorNS.DecorationType.None);
            this.tab2.DisabledColor = System.Drawing.Color.Gray;
            this.tab2.Iconcolor = System.Drawing.Color.Transparent;
            this.tab2.Iconimage = global::EventSYS.Properties.Resources.home_run__4_;
            this.tab2.Iconimage_right = null;
            this.tab2.Iconimage_right_Selected = null;
            this.tab2.Iconimage_Selected = null;
            this.tab2.IconMarginLeft = 40;
            this.tab2.IconMarginRight = 0;
            this.tab2.IconRightVisible = true;
            this.tab2.IconRightZoom = 0D;
            this.tab2.IconVisible = true;
            this.tab2.IconZoom = 45D;
            this.tab2.IsTab = false;
            this.tab2.Location = new System.Drawing.Point(-21, 212);
            this.tab2.Name = "tab2";
            this.tab2.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.tab2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tab2.OnHoverTextColor = System.Drawing.Color.White;
            this.tab2.selected = true;
            this.tab2.Size = new System.Drawing.Size(222, 72);
            this.tab2.TabIndex = 43;
            this.tab2.Tag = "1";
            this.tab2.Text = "        Venues";
            this.tab2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab2.Textcolor = System.Drawing.Color.White;
            this.tab2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab1
            // 
            this.tab1.Activecolor = System.Drawing.Color.MidnightBlue;
            this.tab1.BackColor = System.Drawing.Color.MidnightBlue;
            this.tab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab1.BorderRadius = 0;
            this.tab1.ButtonText = "        Home";
            this.tab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab1, BunifuAnimatorNS.DecorationType.None);
            this.tab1.DisabledColor = System.Drawing.Color.Gray;
            this.tab1.Iconcolor = System.Drawing.Color.Transparent;
            this.tab1.Iconimage = global::EventSYS.Properties.Resources.home_run__1_;
            this.tab1.Iconimage_right = null;
            this.tab1.Iconimage_right_Selected = null;
            this.tab1.Iconimage_Selected = null;
            this.tab1.IconMarginLeft = 40;
            this.tab1.IconMarginRight = 0;
            this.tab1.IconRightVisible = true;
            this.tab1.IconRightZoom = 0D;
            this.tab1.IconVisible = true;
            this.tab1.IconZoom = 45D;
            this.tab1.IsTab = false;
            this.tab1.Location = new System.Drawing.Point(-21, 141);
            this.tab1.Name = "tab1";
            this.tab1.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.tab1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tab1.OnHoverTextColor = System.Drawing.Color.White;
            this.tab1.selected = true;
            this.tab1.Size = new System.Drawing.Size(222, 72);
            this.tab1.TabIndex = 42;
            this.tab1.Tag = "0";
            this.tab1.Text = "        Home";
            this.tab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab1.Textcolor = System.Drawing.Color.White;
            this.tab1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 106);
            this.panel2.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 106);
            this.panel3.TabIndex = 40;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::EventSYS.Properties.Resources.firework;
            this.pictureBox2.Location = new System.Drawing.Point(79, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::EventSYS.Properties.Resources.firework;
            this.pictureBox1.Location = new System.Drawing.Point(79, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subMenu1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 633);
            this.panel1.TabIndex = 39;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // btnExit
            // 
            this.bunifuTransition1.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::EventSYS.Properties.Resources.icon__1___1_2;
            this.btnExit.Location = new System.Drawing.Point(1103, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // subMenu1
            // 
            this.bunifuTransition1.SetDecoration(this.subMenu1, BunifuAnimatorNS.DecorationType.None);
            this.subMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.subMenu1.Location = new System.Drawing.Point(0, 0);
            this.subMenu1.Name = "subMenu1";
            this.subMenu1.Size = new System.Drawing.Size(814, 633);
            this.subMenu1.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 633);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.pnlMainMenu);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMainMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMainMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMainMenu_MouseUp);
            this.pnlMainMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton tab5;
        private Bunifu.Framework.UI.BunifuFlatButton tab6;
        private Bunifu.Framework.UI.BunifuFlatButton tab4;
        private Bunifu.Framework.UI.BunifuFlatButton tab3;
        private Bunifu.Framework.UI.BunifuFlatButton tab2;
        private Bunifu.Framework.UI.BunifuFlatButton tab1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer MouseDetect;
        private System.Windows.Forms.Panel panel1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private subMenu subMenu1;
    }
}

