# Instance vs Static member #

##  การทดลองที่ 10.1 ##

1. ให้นักศึกษาสร้าง project ชนิด console แล้วแก้ไข  sourrce code ตามโปรแกรมด้านล่างนี้


```cs
using System;

namespace Project_10._1
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
            Console.WriteLine($"id2: hashcode = [{ id2   .GetHashCode():X}], value = { id2   }");
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
            s1.SetId2    ("Computer Engineering");
            Console.WriteLine();

            //  กำหนดและแสดงค่าใน member ของ s2
            s2.SetId(1002);
            s2.SetId2    ("Electrical Engineering");
            Console.WriteLine();

            //  กำหนดและแสดงค่าใน member ของ s3
            s3.SetId(1003);
            s3.SetId2    ("Mechanical Engineering");
            Console.WriteLine();

            //  แสดงค่าใน static member ของ s1-s3 อีกครั้ง
            Console.Write("S1."); s1.ShowId2    ();
            Console.Write("S2."); s2.ShowId2    ();
            Console.Write("S3."); s3.ShowId2    ();
        }
    }
}


```

2. เติมค่าลงในตารางต่อไปนี้ให้ครบถ้วน


|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1       |0378734A| -    |
| s2       |033C0D9D| -    |
| s3       |011C7A8C| -    |
| s1.id    | 3E9  | 1001 |
| s1.     | 561C0278 |Computer Engineering|
| s2.id    | 3EA  |1002 |
| s2.     | 9BFCA87B |Electrical Engineering|
| s3.id    | 3EB | 1003|
| s3.     | CB90581D |Mechanical Engineering|

หลังจากสร้างและกำหนดค่าให้กับ instance ทั้งสามแล้ว ให้บันทึกค่าตัวแปร static ของคลาส (`    `) อีกครั้ง

|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1.id2     |CB90581D |Mechanical Engineering|
| s2.id2     |CB90581D |Mechanical Engineering|
| s3.id2     |CB90581D |Mechanical Engineering|

![image](https://user-images.githubusercontent.com/92080665/169262152-406231bc-7175-4386-90e1-d06d38de6db4.png)



3. สรุปผลการทดลอง

### คำถาม ###
1. ตัวแปร instance คืออะไร

```
เป็นตัวเเปรที่จำเป็นต้องใช้งานใน Class เเละประกาศตัวเเปรใน Class เท่านั้น
```
2. ตัวแปร static คืออะไร

```
เป็นตัวเเปรเเปลที่มีค่าเป็น default เเละไม่สามารถเปลี่ยนเเปลงได้
```
3. ตัวแปรทั้งสอง ทำงานต่างกันอย่างไร

```
instance จะถูกสร้างขึ้นใหม่เมื่อมีการสร้าง Object
static จะถูกสร้างเพียงแค่ครั้งเดียวและค่าจะไม่เปลี่ยนแปลง
```
4. ตัวแปรทั้งสอง ให้ผลต่างกันอย่างไร

```
instance จำเป็นต้องสร้างใน Class เเละเรียกใช้งานได้ใน Class
static ค่าจะไม่สามารถเปลี่ยนเเปลงได้
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
![image](https://user-images.githubusercontent.com/92080665/169263969-4e34249a-0fe0-4801-a248-d77c06324fe6.png)


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
```
เกิด Error เพราะว่ากำหนดจัวเเปรเเบบ Static ทำให้ Class Program ไม่สามารถนำไปใช้งานได้
```
![image](https://user-images.githubusercontent.com/92080665/169264277-43126c85-4766-468a-8600-d1b71332006a.png)




###  คำถาม ### 
1. จงเปรียบเทียบผลที่ได้จากการรัน source code ในข้อ 1 และ ข้อ 3 ว่าเหมือนกันหรือไม่
```
ไม่เหมือนกัน
```
3. เหตุใดผลการเปรียบเทียบจึงเป็นเช่นนั้น
```
   ในข้อ 1 เป็นการประกาศตัวแปรและ method ให้เป็นแบบ static 
   ในข้อ 3 เป็นการประกาศตัวแปรและ method ให้เป็น public 
```



