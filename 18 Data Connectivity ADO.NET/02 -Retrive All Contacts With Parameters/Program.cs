using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieveAllContactsWithParameters
{
    internal class Program
    {
        static string connectionsString = "Server=Abu-Ghaith\\AMSSQLSERVER;Database=ContactsDB;User Id =sa;Password=isa123456";

        static void PrintAllContactsWith(string FirstName)
        {
            SqlConnection connection = new SqlConnection(connectionsString);

            // another way to deal with parameters but not recommended 
            // string query = "SELECT * FROM Contacts WHERE FirstName ="+FirstName;

            string query = "SELECT * FROM Contacts WHERE FirstName =@FirstName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    int CountryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact Id  : {contactID}");
                    Console.WriteLine($"First Name  : {firstName}");
                    Console.WriteLine($"Last  Name  : {lastName}");
                    Console.WriteLine($"Email       : {email}");
                    Console.WriteLine($"Phone       : {phone}");
                    Console.WriteLine($"Country ID  : {CountryID}");
                    Console.WriteLine("-----------------------------");
                }
                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        static void PrintAllContactsWith(string FirstName, int CountryID)
        {
            SqlConnection connectoin = new SqlConnection(connectionsString);

            string query = "SELECT * FROM Contacts WHERE FirstName =@FirstName and CountryID =@CountryID";

            SqlCommand command = new SqlCommand(query, connectoin);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connectoin.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact Id  : {contactID}");
                    Console.WriteLine($"First Name  : {firstName}");
                    Console.WriteLine($"Last  Name  : {lastName}");
                    Console.WriteLine($"Email       : {email}");
                    Console.WriteLine($"Phone       : {phone}");
                    Console.WriteLine($"Country ID  : {countryID}");
                    Console.WriteLine("-----------------------------");
                }
                reader.Close();
                connectoin.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        static void Main(string[] args)
        {
            PrintAllContactsWith("Jane", 1);

            Console.ReadKey();
        }
    }
}
