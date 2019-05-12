using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.IO;

namespace SpaceStation
{
    class Admin : Person
    {
        private byte eye_print;
        private byte finger_print;

        private void Shutdown() { }

        private void Update_System() { }

        private void Scan() { }
        public int Reply;

        public void Delete(string firstname, string lastname)
        {
            SqlConnectionStringBuilder connectionstring = new SqlConnectionStringBuilder();


            connectionstring.DataSource = "PKAY\\SQLEXPRESS";
            connectionstring.InitialCatalog = "Spacestation";
            connectionstring.IntegratedSecurity = true;
            connectionstring.MultipleActiveResultSets = true;


            using (SqlConnection myConnection = new SqlConnection(connectionstring.ToString()))
            {
                SqlCommand myCommand = new SqlCommand("proceduredelete", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@FN", firstname);
                myCommand.Parameters.AddWithValue("@LN", lastname);

                myConnection.Open();
                 Reply = myCommand.ExecuteNonQuery();
                //if (reply == -1)
                //{
                //    Console.WriteLine("Employee doesn't exist");
                //}
                //else
                //{
                //    Console.WriteLine("Employee Deleted succesfully");

                //}
            }
        }

        private void Update() { }

        public void Add(string firstname, string lastname, string password)
        {
          SqlConnectionStringBuilder connectionstring = new SqlConnectionStringBuilder();
          

            connectionstring.DataSource = "PKAY\\SQLEXPRESS";
            connectionstring.InitialCatalog = "Spacestation";
            connectionstring.IntegratedSecurity = true;
            connectionstring.MultipleActiveResultSets = true;


            using (SqlConnection myConnection = new SqlConnection(connectionstring.ToString()))
            {
                SqlCommand myCommand = new SqlCommand("procedureadd", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@FN", firstname );
                myCommand.Parameters.AddWithValue("@LN", lastname );
                myCommand.Parameters.AddWithValue("@PW", password);


                myConnection.Open();
                Reply = myCommand.ExecuteNonQuery();
                //if (reply == -1)
                //{
                //    Console.WriteLine("Employee already exists");
                //}
                //else {
                //    Console.WriteLine("Employee added succesfully");

                //}
            }



             bool Check_Device() { return true; }


        }
    }
}
