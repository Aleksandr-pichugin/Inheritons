using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Graduate : Student
	{
		public string Work { get; set; }

		public int Estimation { get; set; }
		public Graduate
			(
			string lastName, string firstName, int Age,
			string speciality, string group, double rating, double attendance,
			string work, int estimation
			) : base(lastName, firstName, Age, speciality, group, rating, attendance)
		{
			Work = work;
			Estimation = estimation;
			Console.WriteLine($"SConstructor:{GetHashCode()}");
		}
		~Graduate()
		{
			Console.WriteLine($"SDestructor:{GetHashCode()}");
		}
		public void Print()
		{
			base.Print();
			Console.WriteLine($"{Work} {Estimation}");
		}
		public override string ToString()
		{
			return base.ToString() + $"{Work} {Estimation}";
		}

	}
}
