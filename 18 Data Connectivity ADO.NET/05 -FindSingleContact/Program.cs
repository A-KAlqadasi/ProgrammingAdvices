using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FindSingleContact
{
    internal class Program
    {
        static string connectionString = "Server=Abu-Ghaith\\AMSSQLSERVER;Database=ContactsDB;User Id =sa;Password=isa123456";

        struct stContactInfo
        {
            public int ContactID;
            public string FirstName;
            public string LastName;
            public string Address;
            public string Email;
            public int CountryId;
        }

        static bool FindContactBy(int ContactID,ref stContactInfo Contact)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Contacts Where ContactID = @ContactID";

            SqlCommand command= new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;
                    Contact.ContactID = (int)reader["ContactID"];
                    Contact.FirstName = (string)reader["FirstName"];
                    Contact.LastName = (string)reader["LastName"];
                    Contact.Email = (string)reader["Email"];
                    Contact.Address = (string)reader["Address"];
                    Contact.CountryId = (int)reader["CountryID"];
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erorr: "+ ex.Message);
            }
            return isFound;
        }


        static void Main(string[] args)
        {
            stContactInfo Contact =new stContactInfo();

            if(FindContactBy(3,ref Contact))
            {
                Console.WriteLine($"ContactID : {Contact.ContactID}");
                Console.WriteLine($"FirstName : {Contact.FirstName}");
                Console.WriteLine($"LastName  : {Contact.LastName}");
                Console.WriteLine($"Email     : {Contact.Email}");
                Console.WriteLine($"Address   : {Contact.Address}");
                Console.WriteLine($"Country Id: {Contact.CountryId}");
            }
            else
            {
                Console.WriteLine($"\nContact Id is not found");
            }

            Console.ReadKey();
        }
    }
}
