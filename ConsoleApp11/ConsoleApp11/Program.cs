using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.Arm;
using System.Data;
using System.Xml;


/*class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Data Source=49C2C7424B625C6;Initial Catalog=amazondb;" +
                                      "Integrated Security=true";
        int productID = 1;
        double newunitprice = 22.22;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand("UpdateProductPrice", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductID", productID);
                command.Parameters.AddWithValue("@NewUnitPrice", newunitprice);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Product price updated successfully.");
                }
                else
                {
                    Console.WriteLine("No data found for specified product ID.");
                }
                connection.Close();
            }
        }
    }
}*/

/*class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Data Source=49C2C7424B625C6;Initial Catalog=amazondb;" +
                                      "Integrated Security=true";
        int employeeId = 5;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand("GetOrdersByEmployeeAndDateRange", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", employeeId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    { 
                        int employeeid = (int)reader["EmployeeID"];
                        int startdate = (int)reader["Start Date"];
                        int enddate = (int)reader["End Date"];
                        Console.WriteLine($"Employee ID: {employeeId}, Start Date: {startdate},End Date:{enddate}");
                    }
                }
                else
                {
                    Console.WriteLine("No data found for specified customer");
                }
                reader.Close();
                connection.Close();
            }
        }
    }
}*/
/*class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Data Source=49C2C7424B625C6;Initial Catalog=amazondb;" +
                                      "Integrated Security=true";
        string customerId = "ALFKI";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand("CustOrderHist", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerID", customerId);
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string productName = reader["ProductName"].ToString();
                        int totalOrders = (int)reader["Total"];
                        Console.WriteLine($"Product Name: {productName}, TotalOrders: {totalOrders}");
                    }
                }
                else
                {
                    Console.WriteLine("No data found for specified customer");
                }
                reader.Close();
                connection.Close();
            }
        }
    }
}*/
/*namespace ConsoleApp11
{
    class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "Data Source=49C2C7424B625C6;Initial Catalog=amazondb;"+
                                      "Integrated Security=true";
            string queryString = "SELECT * FROM dbo.customers WHERE CustomerID != @customerid";

            string paramValue = "ALFKI";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@customerid",paramValue);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("{0,-20} {1,-20} {2,-30}", 
                        "Contact Name", "City", "Company Name");
                    Console.WriteLine("{0,-20} {1,-20} {2,-30}",
                        "--------------", "------------", "-------------");

                    while (reader.Read())
                    {
                        Console.WriteLine("{0,-20} {1,-20} {2,-30}", 
                            reader["ContactName"], reader["City"], reader["CompanyName"]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadLine();
            }
        }
    }
}*/


/*namespace ConsoleApp11
{
    class Program
    {
        public static void Main(string[] args)
        {
            string connectionstring = "Data Source=49C2C7424B625C6;Initial Catalog=amazondb;"
                + "Integrated Security=true";
            string queryString = "Select EmployeeID,LastName,FirstName from dbo.employees " +
                    "Where FirstName!=LastName " +
                    "Order by EmployeeID";

            int paramValue = 5;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@EmployeeID", paramValue);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}*/


/*namespace ConsoleApp11
{
    class Program
    {
        public static void Main(string[] args)
        {
            string connectionstring = "Data Source=49C2C7424B625C6;Initial Catalog=amazondb;" 
                + "Integrated Security=true";
            string queryString = "Select ProductID,UnitPrice,ProductName from dbo.products " +
                    "Where UnitPrice > @PricePoint " +
                    "Order by UnitPrice DESC";

            int paramValue = 5;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@PricePoint", paramValue);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}*/
