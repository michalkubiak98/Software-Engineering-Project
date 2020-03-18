using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmBookingsMy : Form
    {
        private frmMenu parent = new frmMenu();

        public frmBookingsMy()
        {
            InitializeComponent();
        }

        public frmBookingsMy(frmMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
            parent.Left = this.Left;
            parent.Top = this.Top;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void frmBookingsUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmBookingsUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmBookingsUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
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