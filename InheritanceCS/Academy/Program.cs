//#define INHERITANCE_1
//#define INHERITANCE_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Academy
{
	class Program
	{
		static readonly string delimiter = "\n-----------------------------------\n";
		static void Main(string[] args)
		{
#if INHERITANCE_1
			Console.WriteLine("Academy");
			Human human = new Human("Montana", "Antonio", 25);
			human.Info();
			Console.WriteLine(delimiter);

			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 90, 95);
			student.Info();
			Console.WriteLine(delimiter);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Info();
			Console.WriteLine(delimiter); 
#endif

#if INHERITANCE_2
			Human human = new Human("Pinkman", "Jessie", 22);
			human.Info();
			Console.WriteLine(delimiter);
			Student student = new Student(human, "Chemistry", "WW_220", 90, 95);
			student.Info();
			Console.WriteLine(delimiter);

			Teacher teacher = new Teacher(new Human("White", "Walter", 50), "Chemistry", 25);
			teacher.Info();
			Console.WriteLine(delimiter);

			Human h_hank = new Human("Schreder", "Hank", 40);
			Student s_hank = new Student(h_hank, "Criminalistic", "OBN", 50, 60);
			Graduate graduate = new Graduate(s_hank, "How to catch Heisenberg");
			graduate.Info();
#endif

			//Base-class pointers:
			//Generalisation (Upcast - приведение дочернего объекта к базовому типу)
			Human[] group =
			{
				new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_220", 90, 95),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Graduate("Schreder", "Hank", 40,"Criminalistic", "OBN", 50, 60, "How to catch Heisenberg"),
				new Student("Vercetty", "Tommy", 30, "Theft", "Vice", 98, 99),
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20),
				new Teacher("Schwazenegger", "Arnold", 78, "Heavy Metal", 65)
			};

			Console.WriteLine(delimiter);
			//Specialisation:
			for (int i = 0; i < group.Length; i++)
			{
				//group[i].Info();
				Console.WriteLine(group[i].ToString());
				Console.WriteLine(delimiter);
			}
			Save(group, "group.txt");
		}
		static void Save(Human[] group, string filename)
		{
			StreamWriter writer = new StreamWriter(filename);

			for (int i = 0; i < group.Length; i++)
			{
				writer.WriteLine(group[i].ToStringCSV());
			}

			writer.Close();
			System.Diagnostics.Process.Start("notepad", filename);
		}
	}
}