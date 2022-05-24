# Instance vs Static member #

##  การทดลองที่ 10.1 ##

1. ให้นักศึกษาสร้าง project ชนิด console แล้วแก้ไข  sourrce code ตามโปรแกรมด้านล่างนี้


```cs
class Student
{
    int id;                 // instance member
    static string id2;    // static member
    internal void SetId(int value)
    {
        id = value;
        ShowId();
    }
    internal void Set(string value)
    {
        id2 = value;
        Show();
    }

    internal void ShowId()
    {
        Console.WriteLine($"id : hashcode = [{this.id.GetHashCode():X}], value = {id}");
    }

    internal unsafe void Show()
    {
        Console.WriteLine($"id2 : hashcode = [{Student.id2.GetHashCode():X}], value = {id2}");
    }
}

class Program
{
    static void Main()
    {
        //  สร้าง instance "s1"
        Student s1 = new Student();
        Console.WriteLine($"Instance 's1' Hashcode = {s1.GetHashCode():X8}");

        //  สร้าง instance "s2"
        Student s2 = new Student();
        Console.WriteLine($"Instance 's2' Hashcode = {s2.GetHashCode():X8}");

        //  สร้าง instance "s3"
        Student s3 = new Student();
        Console.WriteLine($"Instance 's3' Hashcode = {s3.GetHashCode():X8}");
        Console.WriteLine();

        //  กำหนดและแสดงค่าใน member ของ s1
        s1.SetId(1001);
        s1.Set("Computer Engineering");
        Console.WriteLine();

        //  กำหนดและแสดงค่าใน member ของ s2
        s2.SetId(1002);
        s2.Set("Electrical Engineering");
        Console.WriteLine();

        //  กำหนดและแสดงค่าใน member ของ s3
        s3.SetId(1003);
        s3.Set("Mechanical Engineering");
        Console.WriteLine();

        //  แสดงค่าใน static member ของ s1-s3 อีกครั้ง
        Console.Write("S1."); s1.Show();
        Console.Write("S2."); s2.Show();
        Console.Write("S3."); s3.Show();
    }
} 

```

2. เติมค่าลงในตารางต่อไปนี้ให้ครบถ้วน


|  วัตถุ  |hashcode| 	   value	  |
|:-----:|:------:|:--------------------:|
| s1    |0378734A| -    	      	|
| s2    |033C0D9D| -    	      	|
| s3    |011C7A8C| -    	      	|
| s1.id |3E9	 |1001			|
| s1.id2|48F2F7CF|Computer Engineering	|
| s2.id |3EA	 |1002			|
| s2.id2|34EF076|Electrical Engineering|
| s3.id |3EB	 |1003			|
| s3.id2|2BDBFBE5|Mechanical Engineering|

หลังจากสร้างและกำหนดค่าให้กับ instance ทั้งสามแล้ว ให้บันทึกค่าตัวแปร static ของคลาส (`    `) อีกครั้ง

|   วัตถุ    |hashcode| 	value	     |
|----------|--------|----------------------|
| s1.id2   |2BDBFBE5|Mechanical Engineering|
| s2.id2   |2BDBFBE5|Mechanical Engineering|
| s3.id2   |2BDBFBE5|Mechanical Engineering|


3. สรุปผลการทดลอง

![10 1](https://user-images.githubusercontent.com/89035964/167916502-3bc4488d-8544-42f7-98bf-f5ac64d1463b.png)


### คำถาม ###
1. ตัวแปร instance คืออะไร
```
  คือตัวแปรที่ถูกประกาศภายใน Class เท่านั้น ไม่อยู่นอก method, constructor หรือ block สามารถเข้าถึงได้โดยตรงจากการเรียกใช้งานภายใน Class 
  หรือเรียกภายนอก Class ผ่านทาง Interface Public Method
```
2. ตัวแปร static คืออะไร
```
  คือตัวแปรที่มีค่าคงที่ เมื่อเราประกาศค่าให้กับตัวแปร ค่าของตัวแปรนั้นจะมีค่าคงที่ไม่เปลี่ยนแปลง
```
3. ตัวแปรทั้งสอง ทำงานต่างกันอย่างไร
```
  instance จะถูกสร้างขึ้นใหม่เมื่อมีการสร้าง Object
  static จะถูกสร้างเพียงแค่ครั้งเดียวและค่าจะไม่เปลี่ยนแปลง
```
4. ตัวแปรทั้งสอง ให้ผลต่างกันอย่างไร

```
  instance สามารถเข้าถึงได้โดยตรงจากการเรียกใช้งานภายใน Class หรือเรียกภายนอก Class และการสร้าง Object
  static สามารถถูกเรียกใช้งานได้ทันทีจากภายใน Class และค่าของตัวแปรจะคงที่ไม่เปลี่ยนแปลง
```


##  การทดลองที่ 10.2 ##

1. ให้นักศึกษาสร้าง project ชนิด console แล้วแก้ไข  sourrce code ตามโปรแกรมด้านล่างนี้

```cs
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
```

2. บันทึกผลจากการรันโปรแกรม
![10 2 2](https://user-images.githubusercontent.com/89035964/167917159-d5e63c6e-c0e0-4406-a5e5-42dbcb91b39b.png)

3. แก้ไข code ให้เป็นดังต่อไปนี้

```cs
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
		stu.id = 1002;
		stu.PrintID();
	}
}
```
4. บันทึกผลจากการรันโปรแกรม
![10 2 4](https://user-images.githubusercontent.com/89035964/167917170-a6660593-4def-4d4b-8c19-8d8dd4d6f0c7.png)

###แก้ไขโปรแกรมแล้ว###

![10 2 5](https://user-images.githubusercontent.com/89035964/167917604-2661e7f1-25ed-4bf4-9d59-802297e1ab0f.png)


###  คำถาม ### 
1. จงเปรียบเทียบผลที่ได้จากการรัน source code ในข้อ 1 และ ข้อ 3 ว่าเหมือนกันหรือไม่
```
   ผลที่ได้จากการรันโปรแกรมไม่เหมือนกัน
```
2. เหตุใดผลการเปรียบเทียบจึงเป็นเช่นนั้น

```
   ในข้อ 1 เป็นการประกาศตัวแปรและ method ให้เป็นแบบ static และเรียกใช้งานโดยกำหนดค่าให้กับตัวแปร id ของ Student
   ในข้อ 3 เป็นการประกาศตัวแปรและ method ให้เป็น public และเรียกใช้งานโดยสร้าง instance ของ Student
```

