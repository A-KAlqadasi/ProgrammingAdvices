using System;
using System.Data.SqlClient;

namespace DeleteData
{
    internal class Program
    {
        static string connectionString = "Server=Abu-Ghaith\\AMSSQLSERVER;Database=ContactsDB;User Id=sa;Password=isa123456";
        
        static void DeleteContact (int ContactID)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "Delete From Contacts " +
                            "Where ContactID = @ContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Record deleted successfully");
                }
                else
                {
                    Console.WriteLine("Record delete faild!");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
            }

            
        }
        
        static void DeleteCountry(int CountryId)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "DELETE from Countries " +
                            "WHERE CountryId = @CountryId";

            SqlCommand command = new SqlCommand (query, connection);
            command.Parameters.AddWithValue("@CountryId", CountryId);

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"{rowsAffected} row deleted successfully!");
                }
                else
                {
                    Console.WriteLine("row delete faild!");

                }
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        static void Main(string[] args)
        {
            DeleteContact(8);
            DeleteCountry(8);
            Console.ReadKey();
        }
    }
}
