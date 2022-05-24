# Instance vs Static member #

##  การทดลองที่ 10.1 ##

1. ให้นักศึกษาสร้าง project ชนิด console แล้วแก้ไข  sourrce code ตามโปรแกรมด้านล่างนี้


```cs
using System;

namespace method_examples
{
    class Student
    {
        int id;                 // instance member
        static string id2;    // static member
        internal void SetId(int value)
        {
            id = value;
            ShowId();
        }
        internal void SetId2(string value)
        {
            id2 = value;
            ShowId2();
        }

        internal void ShowId()
        {
            Console.WriteLine($"id : hashcode = [{this.id.GetHashCode():X}], value = {id}");
        }

        internal void ShowId2()
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
            s1.SetId2("Computer Engineering");
            Console.WriteLine();

            //  กำหนดและแสดงค่าใน member ของ s2
            s2.SetId(1002);
            s2.SetId2("Electrical Engineering");
            Console.WriteLine();

            //  กำหนดและแสดงค่าใน member ของ s3
            s3.SetId(1003);
            s3.SetId2("Mechanical Engineering");
            Console.WriteLine();

            //  แสดงค่าใน static member ของ s1-s3 อีกครั้ง
            Console.Write("S1."); s1.ShowId2();
            Console.Write("S2."); s2.ShowId2();
            Console.Write("S3."); s3.ShowId2();
        }
    }
}

```

2. เติมค่าลงในตารางต่อไปนี้ให้ครบถ้วน


|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1       |029E8405 | -    |
| s2       |0392A42D | -    |
| s3       |0027C59A | -    |
| s1.id    |3E9      |1001  |
| s1.     |336628C9  |Computer Engineering |
| s2.id    |3EA     |1002   |
| s2.     |8E5E4AEF |Electrical Engineering |
| s3.id    |3EB     |1003   |
| s3.     |D064EC42 |Mechanical Engineering |

หลังจากสร้างและกำหนดค่าให้กับ instance ทั้งสามแล้ว ให้บันทึกค่าตัวแปร static ของคลาส (`    `) อีกครั้ง

|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1.     |D064EC42  |Mechanical Engineering |
| s2.     |D064EC42  |Mechanical Engineering |
| s3.     |D064EC42  |Mechanical Engineering |

![image](https://user-images.githubusercontent.com/92079514/168632389-3dffe3a5-f8c7-4716-b6b9-d20d5094146e.png)

3. สรุปผลการทดลอง

### คำถาม ###
1. ตัวแปร instance คืออะไร

  -Instance คือ ตัวแปรชนิดหนึ่งที่คงอยู่ และทำงานในระดับของ Class กระบวนการทำงานนั้นจะเกิดพร้อมกับการทำงานของ Class ไม่อยู่นอก method, constructor หรือ block สามารถเข้าถึงได้โดยตรงจากการเรียกใช้งานภายใน Class หรือเรียกภายนอก Class ผ่านทาง Interface Public Method
  
2. ตัวแปร static คืออะไร
  
  -ประเภทตัวแปรแบบหนึ่งที่มีการใช้คำสั่ง (Keyword) ว่า static วางไว้ข้างหน้าตัวแปร เพื่อประกาศให้โปรแกรมรู้ว่า ตัวแปรนี้เป็นตัวแปรแบบ static ของ class โดยเป็นตัวแปรแบบค่าคงที่
  
3. ตัวแปรทั้งสอง ทำงานต่างกันอย่างไร
   
   -ตัวแปรแบบ instance จะถูกสร้างขึ้นมาเมื่อมีการสร้าง Objectและตัวแปรแบบ static จะใช้กับ Class เท่านั้น ซึ่ง Class จะสามารถมีได้แค่ Class เดียว
   
4. ตัวแปรทั้งสอง ให้ผลต่างกันอย่างไร
  
  -instance สามารถเข้าถึงได้โดยตรงจากการเรียกใช้งานภายใน Class หรือเรียกภายนอก Class และการสร้าง Object
  -static สามารถถูกเรียกใช้งานได้ทันทีจากภายใน Class และค่าของตัวแปรจะคงที่ไม่เปลี่ยนแปลง

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

![image](https://user-images.githubusercontent.com/92079514/168635959-9bfd739a-da79-479c-b1cc-2ca6296f15d4.png)

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

![image](https://user-images.githubusercontent.com/92079514/168636080-a63d5d8d-2fb1-4e68-b1a5-fa24a75aac7e.png)

###  คำถาม ### 
1. จงเปรียบเทียบผลที่ได้จากการรัน source code ในข้อ 1 และ ข้อ 3 ว่าเหมือนกันหรือไม่
   
   -ผลที่ได้จากการรันโปรแกรมไม่เหมือนกัน

2. เหตุใดผลการเปรียบเทียบจึงเป็นเช่นนั้น
   
   -ข้อที่ 1 จะเป็นการประกาศตัวแปรและ method ให้เป็นแบบ static และเรียกใช้งานโดยกำหนดค่าให้กับตัวแปร id ของ Student
   ส่วนในข้อที่ 3 จะเป็นการประกาศตัวแปรและ method ให้เป็นแบบ public และเรียกใช้งานโดยสร้าง instance ของ Student


