﻿using KimtToo.VisualReactive;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmMenuAdmin : Form
    {
        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void subMenu1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void subMenu1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void subMenu1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        private void frmMenu_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void frmMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void frmMenu_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }


        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.WhiteSmoke;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            btnSignOut.Enabled = false;
            this.Close();
            frmLogIn nextForm = new frmLogIn();
            nextForm.Show();
            nextForm.Left = this.Left;
            nextForm.Top = this.Top;
        }

        //Side menu taken from https://www.youtube.com/watch?v=VJoC8_rUQUY&t=64s
        private bool mnuExpanded = true;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!bunifuTransition1.IsCompleted) return;
            if (pnlMainMenu.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!mnuExpanded)
                {
                    mnuExpanded = true;
                    pnlMainMenu.Width = 200;
                }
            }
            else
            {
                if (mnuExpanded)
                {
                    mnuExpanded = false;
                    pnlMainMenu.Width = 62;
                    bunifuTransition1.Show(pnlMainMenu);
                }
            }
        }
        private void sideMenu_Click(object sender, EventArgs e)
        {
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
        }
        

    }
}