# LAB 63030015 #
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
| s1       |019FD5C7 | -    |
| s2       |0392A42D | -    |
| s3       |0027C59A | -    |
| s1.id    | 3E9      | 1001     |
| s1.      | 3A8B0D8D | Computer Engineering     |
| s2.id    | 3EA      | 1002     |
| s2.      | ADC25364 | Electrical Engineering   |
| s3.id    | 3EB      | 1003     |
| s3.      | 17F78F38 | Mechanical Engineering   |

หลังจากสร้างและกำหนดค่าให้กับ instance ทั้งสามแล้ว ให้บันทึกค่าตัวแปร static ของคลาส (`    `) อีกครั้ง

|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1.kla   |17F78F38 |Mechanical Engineering|
| s2.kla   |17F78F38 |Mechanical Engineering|
| s3.kla   |17F78F38 |Mechanical Engineering|


3. สรุปผลการทดลอง

### คำถาม ###
1. ตัวแปร instance คืออะไร

```ตัวแปรชนิดหนึ่งที่ทำงานในระดับของ Class ```

2. ตัวแปร static คืออะไร

``` ประเภทตัวแปรแบบหนึ่งที่มีการใช้คำสั่ง  ```

3. ตัวแปรทั้งสอง ทำงานต่างกันอย่างไร

``` ประเภทตัวแปรแบบหนึ่งที่มีการใช้คำสั่ง  ```

4. ตัวแปรทั้งสอง ให้ผลต่างกันอย่างไร

``` Instance  จะเรียกใช้ได้ทั้งภายใน class  และภายนอก class ด้วยคำสั่ง new และถูกทำลายทิ้งเมื่อ Object ถูกทำลายลง
    Static  จะถูกสร้างขึ้นหรือใช้งานได้ทันทีภายใย class และถูกทำลายลงเมื่อโปรแกรมหยุดการทำงาน  
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

![image](https://user-images.githubusercontent.com/92082259/169584884-ffc6682e-def0-4de6-9287-c4aea5cda12e.png)

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

![image](https://user-images.githubusercontent.com/92082259/169585344-ecaddd86-b451-4a54-8211-baf486d34ab8.png)


###  คำถาม ### 
1. จงเปรียบเทียบผลที่ได้จากการรัน source code ในข้อ 1 และ ข้อ 3 ว่าเหมือนกันหรือไม่

```  ผลการทำงานหรือการรันโปรแกรมไม่หมือนกัน ```

2. เหตุใดผลการเปรียบเทียบจึงเป็นเช่นนั้น

``` 
ข้อ 1 เป็นการประกาศให้เป็น static        
ข้อ 3 เป็นการประกาศให้เป็น public
```


