//#define INHERITANCE_CHECK
//#define SAVE_CHECK
#define LOAD_CHECK
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

#if SAVE_CHECK
			Human[] group = new Human[]
				{
				new Graduate("Montana", "Adriana", 43, "Criminalistic","DEA",93, 96, "How to catch"),
				new Student ("Pinkman", "Jessie", 22, "Chemistry", "ww_220", 95, 96),
				new Teacher("White", "Walter", 50, "Chemistry", 25),

				};
			Streamer.Print(group);
			Streamer.Save(group, "group.csv");
			/*StreamWriter gr = new StreamWriter("File.txt");
			for (int i = 0; i < group.Length; i++)
			{
				gr.WriteLine(group[i].ToString());
			}
				gr.Close();
			Process.Start("notepad", "File.txt");*/ 
#endif
#if LOAD_CHECK
			Human[] group = Streamer.Load("group.csv");
			Streamer.Print(group);

#endif
		}

	}
}
