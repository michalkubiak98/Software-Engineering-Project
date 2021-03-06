﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        //Slider https://www.youtube.com/watch?v=Ie09lhMEczU
        private int imageNumber = 1;
        public static int CustomerID;
        public static bool admin = false;

        private void loadImage()
        {
            if (imageNumber == 5)
            {
                imageNumber = 1;
            }

            pctBox.ImageLocation = string.Format(@"..\..\Resources\{0}.png", imageNumber);
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadImage();
        }
        
        //Switch to Sign Up
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignUp nextForm = new frmSignUp();
            nextForm.Show();
            nextForm.Left = this.Left;
            nextForm.Top = this.Top;
        }
        //Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        //Move form methods for panel on the right and picture box on the left
        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private void pnlSide_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void pnlSide_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void pnlSide_MouseUp(object sender, MouseEventArgs e)
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


        //Log In and Validation
        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter username and password");

                return;
            }

            if (txtEmail.Text == "admin" && txtPassword.Text == "admin")
            {
                btnLogIn.Enabled = false;
                admin = true;
                this.Close();
                frmMenuAdmin nextForm = new frmMenuAdmin();
                nextForm.Show();
                nextForm.Left = this.Left;
                nextForm.Top = this.Top;
            }
            else if (Customer.checkEmail(txtEmail.Text))
            {
                if (Customer.checkPass(txtPassword.Text, txtEmail.Text))
                {
                    btnLogIn.Enabled = false;

                    CustomerID = Customer.getCustIDFromEmail(txtEmail.Text);

                    admin = false;
                    this.Close();

                    frmMenuCustomer nextForm = new frmMenuCustomer();

                    nextForm.Show();

                    nextForm.Left = this.Left;
                    nextForm.Top = this.Top;
                }
                else
                {
                    MessageBox.Show("Password is incorrect");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Email does not exist, please sign up!");
                return;
            }
        }

     
    }
}