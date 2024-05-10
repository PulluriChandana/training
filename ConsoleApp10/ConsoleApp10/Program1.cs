/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp10
{
    class SqlCommandDemo
    {
        SqlConnection conn;
        public SqlCommandDemo()
        {
            conn = new SqlConnection("Data Source=49C2C7424B625C6;Initial Catalog=retail;Integrated Security=SSPI");
        }
        public static void Main(string[] args)
        {
            SqlCommandDemo cmd = new SqlCommandDemo();
            Console.WriteLine();
            Console.WriteLine("Orders before insert");
            Console.WriteLine("----------------------------------");
            cmd.ReadData();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Insert Orders");
            Console.WriteLine("----------------------------------");
            cmd.InsertData();
            Console.WriteLine("Orders after inserting");
            Console.WriteLine("----------------------------------");
            cmd.ReadData();
            Console.WriteLine();
            Console.WriteLine("Orders updating.....");
            cmd.Updatedata();
            Console.WriteLine("------------------------");
            Console.WriteLine("Orders updated");
            cmd.ReadData();
            Console.WriteLine();
            Console.WriteLine("Deleting data");
            cmd.Deletedata();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Deleted data");
            cmd.ReadData();
        }
        public void ReadData()
        {
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select CustomerName from orders", conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void InsertData()
        {
            try
            {
                conn.Open();
                string insertString = @"INSERT INTO Orders (OrderID, CustomerName, OrderDate, TotalAmount, Status) 
                                VALUES (1013, 'Olivia Johnson', '2024-06-11', 95.00, 'Processing')";

                SqlCommand scd = new SqlCommand(insertString, conn);
                scd.ExecuteNonQuery();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Updatedata()
        {
            try
            {
                conn.Open();
                string updatestring =
                                     @"UPDATE Orders 
                                        SET CustomerName = 'Updated Customer Name' 
                                        WHERE OrderID = 1011";
                SqlCommand cmd = new SqlCommand(updatestring);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Deletedata()
        {
            try
            {
                conn.Open();
                string deletestring = @"delete from orders where CustomerName='Olivia Johnson'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = deletestring;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

    }
}*/