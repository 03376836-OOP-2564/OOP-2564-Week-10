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

        internal unsafe void ShowId2()
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
| s1       |0378734A | -    |
| s2       |033C0D9D | -    |
| s3       |011C7A8C | -    |
| s1.id    |3E9      |1001  |
| s1.      |AB0A91D1 |Computer Engineering  |
| s2.id    |3EA      |1002  |
| s2.      |6F43B3FF |Electrical Engineering  |
| s3.id    |3EB      |1003  |
| s3.      |B3DAE0B  |Mechanical Engineering  |

หลังจากสร้างและกำหนดค่าให้กับ instance ทั้งสามแล้ว ให้บันทึกค่าตัวแปร static ของคลาส (`    `) อีกครั้ง

|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1.      |B3DAE0B  |Mechanical Engineering      |
| s2.      |B3DAE0B  |Mechanical Engineering      |
| s3.      |B3DAE0B  |Mechanical Engineering      |

![image](https://user-images.githubusercontent.com/91675464/168088001-a16470a0-a635-4397-90ef-1262a025beb1.png)

3. สรุปผลการทดลอง

### คำถาม ###
1. ตัวแปร instance คืออะไร
```
  Instance คือ ตัวแปรชนิดหนึ่งที่คงอยู่ และทำงานในระดับของ Class กระบวนการทำงานนั้นจะเกิดพร้อมกับการทำงานของ Class ไม่อยู่นอก method, constructor 
  หรือ block สามารถเข้าถึงได้โดยตรงจากการเรียกใช้งานภายใน Class หรือเรียกภายนอก Class ผ่านทาง Interface Public Method
```
2. ตัวแปร static คืออะไร
```
  คือตัวแปรที่มีค่าคงที่ เมื่อเราประกาศค่าให้กับตัวแปร ค่าของตัวแปรนั้นจะมีค่าคงที่ไม่เปลี่ยนแปลง 
  เราสามารถใช้ static ได้กับตัวแปร (variable), ฟังก์ชั่น (method) และอื่นๆ ได้โดยการประกาศไว้ก่อน data type
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

![image](https://user-images.githubusercontent.com/91675464/168093136-126e76e9-a9eb-4208-8747-f9a5e1d9451c.png)

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

![image](https://user-images.githubusercontent.com/91675464/168093915-1a56e46d-aa54-485b-9808-3820bb1b1065.png)


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



