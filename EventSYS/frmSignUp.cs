using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4 x

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);


        private void timer1_Tick(object sender, EventArgs e)
        {
            loadImage();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void pctBox_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void pctBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void pctBox_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        private int imageNumber = 1;

        private void loadImage()
        {
            if (imageNumber == 4)
            {
                imageNumber = 1;
            }

            pctBox.ImageLocation = string.Format(@"..\..\Resources\{0}.jpg", imageNumber);
            imageNumber++;
        }

 
        

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn nextForm = new frmLogIn();
            nextForm.Show();
            nextForm.Left = this.Left;
            nextForm.Top = this.Top;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("") || txtPassword.Text.Equals("") || txtConfirmPassword.Text.Equals("") || txtEmail.Text.Equals("") || txtContact.Text.Equals(""))
            {
                MessageBox.Show("Fill Out All Details!");
                txtName.Focus();
                return;
            }

            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Passwords Not Matching");
                txtConfirmPassword.Focus();
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Confirm this information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Check if cust with same email already exists
            if (!Customer.checkEmail(txtEmail.Text))
            {
                if (chkTerms.Checked)
                {
                    if (Customer.checkEmail(txtEmail.Text))
                    {
                        Customer cust = new Customer();

                        cust.setCustID(Customer.getNextID());
                        cust.setForename(txtName.Text);
                        cust.setSurname(txtSurname.Text);
                        cust.setEmail(txtEmail.Text);
                        cust.setPassword(txtPassword.Text);
                        cust.setContactNo(txtContact.Text);

                        cust.AddCustomer();

                        MessageBox.Show("Your account has been created! Proceeding to the log in page!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.Hide();
                        frmLogIn nextForm = new frmLogIn();
                        nextForm.Show();
                        nextForm.Left = this.Left;
                        nextForm.Top = this.Top;
                    }
                    else
                    {
                        MessageBox.Show("Email Not Valid");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Check Terms & Conditions");
                    chkTerms.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Email Already Taken");
                return;
            }
        }


    }
}