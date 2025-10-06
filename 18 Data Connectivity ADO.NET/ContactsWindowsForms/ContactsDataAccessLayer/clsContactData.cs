using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace ContactsDataAccessLayer
{
    public static class clsContactData
    {

        public static bool GetContactInfoById(int ContactID , ref string FirstName , ref string LastName ,
            ref DateTime Birthdate, ref string Email,ref string Phone , ref string Address ,ref int CountryId ,ref string ImagePath )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT FirstName,LastName, Email,Phone,Address,BirthDate, CountryID,ImagePath From Contacts WHERE ContactID = @ContactId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactId", ContactID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    Birthdate = (DateTime)reader["BirthDate"];
                    CountryId = (int)reader["CountryId"];
                    ImagePath = reader["ImagePath"] != DBNull.Value ?(string)reader["ImagePath"]: string.Empty;

                }
                else
                {
                    isFound=false;
                }
                reader.Close();
                
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            { 
                connection.Close(); 
            }

            return isFound; 
        }


        public static int InsertNewContact(string FirstName, string LastName,
            DateTime BirthDate,string Email , string Phone , string Address , int CountryId , string ImagePath)
        {
            int contactID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Contacts(FirstName,LastName,BirthDate,Email,Phone,Address,CountryId,ImagePath) 
                            VALUES(@FirstName,@LastName,@BirthDate ,@Email,@Phone,@Address,@CountryId,@ImagePath);
                            SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@CountryId", CountryId);
            
            

            if(ImagePath != "" ) 
            { 
                 command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                 command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();

                object reader = command.ExecuteScalar();
                if(reader != null  && int.TryParse(reader.ToString(), out int insertedId ))
                {
                    contactID = insertedId;
                }
                else
                { 
                    contactID = -1; 
                }
                

            }
            catch(Exception ex)
            {
                // here we can add log to record the error.
            }
            finally 
            { 
                connection.Close(); 
            }


            return contactID;
        }

        public static bool UpdateContact(int ID, string FirstName, string LastName,
            DateTime BirthDate, string Email, string Phone, string Address, int CountryId, string ImagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Update Contacts
                            Set FirstName=  @FirstName,
                                LastName =  @LastName,
                                BirthDate = @BirthDate,
                                Email=      @Email,
                                Phone =     @Phone,
                                Address=    @Address,
                                CountryID=  @CountryId,
                                ImagePath=  @ImagePath 
                                WHERE ContactID=@ContactId";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@CountryId", CountryId);
            command.Parameters.AddWithValue("@ContactID", ID);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }

            catch(Exception ex) 
            {
                
            }
            finally
            {
                connection.Close();
            }

            return(rowsAffected > 0);

        }

        
        public static bool DeleteContact(int ContactID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "DELETE FROM Contacts " +
                            "Where ContactID = @ContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error:"+ex.Message) ; // we can add it to log file
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);

        }

        public static bool IsContactExist(int ContactID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection (clsDataAccessSettings.connectionString);

            string query = "Select Found=1 From Contacts Where ContactID =@ContactID";

            SqlCommand command = new SqlCommand (query, connection);

            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                connection.Open();
                // I Think using scalar is better than this
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;

                reader.Close();

            }
            catch(Exception ex)
            {
                isFound= false; 
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static DataTable GetAllContacts()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT * FROM Contacts";

            SqlCommand command = new SqlCommand(query,connection);  

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();

            }
            catch(Exception ex)
            {
                // if Error occered
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


    }
}
