using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmBookingsDelete : Form
    {
        //home button

        private frmMenu parent = new frmMenu();

        public frmBookingsDelete()
        {
            InitializeComponent();
        }

        public frmBookingsDelete(frmMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
            parent.Left = this.Left;
            parent.Top = this.Top;
        }

        //exit

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void frmBookingsDelete_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmBookingsDelete_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmBookingsDelete_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        //refreshes the form after clicking confirm - https://stackoverflow.com/questions/6094693/how-to-clear-or-regenerate-window-form-after-submitting-using-c
        private void btnDeleteBookingConfirm_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("You must add a booking ID", "Booking ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Confirm this information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Controls.Clear();

                InitializeComponent();
            }
        }
    }
}