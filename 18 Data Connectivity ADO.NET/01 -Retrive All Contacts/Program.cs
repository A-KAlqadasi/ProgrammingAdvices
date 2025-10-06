using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using Microsoft.SqlServer.Server;


namespace Retrive_All_Contacts
{
    internal class Program
    {
        static string connectionString = "Server=Abu-Ghaith\\AMSSQLSERVER;Database=ContactsDB;User Id=sa;Password=isa123456";
        
        static void PrintAllContacts()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Contacts";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
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
            catch(Exception ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
            }
            
        }

        static void PrintAllCountries()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Countries";

            SqlCommand command = new SqlCommand(query,connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    // not recommended to use 0 , 1 , instead use column's name
                    int countryID = (int)reader[0];
                    string countryName = (string) reader[1];

                    Console.WriteLine($"Country ID : {countryID}");
                    Console.WriteLine($"Country Name : {countryName}");
                    Console.WriteLine("-------------------------");

                }
                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


        }

        static void PrintAllContactsWithCountries()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM vwMasterContactDetails";

            SqlCommand command = new SqlCommand(query,connection);

            try
            {
                connection.Open();

                SqlDataReader reader  = command.ExecuteReader();

                while(reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    int countryID = (int)reader["CountryID"];
                    string countryName = (string)reader["CountryName"];


                    Console.WriteLine($"Contact Id  : {contactID}");
                    Console.WriteLine($"First Name  : {firstName}");
                    Console.WriteLine($"Last  Name  : {lastName}");
                    Console.WriteLine($"Email       : {email}");
                    Console.WriteLine($"Phone       : {phone}");
                    Console.WriteLine($"Country ID  : {countryID}");
                    Console.WriteLine($"Country Name: {countryName}");

                    Console.WriteLine("-----------------------------");
                }

                reader.Close();
                connection.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



        }



        static void Main(string[] args)
        {
            //Console.WriteLine("\n-----------------");
            //Console.WriteLine("All Contacts Details");
            //Console.WriteLine("-----------------");

            //PrintAllContacts();

            //Console.WriteLine("\n-----------------");
            //Console.WriteLine("All Countries Details");
            //Console.WriteLine("-----------------");

            //PrintAllCountries();
            Console.WriteLine("\n-----------------");
            Console.WriteLine("All Contacts Details");
            Console.WriteLine("-----------------");

            PrintAllContactsWithCountries();


            Console.ReadKey();
        }
    }
}
