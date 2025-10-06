using System;
using System.Data.SqlClient;


namespace HandleInStatment
{
    internal class Program
    {
        static string connectionString = "Server=Abu-Ghaith\\AMSSQLSERVER;Database=ContactsDB;User Id=sa;Password=isa123456";

        static void DeleteFromContacts(string ContactsIds)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "Delete From Contacts " +
                            "Where ContactID IN (" + ContactsIds + ") ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine($"{rowsAffected} row deleted successfully");
                }
                else
                {
                    Console.WriteLine("row delete faild!");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


        }
        static void Main(string[] args)
        {
            DeleteFromContacts("12,13,14");

            Console.ReadKey();
        }
    }
}
