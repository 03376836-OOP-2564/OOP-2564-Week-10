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
        static string Branch;    // static member
        internal void SetId(int value)
        {
            id = value;
            ShowId();
        }
        internal void SetBranch(string value)
        {
            Branch = value;
            ShowBranch();
        }

        internal void ShowId()
        {
            Console.WriteLine($"id : hashcode = [{this.id.GetHashCode():X}], value = {id}");
        }

        internal unsafe void ShowBranch()
        {
            Console.WriteLine($"Branch : hashcode = [{Branch.GetHashCode():X}], value = {Branch}");
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
            s1.SetBranch("Computer Engineering");
            Console.WriteLine();

            //  กำหนดและแสดงค่าใน member ของ s2
            s2.SetId(1002);
            s2.SetBranch("Electrical Engineering");
            Console.WriteLine();

            //  กำหนดและแสดงค่าใน member ของ s3
            s3.SetId(1003);
            s3.SetBranch("Mechanical Engineering");
            Console.WriteLine();

            //  แสดงค่าใน static member ของ s1-s3 อีกครั้ง
            Console.Write("S1."); s1.ShowBranch();
            Console.Write("S2."); s2.ShowBranch();
            Console.Write("S3."); s3.ShowBranch();
        }
    }
}


```

2. เติมค่าลงในตารางต่อไปนี้ให้ครบถ้วน


| วัตถุ         | hashcode | value                  |
|-------------|----------|------------------------|
| s1          | 0378734A | -                      |
| s2          | 033C0D9D | -                      |
| s3          | 011C7A8C | -                      |
| s1.id       | 3E9      | 1001                   |
| s1.Branch   | 28531D3C | Computer Engineering   |
| s2.id       | 3EA      | 1002                   |
| s2.Branch   | 1D6164DD | Electrical Engineering |
| s3.id       | 3EB      | 1003                   |
| s3.Branch   | E17AE63B | Mechanical Engineering |

หลังจากสร้างและกำหนดค่าให้กับ instance ทั้งสามแล้ว ให้บันทึกค่าตัวแปร static ของคลาส (`    `) อีกครั้ง

| วัตถุ         | hashcode | value                   |
|-------------|----------|-------------------------|
| s1.Branch   | E17AE63B | Mechanical Engineering  |
| s2.Branch   | E17AE63B | Mechanical Engineering  |
| s3.Branch   | E17AE63B | Mechanical Engineering  |


3. สรุปผลการทดลอง

![image](https://user-images.githubusercontent.com/92082299/169664808-c674a9e7-85ae-40e4-9997-fc216c386285.png)

### คำถาม ###
1. ตัวแปร instance คืออะไร
```
   ตัวแปร instance คือ ตัวแปรที่ถูกประกาศภายใน Class เท่านั้น ซึ่งสามารถเข้าถึงได้โดยตรงจากการเรียกใช้งานภายใน Class หรือเรียกใช้งานภายนอก Class ผ่านทาง Interface Public Method
```
2. ตัวแปร static คืออะไร
```
   ตัวแปร static คือ ตัวแปรที่มีค่าคงที่ ซึ่งเมื่อมีการประกาศค่าให้ตัวแปรแล้วก็จะมีค่าคงที่ไม่เปลี่ยนแปลง
```
3. ตัวแปรทั้งสอง ทำงานต่างกันอย่างไร
```
   ตัวแปรทั้งสองทำงานต่างกัน คือ 
   ตัวแปร instance ถูกสร้างขึ้นมาใหม่เมื่อมีการสร้าง object 
   ตัวแปร static ถูกสร้างเพียงครั้งเดียว โดยที่ค่าจะเหมือนเดิมไม่เปลี่ยนแปลง
```
4. ตัวแปรทั้งสอง ให้ผลต่างกันอย่างไร
```
   ตัวแปรทั้งสองให้ผลต่างกัน คือ 
   ตัวแปร instance จะเข้าถึงได้โดยตรงจากการเรียกใช้งานภายในหรือภายนอก Class หรือการสร้าง Object 
   ตัวแปร static จะถูกเรียกใช้งานได้ทันทีจากภายใน Class โดยที่ค่าจะเหมือนเดิมไม่เปลี่ยนแปลง
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

![image](https://user-images.githubusercontent.com/92082299/169665084-ee24f7be-7ddd-4d54-a5c0-6de5b6d7d98f.png)

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

![image](https://user-images.githubusercontent.com/92081884/168960075-53811cf8-6641-4b93-a95d-7299f28f631c.png)

###  คำถาม ### 
1. จงเปรียบเทียบผลที่ได้จากการรัน source code ในข้อ 1 และ ข้อ 3 ว่าเหมือนกันหรือไม่
```
   ผลที่ได้จากการรัน source code ในข้อ 1 และ ข้อ 3 ไม่ต่างกัน แต่ไม่เหมือนกันที่ค่าที่กำหนดให้แสดง
```
2. เหตุใดผลการเปรียบเทียบจึงเป็นเช่นนั้น
```
   เนื่องจากในข้อ 1 method เป็นแบบ static ที่เรียกใช้งานได้โดยการให้ค่ากับตัวแปร id ของ Student
   ส่วนในข้อ 3 method เป็นแบบ public ที่เรียกใช้งานได้โดยสร้าง instance ของ Student
   แต่ทั้งสองวิธีเมื่อรันก็ได้ผลที่ไม่ต่างกัน แต่ไม่เหมือนกันที่การสร้างและการเรียกใช้
```


