using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmVenueAdd : Form
    {
        //Find out how to close the menu after hiding it without Application.Run crashing or making a new instance of the form

        public frmVenueAdd()
        {
            InitializeComponent();
        }

        private void frmVenueAdd_Load(object sender, EventArgs e)
        {
            txtID.Text = Convert.ToString(Venue.getNextID());
            grdAddVenue.DataSource = Venue.getActiveVenuesMini().Tables["avm"];

            Utilities.BunifuMetro(txtName, 80);
            Utilities.BunifuMetro(txtStreet, 30);
            Utilities.BunifuMetro(txtTown, 30);
            Utilities.BunifuMetro(txtCounty, 30);
            Utilities.BunifuMetro(txtManagerName, 50);
            Utilities.BunifuMetro(txtManagerEmail, 60);
            Utilities.BunifuMetro(txtManagerMobile, 20);
            Utilities.BunifuMetro(txtMaxCapacity, 5);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMenu parent = new frmMenu();
            this.Hide();
            parent.Show();
            parent.Left = this.Left;
            parent.Top = this.Top;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4
        private bool _dragging = false;

        private Point _start_point = new Point(0, 0);

        private void frmVenueAdd_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmVenueAdd_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmVenueAdd_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtManagerEmail.Text.Equals("") || txtName.Text.Equals("") || txtStreet.Text.Equals("") || txtTown.Text.Equals("") ||
                txtCounty.Text.Equals("") || txtManagerName.Text.Equals("") || txtManagerMobile.Text.Equals("") || txtMaxCapacity.Text.Equals(""))
            {
                MessageBox.Show("One or more fields have been left empty! Please enter all required details.", "Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            DialogResult dialogResult = MessageBox.Show("Confirm this information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (Utilities.IsValid(txtManagerEmail.Text))
                {
                    if (!Venue.checkVenueName(txtName.Text))
                    {
                        Venue myVenue = new Venue();

                        myVenue.setVenueID(Convert.ToInt32(txtID.Text));
                        myVenue.setVenueName(txtName.Text);
                        myVenue.setStreet(txtStreet.Text);
                        myVenue.setTown(txtTown.Text);
                        myVenue.setCounty(txtCounty.Text);
                        myVenue.setManagerName(txtManagerName.Text);
                        myVenue.setManagerEmail(txtManagerEmail.Text);
                        myVenue.setManagerMobile(txtManagerMobile.Text);
                        myVenue.setMaxCapacity(Convert.ToInt32(txtMaxCapacity.Text));

                        myVenue.AddVenue();
                        MessageBox.Show("All Done!");
                        grdAddVenue.DataSource = Venue.getActiveVenuesMini().Tables["avm"];
                    }
                    else
                    {
                        MessageBox.Show("Venue with this name already exists.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Email format not valid.");
                    return;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Reset Fields?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                txtName.Text = "";
                txtTown.Text = "";
                txtStreet.Text = "";
                txtCounty.Text = "";
                txtManagerName.Text = "";
                txtManagerEmail.Text = "";
                txtManagerMobile.Text = "";
                txtMaxCapacity.Text = "";
            }
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

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
        }
    }
}