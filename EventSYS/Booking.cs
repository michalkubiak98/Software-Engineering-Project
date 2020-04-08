using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace EventSYS
{
    internal class Booking
    {
        private int bookingID;
        private int custID;
        private int eventID;
        private String bookingDate;
        private int noTickets;
        private double bookingTotal;
        private char status;
        
        //Constructor
        public Booking(int bookingID, int custID, int eventID, String bookingDate, int noTickets, double bookingTotal, char status)
        {
            setBookingID(bookingID);
            setCustID(custID);
            setEventID(eventID);
            setBookingDate(bookingDate);
            setNoTickets(noTickets);
            setBookingTotal(bookingTotal);
            setStatus(status);
        }
        public Booking()
        {
            setBookingID(0);
            setCustID(0);
            setEventID(0);
            setBookingDate("unknown");
            setNoTickets(0);
            setBookingTotal(0.00);
            setStatus('Y');
        }

        public int getBookingID()
        {
            return bookingID;
        }
        public int getCustID()
        {
            return custID;
        }
        public int getEventID()
        {
            return eventID;
        }
        public String getBookingDate()
        {
            return bookingDate;
        }
        public int getNoTickets()
        {
            return noTickets;
        }
        public double getBookingTotal()
        {
            return bookingTotal;
        }
        public char getStatus()
        {
            return status;
        }

        public void setBookingID(int bookingID)
        {
            this.bookingID = bookingID;
        }
        public void setCustID(int custID)
        {
            this.custID = custID;
        }
        public void setEventID(int eventID)
        {
            this.eventID = eventID;
        }
        public void setBookingDate(String bookingDate)
        {
            this.bookingDate = bookingDate;
        }
        public void setNoTickets(int noTickets)
        {
            this.noTickets = noTickets;
        }
        public void setBookingTotal(double bookingTotal)
        {
            this.bookingTotal = bookingTotal;
        }
        public void setStatus(char status)
        {
            this.status = status;
        }


        //Methods
        public void AddBooking()
        {
            int tickets = Event.getTickets(this.eventID);

            String sql = "UPDATE Events SET ticketsAvailable = :ticketsAvailable WHERE eventID = :eventID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("ticketsAvailable",tickets - this.noTickets),
                new OracleParameter("eventID",getEventID())
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();
            
            //---------------------------------------------------------------------

            String sqll = "INSERT INTO Bookings (bookingID, custID, eventID, bookingDate, noTickets, bookingTotal, status) VALUES " + "(:bookingID, :custID, :eventID, :bookingDate, :noTickets, :bookingTotal, :status)";

            OracleConnection connn = new OracleConnection(DBConnect.oradb);
            connn.Open();
            OracleCommand cmdd = new OracleCommand(sqll, connn);

            OracleParameter[] parameterss = new OracleParameter[] {
                new OracleParameter("bookingID", getNextID()),
                new OracleParameter("custID",getCustID()),
                new OracleParameter("eventID",getEventID()),
                new OracleParameter("bookingDate",getBookingDate()),
                new OracleParameter("noTickets",getNoTickets()),
                 new OracleParameter("bookingTotal",getBookingTotal()),
                new OracleParameter("status",'Y')
            };

            cmdd.Parameters.AddRange(parameterss);
            cmdd.ExecuteNonQuery();
            connn.Close();
        }

        public void CancelBooking()
        {
            int tickets = Event.getTickets(this.eventID);

            String sql = "UPDATE Events SET ticketsAvailable = :ticketsAvailable WHERE eventID = :eventID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("ticketsAvailable",tickets - this.noTickets),
                new OracleParameter("eventID",getEventID())
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();

            //-----------------------------------------------------------------------------------------

            String sql2 = "UPDATE Bookings SET status = 'N' WHERE bookingID = :bookingID";

            OracleConnection conn2 = new OracleConnection(DBConnect.oradb);
            conn2.Open();
            OracleCommand cmd2 = new OracleCommand(sql2, conn2);

            OracleParameter[] parameters2 = new OracleParameter[] {
                new OracleParameter("bookingID",getBookingID())
            };

            cmd2.Parameters.AddRange(parameters2);
            cmd2.ExecuteNonQuery();
            conn2.Close();
        }

        public static int getNextID()
        {
            String strSQL = "SELECT MAX(bookingID) From Bookings";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            int nxt = 0;
            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                try
                {
                    nxt = reader.GetInt32(0) + 1;
                }
                catch
                {
                    nxt = 1;
                }
            }

            conn.Close();
            return nxt;
        }

        public static DataSet getActiveBookings(int id)
        {
            String strSQL = "Select Bookings.bookingID as ID, Events.Title, Venues.VenueName as Venue, Venues.Town, Events.EventDate, Events.EventTime as Time, Bookings.NoTickets as Tickets, Bookings.BookingTotal as Total  From Venues, Events, Bookings  where Venues.VenueID = Events.VenueID  and Events.EventID = Bookings.EventID and Bookings.CustID = '" + id + "' and Bookings.Status = 'Y' and Events.Status = 'Y' and Venues.Status = 'Y'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "ab");
            conn.Close();
            return ds;
        }

        public static int getIDfromEmail(String email)
        {
            String strSQL = "Select CustID from Customers where email = '" + email + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            return dr.GetInt32(0);
        }

        public void getABooking(int id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "Select * From Bookings Where BookingID = " + id;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            this.bookingID = dr.GetInt32(0);
            this.custID = dr.GetInt32(1);
            this.eventID = dr.GetInt32(2);
            this.bookingDate = dr.GetString(3);
            this.noTickets = dr.GetInt32(4);
            this.bookingTotal = dr.GetDouble(5);
        }
    }
}