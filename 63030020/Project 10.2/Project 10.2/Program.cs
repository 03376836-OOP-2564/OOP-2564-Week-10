using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10._2
{
	class Student
	{
		static public int id;
		static public void PrintID()
		{
			Console.WriteLine($"student ID = {id}");
		}

	}
	class Program
	{
		static void Main()
		{
			// เรียกใช้ได้โดยไม่ต้องสร้าง instance ของ Student
			Student.id = 1001;
			Student.PrintID();
		}
	}
}
