using System;
using System.Data;
using System.Data.SqlClient;


class Program
{
    public static string connectionString = "Server=Abu-Ghaith\\AMSSQLSERVER;Database=C21_DB1;User Id=sa;Password=isa123456;";

    static void Main()
    {
        //int newPersonID = AddNewPerson("Ali", "Saleh", "Ali@Gmail.com");

        //if(newPersonID != -1)
        //    Console.WriteLine($"New Person added successfully with Id={newPersonID}");
        //else
        //    Console.WriteLine("New person adding failed!!");

        if (CheckPersonExists(3))
            Console.WriteLine("Person is exists");
        else
            Console.WriteLine("Person is not exists");



        Console.Read();
    }

    public static int AddNewPerson(string firstName, string lastName,string email)
    {
        int newPersonID = -1;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
            {
                command.CommandType = CommandType.StoredProcedure;


                // Add parameters
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                SqlParameter outputIdParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);


                // Execute
                connection.Open();
                command.ExecuteNonQuery();


                // Retrieve the ID of the new person
                newPersonID = (int)command.Parameters["@NewPersonID"].Value;
               
            }
        }
        return newPersonID;
    }

    public static bool CheckPersonExists(int PersonID)
    {
        bool personExists = false;
        try
        {
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SP_CheckPersonExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                    SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };

                    command.Parameters.Add(returnParameter);
                    command.ExecuteNonQuery();

                    personExists = (int)returnParameter.Value == 1;

                  

                    connection.Close();

                }
            }
            

        }
        catch (Exception ex)
        {

            Console.WriteLine($" Person doesn't Exist   {ex.Message}");
        }
        return personExists;
    }


}
