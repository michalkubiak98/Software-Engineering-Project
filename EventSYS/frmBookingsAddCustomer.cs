using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmBookingsAddCustomer : Form
    {
        public frmBookingsAddCustomer()
        {
            InitializeComponent();
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void frmBookingsAdd_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void frmBookingsAdd_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void frmBookingsAdd_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void frmBookingsAdd_Load(object sender, EventArgs e)
        {
            
            txtEmail.Text = Customer.getEmailFromID(frmLogIn.CustomerID);

            txtID.Text = Convert.ToString(Booking.getNextID());

            grdEvents.DataSource = Event.getActiveEventsMini().Tables["aem"];

            for (int i = 1; i <= 10; i++)
            {
                string[] numbers = { i.ToString() };
                cboTickets.Items.AddRange(numbers);
            }

            lblEventID.Visible = false;
            txtEventID.Visible = false;
            txtEmail.Visible = false;
            lblEmail.Visible = false;
            lblTickets.Visible = false;
            cboTickets.Visible = false;

            txtEvent.Visible = false;
            lblEvent.Visible = false;
            lblVenue.Visible = false;
            txtVenue.Visible = false;
            lblDate.Visible = false;
            txtDate.Visible = false;

            lblTotal.Visible = false;
            txtTotal.Visible = false;
            lblEu.Visible = false;
        }

        private void cboTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price = Event.getPrice(txtEvent.Text, txtVenue.Text);
            double selectedValue = Convert.ToDouble(cboTickets.Text);
            txtTotal.Text = Convert.ToString(price * selectedValue);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
                frmMenuCustomer menu = new frmMenuCustomer();
                menu.Show();
                menu.Left = this.Left;
                menu.Top = this.Top;
                this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm this information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (txtEvent.Text == "")
            {
                MessageBox.Show("Please select an event!", "Select Event", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("One or more fields have been left empty! Please enter all required details.", "Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (dialogResult == DialogResult.Yes)
            {
                if (Utilities.IsValid(txtEmail.Text))
                {
                    if (Customer.checkEmail(txtEmail.Text))
                    {
                        int tickets = Event.getTickets(Convert.ToInt32(txtEventID.Text));
                        if (tickets <= Convert.ToInt32(cboTickets.Text))
                        {
                            MessageBox.Show("Not enough tickets left. There is " + tickets + " tickets left.");
                            return;
                        }
                        else
                        {
                            Booking booking = new Booking();
                            booking.setBookingID(Convert.ToInt32(txtID.Text));
                            booking.setCustID(Customer.getCustIDFromEmail(Convert.ToString(txtEmail.Text)));
                            booking.setEventID(Convert.ToInt32(txtEventID.Text));
                            booking.setBookingDate(DateTime.Now.ToString("yyyy-MM-dd"));
                            booking.setNoTickets(Convert.ToInt32(cboTickets.Text));
                            booking.setBookingTotal(Convert.ToDouble(txtTotal.Text));
                            booking.AddBooking();

                            MessageBox.Show("All Done!");
                            grdEvents.DataSource = Event.getActiveEventsMini().Tables["aem"];
                            txtID.Text = Convert.ToString(Booking.getNextID());
                        }
                    }
                    else
                    {
                        DialogResult dialogResult2 = MessageBox.Show("Email does not exist, sign up?", "Sign Up?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Hide();
                            frmSignUp nextForm = new frmSignUp();
                            nextForm.Show();
                            nextForm.Left = this.Left;
                            nextForm.Top = this.Top;
                        }
                        else return;
                    }
                }
                else
                {
                    MessageBox.Show("Email format not valid!");
                    return;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void grdEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Event ev = new Event();

            try
            {
                string strSno = grdEvents.Rows[grdEvents.CurrentCell.RowIndex].Cells[0].Value.ToString();
                ev.getAnEvent(Convert.ToInt32(strSno));
            }
            catch (ArgumentOutOfRangeException OoREx)
            {
                MessageBox.Show(OoREx.Message + "\n\n Row: " + grdEvents.CurrentCell.RowIndex);
            }

            txtEventID.Text = ev.getEventID().ToString();

            txtEvent.Text = ev.getTitle();
            txtVenue.Text = ev.getVenueName();
            txtDate.Text = ev.getEventDate().ToString();

            lblEventID.Visible = true;
            txtEventID.Visible = true;
            txtEmail.Visible = true;
            lblEmail.Visible = true;
            lblTickets.Visible = true;
            cboTickets.Visible = true;

            txtEvent.Visible = true;
            lblEvent.Visible = true;
            lblVenue.Visible = true;
            txtVenue.Visible = true;
            lblDate.Visible = true;
            txtDate.Visible = true;

            lblTotal.Visible = true;
            txtTotal.Visible = true;
            lblEu.Visible = true;

            cboTickets.SelectedIndex = 0;
            double price = ev.getPrice();
        }
    }
}