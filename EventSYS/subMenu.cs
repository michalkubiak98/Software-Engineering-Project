using KimtToo.VisualReactive;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class subMenu : UserControl
    {


        public subMenu()
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

        private void btnCancelVenue_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Hide();
            frmVenueDelete nextForm = new frmVenueDelete();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
        }

        private void btnUpdateVenue_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Hide();
            frmVenueUpdate nextForm = new frmVenueUpdate();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
        }

        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Hide();
            frmVenueAdd nextForm = new frmVenueAdd();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
        }

        private void btnCancelEvent_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Hide();
            frmEventDelete nextForm = new frmEventDelete();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Hide();
            frmEventUpdate nextForm = new frmEventUpdate();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Hide();
            frmEventAdd nextForm = new frmEventAdd();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
        }

        private void btnMyBookings_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Hide();
            frmBookingsMy nextForm = new frmBookingsMy();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Hide();
            frmBookingsAdd nextForm = new frmBookingsAdd();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
        }

        private void btnRevenueAnalysis_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Hide();
            frmAdminRevenueAnalysis nextForm = new frmAdminRevenueAnalysis();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
        }

        private void btnVenueAnalysis_Click(object sender, EventArgs e)
        {
            ((Form)TopLevelControl).Hide();
            frmAdminVenueAnalysis nextForm = new frmAdminVenueAnalysis();
            nextForm.Show();
            nextForm.Left = ((Form)TopLevelControl).Left;
            nextForm.Top = ((Form)TopLevelControl).Top;
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