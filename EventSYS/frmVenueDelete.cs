using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmVenueDelete : Form
    {
        public frmVenueDelete()
        {
            InitializeComponent();
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4
        private bool _dragging = false;

        private Point _start_point = new Point(0, 0);

        private void frmVenueDelete_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmVenueDelete_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmVenueDelete_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void frmVenueDelete_Load(object sender, EventArgs e)
        {
            loadVenues();
            grpBox.Visible = false;
            //https://stackoverflow.com/questions/49424788/how-to-set-max-length-for-bunifu-net-ui-framework-text-box
            grpBox.Paint += PaintBorderlessGroupBox;
        }

        public void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(SystemColors.Control);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.White, 0, 0);
        }

        public void loadVenues()
        {
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
                cboVenues.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString());
            }
        }

        private void cboVenues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVenues.SelectedIndex == -1)
            {
                return;
            }

            Venue aVenue = new Venue();

            aVenue.getAVenue(Convert.ToInt32(cboVenues.Text.Substring(0, 3))); //change in db to 2

            txtID.Text = aVenue.getVenueID().ToString();
            txtName.Text = aVenue.getVenueName().ToString();
            txtCounty.Text = aVenue.getCounty().ToString();
            txtTown.Text = aVenue.getTown().ToString();
            txtStreet.Text = aVenue.getStreet().ToString();
            txtManagerName.Text = aVenue.getManagerName().ToString();
            txtManagerEmail.Text = aVenue.getManagerEmail().ToString();
            txtManagerMobile.Text = aVenue.getManagerMobile().ToString();
            txtMaxCapacity.Text = aVenue.getMaxCapacity().ToString();

            grpBox.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu parent = new frmMenu();
            this.Close();
            parent.Show();
            parent.Left = this.Left;
            parent.Top = this.Top;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this venue?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Venue myVenue = new Venue();
                myVenue.setVenueID(Convert.ToInt32(txtID.Text));
                myVenue.CancelVenue();
                MessageBox.Show("Venue Removed! (Set to unavailable)");
                grpBox.Visible = false;
                loadVenues();
            }
        }
    }
}