using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
class Program
{
    public static void Main(string[] args)
    {
        string connectionString = "Data Source=49C2C7424B625C6;Initial Catalog=master;" +
            "Integrated Security=true";
        DataSet dataSet = new DataSet();
        DataTable customertable = ReadDataFromNorthWind(connectionString, "Select * from customers","Customers");
        dataSet.Tables.Add(customertable);

        DataTable ordersTable = ReadDataFromNorthWind(connectionString, "Select * from orders","Orders");
        dataSet.Tables.Add(ordersTable);
        Console.WriteLine("Customers Table");
        DisplayDataTable(customertable);
        Console.WriteLine("Orders Table");
        DisplayDataTable(ordersTable);
    }
    static DataTable ReadDataFromNorthWind(string connectionString, string sql,string tablename)
    {
        DataTable dataTable = new DataTable(tablename);
        try
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlDataAdapter adapter = new SqlDataAdapter(sql,connection))
                {
                    adapter.Fill(dataTable);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return dataTable;
    }
    static void DisplayDataTable(DataTable dataTable)
    {
        foreach(DataRow row in dataTable.Rows)
        {
            foreach(DataColumn column in dataTable.Columns)
            {
                Console.Write($"{column.ColumnName}:{row[column]}");
            }
            Console.WriteLine();    
        }
    }
}
/*class Program
{
    static void Main()
    {
        string connectionString = "Data Source=49C2C7424B625C6;Initial Catalog=employee;"+
            "Integrated Security=true";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Open the connection
            connection.Open();

            // SQL query to select data
            string sqlQuery = "SELECT * FROM employee";

            // Create a DataAdapter to retrieve data
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);

            // Create a DataSet to hold the data
            DataSet dataSet = new DataSet();

            // Fill the DataSet with data from the DataAdapter
            adapter.Fill(dataSet, "employee");
            //display the data from the dataset using column
            foreach (DataColumn column in dataSet.Tables["employee"].Columns)
            {
                Console.Write(column.ColumnName + "\t");
            }
            Console.WriteLine();

            // Display the data from the DataSet (or manipulate it further)
            foreach (DataRow row in dataSet.Tables["employee"].Rows)
            {
                Console.WriteLine($"{ row["employeeID"],-15}"+ " " +
                    $"{ row["firstname"],-15}" +" " + 
                    $"{row["lastname"],-15}"+ " "+ 
                    $"{row["jobtitle"],-15}"+" "+ 
                    $"{row["hiredate"]}");
            }
        }
    }
}*/


/*namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=49C2C7424B625C6;Initial Catalog=employee;" +
                                          "Integrated Security=true";
            //reteriving data by employeeID
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Getemployee1ID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeID", 1);
                    //connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Console.WriteLine($"EmployeeID: {reader["employeeID"]}, FirstName:  " +
                                $"{reader["firstname"]}, LastName: {reader["lastname"]},  " +
                                $"JobTitle: {reader["jobtitle"]}, HireDate: {reader["hiredate"]}");
                        }
                       
                    }
                }
            }
            //inserting a new record using storedprocedure
            using(SqlConnection connection = new SqlConnection( connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("insertemployee",connection))
                {
                    cmd.CommandType=CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstname", "Pulluri");
                    cmd.Parameters.AddWithValue("@lastname", "Meghana");
                    cmd.Parameters.AddWithValue("@jobtitle", "SE");
                    cmd.Parameters.AddWithValue("@hiredate", DateTime.Parse("2024-06-10"));
                    int rowsAffected=cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted.");
                }
            }
            //updating a record using storedprocedure
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UpdateEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeID", 2);
                    command.Parameters.AddWithValue("@firstname", "NewFirstName");
                    command.Parameters.AddWithValue("@lastname", "NewLastName");
                    command.Parameters.AddWithValue("@jobtitle", "NewJobTitle");
                    command.Parameters.AddWithValue("@hiredate", DateTime.Parse("2024-01-01"));

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) updated.");
                }

            }
            //deleting a record using stored procedure
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Deleteemployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@employeeID", 1);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) deleted.");
                }
            }
            Console.ReadLine();
        }
    }
}*/