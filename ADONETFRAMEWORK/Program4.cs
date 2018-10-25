using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETFRAMEWORK
{
    class Program4
    {
        static void Main(string[] args)
        {
            new Program4().UpdateTable();
            Console.Read();
        }
        public void UpdateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                // writing sql query  
                string sql = "update student set name = 'Alfred Schmidt', email = 'Frankfurt@gmail.com' WHERE id = 102 ";
                SqlCommand cm = new SqlCommand(sql, con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record updated Successfully");
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