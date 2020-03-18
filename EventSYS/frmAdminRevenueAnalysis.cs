using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventSYS
{
    public partial class frmAdminRevenueAnalysis : Form
    {
        public frmAdminRevenueAnalysis()
        {
            InitializeComponent();

            cartesianChart1.Visible = false;
        }

        //Code to move the form - take from https://www.youtube.com/watch?v=S2kzd7iZVm4

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void frmAdminRevenueAnalysis_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void frmAdminRevenueAnalysis_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void frmAdminRevenueAnalysis_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            String year = cboYear.Text;

            txtRevenue.Text = Convert.ToString(Event.TotalRevenueYear(year));
            txtNoTicketsSold.Text = Convert.ToString(Event.TicketsSoldYear(year));
            txtNoEvents.Text = Convert.ToString(Event.eventsYear(year));

            cartesianChart1.Visible = true;

            //CAHRTS

            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            cartesianChart1.LegendLocation = LegendLocation.Right;

            cartesianChart1.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries

                {
                    Values = new ChartValues<ObservablePoint>
                    {
                       //Only pass in -MM- format
                       new ObservablePoint(1, Event.TotalRevenueYear("01/" + year)),
                       new ObservablePoint(2, Event.TotalRevenueYear("02/" + year)),
                       new ObservablePoint(3, Event.TotalRevenueYear("03/" + year)),
                       new ObservablePoint(4, Event.TotalRevenueYear("04/" + year)),
                       new ObservablePoint(5, Event.TotalRevenueYear("05/" + year)),
                       new ObservablePoint(6, Event.TotalRevenueYear("06/" + year)),
                       new ObservablePoint(7, Event.TotalRevenueYear("07/" + year)),
                       new ObservablePoint(8, Event.TotalRevenueYear("08/" + year)),
                       new ObservablePoint(9, Event.TotalRevenueYear("09/" + year)),
                       new ObservablePoint(10, Event.TotalRevenueYear("10/" + year)),
                       new ObservablePoint(11, Event.TotalRevenueYear("11/" + year)),
                       new ObservablePoint(12, Event.TotalRevenueYear("12/" + year))
                     },

                    PointGeometrySize = 10,
                   Title = "Revenue"
                },

                 new LineSeries

                {
                    Values = new ChartValues<ObservablePoint>
                    {
                       //Only pass in -MM- format
                       new ObservablePoint(1, Event.eventsYear("01/" + year)),
                       new ObservablePoint(2, Event.eventsYear("02/" + year)),
                       new ObservablePoint(3, Event.eventsYear("03/" + year)),
                       new ObservablePoint(4, Event.eventsYear("04/" + year)),
                       new ObservablePoint(5, Event.eventsYear("05/" + year)),
                       new ObservablePoint(6, Event.eventsYear("06/" + year)),
                       new ObservablePoint(7, Event.eventsYear("07/" + year)),
                       new ObservablePoint(8, Event.eventsYear("08/" + year)),
                       new ObservablePoint(9, Event.eventsYear("09/" + year)),
                       new ObservablePoint(10, Event.eventsYear("10/" + year)),
                       new ObservablePoint(11, Event.eventsYear("11/" + year)),
                       new ObservablePoint(12, Event.eventsYear("12/" + year))
                     },

                    PointGeometrySize = 10,
                   Title = "Events"
                },
                  new LineSeries

                {
                    Values = new ChartValues<ObservablePoint>
                    {
                       //Only pass in -MM- format
                       new ObservablePoint(1, Event.TicketsSoldYear("01/" + year)),
                       new ObservablePoint(2, Event.TicketsSoldYear("02/" + year)),
                       new ObservablePoint(3, Event.TicketsSoldYear("03/" + year)),
                       new ObservablePoint(4, Event.TicketsSoldYear("04/" + year)),
                       new ObservablePoint(5, Event.TicketsSoldYear("05/" + year)),
                       new ObservablePoint(6, Event.TicketsSoldYear("06/" + year)),
                       new ObservablePoint(7, Event.TicketsSoldYear("07/" + year)),
                       new ObservablePoint(8, Event.TicketsSoldYear("08/" + year)),
                       new ObservablePoint(9, Event.TicketsSoldYear("09/" + year)),
                       new ObservablePoint(10, Event.TicketsSoldYear("10/" + year)),
                       new ObservablePoint(11, Event.TicketsSoldYear("11/" + year)),
                       new ObservablePoint(12, Event.TicketsSoldYear("12/" + year))
                     },

                    PointGeometrySize = 10,
                   Title = "Tickets"
                }
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu parent = new frmMenu();
            this.Close();
            parent.Show();
            parent.Left = this.Left;
            parent.Top = this.Top;
        }
    }
}