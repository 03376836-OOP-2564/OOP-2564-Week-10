using System;
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