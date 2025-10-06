using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeOnListWithLINQ
{
	internal class Program
	{
		static public List<Student> Students = new List<Student> 
		{ 
			new Student{Id =1, Name = "Abdulkareem Shawqi", Subject = "Software Engineering", Grade = 90},
			new Student{Id =2, Name = "Mohammed", Subject = "Software Engineering", Grade = 70},
			new Student{Id =3, Name = "Waleed Awn", Subject = "AI", Grade = 86},
			new Student{Id =4, Name = "Abdulrahman Aldarafi", Subject = "AI", Grade = 70},
			new Student{Id =5, Name = "Yousuf Mansor", Subject = "Information Security", Grade = 80}

		};
		static void Main(string[] args)
		{

			Student newStudent = new Student();
			newStudent.Id = 6;
			newStudent.Name = "Ali";
			newStudent.Grade = 88;
			newStudent.Subject = "HCI";

			Console.WriteLine("All Students ");
			Students.ForEach(student => Console.WriteLine(student));

			Console.WriteLine("All Students order by grade");
			Console.WriteLine(string.Join("\n", Students.OrderBy(s=>s.Grade))); ;

			Console.WriteLine("All Students Subject Software Engineering");

			Console.WriteLine(string.Join("\n", Students.Where(student1 => student1.Subject == "Software Engineering"))); ;

			Students.Insert(1,newStudent);
			Console.WriteLine("Print all after inserting HCI student at position 2");
			Students.ForEach(student => Console.WriteLine(student));

			//Students.RemoveAll(student => student.Subject == "AI");
			//Students.Remove(newStudent);
			Students.RemoveAt(Students.Count - 1);

			Console.WriteLine("Print all after deleting last student");
			Students.ForEach(student => Console.WriteLine(student));


			Console.ReadKey();
		}
	}
}
