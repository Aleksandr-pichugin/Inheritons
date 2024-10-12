using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Graduate : Student
	{
		public string Subject { get; set; }

		public Graduate
			(
			string lastName, string firstName, int Age,
			string speciality, string group, double rating, double attendance,
			string subject
			) : base(lastName, firstName, Age, speciality, group, rating, attendance)
		{
			Subject = Subject;
			Console.WriteLine($"SConstructor:{GetHashCode()}");
		}
		~Graduate()
		{
			Console.WriteLine($"SDestructor:{GetHashCode()}");
		}
		/*public void Print()
		{
			base.Print();
			Console.WriteLine(Subject);
		}*/
		public override string ToString()
		{
			return base.ToString() + Subject;
		}
		public override string ToFileString()
		{
			return base.ToFileString()+$";{Subject}";
		}
	}
}
