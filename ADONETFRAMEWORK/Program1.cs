using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETFRAMEWORK
{
    class Program1
    {
        static void Main(string[] args)
        {
            new Program1().CreateTable();
            Console.Read();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");

                string sql = "insert into student (id, name, email, join_date)values("+"'106', 'Ronald Trump', 'ronald@example.com', '1/12/2017')";
                // writing sql query  
                SqlCommand cm = new SqlCommand(sql, con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}