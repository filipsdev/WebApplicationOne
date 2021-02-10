using System.Collections.Generic;
using System.Data.SqlClient;
using WebApplicationOne.Models;

namespace WebApplicationOne.Data
{
    internal class ItemDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DSCdatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        // performs all operations on the DB. get all, create, delete, get one, search etc.

        public List<ItemModel> FetchAll()
        {
            List<ItemModel> returnList = new List<ItemModel>();

            // access the DB
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.Items";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new item object. Add it to the list to return.
                        ItemModel item = new ItemModel();
                        item.Id = reader.GetInt32(0);
                        item.Name = reader.GetString(1);
                        item.Type = reader.GetString(2);
                        item.Size = reader.GetString(3);
                        item.Price = reader.GetString(4);
                        item.Description = reader.GetString(5);

                        returnList.Add(item);
                    }
                }
            }

            return returnList;
        }
        public ItemModel FetchOne(int Id)
        {

            // access the DB
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.Items WHERE Id = @id";

                // associate @Id with Id parameter

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;


                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                ItemModel item = new ItemModel();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new item object. Add it to the list to return.
                        item.Id = reader.GetInt32(0);
                        item.Name = reader.GetString(1);
                        item.Type = reader.GetString(2);
                        item.Size = reader.GetString(3);
                        item.Price = reader.GetString(4);
                        item.Description = reader.GetString(5);

                    }
                }
             return item;
            }
        }
    }
}