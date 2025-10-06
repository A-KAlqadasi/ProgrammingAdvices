using StudentAPI.Model;
namespace StudentAPI.DataSimulation
{
    public class StudentDataSimulation
    {
        public static readonly List<Student> StudentList = new List<Student>
        {
            new Student{Id = 1,Name="Abdulkareem Shawqi",Age =20, Grade=66},
            new Student{Id = 2,Name="Waleed Awn",Age =21, Grade=44},
            new Student{Id = 3,Name="Mr. Gosh",Age =22, Grade=70},
            new Student{Id = 4,Name="Mohammed Basheer",Age =20, Grade=49}

        };
    }
}
