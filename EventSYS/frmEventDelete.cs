using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmEventDelete : Form
    {
        public frmEventDelete()
        {
            InitializeComponent();
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4
        private bool _dragging = false;

        private Point _start_point = new Point(0, 0);

        private void frmEventDelete_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmEventDelete_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmEventDelete_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void frmEventDelete_Load(object sender, EventArgs e)
        {
            loadEvents();
        }

       

        public void loadEvents()
        {
            DataSet ds = new DataSet();
            ds = Event.getActiveEvents();

            cboEvents.Items.Clear();
            //load combo box
            for (int i = 0; i < ds.Tables["ae"].Rows.Count; i++)
            {
                cboEvents.Items.Add(ds.Tables[0].Rows[i][3].ToString());
                
            }
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this venue?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Event myEvent = new Event();
                myEvent.setEventID(Convert.ToInt32(txtID.Text));
                myEvent.CancelEvent();
                MessageBox.Show("Event Removed! (Set to unavailable)");
                grpBox.Visible = false;
                loadEvents();
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

        private void cboEvents_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboEvents.SelectedIndex == -1)
            {
                return;
            }

            Event anEvent = new Event();
            anEvent.getAnEvent(Event.getIDFromName(cboEvents.Text));

            txtID.Text = anEvent.getEventID().ToString();
            txtVenue.Text = anEvent.getVenueName().ToString();
            txtTitle.Text = anEvent.getTitle().ToString();
            txtDescription.Text = anEvent.getDescription().ToString();
            txtDate.Text = anEvent.getEventDate().ToString();
            txtTime.Text = anEvent.getEventTime().ToString();
            txtTickets.Text = anEvent.getTicketsAvailable().ToString();
            txtPrice.Text = anEvent.getPrice().ToString();

            grpBox.Visible = true;
        }
    }
}