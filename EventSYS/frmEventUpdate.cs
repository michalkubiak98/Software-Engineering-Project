using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmEventUpdate : Form
    {
        public frmEventUpdate()
        {
            InitializeComponent();
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void frmEventUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void frmEventUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void frmEventUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void frmEventUpdate_Load(object sender, EventArgs e)
        {
            grdUpdateEvent.DataSource = Event.getActiveEventsMini().Tables["aem"];
            grpBox.Visible = false;

            List<String> venues = Venue.fillVenueCombo();
            cboVenue.Items.AddRange(venues.ToArray());

            //Max Length of the Bunifu Custom TextBoxes
            //https://stackoverflow.com/questions/49424788/how-to-set-max-length-for-bunifu-net-ui-framework-text-box
            Utilities.BunifuMetro(txtTitle, 50);
            Utilities.BunifuMetro(txtDescription, 140);
            Utilities.BunifuMetro(txtTime, 5);
            Utilities.BunifuMetro(txtTicketsAvailable, 4);
            Utilities.BunifuMetro(txtPrice, 6);

            //https://stackoverflow.com/questions/49424788/how-to-set-max-length-for-bunifu-net-ui-framework-text-box
            grpBox.Paint += PaintBorderlessGroupBox;
        }

        //Group Box invisible on load
        //https://social.msdn.microsoft.com/Forums/windows/en-US/60767912-6ea4-4ff6-acb5-44002bd94e82/how-to-change-border-color-of-groupbox-in-cnet?forum=winforms
        public void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(SystemColors.Control);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.White, 0, 0);
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
            if (cboVenue.SelectedItem == null || txtTitle.Text == "" || txtTime.Text == "" ||
              txtTicketsAvailable.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("One or more fields have been left empty! Please enter all required details.", "Empty Field(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Confirm this information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    Event myEvent = new Event();

                    myEvent.setEventID(Convert.ToInt32(txtID.Text));
                    String name = Convert.ToString(cboVenue.SelectedItem);
                    myEvent.setVenueID(Venue.getIDFromName(name));
                    myEvent.setTitle(txtTitle.Text);
                    myEvent.setDescription(txtDescription.Text);
                    myEvent.setEventDate(dtpDate.Text);
                    myEvent.setEventTime(txtTime.Text);
                    myEvent.setTicketsAvailable(Convert.ToInt32(txtTicketsAvailable.Text));
                    myEvent.setPrice(Convert.ToDouble(txtPrice.Text));

                    myEvent.UpdateEvent();
                    MessageBox.Show("All Done!");
                    grdUpdateEvent.DataSource = Event.getActiveEventsMini().Tables["aem"];
                }
                catch (Oracle.ManagedDataAccess.Client.OracleException)
                {
                    MessageBox.Show("The price or time format you have entered is incorrect! " +
                        "Try and put a decimal point in the price (eg. 120.00) or a colon (:) in the time box!");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
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

        //TextBox input restrictions
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

        //Fetch Event Data from cell click
        private void grdUpdateEvent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Event myEvent = new Event();

            try
            {
                string strSno = grdUpdateEvent.Rows[grdUpdateEvent.CurrentCell.RowIndex].Cells[0].Value.ToString();
                myEvent.getAnEvent(Convert.ToInt32(strSno));
            }
            catch (ArgumentOutOfRangeException OoREx)
            {
                MessageBox.Show(OoREx.Message + "\n\n Row: " + grdUpdateEvent.CurrentCell.RowIndex);
            }

            txtID.Text = myEvent.getEventID().ToString();
            txtTitle.Text = myEvent.getTitle();
            txtDescription.Text = myEvent.getDescription();
            dtpDate.Value = Convert.ToDateTime(myEvent.getEventDate().ToString());
            txtTime.Text = myEvent.getEventTime();
            txtTicketsAvailable.Text = Convert.ToString(myEvent.getTicketsAvailable());
            txtPrice.Text = Convert.ToString(myEvent.getPrice());
            lblSelect.Visible = false;
            grpBox.Visible = true;
        }
    }
}