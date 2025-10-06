using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetriveSingleValue
{
    internal class Program
    {
        static string connectionString = "Server=Abu-Ghaith\\AMSSQLSERVER;Database=ContactsDB;User Id=sa;Password=isa123456";

        static string GetFirstName(int ContactID)
        {
            string firstName = "";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT FirstName FROM Contacts WHERE ContactID = @ContactID";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                connection.Open();

                // ExecuteScalar() returns only the first column from the first row

                object result = command.ExecuteScalar();

                if(result != null)
                {
                    firstName = result.ToString();
                }
                else
                {
                    firstName = "";
                }

                connection.Close();

               
            }

            catch (Exception ex)
            {
                Console.WriteLine( "Erorr: "+ ex.Message);
            }

            return firstName;
        }

        static string GetFirstNameByCountryID (int CountryID)
        {
            string firstName = "";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT FirstName FROM Contacts WHERE CountryID =@CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                
                if(result != null)
                {
                    firstName = result.ToString();
                }
                else
                {
                    firstName = "";
                }

                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return firstName; 

        }
        static void Main(string[] args)
        {

            Console.WriteLine(GetFirstNameByCountryID(1));

            Console.ReadKey();
        }
    }
}
