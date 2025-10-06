using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAddData
{
    internal class Program
    {
        static string connectionString = "Server=Abu-Ghaith\\AMSSQLSERVER;Database=ContactsDB;User Id =sa;Password=isa123456";

        struct stContactInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public int CountryId { get; set; }

        }
      
        static void AddNewContact(stContactInfo Contact)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            
            string query = "INSERT INTO Contacts(FirstName,LastName,Email,Phone,Address,CountryID)" +
                            "VALUES (@FirstName,@LastName, @Email, @Phone,@Address,@CountryID)";
            
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@FirstName",Contact.FirstName);
            command.Parameters.AddWithValue("@LastName", Contact.LastName);
            command.Parameters.AddWithValue("@Email", Contact.Email);
            command.Parameters.AddWithValue("@Phone", Contact.Phone);
            command.Parameters.AddWithValue("@Address", Contact.Address);
            command.Parameters.AddWithValue("@CountryID", Contact.CountryId);


            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"{rowsAffected} row Insertion succeeded!");
                }
                else
                {
                    Console.WriteLine("row Insertion faild!");
                }



                connection.Close();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error: "+ex.Message);
            }

        }

        static void AddNewCountry(string CountryName)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Countries (CountryName) " +
                           "VALUES (@CountryName)";

            SqlCommand command = new SqlCommand (query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"{rowsAffected} row Insertion Succeeded");
                }
                else
                {
                    Console.WriteLine($"row Insertion faild");
                }
                connection.Close ();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



        }

        static void Main(string[] args)
        {
            stContactInfo Contact = new stContactInfo
            {
                FirstName = "Abdulkareem",
                LastName = "Shawqi",
                Email = "A@example.com",
                Phone = "1234568" ,
                Address = "123 Main St",
                CountryId = 6 
            };

            AddNewContact(Contact);

            //AddNewCountry("Yemen");
            //AddNewCountry("Jordan");


            Console.ReadKey();

        }
    }
}
