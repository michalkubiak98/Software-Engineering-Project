using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmAdminVenueAnalysis : Form
    {
        //home button

        public frmAdminVenueAnalysis()
        {
            InitializeComponent();
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void frmAdminVenueAnalysis_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmAdminVenueAnalysis_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmAdminVenueAnalysis_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void frmAdminVenueAnalysis_Load(object sender, EventArgs e)
        {
            lblEvents.Visible = false;
            lblRevenue.Visible = false;
            lblSold.Visible = false;
            txtNoEvents.Visible = false;
            txtNoTicketsSold.Visible = false;
            txtRevenue.Visible = false;

            DataSet ds = new DataSet();
            ds = Venue.getActiveVenues();
            // check that there are venues to delete
            if (ds.Tables["av"].Rows.Count == 0)
            {
                cboVenues.SelectedIndex = -1;
                cboVenues.Items.Clear();
                cboVenues.Text = "No Venues";
                return;
            }

            //load combo box
            for (int i = 0; i < ds.Tables["av"].Rows.Count; i++)
            {
                cboVenues.Items.Add(ds.Tables[0].Rows[i][1].ToString());
            }


        }
        

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm this information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                String date = "";

                if (cboVenues.SelectedIndex >= 0)
                {
                    if (cboYear.SelectedIndex >= 0)
                    {
                        String year = cboYear.Text;
                        if (cboMonth.SelectedIndex >= 0)
                        {
                            String month = cboMonth.Text.Substring(0, 2);
                            date = year + "-" + month;
                        }
                        else
                        {
                            date = year;
                        }

                        lblEvents.Visible = true;
                        lblRevenue.Visible = true;
                        lblSold.Visible = true;
                        txtNoEvents.Visible = true;
                        txtNoTicketsSold.Visible = true;
                        txtRevenue.Visible = true;

                        String venueName = cboVenues.Text;
                        txtNoEvents.Text = Event.noEvents(date, Venue.getIDFromName(venueName));
                        txtNoTicketsSold.Text = Event.noTicketsSold(date, Venue.getIDFromName(venueName));
                        txtRevenue.Text = Event.totalRevenue(date, Venue.getIDFromName(venueName));
                    }
                    else
                    {
                        MessageBox.Show("Please Select At Least The Year!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Venue!");
                    return;
                }
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmMenu parent = new frmMenu();
            this.Close();
            parent.Show();
            parent.Left = this.Left;
            parent.Top = this.Top;
        }
    }
}