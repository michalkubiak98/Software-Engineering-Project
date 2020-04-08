using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmBookingsMy : Form
    {

        //Customer 'My Bookings' form, where the signed in customer sees all of their bookings to cancel
        private frmMenuCustomer parent = new frmMenuCustomer();

        public frmBookingsMy()
        {
            InitializeComponent();
        }

        //Parent frmMenuCustomer
        public frmBookingsMy(frmMenuCustomer Parent)
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
        
        private void frmBookingsMy_Load(object sender, EventArgs e)
        {
            grdBooking.DataSource = Booking.getActiveBookings(frmLogIn.CustomerID).Tables["ab"];
        }

        private void grdBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            lblIDFull.Text = grdBooking.Rows[grdBooking.CurrentCell.RowIndex].Cells[0].Value.ToString();
            lblTitleFull.Text = grdBooking.Rows[grdBooking.CurrentCell.RowIndex].Cells[1].Value.ToString();
            lblDateFull.Text = grdBooking.Rows[grdBooking.CurrentCell.RowIndex].Cells[4].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this booking?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Booking booking = new Booking();

                string strno = grdBooking.Rows[grdBooking.CurrentCell.RowIndex].Cells[0].Value.ToString();

                booking.getABooking(Convert.ToInt32(strno));

                booking.CancelBooking();

                MessageBox.Show("All Done");

                try
                {
                    grdBooking.DataSource = Booking.getActiveBookings(frmLogIn.CustomerID).Tables["ab"];
                }
                catch
                {
                    MessageBox.Show("You have no bookings at this time.");
                    return;
                }
            }
        }
    }
}