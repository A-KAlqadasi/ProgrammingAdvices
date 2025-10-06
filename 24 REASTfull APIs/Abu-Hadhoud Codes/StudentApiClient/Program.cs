

using System.Net.Http.Json;

namespace StudentApiClient
{
    class Program
    {
        static readonly HttpClient httpClient = new HttpClient();
        
        static async Task Main(string[] args)
        {
            httpClient.BaseAddress = new Uri("http://localhost:5062/api/Students/");
            await GetAllStudents();
            await GetPassedStudents();
            await GetAverageGrade();
            await GetStudentById(2);
            Student Student = new Student { Name = "Alia", Age = 20, Grade = 90 };
            await AddStudent(Student);
            await GetAllStudents();
            await DeleteStudent(1);
            await GetAllStudents();
            Student updatedStudent = new Student { Name = "W A", Age = 22, Grade = 94 };
            await UpdateStudent(2, updatedStudent);
            await GetAllStudents();
            Console.Read();
        }

        static async Task GetAllStudents()
        {
            try
            {
                Console.WriteLine("\n-----------------------");
                Console.WriteLine("Fetching Students...");

                var Students = await httpClient.GetFromJsonAsync<List<Student>>("All");
                if (Students != null)
                {
                    foreach (var Student in Students)
                    {
                        Console.WriteLine($"Id: {Student.Id}, Name:{Student.Name}, Age:{Student.Age}, Grade:{Student.Grade}");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }
        }

        static async Task GetPassedStudents()
        {
            try
            {
                Console.WriteLine("\n-------------------------");
                Console.WriteLine("Passed Students...");

                var Students = await httpClient.GetFromJsonAsync<List<Student>>("Passed");
                if (Students != null)
                {
                    foreach (var Student in Students)
                    {
                        Console.WriteLine($"Id:{Student.Id}, Name:{Student.Name}, Age={Student.Age}, Grade={Student.Grade}");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erorr: " + ex.Message);
            }

        }
        
        static async Task GetAverageGrade()
        {
            try
            {
                Console.WriteLine("\n------------------------");
                Console.Write("Average Grade = ");
                double average = await httpClient.GetFromJsonAsync<double>("AverageGrade");
                Console.WriteLine(average);

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static async Task GetStudentById(int Id)
        {
            try
            {
                Console.WriteLine("\n------------------------");
                Console.WriteLine($"Find Student by Id[{Id}]");

                var response = await httpClient.GetAsync($"{Id}");

                if( response.IsSuccessStatusCode)
                {
                    var Student = await response.Content.ReadFromJsonAsync<Student>();

                    if (Student != null)
                    {
                        Console.WriteLine($"Id:{Student.Id}, Name:{Student.Name}, Age={Student.Age}, Grade={Student.Grade}");
                    }
                    
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine($"Bad Request: Not accepted Id = [{Id}]");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Not Found: Student with Id=[{Id}] not found");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        
        static async Task AddStudent(Student newStudent)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync("",newStudent);

                if ((response.IsSuccessStatusCode))
                {
                    var addedStudent =await response.Content.ReadFromJsonAsync<Student>();
                    Console.WriteLine($"Added Student - Id: {addedStudent.Id}, Name: {addedStudent.Name}, Age: {addedStudent.Age}, Grade: {addedStudent.Grade}");

                }
                else if(response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine($"Bad request: invalId Student data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
        }

        static async Task DeleteStudent(int StudentId)
        {
            try
            {
                Console.WriteLine("\n-----------------");
                Console.WriteLine($"Deleting Student with Id={StudentId}");
                var response = await httpClient.DeleteAsync($"{StudentId}");

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Student deleted successfully!");
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Student with Id={StudentId} was not found!");
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine($"Not accepted Id={StudentId}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
        }

        static async Task UpdateStudent(int StudentId,Student updatedStudent)
        {
            try
            {
                Console.WriteLine("\n--------------------------");
                Console.WriteLine("updateing Student with Id ="+StudentId);
                var response = await httpClient.PutAsJsonAsync($"{StudentId}",updatedStudent);

                if (response.IsSuccessStatusCode)
                {
                    Student Student = await response.Content.ReadFromJsonAsync<Student>();
                    Console.WriteLine($"Student Id: {Student.Id}, Name: {Student.Name}, Age: {Student.Age}, Grade: {Student.Grade}");
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Not Found: Student with Id:{StudentId} not found!");
                }
                else if(response.StatusCode ==System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine($"Bad Request: Not accepted Id:{StudentId}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
            }
        }

    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        
    }

}