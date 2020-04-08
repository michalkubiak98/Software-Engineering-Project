using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmBookingsMyAdmin : Form
    {
        public frmBookingsMyAdmin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private frmMenuAdmin parent = new frmMenuAdmin();

        public frmBookingsMyAdmin(frmMenuAdmin Parent)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this booking?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Booking booking = new Booking();

                    string strno = grdBooking.Rows[grdBooking.CurrentCell.RowIndex].Cells[0].Value.ToString();

                    booking.getABooking(Convert.ToInt32(strno));

                    booking.CancelBooking();

                    MessageBox.Show("All Done");

                    try
                    {
                        grdBooking.DataSource = Booking.getActiveBookings(Customer.getCustIDFromEmail(txtEmail.Text)).Tables["ab"];
                    }
                    catch
                    {
                        MessageBox.Show("This user does not have any bookings at this time.");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("This user does not have any bookings at this time.");
                    return;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter username and password");

                return;
            }

            if (Customer.checkEmail(txtEmail.Text))
            {
                lblEmail.Visible = false;
                txtEmail.Visible = false;
                btnConfirm.Visible = false;

                try
                {
                    grdBooking.DataSource = Booking.getActiveBookings(Customer.getCustIDFromEmail(txtEmail.Text)).Tables["ab"];
                }
                catch
                {
                    MessageBox.Show("This user does not have any bookings at this time.");
                    return;
                }

                grdBooking.Visible = true;
                bunifuSeparator3.Visible = true;
                lblIDFull.Visible = true;
                lblID.Visible = true;
                lblTitle.Visible = true;
                lblTitleFull.Visible = true;
                lblDate.Visible = true;
                lblDateFull.Visible = true;
                btnCancel.Visible = true;
            }
            else
            {
                MessageBox.Show("Email does not exist.");
                return;
            }
        }

        private void frmBookingsMyCustomer_Load(object sender, EventArgs e)
        {
            grdBooking.Visible = false;
            bunifuSeparator3.Visible = false;
            lblIDFull.Visible = false;
            lblID.Visible = false;
            lblTitle.Visible = false;
            lblTitleFull.Visible = false;
            lblDate.Visible = false;
            lblDateFull.Visible = false;
            btnCancel.Visible = false;
        }

        private void grdBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIDFull.Text = grdBooking.Rows[grdBooking.CurrentCell.RowIndex].Cells[0].Value.ToString();
            lblTitleFull.Text = grdBooking.Rows[grdBooking.CurrentCell.RowIndex].Cells[1].Value.ToString();
            lblDateFull.Text = grdBooking.Rows[grdBooking.CurrentCell.RowIndex].Cells[4].Value.ToString();
        }


        //Move Form Code
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void frmBookingsMyCustomer_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void frmBookingsMyCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void frmBookingsMyCustomer_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}