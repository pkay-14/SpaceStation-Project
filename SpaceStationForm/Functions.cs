using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SpaceStationForm
{
    class Functions
    {
        public int reply;

        public int Login(string firstname, string surname, string password)
        {
            SqlConnectionStringBuilder connectionstring = new SqlConnectionStringBuilder();


            connectionstring.DataSource = "PKAY\\SQLEXPRESS";
            connectionstring.InitialCatalog = "Spacestation";
            connectionstring.IntegratedSecurity = true;
            connectionstring.MultipleActiveResultSets = true;


            using (SqlConnection myConnection = new SqlConnection(connectionstring.ToString()))
            {
                SqlCommand myCommand = new SqlCommand("personlogin", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@FN", firstname);
                myCommand.Parameters.AddWithValue("@LN", surname);
                myCommand.Parameters.AddWithValue("@PW", password);


                myConnection.Open();
                //  myCommand.ExecuteNonQuery();

                int userindatabase = (int)myCommand.ExecuteScalar();
                if (userindatabase == 1)
                {
                    reply = 1;
                    // Console.ForegroundColor = ConsoleColor.Green;
                    // Console.WriteLine( Console.ForegroundColor);


                }
                else
                {
                    reply = -1;
                    //Console.ForegroundColor = ConsoleColor.Red;
                    // Console.WriteLine(reply, Console.ForegroundColor);
                }

                return reply;
            }
        }
    
       
    }
}
