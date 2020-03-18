using Oracle.ManagedDataAccess.Client;
using System;

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

        public Booking(int bookingID, int custID, int eventID, String bookingDate, int noTickets, double bookingTotal)
        {
            setBookingID(bookingID);
            setCustID(custID);
            setEventID(eventID);
            setBookingDate(bookingDate);
            setNoTickets(noTickets);
            setBookingTotal(bookingTotal);
        }

        public Booking()
        {
            setBookingID(0);
            setCustID(0);
            setEventID(0);
            setBookingDate("Unknown");
            setNoTickets(0);
            setBookingTotal(0.00);
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

            String sqll = "INSERT INTO Bookings (bookingID, custID, eventID, bookingDate, noTickets, bookingTotal) VALUES " + "(:bookingID, :custID, :eventID, :bookingDate, :noTickets, :bookingTotal)";

            OracleConnection connn = new OracleConnection(DBConnect.oradb);
            connn.Open();
            OracleCommand cmdd = new OracleCommand(sqll, connn);

            OracleParameter[] parameterss = new OracleParameter[] {
                new OracleParameter("bookingID",getBookingID()),
                new OracleParameter("custID",getCustID()),
                new OracleParameter("eventID",getEventID()),
                new OracleParameter("bookingDate",getBookingDate()),
                new OracleParameter("noTickets",getNoTickets()),
                new OracleParameter("bookingTotal",getBookingTotal())
            };

            cmdd.Parameters.AddRange(parameterss);
            cmdd.ExecuteNonQuery();
            connn.Close();
        }

        public void UpdateBooking()
        {
            String sql = "UPDATE Bookings SET bookingID = :bookingID, custID = :custID, eventID = :eventID, bookingDate = :bookingDate, noTickets = :noTickets, bookingTotal = :bookingTotal WHERE bookingID = :bookingID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("bookingID",getBookingID()),
                new OracleParameter("custID",getCustID()),
                new OracleParameter("eventID",getEventID()),
                new OracleParameter("bookingDate",getBookingDate()),
                new OracleParameter("noTickets",getNoTickets()),
                new OracleParameter("bookingTotal",getBookingTotal())
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void CancelBooking()
        {
            int tickets = Event.getTickets(this.eventID);

            String sql = "UPDATE Events SET ticketsAvailable = :ticketsAvailable WHERE eventID = :eventID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("ticketsAvailable",tickets + this.noTickets),
                new OracleParameter("eventID",getEventID())
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();

            String strSQL = "DELETE FROM BOOKINGS WHERE WHERE bookingID = :BookingID";

            OracleConnection connn = new OracleConnection(DBConnect.oradb);
            connn.Open();
            OracleCommand cmdd = new OracleCommand(strSQL, connn);

            OracleParameter[] parameterss = new OracleParameter[] {
                new OracleParameter("bookingID", getBookingID())
            };

            cmdd.Parameters.AddRange(parameterss);
            cmdd.ExecuteNonQuery();
            connn.Close();
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
                while (reader.Read())
                {
                    nxt = reader.GetInt32(0) + 1;
                }
            }

            conn.Close();
            return nxt;
        }
    }
}