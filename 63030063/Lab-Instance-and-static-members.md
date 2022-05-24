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
        static string     ;    // static member
        internal void SetId(int value)
        {
            id = value;
            ShowId();    
        }
        internal void Set    (string value)
        {
                 = value;
            Show    ();
        }

        internal void ShowId()
        {
            Console.WriteLine($"id : hashcode = [{this.id.GetHashCode():X}], value = {id}");
        }

        internal unsafe void Show    ()
        {
            Console.WriteLine($"     : hashcode = [{    .GetHashCode():X}], value = {    }");
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
            s1.Set    ("Computer Engineering");
            Console.WriteLine();

            //  กำหนดและแสดงค่าใน member ของ s2
            s2.SetId(1002);
            s2.Set    ("Electrical Engineering");
            Console.WriteLine();

            //  กำหนดและแสดงค่าใน member ของ s3
            s3.SetId(1003);
            s3.Set    ("Mechanical Engineering");
            Console.WriteLine();

            //  แสดงค่าใน static member ของ s1-s3 อีกครั้ง
            Console.Write("S1."); s1.Show    ();
            Console.Write("S2."); s2.Show    ();
            Console.Write("S3."); s3.Show    ();
        }
    }
}

```

2. เติมค่าลงในตารางต่อไปนี้ให้ครบถ้วน


|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1            |0378734A       | -    |
| s2            | 033C0D9D      | -    |
| s3            | 011C7A8C      | -    |
| s1.id         | 3E9           | 1001     |
| s1.           | A6DE2AC9      | Computer Engineering     |
| s2.id         | 3EA           |  1002    |
| s2.           |  A98E4CE7     | Electrical Engineering     |
| s3.id         | 3EB           |   1003   |
| s3.           | 822D57AB      | Mechanical Engineering     |

หลังจากสร้างและกำหนดค่าให้กับ instance ทั้งสามแล้ว ให้บันทึกค่าตัวแปร static ของคลาส (`    `) อีกครั้ง

|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1.      | 822D57AB        |  Mechanical Engineering    |
| s2.      | 822D57AB        | Mechanical Engineering     |
| s3.      | 822D57AB        | Mechanical Engineering     |


3. สรุปผลการทดลอง
![p10_1](./pic/p10_1.PNG)
### คำถาม ###
1. ตัวแปร instance คืออะไร

ตอบ เป็นตัวแปรที่ทำงานใน Class และจะไม่อยู่นอก Method, Constructor กระบวนการทำงานนั้นจะเกิดพร้อมกับการทำงานของ Class 

2. ตัวแปร static คืออะไร

 ตอบ ประเภทตัวแปรแบบหนึ่งที่มีการใช้คำสั่ง (Keyword) ว่า static วางไว้ข้างหน้าตัวแปร เพื่อประกาศให้โปรแกรมรู้ว่า ตัวแปรนี้เป็นตัวแปรแบบ static ของ class โดยเป็นตัวแปรแบบค่าคงที่
    
3. ตัวแปรทั้งสอง ทำงานต่างกันอย่างไร

ตอบ ตัวแปรแบบ instance จะถูกสร้างขึ้นมาเมื่อมีการสร้าง Objectและตัวแปรแบบ static จะใช้กับ Class เท่านั้น ซึ่ง Class จะสามารถมีได้แค่ Class เดียว

4. ตัวแปรทั้งสอง ให้ผลต่างกันอย่างไร

ตอบ ตัวแปรแบบ instance เป็นตัวแปรที่สามารถเข้าถึงได้โดยการสร้าง Object ของ Classและตัวแปรแบบ static เป็นตัวแปรที่ค่าคงทีแบบตายตัว เป็นค่าที่คงที่ไม่เปลี่ยนแปลง



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
![p10_2_1](./pic/p10_2_1.PNG)
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
![p10_2_2](./pic/p10_2_2.PNG)
###  คำถาม ### 
1. จงเปรียบเทียบผลที่ได้จากการรัน source code ในข้อ 1 และ ข้อ 3 ว่าเหมือนกันหรือไม่

ตอบ    ผลที่ได้จากการรันโปรแกรมแตกต่างกัน

2. เหตุใดผลการเปรียบเทียบจึงเป็นเช่นนั้น

ตอบ ข้อ 1 เป็น Method แบบ Statid
    ข้อ 2 เป็น method แบบ Instance



