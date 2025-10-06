using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Model;
using StudentAPI.DataSimulation;

namespace StudentAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/Students")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {

        [HttpGet("All", Name = "GetAllStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            if (StudentDataSimulation.StudentList.Count == 0)
                return NotFound("No students found!");

            return Ok(StudentDataSimulation.StudentList);
        }

        [HttpGet("Passed", Name = "GetPassedStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Student>> GetPassedStudents()
        {
            var passedStudents = StudentDataSimulation.StudentList.Where(student => student.Grade >= 50).ToList();

            if (passedStudents.Count == 0)
                return NotFound("No student passed");

            return Ok(passedStudents);
        }

        [HttpGet("AverageGrade", Name = "GetAverageGrade")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<double> GetAverageGrade()
        {
            //StudentDataSimulation.StudentList.Clear();
            if (StudentDataSimulation.StudentList.Count == 0)
            {
                return NotFound("No students found");
            }

            double average = StudentDataSimulation.StudentList.Average(student => student.Grade);
            return Ok(average);
        }


        [HttpGet("{id}", Name = "GetStudentByID")]
        [ProducesResponseType(StatusCodes.Status200OK)] // decomenting the errors
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Student> GetStudentByID(int id)
        {
            if (id < 1)
            {
                return BadRequest($"No student with Id = {id}");
            }

            var student = StudentDataSimulation.StudentList.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound($"Student with Id [{id}] not found!");
            }

            return Ok(student);
        }

        [HttpPost(Name = "AddStudent")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Student> AddStudent(Student newStudent)
        {
            if(newStudent == null || string.IsNullOrEmpty(newStudent.Name)|| newStudent.Age <0 || newStudent.Grade<0)
            {
                return BadRequest("Invalid student data!");
            }

            newStudent.Id = StudentDataSimulation.StudentList.Count > 0 ? StudentDataSimulation.StudentList.Max(s => s.Id)+ 1 : 1;

            StudentDataSimulation.StudentList.Add(newStudent);
            //return Ok(newStudent);
            //return CreatedAtRoute(GetStudentByID(newStudent.Id), newStudent);
            return CreatedAtRoute("GetStudentByID", new { id = newStudent.Id },newStudent);
        }

        [HttpDelete("{id}", Name = "DeleteStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)] // decomenting the errors
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteStudent(int id)
        {
            if(id<1)
            {
                return BadRequest($"Not accepted student Id= {id}");
            }

            var student = StudentDataSimulation.StudentList.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound($"Student wiht Id={id} not found");
            }
            StudentDataSimulation.StudentList.Remove(student);
            return Ok($"Student with Id={id} deleted successfully!");
        }

        [HttpPut("{studentId}", Name = "UpdateStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)] // decomenting the errors
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Student> UpdateStudent(int studentId, Student updatedStudent)
        {
            if (studentId < 1 || updatedStudent == null || string.IsNullOrEmpty(updatedStudent.Name) || updatedStudent.Age <= 0 || updatedStudent.Grade <= 0)
            {
                return BadRequest("Invalid updated student data");
            }

            var student = StudentDataSimulation.StudentList.FirstOrDefault(s => s.Id == studentId);
            if (student == null)
            {
                return NotFound($"Student with Id={studentId} was not found!");
            }
            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.Grade =updatedStudent.Grade;

            return Ok(student);

        }




    }
}
