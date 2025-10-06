using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace UpdateEmployeeSalary
{
    internal class DataAccess
    {
        private static string _connectionString = "Server=Abu-Ghaith\\AMSSQLSERVER;Database=C21_DB1;User Id=sa;Password=isa123456"; 
        
        public static DataTable GetEmployeesSalaryEndRate()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "Select Salary,PerformanceRating From Employees2";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                   
                }


            }
            return dt;
        }

       

    }
}
