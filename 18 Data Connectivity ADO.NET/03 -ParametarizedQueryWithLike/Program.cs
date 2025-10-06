using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ParametarizedQueryWithLike
{
    internal class Program
    {
        static string connectionString = "Server=Abu-Ghaith\\AMSSQLSERVER;Database=ContactsDB;User Id=sa;Password=isa123456";
        
        static void SearchContactsStartsWith(string StartWith)
        {
           SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Contacts WHERE FirstName LIKE '' + @StartWith+ '%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("StartWith", StartWith);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string email = (string)reader["email"];
                    string address = (string)reader["address"];
                    int countryID = (int)reader["CountryID"];
                    
                    Console.WriteLine($"ContactID  : {contactID}");
                    Console.WriteLine($"FirstName  : {firstName}");
                    Console.WriteLine($"LastName   : {lastName}");
                    Console.WriteLine($"Email      : {email}");
                    Console.WriteLine($"Address    : {address}");
                    Console.WriteLine($"Country ID : {countryID}");
                    Console.WriteLine("------------------------------");

                }
                reader.Close();
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void SearchContactsEndsWtih(string EndsWith)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT FirstName ,LastName ,CountryID FROM Contacts WHERE FirstName LIKE '%' + @EndsWith + ''";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@EndsWith", EndsWith);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) 
                {
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine($"FirstName : {firstName}");
                    Console.WriteLine($"LastName  : {lastName}");
                    Console.WriteLine($"CountryId : {countryID}");
                    Console.WriteLine("-----------------------");

                }
                reader.Close();
                connection.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }



        }

        static void SearchContactsContains(string Contains)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Contacts WHERE FirstName LIKE '%'+@Contains+'%'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Contains", Contains);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string email = (string)reader["email"];
                    string address = (string)reader["address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine($"ContactID  : {contactID}");
                    Console.WriteLine($"FirstName  : {firstName}");
                    Console.WriteLine($"LastName   : {lastName}");
                    Console.WriteLine($"Email      : {email}");
                    Console.WriteLine($"Address    : {address}");
                    Console.WriteLine($"Country ID : {countryID}");
                    Console.WriteLine("------------------------------");
                }
                reader.Close();
                connection.Close();
            }
            catch( Exception ex )
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--------Contacts Starts With j");
            SearchContactsStartsWith("j");

            Console.WriteLine("--------Contacts Ends With ne");
            SearchContactsEndsWtih("ne");

            Console.WriteLine("--------Contacts contains ae");
            SearchContactsContains("ae");

            Console.ReadKey();
        }
    }
}
