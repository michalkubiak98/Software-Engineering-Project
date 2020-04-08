using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmEventAdd : Form
    {
        public frmEventAdd()
        {
            InitializeComponent();
        }

        private void frmEventAdd_Load(object sender, EventArgs e)
        {
            txtID.Text = Convert.ToString(Event.getNextID());
            grdAddEvent.DataSource = Event.getActiveEventsMini().Tables["aem"];

            List<String> venues = Venue.fillVenueCombo();
            cboVenue.Items.AddRange(venues.ToArray());

            Utilities.BunifuMetro(txtTitle, 50);
            Utilities.BunifuMetro(txtDescription, 140);
            Utilities.BunifuMetro(txtTime, 5);
            Utilities.BunifuMetro(txtTicketsAvailable, 5);
            Utilities.BunifuMetro(txtPrice, 6);
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void frmEventAdd_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void frmEventAdd_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void frmEventAdd_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenuAdmin parent = new frmMenuAdmin();
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
                Environment.Exit(0);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cboVenue.SelectedItem == null || txtTitle.Text == "" ||
             txtTicketsAvailable.Text == "" || txtTime.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("One or more fields have been left empty! Please enter all required details.", "Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Confirm this information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (!Event.checkEventTitle(txtTitle.Text, Venue.getIDFromName(cboVenue.SelectedItem.ToString())))
                {
                    String name = Convert.ToString(cboVenue.SelectedItem);
                    Event myEvent = new Event();

                    DateTime dt1 = DateTime.Parse(dtpDate.Value.ToString("yyyy-MM-dd"));
                    DateTime dt2 = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

                    if (dt1.Date >= dt2.Date)
                    {
                        myEvent.setEventID(Convert.ToInt32(txtID.Text));
                        myEvent.setVenueID(Venue.getIDFromName(name));
                        myEvent.setVenueName(name);
                        myEvent.setTitle(Convert.ToString(txtTitle.Text));
                        myEvent.setDescription(Convert.ToString(txtDescription.Text));
                        myEvent.setEventDate(dtpDate.Value.ToString("yyyy-MM-dd"));
                        myEvent.setEventTime(txtTime.Text);
                        myEvent.setTicketsAvailable(Convert.ToInt32(txtTicketsAvailable.Text));
                        myEvent.setPrice(Convert.ToDouble(txtPrice.Text));

                        if (myEvent.isVenueFree(myEvent.getEventDate()))
                        {
                            int ticks = Venue.getMaxCapacity(cboVenue.Text);

                            if (Convert.ToInt32(txtTicketsAvailable.Text) <= ticks)
                            {
                                try
                                {
                                    myEvent.AddEvent();
                                    MessageBox.Show("All Done!");
                                    grdAddEvent.DataSource = Event.getActiveEventsMini().Tables["aem"];
                                    txtID.Text = Convert.ToString(Event.getNextID());

                                    txtTitle.Text = "";
                                    txtDescription.Text = "";
                                    dtpDate.Refresh();
                                    txtTime.Text = "";
                                    txtPrice.Text = "";
                                    txtTicketsAvailable.Text = "";
                                }
                                catch (Oracle.ManagedDataAccess.Client.OracleException)
                                {
                                    MessageBox.Show("The price or time format you have entered is incorrect! " +
                                        "Try and put a decimal point in the price (eg. 120.00) or a colon (:) in the time box!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Cannot have more than " + ticks + " tickets for this venue!");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("This venue already has an event that day!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Event must be in the future!");
                    }
                }
                else
                {
                    MessageBox.Show("Event with this title and venue already exists.");
                    return;
                }
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Clear All Fields?", "Clear Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                cboVenue.SelectedIndex = -1;
                txtTitle.Text = "";
                txtDescription.Text = "";
                dtpDate.Refresh();
                txtTime.Text = "";
                txtPrice.Text = "";
                txtTicketsAvailable.Text = "";
            }
        }


        //Key Press TextBox Restrictions for DB Insert Error Handling
        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            //https://stackoverflow.com/questions/16050749/how-restrict-textbox-in-c-sharp-to-only-receive-numbers-and-dot-or-comma

            if (char.IsDigit(e.KeyChar) || e.KeyChar == ':' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtTicketsAvailable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void cboVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ticks = Venue.getMaxCapacity(cboVenue.Text);
            txtTicketsAvailable.Text = Convert.ToString(ticks);
        }
    }
}