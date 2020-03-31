using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmBookingsMy : Form
    {
        private frmMenu parent = new frmMenu();

        public frmBookingsMy()
        {
            InitializeComponent();
        }

        public frmBookingsMy(frmMenu Parent)
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

        

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (txtEmail.Equals("") || txtPassword.Equals(""))
            {
                MessageBox.Show("Please enter username and password");

                return;
            }

            if (Customer.checkEmail(txtEmail.Text))
            {
                if (Customer.checkPass(txtPassword.Text, txtEmail.Text))
                {

                    grdBooking.Visible = true;

                    grdBooking.DataSource = Booking.getActiveBookings(Booking.getIDfromEmail(txtEmail.Text)).Tables["ab"];
                    
                    lblEmail.Visible = false;
                    lblPassword.Visible = false;
                    txtEmail.Visible = false;
                    txtPassword.Visible = false;
                    btnConfirm.Visible = false;

                }
                else
                {
                    MessageBox.Show("Password is incorrect");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Are you sure you want to exit?");
                return;
            }
        }

        private void frmBookingsMy_Load(object sender, EventArgs e)
        {
            grdBooking.Visible = false;
        }

        private void grdBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Booking booking = new Booking();

            try
            {
                string strSno = grdBooking.Rows[grdBooking.CurrentCell.RowIndex].Cells[0].Value.ToString();
                booking.getABooking(Convert.ToInt32(strSno));
            }
            catch (ArgumentOutOfRangeException OoREx)
            {
                MessageBox.Show(OoREx.Message + "\n\n Row: " + grdBooking.CurrentCell.RowIndex);
            }

            //load venues details onto form
            /*
            lblEuro.Text = ven.getVenueID().ToString();
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
    */    
    }
    }
}