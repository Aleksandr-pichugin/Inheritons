//#define INHERITANCE_CHECK
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Http.Headers;


namespace Academy
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if INHERITANCE_CHECK
			Human human = new Human("Montana ", "Antonio", 25);
			human.Print();
			Console.WriteLine(human);

			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW_22 ", 95, 96);
			student.Print();
			Console.WriteLine(student);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Print();
			Console.WriteLine(teacher); 
#endif

			Human[] group = new Human[]
			{
				new Graduate("Montana", "Adriana", 43, "Criminalistic","DEA",93, 96, "How to catch"),
				new Student ("Pinkman", "Jessie", 22, "Chemistry", "ww_220", 95, 96),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
			
			};
			Print (group);
			Save(group, "group.txt");
			/*StreamWriter gr = new StreamWriter("File.txt");
			for (int i = 0; i < group.Length; i++)
			{
				gr.WriteLine(group[i].ToString());
			}
				gr.Close();
			Process.Start("notepad", "File.txt");*/
		}
		static void Print(Human[] group)
		{
			for (int i = 0; i < group.Length; i++)
			{
			 Console.WriteLine(group[i]);
			}
			Console.WriteLine();

		}
		static void Save(Human[] group, string filename)
		{
			StreamWriter sw= new StreamWriter(filename);
			for (int i = 0; i < group.Length; i++)
			{
			sw.WriteLine(group[i]);
			}
			sw.Close();
			Process.Start("notepad", filename);
		}
	}
}
