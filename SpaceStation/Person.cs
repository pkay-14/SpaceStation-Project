using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SpaceStation
{
    class Person
    {
        public int reply;
        public int id;
        public string firstname;
        public string lastname;
        public string gender;
        public DateTime DateofBirth;
        public int age;
        public string address;
        public string phone;
        public string email;
        public string password;
        public string report;

        public void Login(string firstname, string lastname, string password)
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
                myCommand.Parameters.AddWithValue("@LN", lastname);
                myCommand.Parameters.AddWithValue("@PW", password);


                myConnection.Open();
              //  myCommand.ExecuteNonQuery();

                int userindatabase = (int)myCommand.ExecuteScalar();
                if (userindatabase==1)
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


            }
        }

        public void Print() { }

        public string Get_Information()
        {
            string info = "";
            return info;
        }

        public void Contact() { }

        public void Logout() { }

        public void Save() {/*change to DataTable*/  }
    }
}
