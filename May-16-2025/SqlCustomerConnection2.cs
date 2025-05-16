using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp3
{
    class SqlCustomerConnection
    {
        static void Main()
        {
            // 1. Instantiate the connection
            SqlConnection conn = new SqlConnection(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");

            //string queryString = "select CONTACTNAME, CITY, CompanyName from Customers;";

            SqlDataReader rdr = null;

            try
            {
                // 2. Open the connection
                conn.Open();

                // 3. Pass the connection to a command object
                SqlCommand cmd = new SqlCommand("select * from customers", conn);

                // 4. Use the connection
                // get query results
                rdr = cmd.ExecuteReader();

                // print the CustomerID of each record
                Console.WriteLine("{0,-25} {1,-20} {2}", "CONTACTNAME", "CITY", "COMPANYNAME");
                Console.WriteLine(new string('-', );
                while (rdr.Read())
                {
                    string ContactName = rdr["ContactName"].ToString();
                    string City = rdr["city"].ToString();
                    string CompanyName = rdr["CompanyName"].ToString();
                    Console.WriteLine("{0,-25} {1,-20} {2}", ContactName, City, CompanyName);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // 5. Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
