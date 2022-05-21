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
| s1       | 029E8405| -    |
| s2       | 0392A42D| -    |
| s3       | 0027C59A| -    |
| s1.id    |  3E9    | 1001 |
| s1.      | 3A31219F|Computer Engineering    |
| s2.id    |  3EA    | 1002 |
| s2.      | 4CFAF702|Electrical Engineering     |
| s3.id    |  3EB    | 1003 |
| s3.      |7A44CD7F |Mechanical Engineering      |

หลังจากสร้างและกำหนดค่าให้กับ instance ทั้งสามแล้ว ให้บันทึกค่าตัวแปร static ของคลาส (`    `) อีกครั้ง

|   วัตถุ    | hashcode | value|
|----------|--------- |------|
| s1.      |7A44CD7F  |Mechanical Engineering      |
| s2.      |7A44CD7F  |Mechanical Engineering      |
| s3.      |7A44CD7F  |Mechanical Engineering      |


3. สรุปผลการทดลอง
![image](https://user-images.githubusercontent.com/91043042/169653031-0ba52cae-d4e2-4117-b5a7-713b563da886.png)


### คำถาม ###

1. ตัวแปร instance คืออะไร
```
ตัวแปรชนิดหนึ่งที่คงอยู่ และทำงานในระดับของ Class กระบวนการทำงานนั้นจะเกิดพร้อมกับการทำงานของ Class
```

2. ตัวแปร static คืออะไร
```
คือ ประเภทตัวแปรแบบหนึ่งที่มีการใช้คำสั่ง (Keyword) ว่า static วางไว้ข้างหน้าตัวแปร เพื่อประกาศให้โปรแกรมรู้ว่า ตัวแปรนี้เป็นตัวแปรแบบ static ของ class
```

3. ตัวแปรทั้งสอง ทำงานต่างกันอย่างไร
```
 ตัว  instance จะกระทำกับตัว oject โดยตรง
 ตัว static มีพฤติกรรมที่ไม่ขึ้นอยู่กับ object ใดๆ
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
![image](https://user-images.githubusercontent.com/91043042/169653576-c1c3c025-1619-454e-8475-70872f150d3a.png)

4. แก้ไข code ให้เป็นดังต่อไปนี้

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
![image](https://user-images.githubusercontent.com/91043042/169653661-432e3a01-94e9-44d6-8bd1-618a7933fc06.png)

###  คำถาม ### 
1. จงเปรียบเทียบผลที่ได้จากการรัน source code ในข้อ 1 และ ข้อ 3 ว่าเหมือนกันหรือไม่
```
	ผลต่างกัน
```
2. เหตุใดผลการเปรียบเทียบจึงเป็นเช่นนั้น
```
	ข้อ 1 ตัวแปรเป็นแบบ static
	ข้อ 3 ตัวแปรเป็นแบบ public
```

