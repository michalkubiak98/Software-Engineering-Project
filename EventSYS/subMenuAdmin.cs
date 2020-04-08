﻿using KimtToo.VisualReactive;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class subMenuAdmin : UserControl
    {
        public subMenuAdmin()
        {
            InitializeComponent();
            if (Program.IsInDesignMode()) return;

            //https://www.youtube.com/watch?v=VJoC8_rUQUY&t=64s
            VSReactive<int>.Subscribe("menu", e => tab1.SelectedIndex = e);
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void frmMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void frmMainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void frmMainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }


        //Disabled the buttons before going to the next form as they still have opeprations running like changing colours and such and whene the form is closed and the next one opens it crashes the App.

        // Sub Menu Buttons
        private void btnCancelVenue_Click(object sender, EventArgs e)
        {
            btnCancelVenue.Enabled = false;

            frmVenueDelete nextForm = new frmVenueDelete();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
            ((Form)TopLevelControl).Close();
        }
        private void btnUpdateVenue_Click(object sender, EventArgs e)
        {
            btnUpdateVenue.Enabled = false;
            frmVenueUpdate nextForm = new frmVenueUpdate();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
            ((Form)TopLevelControl).Close();
        }
        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            btnAddVenue.Enabled = false;
            frmVenueAdd nextForm = new frmVenueAdd();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
            ((Form)TopLevelControl).Close();
        }
        private void btnCancelEvent_Click(object sender, EventArgs e)
        {
            btnCancelEvent.Enabled = false;
            frmEventDelete nextForm = new frmEventDelete();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
            ((Form)TopLevelControl).Close();
        }
        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            btnUpdateEvent.Enabled = false;
            frmEventUpdate nextForm = new frmEventUpdate();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
            ((Form)TopLevelControl).Close();
        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            btnAddEvent.Enabled = false;
            frmEventAdd nextForm = new frmEventAdd();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
            ((Form)TopLevelControl).Close();
        }
        private void btnMyBookings_Click(object sender, EventArgs e)
        {
            btnMyBookings.Enabled = false;
            frmBookingsMyAdmin nextForm = new frmBookingsMyAdmin();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
            ((Form)TopLevelControl).Close();
        }
        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            btnMakeBooking.Enabled = false;
            frmBookingsAdd nextForm = new frmBookingsAdd();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
            ((Form)TopLevelControl).Close();
        }
        private void btnRevenueAnalysis_Click(object sender, EventArgs e)
        {
            btnRevenueAnalysis.Enabled = false;
            frmAdminRevenueAnalysis nextForm = new frmAdminRevenueAnalysis();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
            ((Form)TopLevelControl).Close();
        }
        private void btnVenueAnalysis_Click(object sender, EventArgs e)
        {
            btnVenueAnalysis.Enabled = false;
            frmAdminVenueAnalysis nextForm = new frmAdminVenueAnalysis();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
            ((Form)TopLevelControl).Close();
        }
        private void btnPaymentMethod_Click(object sender, EventArgs e)
        {
        }
        private void btnTheme_Click(object sender, EventArgs e)
        {
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
        }
    }
}