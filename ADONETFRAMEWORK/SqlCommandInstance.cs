using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETFRAMEWORK
{
    class SqlCommandInstance
    {
            static void Main(string[] args)
            {
                new SqlCommandInstance().CreateTable();
                 Console.Read();
            }
            public void CreateTable()
            {
                SqlConnection con = null;
                try
                {
                    // Creating Connection  
                    con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                    // writing sql query  
                    SqlCommand cm = new SqlCommand("select * from student", con);
                    // Opening Connection  
                    con.Open();
                    // Executing the SQL query  
                    SqlDataReader sdr = cm.ExecuteReader();
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["name"] + " " + sdr["email"] );
                    }
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

