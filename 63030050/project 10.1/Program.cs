using System;

namespace PJ_10._2
{
	class Student
	{
		public int id;
		public void PrintID()
		{
			Console.WriteLine($"student ID = {id}");
		}

	}
	class Program
	{
		static void Main()
		{
			// เรียกใช้ได้โดยสร้าง instance ของ Student
			Student stu = new Student();
			stu.id = 1002;
			stu.PrintID();
		}
	}
}
