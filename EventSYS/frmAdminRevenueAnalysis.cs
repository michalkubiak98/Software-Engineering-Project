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
                       
                       new ObservablePoint(1, Event.TotalRevenueYear(year + "-01")),
                       new ObservablePoint(2, Event.TotalRevenueYear(year + "-02")),
                       new ObservablePoint(3, Event.TotalRevenueYear(year + "-03")),
                       new ObservablePoint(4, Event.TotalRevenueYear(year + "-04")),
                       new ObservablePoint(5, Event.TotalRevenueYear(year + "-05")),
                       new ObservablePoint(6, Event.TotalRevenueYear(year + "-06")),
                       new ObservablePoint(7, Event.TotalRevenueYear(year + "-07")),
                       new ObservablePoint(8, Event.TotalRevenueYear(year + "-08")),
                       new ObservablePoint(9, Event.TotalRevenueYear(year + "-09")),
                       new ObservablePoint(10, Event.TotalRevenueYear(year + "-10")),
                       new ObservablePoint(11, Event.TotalRevenueYear(year + "-11")),
                       new ObservablePoint(12, Event.TotalRevenueYear(year + "-12"))
                     },

                    PointGeometrySize = 10,
                   Title = "Revenue"
                },

                 new LineSeries

                {
                    Values = new ChartValues<ObservablePoint>
                    {
                       //Only pass in -MM- format
                       new ObservablePoint(1, Event.eventsYear(year + "-01")),
                       new ObservablePoint(2, Event.eventsYear(year + "-02")),
                       new ObservablePoint(3, Event.eventsYear(year + "-03")),
                       new ObservablePoint(4, Event.eventsYear(year + "-04")),
                       new ObservablePoint(5, Event.eventsYear(year + "-05")),
                       new ObservablePoint(6, Event.eventsYear(year + "-06")),
                       new ObservablePoint(7, Event.eventsYear(year + "-07")),
                       new ObservablePoint(8, Event.eventsYear(year + "-08")),
                       new ObservablePoint(9, Event.eventsYear(year + "-09")),
                       new ObservablePoint(10, Event.eventsYear(year + "-10")),
                       new ObservablePoint(11, Event.eventsYear(year + "-11")),
                       new ObservablePoint(12, Event.eventsYear(year + "-12"))
                    
                     },

                    PointGeometrySize = 10,
                   Title = "Events"
                },
                  new LineSeries

                {
                    Values = new ChartValues<ObservablePoint>
                    {
                       //Only pass in -MM- format
                       
                       new ObservablePoint(1, Event.TicketsSoldYear(year + "-01")),
                       new ObservablePoint(2, Event.TicketsSoldYear(year + "-02")),
                       new ObservablePoint(3, Event.TicketsSoldYear(year + "-03")),
                       new ObservablePoint(4, Event.TicketsSoldYear(year + "-04")),
                       new ObservablePoint(5, Event.TicketsSoldYear(year + "-05")),
                       new ObservablePoint(6, Event.TicketsSoldYear(year + "-06")),
                       new ObservablePoint(7, Event.TicketsSoldYear(year + "-07")),
                       new ObservablePoint(8, Event.TicketsSoldYear(year + "-08")),
                       new ObservablePoint(9, Event.TicketsSoldYear(year + "-09")),
                       new ObservablePoint(10, Event.TicketsSoldYear(year + "-10")),
                       new ObservablePoint(11, Event.TicketsSoldYear(year + "-11")),
                       new ObservablePoint(12, Event.TicketsSoldYear(year + "-12"))
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