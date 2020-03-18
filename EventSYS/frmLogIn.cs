using System;
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

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4
        private bool _dragging = false;

        private Point _start_point = new Point(0, 0);

        private void frmLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmLogIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmLogIn_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
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
                    this.Hide();
                    frmMenu nextForm = new frmMenu();
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
                MessageBox.Show("Are you sure you want to exit?");
                return;
            }
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmSignUp nextForm = new frmSignUp();
            nextForm.Show();
            nextForm.Left = this.Left;
            nextForm.Top = this.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}