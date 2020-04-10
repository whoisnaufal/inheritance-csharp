using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person("Naufal", 18);
			person.GetNameAndAge();

			Teacher teacher = new Teacher("Ryan", 35, "190302", "Algorithm");
			teacher.GetNameAndAge();

			Student student = new Student("Hafiizh", 18, "19112643", "mohammad.hafiizh@students.amikom.ac.id");
			student.GetNameAndAge();

			Console.ReadKey();
		}
	}
}
