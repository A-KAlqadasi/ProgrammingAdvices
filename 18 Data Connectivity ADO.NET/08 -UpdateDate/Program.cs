using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UpdateDate
{
    internal class Program
    {
        static string connectionString = "Server=Abu-Ghaith\\AMSSQLSERVER;Database=ContactsDB;User Id=sa;Password =isa123456;";

        struct stContactInfo
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public int CountryId { get; set; }

        }


        static void UpdateData(int ContactId,stContactInfo ContactInfo)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "UPDATE Contacts " +
                            "Set FirstName = @FirstName, " +
                            "LastName = @LastName, " +
                            "Email = @Email, " +
                            "Phone = @Phone, " +
                            "CountryId =@CountryId " +
                            "WHERE ContactID = @ContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactId);
            command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
            command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
            command.Parameters.AddWithValue("@Email", ContactInfo.Email);
            command.Parameters.AddWithValue("@Phone", ContactInfo.Phone);
            command.Parameters.AddWithValue("@CountryId", ContactInfo.CountryId);

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    Console.WriteLine($"{rowsAffected} row affected!");
                }
                else
                {
                    Console.WriteLine($"{rowsAffected} row affected");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
            }
        }
        
        static void UpdateSalaryToAllData(float NewSalary )
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "Update Contacts " +
                            "Set Salary = @Salary";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Salary", NewSalary);

            try
            {
                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if(rowsAffected >0)
                {
                    Console.WriteLine($"{rowsAffected} row updated successfully!");
                }
                else {
                    Console.WriteLine($"{rowsAffected} row affected, update faild!");
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }

        }

        static void Main(string[] args)
        {
            stContactInfo contactInfo = new stContactInfo
            {
                FirstName = "Waleed",
                LastName = "Awn",
                Email = "waleed@gmail.com",
                Phone = "778500511",
                CountryId = 6
            };

            //UpdateData(1,contactInfo);
            UpdateSalaryToAllData(5000);

            Console.ReadKey();
        }
    }
}
