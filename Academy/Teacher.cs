﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Teacher:Human
	{
		public string Speciality {  get; set; }
		public int Experience { get; set; }
		public Teacher
			(
			string lastName, string firstName, int age,
			string speciality, int experiance
			): base(lastName, firstName, age)
		{
			Speciality = speciality;
			Experience = experiance;
			Console.WriteLine($"TConstructor:{GetHashCode()}");
		}
		~Teacher()
		{
			Console.WriteLine($"TDestructor:{GetHashCode()}");
				}
		public override void Print()
		{
			base.Print();
			Console.WriteLine($" {Speciality} {Experience}");
		}
		public override string ToString()
		{
			return base.ToString() + $"{ Speciality} {Experience}";
		}
	}
}