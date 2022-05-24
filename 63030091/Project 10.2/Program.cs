//using System;
//class Student
//{
	//static public int id;
	//static public void PrintID()
	//{
		//Console.WriteLine($"student ID = {id}");
	//}

//}
//class Program
//{
	//static void Main()
	//{
		// เรียกใช้ได้โดยไม่ต้องสร้าง instance ของ Student
		//Student.id = 1001;
		//Student.PrintID();
	//}
//}

using System;
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