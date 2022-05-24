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
        internal void Set(string value)
        {
                 id2= value;
            Show();
        }

        internal void ShowId()
        {
            Console.WriteLine($"id : hashcode = [{this.id.GetHashCode():X}], value = {id}");
        }

        internal unsafe void Show()
        {
            Console.WriteLine($"id2 : hashcode = [{id2.GetHashCode():X}], value = {id2}");
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
}

```

2. เติมค่าลงในตารางต่อไปนี้ให้ครบถ้วน


|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1       | 0378734A | -    |
| s2       | 033C0D9D | -    |
| s3       | 011C7A8C | -    |
| s1.id    | 3E9 | 1001 |
| s1.id2   | 23FFB3B6 | Computer Engineering |
| s2.id    | 3EA | 1002 |
| s2.id2   | 8FCDF26A | Electrical Engineering |
| s3.id    | 3EB | 1003 |
| s3.id2   | 3EB6DD22 | Mechanical Engineering |

หลังจากสร้างและกำหนดค่าให้กับ instance ทั้งสามแล้ว ให้บันทึกค่าตัวแปร static ของคลาส (`    `) อีกครั้ง

|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1.id2   | 3EB6DD22 | Mechanical Engineering |
| s2.id2   | 3EB6DD22 | Mechanical Engineering |
| s3.id2   | 3EB6DD22 | Mechanical Engineering |


3. สรุปผลการทดลอง
	จาการทดลองทำให้สามารถแก้ไขโค้ด โดยสร้างตัวแปรใหม่ขึ้นมา ทำให้เรียนรู้ hash code
	![image](https://user-images.githubusercontent.com/92079547/169322845-0f309385-a390-4376-a9a8-8e6a482a198b.png)


### คำถาม ###
1. ตัวแปร instance คืออะไร

Instance Variable คือ ตัวแปรชนิดหนึ่งที่คงอยู่

2. ตัวแปร static คืออะไร

Static Variable คือ ประเภทตัวแปรแบบหนึ่งที่มีการใช้คำสั่ง (Keyword) ว่า static วางไว้ข้างหน้าตัวแปร

3. ตัวแปรทั้งสอง ทำงานต่างกันอย่างไร

ตัวแปรแบบ Static หรือตัวแปรของ Class นั้นจะมีการประกาศคล้ายๆ กับตัวแปรแบบ Instance โดยจะแตกต่างกันที่ ตัวแปรแบบ Static นั้นจะมีการประกาศคำว่า Static เอาไว้ข้างหน้าของตัวแปรเช่น static String testStatic; และข้อแตกต่างอีกอย่างหนึ่งก็คือ ตัวแปรแบบ Static จะเอาไว้ใช้กับคลาสเท่านั้น ซึ่งคลาสจะสามารถมีได้แค่ 1 คลาส ส่วนตัวแปรแบบ Instance นั้นจะเกิดขึ้นก็ต่อเมื่อมีการสร้าง Object ขึ้นมา ซึ่ง Object ต่างๆก็จะเกิดขึ้นมาจากคลาส แต่คลาส 1 คลาสสามารถสร้าง Object ได้ไม่จำกัด โดยที่ตัวแปรแบบ Instance นั้นจะใช้ได้แค่ใน Object เดียว ซึ่งถ้าหากเราทำการสร้าง Object ใหม่อีกเราก็จะได้ตัวแปรอันใหม่สำหรับ Object ที่เราสร้างใหม่ ซึ่งไม่เกี่ยวกับ Object เดิมที่เคยสร้างไว้

4. ตัวแปรทั้งสอง ให้ผลต่างกันอย่างไร

Static method สามารถทำได้ผ่านชื่อคลาสโดยตรง โดยไม่จำเป็นต้องสร้างออบเจ็คเหมือนกับ Instance method




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
![image](https://user-images.githubusercontent.com/92079547/169323753-8b0ee808-70e1-48b4-a442-8db910dcfe5c.png)

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
![image](https://user-images.githubusercontent.com/92079547/169324146-6e26f8b5-3b2f-4ece-81b1-309a5945a868.png)

###  คำถาม ### 
1. จงเปรียบเทียบผลที่ได้จากการรัน source code ในข้อ 1 และ ข้อ 3 ว่าเหมือนกันหรือไม่

แตกต่างกัน โดยข้อที่ 1 จะแสดงผลว่า student ID = 1001 แต่ข้อที่ 2 จะแสดงผล student ID = 1002

2. เหตุใดผลการเปรียบเทียบจึงเป็นเช่นนั้น

เนื่องจากมีการเปลี่ยนแปลงโค้ด




