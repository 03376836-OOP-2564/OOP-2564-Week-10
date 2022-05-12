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

![Instance](./im/Instance.png)

2. เติมค่าลงในตารางต่อไปนี้ให้ครบถ้วน


|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1       |0378734A         | -    |
| s2       |011C7A8C         | -    |
| s3       |02004EEE         | -    |
| s1.id    |3E9         |1001      |
| s1.     |DED2C10F         |Computer Engineering      |
| s2.id    |3EA         |	1002      |
| s2.     |745E53C2         |Electrical Engineering      |
| s3.id    |3EB         |1003      |
| s3.     |DFA1D7C5         |Mechanical Engineering      |

หลังจากสร้างและกำหนดค่าให้กับ instance ทั้งสามแล้ว ให้บันทึกค่าตัวแปร static ของคลาส (`    `) อีกครั้ง

|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1.     |DFA1D7C5          |Mechanical Engineering      |
| s2.     |DFA1D7C5          |Mechanical Engineering      |
| s3.     |DFA1D7C5          |Mechanical Engineering      |


3. สรุปผลการทดลอง

### คำถาม ###
1. ตัวแปร instance คืออะไร

```
    ตัวแปรชนิดหนึ่งทำงานใน Class และจะไม่อยู่นอก Method, Constructor กระบวนการทำงานนั้นจะเกิดพร้อมกับการทำงานของ Class 
```

2. ตัวแปร static คืออะไร

```
    ประเภทตัวแปรแบบหนึ่งที่มีการใช้คำสั่ง (Keyword) ว่า static วางไว้ข้างหน้าตัวแปร เพื่อประกาศให้โปรแกรมรู้ว่า ตัวแปรนี้เป็นตัวแปรแบบ static ของ class โดยเป็นตัวแปรแบบค่าคงที่
```

3. ตัวแปรทั้งสอง ทำงานต่างกันอย่างไร

```
    ตัวแปรแบบ instance จะถูกสร้างขึ้นมาเมื่อมีการสร้าง Object
    ตัวแปรแบบ static จะถูกสร้างเพียงแค่ครั้งเดียวและค่าจะไม่เปลี่ยนแปลง
```

4. ตัวแปรทั้งสอง ให้ผลต่างกันอย่างไร

```
    ตัวแปรแบบ instance เป็นตัวแปรที่สามารถเข้าถึงได้โดยการสร้าง Object ของ Class
    ตัวแปรแบบ static เป็นตัวแปรที่ค่าคงทีแบบตายตัว เป็นค่าที่คงที่ไม่เปลี่ยนแปลง
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

![Student](./im/Student.png)

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

![error1](./im/error1.png)

###  คำถาม ### 
1. จงเปรียบเทียบผลที่ได้จากการรัน source code ในข้อ 1 และ ข้อ 3 ว่าเหมือนกันหรือไม่

```
    ผลที่ได้จากการรันโปรแกรมแตกต่างกัน
```
2. เหตุใดผลการเปรียบเทียบจึงเป็นเช่นนั้น

```
    ข้อ 1 เป็น Method แบบ Statid
    ข้อ 2 เป็น method แบบ Instance
```



