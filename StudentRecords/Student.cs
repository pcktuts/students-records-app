using System;
using System.Collections.Generic;

namespace StudentRecords
{
	public class Student
	{
		public int Roll { get; set; }
		public int Total { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
		private readonly List<Student> Students = new List<Student>();

		public void AddStudent()
		{
			try
			{
				Console.Write("Enter the Roll No: ");
				Roll = int.Parse(Console.ReadLine());
				Console.Write("Enter the Name: ");
				Name = Console.ReadLine();
				Console.Write("Enter the Gender: ");
				Gender = Console.ReadLine();
				Console.Write("Enter the Total Marks: ");
				Total = int.Parse(Console.ReadLine());
				Students.Add(
					new Student()
					{
						Roll = Roll,
						Name = Name,
						Gender = Gender,
						Total = Total
					});
				Console.WriteLine("Successfully Added the details:");

			}
			catch (Exception)
			{
				//Console.WriteLine(e);
				Console.WriteLine("Something went wrong, please try again");
				AddStudent();
			}

		}
		public void DisplayStudents()
		{
			Console.WriteLine("=====================================================");
			Console.WriteLine("Roll no\t\tName\t\tTotal\t\tGender");
			Students.ForEach(x =>
			{
				Console.WriteLine(
					x.Roll + "\t\t" +
					x.Name + "\t\t" +
					x.Total + "\t\t" +
					x.Gender + "\t\t\n"
					);

			});
			Console.WriteLine("=====================================================");
		}
		public void UpdateStudent()
		{
			try
			{

				DisplayStudents();
				Console.Write("Enter Roll Number to update: ");
				Roll = int.Parse(Console.ReadLine());
				Student updateStudent = Students.Find(x => x.Roll == Roll);
				if (updateStudent is null)
				{
					Console.WriteLine("No student found with such Roll number, try agian");
					UpdateStudent();
				}


				Console.WriteLine("If you do not want to update a property enter nothing");
				Console.Write("Enter the Name: [" + updateStudent.Name + "]");
				Name = Console.ReadLine();
				if (Name != "")
				{
					updateStudent.Name = Name;
				}
				Console.Write("Enter Gender: [" + updateStudent.Gender + "]");
				Gender = Console.ReadLine();
				if (Gender != "")
				{
					updateStudent.Gender = Gender;
				}
				Console.Write("Enter the Total Marks: [" + updateStudent.Total + "]");
				var input = Console.ReadLine() ?? null;
				
				if (!string.IsNullOrEmpty(input))
				{
					int? t = int.Parse(input);
					updateStudent.Total = (int)t;
				}

				DisplayStudents();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				Console.WriteLine("Something went wrong, please try again");
				UpdateStudent();
			}

			Console.Write("Student has been updated");
		}
		public void DeleteStudent()
		{
			try
			{
				DisplayStudents();
				Console.Write("Enter Roll Number to delete: ");
				Roll = int.Parse(Console.ReadLine());
				Student deleteStudent = Students.Find(x => x.Roll == Roll);
				if (deleteStudent is null)
				{
					Console.WriteLine("No student found with such Roll number, try agian");
					DeleteStudent();
				}
				Console.Write("Are you sure you want to delete?[y/n]");
				retry:
				var confirm = Console.ReadLine();
				if(confirm == "y")
                {
					Students.Remove(deleteStudent);
					Console.WriteLine("Student has been deleted");
					DisplayStudents();
				} else if (confirm == "n")
                {
					Console.WriteLine("Delete has been cancelled");
					DisplayStudents();
				}
                else
				{
					Console.WriteLine("Invalid input, try agian");
					goto retry;

				} 
				

			}
			catch (Exception)
			{
				Console.WriteLine("Something went wrong please try again");
				DeleteStudent();
			}
		}
	}
}
