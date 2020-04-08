using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace EventSYS
{
    internal class Venue
    {
        private int venueID;
        private String venueName;
        private String street;
        private String town;
        private String county;
        private String managerName;
        private String managerEmail;
        private String managerMobile;
        private char status;
        private int maxCapacity;

        public Venue(int venueID, String venueName, String street, String town, String county, String managerName, String managerEmail, String managerMobile, char status, int maxCapacity)
        {
            setVenueID(venueID);
            setVenueName(venueName);
            setStreet(street);
            setTown(town);
            setCounty(county);
            setManagerName(managerName);
            setManagerEmail(managerEmail);
            setManagerMobile(managerMobile);
            setStatus(status);
            setMaxCapacity(maxCapacity);
        }

        public Venue()
        {
            setVenueID(0);
            setVenueName("Unknown");
            setStreet("Unknown");
            setTown("Unknown");
            setCounty("Unknown");
            setManagerName("Unknown");
            setManagerEmail("Unknown");
            setManagerMobile("Unknown");
            setStatus('Y');
            setMaxCapacity(0);
        }

        public int getVenueID()
        {
            return venueID;
        }
        public String getVenueName()
        {
            return venueName;
        }
        public String getStreet()
        {
            return street;
        }
        public String getTown()
        {
            return town;
        }
        public String getCounty()
        {
            return county;
        }
        public String getManagerName()
        {
            return managerName;
        }
        public String getManagerEmail()
        {
            return managerEmail;
        }
        public String getManagerMobile()
        {
            return managerMobile;
        }
        public char getStatus()
        {
            return status;
        }
        public int getMaxCapacity()
        {
            return maxCapacity;
        }

        public void setVenueID(int venueID)
        {
            this.venueID = venueID;
        }
        public void setVenueName(String venueName)
        {
            this.venueName = venueName;
        }
        public void setStreet(String street)
        {
            this.street = street;
        }
        public void setTown(String town)
        {
            this.town = town;
        }
        public void setCounty(String county)
        {
            this.county = county;
        }
        public void setManagerName(String managerName)
        {
            this.managerName = managerName;
        }
        public void setManagerEmail(String managerEmail)
        {
            this.managerEmail = managerEmail;
        }
        public void setManagerMobile(String managerMobile)
        {
            this.managerMobile = managerMobile;
        }
        public void setStatus(char status)
        {
            this.status = status;
        }
        public void setMaxCapacity(int maxCapacity)
        {
            this.maxCapacity = maxCapacity;
        }



        public void AddVenue()
        {
            String sql = "INSERT INTO Venues (venueID, venueName, street, town, county, managerName, managerEmail, managerMobile, maxCapacity) VALUES " + "(:venueID, :venueName, :street, :town, :county, :managerName, :managerEmail, :managerMobile, :maxCapacity)";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("venueID",getVenueID()),
                new OracleParameter("venueName",getVenueName()),
                new OracleParameter("street",getStreet()),
                new OracleParameter("town",getTown()),
                new OracleParameter("county",getCounty()),
                new OracleParameter("managerName",getManagerName()),
                new OracleParameter("managerEmail",getManagerEmail()),
                new OracleParameter("managerMobile",getManagerMobile()),
                new OracleParameter("maxCapacity",getMaxCapacity())
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateVenue()
        {
            String sql = "UPDATE VENUES SET venueID = :venueID, venueName = :venueName, street = :street, " + "town = :town, county = :county, managerName = :managerName, managerEmail = :managerEmail, " + "managerMobile = :managerMobile, maxCapacity = :maxCapacity  WHERE VenueID = :VenueID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("venueID",getVenueID()),
                new OracleParameter("venueName",getVenueName()),
                new OracleParameter("street",getStreet()),
                new OracleParameter("town",getTown()),
                new OracleParameter("county",getCounty()),
                new OracleParameter("managerName",getManagerName()),
                new OracleParameter("managerEmail",getManagerEmail()),
                new OracleParameter("managerMobile",getManagerMobile()),
                new OracleParameter("maxCapacity",getMaxCapacity())
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void CancelVenue()
        {
            

            String strSQL = "UPDATE Venues SET status = :status WHERE VenueID = :VenueID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("status", 'N'),
                new OracleParameter("venueID", this.getVenueID())
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();

            //-------- Cancel all events witrh this venue ID

            String strSQL2 = "UPDATE Events SET status = :status WHERE VenueID = :VenueID";

            OracleConnection conn2 = new OracleConnection(DBConnect.oradb);
            conn2.Open();
            OracleCommand cmd2 = new OracleCommand(strSQL2, conn2);

            OracleParameter[] parameters2 = new OracleParameter[] {
                new OracleParameter("status", 'N'),
                new OracleParameter("venueID", this.getVenueID())
            };

            cmd2.Parameters.AddRange(parameters2);
            cmd2.ExecuteNonQuery();
            conn2.Close();





        }

        public static int getNextID()
        {
            String strSQL = "SELECT MAX(VenueID) From Venues";

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

        public static DataSet getAllVenues()
        {
            String strSQL = "Select * From Venues Order By VenueID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "vns");
            conn.Close();
            return ds;
        }

        public static DataSet getActiveVenues()
        {
            String strSQL = "Select * From Venues WHERE Status = 'Y' Order By VenueID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "av");
            conn.Close();
            return ds;
        }

        public static DataSet getActiveVenuesMini()
        {
            String strSQL = "Select VenueID, VenueName, ManagerName, ManagerMobile, MaxCapacity From Venues WHERE Status = 'Y' Order By VenueID ";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "avm");
            conn.Close();
            return ds;
        }

        public void getAVenue(int id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "Select * From Venues Where VenueID = " + id;

            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            this.venueID = dr.GetInt32(0);
            this.venueName = dr.GetString(1);
            this.street = dr.GetString(2);
            this.town = dr.GetString(3);
            this.county = dr.GetString(4);
            this.managerName = dr.GetString(5);
            this.managerEmail = dr.GetString(6);
            this.managerMobile = dr.GetString(7);
            this.maxCapacity = dr.GetInt32(9);
        }

        public static Boolean checkVenueName(String venueName)
        {
            Boolean answer = false;
            String strSQL = "Select * From Venues WHERE venueName = '" + venueName + "'";

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

        public static List<String> fillVenueCombo()
        {
            string strSQL = "SELECT venueName FROM Venues WHERE status = 'Y'";

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

        public static int getIDFromName(String venueName)
        {
            String strSQL = "SELECT VenueID From Venues WHERE venueName = '" + venueName + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            return dr.GetInt32(0);
        }

        public static String getNameFromID(int id)
        {
            String strSQL = "SELECT VenueName From Venues WHERE venueID = '" + id + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            return Convert.ToString(dr.GetInt32(0));
        }

        public static int getMaxCapacity(String venueName)
        {
            String strSQL = "SELECT maxCapacity From Venues WHERE venueName = '" + venueName + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            return dr.GetInt32(0);
        }
    }
}