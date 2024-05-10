using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp10
{
    public class SqlCommandDemo
    {
        SqlConnection conn;
        public SqlCommandDemo()
        {
            conn = new SqlConnection("Data Source=49C2C7424B625C6;Initial Catalog=amazondb;Integrated Security=SSPI");
        }
        public static void Main(string[] args)
        {
            SqlCommandDemo cmd = new SqlCommandDemo();
            Console.WriteLine();
            Console.WriteLine("Categories before insert");
            Console.WriteLine("----------------------------------");
            cmd.ReadData();
            Console.WriteLine("Insert Categories");
            Console.WriteLine("----------------------------------");
            cmd.InsertData();
            Console.WriteLine("Categories after inserting");
            Console.WriteLine("----------------------------------");
            cmd.ReadData();
            Console.WriteLine();
            Console.WriteLine("Updating data...");
            cmd.Updatedata();

            Console.WriteLine();
            Console.WriteLine("Categories after update");
            Console.WriteLine("----------------------------------");
            cmd.ReadData();
            Console.WriteLine();
            Console.WriteLine("Deleting data....");
            Console.WriteLine("-----------------------------------");
            cmd.Deletedata();
            Console.WriteLine();
            Console.WriteLine("Deleting after data");
            cmd.ReadData();
        }

        public void ReadData()
        {
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select categoryName from Categories", conn);
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
                string insertString = @"
                                      insert into 
                                      Categories(categoryName, Description)
                                      values('Miscellaneous', 'Whatever doesn''t fit elsewhere')";
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
                                     @"UPDATE Categories SET Description = 'General items' WHERE categoryName = 'Miscellaneous'";
                SqlCommand cmd = new SqlCommand(updatestring);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if(conn != null )
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
                string deletestring = @"delete from Categories where CategoryName='Misellaneous'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = deletestring;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if( conn != null )
                {
                    conn.Close();
                }
            }
        }
    }
}
/*namespace ConsoleApp10
{
    class SqlConnectionDemo
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=49C2C7424B625C6;Initial Catalog=amazondb;Integrated Security=SSPI");
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from products", conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[1]);
                }
            }
            catch
            {
                Console.WriteLine("This is a error");
            }

        }
    }
}*/

/*namespace ConsoleApp10
{
    class SqlConnectionDemo
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=49C2C7424B625C6;Initial Catalog=master;Integrated Security=SSPI");
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from customers", conn);
                rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    Console.WriteLine(rdr[1]);
                }
            }
            catch
            {
                Console.WriteLine("This is a error");
            }

        }
    }
}*/
