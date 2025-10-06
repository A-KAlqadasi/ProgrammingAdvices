using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RetriveAutoNumberAfterInserting_Data
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

        static void AddNewContactAndGetID(stContactInfo Contact)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Contacts(FirstName,LastName,Email,Phone,Address,CountryID)" +
                            "VALUES (@FirstName,@LastName, @Email, @Phone,@Address,@CountryID);" +
                            "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
            command.Parameters.AddWithValue("@LastName", Contact.LastName);
            command.Parameters.AddWithValue("@Email", Contact.Email);
            command.Parameters.AddWithValue("@Phone", Contact.Phone);
            command.Parameters.AddWithValue("@Address", Contact.Address);
            command.Parameters.AddWithValue("@CountryID", Contact.CountryId);


            try
            {
                connection.Open();

                Object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out int autoNumber))
                {
                    Console.WriteLine($"New Id Inserted is {autoNumber}");
                }
                else
                {
                    Console.WriteLine("No Id retrived Insertion faild!");
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

            stContactInfo contact = new stContactInfo
            {
                FirstName = "Alia",
                LastName = "Maher",
                Email = "alia@gmail.com",
                Phone = "12397843",
                Address = "123 Main st",
                CountryId = 7

            };

            AddNewContactAndGetID(contact);
            Console.ReadLine();

        }
    }
}
