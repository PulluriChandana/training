using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=49C2C7424B625C6;Initial Catalog=amazondb;" +
                                          "Integrated Security=true";
            //read data from the customers table from amazondb database
            DataTable customersDataTable = ReadDataFromamazondb(connectionString, "Select * from Customers");
            Console.WriteLine(customersDataTable);
            //display original data
            Console.WriteLine("Original Customers Data:");
            DisplayDataTable(customersDataTable);
            //filter the table where country name is france
            Console.WriteLine("French country");
            DataTable frenchCustomersDataTable = FilterData(customersDataTable, "Country='France'");
            DisplayDataTable(frenchCustomersDataTable);
            //sort data by company name
            DataTable sortedCustomersDataTable = SortedData(frenchCustomersDataTable, "CompanyName ASC");
            DisplayDataTable(sortedCustomersDataTable);
            //calculate the display the total number of customers
            int totalCustomers = GetTotalCustomers(customersDataTable);
            Console.WriteLine($"Total number of customers:{totalCustomers}");
        }
        static DataTable ReadDataFromamazondb(string connectionString, string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
            }
            return data;
        }
        static void DisplayDataTable(DataTable data)
        {
            foreach (DataRow row in data.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write($"{item}\t");
                }
                Console.WriteLine();
            }
        }

        static DataTable FilterData(DataTable data, string filterExpression)
        {
            DataTable filteredDataTable = data.Clone();
            DataRow[] filteredRows = data.Select(filterExpression);
            foreach (DataRow row in filteredRows)
            {
                filteredDataTable.ImportRow(row);
            }
            return filteredDataTable;
        }

        static DataTable SortedData(DataTable data, string sortExpression)
        {
            DataView dataView = new DataView(data);
            dataView.Sort = sortExpression;
            return dataView.ToTable();
        }
        static int GetTotalCustomers(DataTable data)
        {
            return data.Rows.Count;
        }
    }
}

