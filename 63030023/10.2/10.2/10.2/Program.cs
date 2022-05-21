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
		// เรียกใช้ได้โดยสร้าง instance ของ Student
		Student stu = new Student();
		Student.id = 1002;
		Student.PrintID();
	}
}