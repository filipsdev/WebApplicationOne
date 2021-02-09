using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplicationOne.Models;

namespace WebApplicationOne.Services.Data
{
    public class SecurityDAO
    {
        internal bool FindByUser(UserModel user)
        {
            // connect to the DB
            string connectuionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // start by assuming that nothing is found in this query
            bool success = false;

            // write the sql expression(with the '@' in front of Username and Password we are preventing SQL Injection Attacks)
            string queryString = "SELECT * FROM dbo.Users WHERE username = @Username AND password = @Password";

            // create and open the connection to the DB inside a using block

            // This ensures that all resources are closed properly when the query is done.

            using (SqlConnection connection = new SqlConnection(connectuionString))
            {
                // create the command and parameter objects
                SqlCommand command = new SqlCommand(queryString, connection);

                // associate @Username with user.Username
                command.Parameters.Add("@Username", System.Data.SqlDbType.NVarChar, 50).Value = user.Username;
                command.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar, 50).Value = user.Password;

                // open the DB and run the command
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                    reader.Close();
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            return success;
        }
    }
}