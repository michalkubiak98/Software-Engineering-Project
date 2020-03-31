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


        //Slider https://www.youtube.com/watch?v=Ie09lhMEczU

        private int imageNumber = 1;

        private void loadImage()
        {
            if(imageNumber == 5){
                imageNumber = 1;
            }

            pctBox.ImageLocation = string.Format(@"..\..\Resources\{0}.png", imageNumber);
            imageNumber++;

          
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

   
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadImage();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            if (txtEmail.Equals("") || txtEmail.Equals(""))
            {
                MessageBox.Show("Please enter username and password");

                return;
            }

            if (Customer.checkEmail(txtEmail.Text))
            {
                if (Customer.checkPass(txtEmail.Text, txtEmail.Text))
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignUp nextForm = new frmSignUp();
            nextForm.Show();
            nextForm.Left = this.Left;
            nextForm.Top = this.Top;
        }
    }
}