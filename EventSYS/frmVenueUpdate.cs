using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmVenueUpdate : Form
    {
        public frmVenueUpdate()
        {
            InitializeComponent();
        }

        private void frmVenueUpdt_Load(object sender, EventArgs e)
        {
            grdVenues.DataSource = Venue.getActiveVenuesMini().Tables["avm"];
            grpBox.Visible = false;

            //https://stackoverflow.com/questions/49424788/how-to-set-max-length-for-bunifu-net-ui-framework-text-box
            grpBox.Paint += PaintBorderlessGroupBox;

            Utilities.BunifuMetro(txtName, 80);
            Utilities.BunifuMetro(txtStreet, 30);
            Utilities.BunifuMetro(txtTown, 30);
            Utilities.BunifuMetro(txtCounty, 30);
            Utilities.BunifuMetro(txtManagerName, 50);
            Utilities.BunifuMetro(txtManagerEmail, 60);
            Utilities.BunifuMetro(txtManagerMobile, 20);
            Utilities.BunifuMetro(txtMaxCapacity, 5);
        }

        public void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(SystemColors.Control);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.White, 0, 0);
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4
        private bool _dragging = false;

        private Point _start_point = new Point(0, 0);

        private void frmVenueUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmVenueUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmVenueUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void grdVenues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Venue ven = new Venue();

            try
            {
                string strSno = grdVenues.Rows[grdVenues.CurrentCell.RowIndex].Cells[0].Value.ToString();
                ven.getAVenue(Convert.ToInt32(strSno));
            }
            catch (ArgumentOutOfRangeException OoREx)
            {
                MessageBox.Show(OoREx.Message + "\n\n Row: " + grdVenues.CurrentCell.RowIndex);
            }

            //load venues details onto form

            txtID.Text = ven.getVenueID().ToString();
            txtName.Text = ven.getVenueName();
            txtStreet.Text = ven.getStreet();
            txtTown.Text = ven.getTown();
            txtCounty.Text = ven.getCounty();
            txtManagerName.Text = ven.getManagerName();
            txtManagerEmail.Text = ven.getManagerEmail();
            txtManagerMobile.Text = ven.getManagerMobile();
            txtMaxCapacity.Text = ven.getMaxCapacity().ToString();
            grpBox.Visible = true;
            lblSelect.Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm this information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Venue myVenue = new Venue();

                myVenue.setVenueID(Convert.ToInt32(txtID.Text));
                myVenue.setVenueName(txtName.Text);
                myVenue.setStreet(txtStreet.Text);
                myVenue.setCounty(txtCounty.Text);
                myVenue.setManagerName(txtManagerName.Text);
                myVenue.setManagerEmail(txtManagerEmail.Text);
                myVenue.setManagerMobile(txtManagerMobile.Text);
                myVenue.setMaxCapacity(Convert.ToInt32(txtMaxCapacity.Text));

                myVenue.UpdateVenue();

                MessageBox.Show("All Done!");
                grdVenues.DataSource = Venue.getActiveVenuesMini().Tables["avm"];
            }
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtTown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtCounty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtMaxCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtManagerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtManagerEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtManagerMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
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
            this.Hide();
            parent.Show();
            parent.Left = this.Left;
            parent.Top = this.Top;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
        }
    }
}