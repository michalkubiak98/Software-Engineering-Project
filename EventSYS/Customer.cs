using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace EventSYS
{
    internal class Customer
    {
        private int custID;
        private String forename;
        private String surname;
        private String email;

        //protect this with hash
        private String password;

        private String contactNo;

        public Customer(int custID, String forename, String surname, String email, String password, String contactNo)
        {
            setCustID(custID);
            setForename(forename);
            setSurname(surname);
            setEmail(email);
            setPassword(password);
            setContactNo(contactNo);
        }

        public Customer()
        {
            setCustID(0);
            setForename("Unknown");
            setSurname("Unknown");
            setEmail("Unknown");
            setPassword("Unknown");
            setContactNo("Unknown");
        }

        public int getCustID()
        {
            return custID;
        }

        public String getForename()
        {
            return forename;
        }

        public String getSurname()
        {
            return surname;
        }

        public String getEmail()
        {
            return email;
        }

        public String getPassword()
        {
            return password;
        }

        public String getContactNo()
        {
            return contactNo;
        }

        public void setCustID(int custID)
        {
            this.custID = custID;
        }

        public void setForename(String forename)
        {
            this.forename = forename;
        }

        public void setSurname(String surname)
        {
            this.surname = surname;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public void setContactNo(String contactNo)
        {
            this.contactNo = contactNo;
        }

        public void AddCustomer()

        {
            String sql = "INSERT INTO Customers (custID, forename, surname, email, password, contactNo) VALUES " +
                "(:custID, :forename, :surname, :email, :password, :contactNo)";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("custID",getCustID()),
                new OracleParameter("forename",getForename()),
                new OracleParameter("surname",getSurname()),
                new OracleParameter("email",getEmail()),
                new OracleParameter("password",getPassword()),
                new OracleParameter("contactNo",getContactNo())
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateCustomer()
        {
            String sql = "UPDATE Customers SET custID = :custID, forename = :forename, surname = :surname, email = :email, password = :password, contactNo = :contactNo WHERE custID = :custID";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("custID",getCustID()),
                new OracleParameter("forename",getForename()),
                new OracleParameter("surname",getSurname()),
                new OracleParameter("email",getEmail()),
                new OracleParameter("password",getPassword()),
                new OracleParameter("contactNo",getContactNo())
            };

            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static int getNextID()
        {
            String strSQL = "SELECT MAX(CustID) From Customers";

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

        public static DataSet getCustInfo(int id)
        {
            String strSQL = "Select * From Customers WHERE custID = '" + id + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "infoID");
            conn.Close();
            return ds;
        }

        public static DataSet getCustInfoFromEmail(String email)
        {
            String strSQL = "Select * From Customers WHERE Email = '" + email + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "infoEmail");
            conn.Close();
            return ds;
        }

        public static Boolean checkEmail(String email)
        {
            Boolean answer = false;
            String strSQL = "Select * From Customers WHERE Email = '" + email + "'";

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

        public static Boolean checkPass(String pass, String email)
        {
            Boolean answer = false;
            String strSQL = "Select * From Customers WHERE Email = '" + email + "'" + "and Password = '" + pass + "'";

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

        public static int getCustIDFromEmail(String email)
        {
            String strSQL = "Select custID From Customers WHERE Email = '" + email + "'";

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            return dr.GetInt32(0);
        }
    }
}