using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace EventSYS
{
    internal class Event
    {
        private int eventID;
        private int venueID;
        private String venueName;
        private String title;
        private String description;
        private String eventDate;
        private String eventTime;
        private int ticketsAvailable;
        private double price;
        private char status;

        //Constructor
        public Event(int eventID, int venueID, String venueName, String title, String description, String eventDate, String eventTime,
            int ticketsAvailable, double price, char status)
        {
            setEventID(eventID);
            setVenueID(venueID);
            setVenueName(venueName);
            setTitle(title);
            setDescription(description);
            setEventDate(eventDate);
            setEventTime(eventTime);
            setTicketsAvailable(ticketsAvailable);
            setPrice(price);
            setStatus(status);
        }

        public Event()
        {
            setEventID(0);
            setVenueID(0);
            setVenueName("Unknown");
            setTitle("Unknown");
            setDescription("Unknown");
            setEventDate("Unknown");
            setEventTime("Unknown");
            setTicketsAvailable(0);
            setPrice(0.00);
            setStatus('Y');
        }

        public int getEventID()
        {
            return eventID;
        }
        public int getVenueID()
        {
            return venueID;
        }
        public String getVenueName()
        {
            return venueName;
        }
        public String getTitle()
        {
            return title;
        }
        public String getDescription()
        {
            return description;
        }
        public String getEventDate()
        {
            return eventDate;
        }
        public String getEventTime()
        {
            return eventTime;
        }
        public int getTicketsAvailable()
        {
            return ticketsAvailable;
        }
        public double getPrice()
        {
            return price;
        }
        public char getStatus()
        {
            return status;
        }

        public void setEventID(int eventID)
        {
            this.eventID = eventID;
        }
        public void setVenueID(int venueID)
        {
            this.venueID = venueID;
        }
        public void setVenueName(String venueName)
        {
            this.venueName = venueName;
        }
        public void setTitle(String title)
        {
            this.title = title;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }
        public void setEventDate(String eventDate)
        {
            this.eventDate = eventDate;
        }
        public void setEventTime(String eventTime)
        {
            this.eventTime = eventTime;
        }
        public void setTicketsAvailable(int ticketsAvailable)
        {
            this.ticketsAvailable = ticketsAvailable;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setStatus(char status)
        {
            this.status = status;
        }


        //Methods
        public void AddEvent()
        {
            String sql = "INSERT INTO Events (eventID, venueID, venueName, title, description, eventDate, eventTime, ticketsAvailable, price, status) VALUES " + "(:eventID, :venueID, :venueName, :title, :description, :eventDate," + " :eventTime, :ticketsAvailable, :price, :status)";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("eventID",getEventID()),
                new OracleParameter("venueID",getVenueID()),
                new OracleParameter("venueName",getVenueName()),
                new OracleParameter("title",getTitle()),
                new OracleParameter("description",getDescription()),
                new OracleParameter("eventDate",getEventDate()),
                new OracleParameter("eventTime",getEventTime()),
                new OracleParameter("ticketsAvailable",getTicketsAvailable()),
                new OracleParameter("price",getPrice()),
                new OracleParameter("status",getStatus())
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateEvent()
        {
            String sql = "UPDATE Events SET eventID = :eventID, venueID = :venueID, venueName = :venueName, title = :title, description = :description, eventDate = :eventDate, eventTime = :eventTime, ticketsAvailable = :ticketsAvailable, price = :price, status = :status  WHERE eventID = :eventID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("eventID",getEventID()),
                new OracleParameter("venueID",getVenueID()),
                new OracleParameter("venueName",getVenueName()),
                new OracleParameter("title",getTitle()),
                new OracleParameter("description",getDescription()),
                new OracleParameter("eventDate",getEventDate()),
                new OracleParameter("eventTime",getEventTime()),
                new OracleParameter("ticketsAvailable",getTicketsAvailable()),
                new OracleParameter("price",getPrice()),
                new OracleParameter("status",getStatus())
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void CancelEvent()
        {
            String SQL = "UPDATE BOOKINGS SET status = :status where EventID = :eventID";

            OracleConnection connn = new OracleConnection(DBConnect.oradb);
            connn.Open();
            OracleCommand cmdd = new OracleCommand(SQL, connn);

            OracleParameter[] parameterss = new OracleParameter[] {
                new OracleParameter("eventID", getEventID())
            };

            cmdd.Parameters.AddRange(parameterss);
            cmdd.ExecuteNonQuery();
            connn.Close();

            String strSQL = "UPDATE Events SET status = :status WHERE EventID = :EventID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("status", 'N'),
                new OracleParameter("EventID", this.getEventID())
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void CancelEventID(int ID)
        {
            String SQL = "UPDATE BOOKINGS SET status = :status where EventID = '" + ID + "'";

            OracleConnection connn = new OracleConnection(DBConnect.oradb);
            connn.Open();
            OracleCommand cmdd = new OracleCommand(SQL, connn);

            OracleParameter[] parameterss = new OracleParameter[] {
                new OracleParameter("status", "N")
            };

            cmdd.Parameters.AddRange(parameterss);
            cmdd.ExecuteNonQuery();
            connn.Close();

            String strSQL = "UPDATE Events SET status = :status WHERE EventID = :EventID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("status", 'N'),
                new OracleParameter("EventID", ID)
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static int getNextID()
        {
            String strSQL = "SELECT MAX(eventID) From Events";

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

        public static DataSet getAllEvents()
        {
            String strSQL = "Select * From Events Order By EventID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "evs");
            conn.Close();
            return ds;
        }

        public static DataSet getActiveEvents()
        {
            String strSQL = "Select * From Events WHERE Status = 'Y' and  EventDate >= (Select TO_CHAR(SYSDATE, 'YYYY-MM-DD') from dual)";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "ae");
            conn.Close();
            return ds;
        }

        public static DataSet getActiveEventsMini()
        {
            String strSQL = "Select EventID, VenueName, Title, Description, EventDate, EventTime, TicketsAvailable, Price From Events WHERE Status = 'Y' and  EventDate >= (Select TO_CHAR(SYSDATE, 'YYYY-MM-DD') from dual)";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "aem");
            conn.Close();
            return ds;
        }

        public void getAnEvent(int id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "Select * From Events Where EventID = " + id;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            this.eventID = dr.GetInt32(0);
            this.venueID = dr.GetInt32(1);
            this.venueName = dr.GetString(2);
            this.title = dr.GetString(3);
            this.description = dr.GetString(4);
            this.eventDate = dr.GetString(5);
            this.eventTime = dr.GetString(6);
            this.ticketsAvailable = dr.GetInt32(7);
            this.price = dr.GetDouble(8);
        }

        public static int getIDFromName(String name)
        {
            String strSQL = "SELECT EventID From Events WHERE title = '" + name + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            return dr.GetInt32(0);
        }

        public static Boolean checkEventTitle(String title, int venueID)
        {
            Boolean answer = false;

            String strSQL = "Select * From Events WHERE title = '" + title + "' and venueID = '" + venueID + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                answer = true;
            }

            conn.Close();
            return answer;
        }

        public static List<String> fillEventCombo()
        {
            string strSQL = "SELECT title FROM Events WHERE status = 'Y' and eventDate > TO_CHAR(SYSDATE, 'DD/MM/YYYYY')";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();

            List<String> items = new List<String>();

            using (OracleDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    items.Add(dr.GetString(0));
                }
            }

            return items;
        }

        public static double getPrice(String title, String venue)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "Select price From Events Where title = '" + title + "' and venueName = '" + venue + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            return dr.GetDouble(0);
        }

        public static int getTickets(int id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "Select ticketsAvailable From Events Where eventID = '" + id + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            return dr.GetInt32(0);
        }

        public Boolean isVenueFree(String date)
        {
            Venue ven = new Venue();
            ven.setVenueID(this.venueID);

            String sql = "SELECT COUNT(E.VENUEID) From Events E Join Venues V ON E.VenueID = V.VenueID WHERE EventDate =  '" + date + "' AND E.VenueID = '" + this.getVenueID() + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            Boolean result = false;

            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int nxt = reader.GetInt32(0);

                    if (nxt == 0)
                    {
                        result = true;
                    }
                    else if (nxt >= 1)
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        public static String noEvents(String date, int id)
        {
            int result = 0;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "Select Count(EventID) From Events Where eventDate like  '" + date + "%' and VenueID = '" + id + "'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.IsDBNull(0))
            {
                return "No results found!";
            }
            else
            {
                result = dr.GetInt32(0);
                return Convert.ToString(result);
            }
        }

        public static String noTicketsSold(String date, int id)
        {
            int result = 0;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT SUM(NoTickets) FROM Bookings B JOIN Events E ON B.EventID = E.EventID WHERE VenueID =" + id + " AND BOOKINGDATE LIKE '" + date + "%'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.IsDBNull(0))
            {
                return "No results found!";
            }
            else
            {
                result = dr.GetInt32(0);
                return Convert.ToString(result);
            }
        }

        public static String totalRevenue(String date, int id)
        {
            double result = 0.00;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();


            
            String strSQL = "SELECT SUM(BookingTotal) FROM Bookings B JOIN Events E ON B.EventID = E.EventID WHERE VenueID =" + id + " AND BOOKINGDATE LIKE '" + date + "%'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.IsDBNull(0))
            {
                return "No results found!";
            }
            else
            {
                result = dr.GetInt32(0);
                return Convert.ToString(result);
            }
        }
        
        public static double TotalRevenueYear(String date)
        {
            double result = 0.00;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT SUM(BookingTotal) FROM Bookings B JOIN Events E ON B.EventID = E.EventID WHERE BOOKINGDATE LIKE '" + date + "%'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //Could have returned a String saying no results
            if (dr.IsDBNull(0))
            {
                return 0.00;
            }
            else
            {
                result = dr.GetDouble(0);
                return result;
            }
        }

        public static int TicketsSoldYear(String date)
        {
            int result = 0;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "SELECT SUM(NoTickets) FROM Bookings WHERE BOOKINGDATE LIKE '" + date + "%'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //Could have returned a String saying no results

            if (dr.IsDBNull(0))
            {
                return 0;
            }
            else
            {
                result = dr.GetInt32(0);
                return result;
            }
        }

        public static int eventsYear(String date)
        {
            int result = 0;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "Select Count(EventID) From Events Where eventDate like  '" + date + "%'";

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();


            //Could have returned a String saying no results
            if (dr.IsDBNull(0))
            {
                return 0;
            }
            else
            {
                result = dr.GetInt32(0);
                return result;
            }
        }
    }
}