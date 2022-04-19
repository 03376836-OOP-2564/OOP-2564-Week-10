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
        static string name;    // static member
        internal void SetId(int value)
        {
            id = value;
            ShowId();
        }
        internal void Set(string value)
        {
            name = value;
            Show();
        }

        internal void ShowId()
        {
            Console.WriteLine($"id : hashcode = [{this.id.GetHashCode():X}], value = {id}");
        }

        internal unsafe void Show()
        {
            Console.WriteLine($"name : hashcode = [{name.GetHashCode():X}], value = {name}");
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

![image](https://user-images.githubusercontent.com/50146617/163880888-6d569351-9ebf-4850-9e01-1f5e688d270f.png)

2. เติมค่าลงในตารางต่อไปนี้ให้ครบถ้วน


|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1       |02BF8098| -    |
| s2       |00BB8560| -    |
| s3       |0297B065| -    |
| s1.id    |3E9|1001|
| s1.name |A7CDCB0E|Computer Engineering|
| s2.id    |3EA|1002|
| s2.name |7E45508C|Electrical Engineering|
| s3.id    |3EB|1003|
| s3.name |16EC5983|Mechanical Engineering|

หลังจากสร้างและกำหนดค่าให้กับ instance ทั้งสามแล้ว ให้บันทึกค่าตัวแปร static ของคลาส (`name`) อีกครั้ง

|   วัตถุ    | hashcode| value|
|----------|---------|------|
| s1.name |16EC5983|Mechanical Engineering|
| s2.name |16EC5983|Mechanical Engineering|
| s3.name |16EC5983|Mechanical Engineering|


3. สรุปผลการทดลอง

### คำถาม ###
1. ตัวแปร instance คืออะไร<br>
`เป็นตัวแปรที่จะประกาศอยู่ใน Class และจะไม่อยู่นอก Method, Constructor สามารถเข้าถึงโดยตรงจากการเรียกใช้งานใน Class หรือนอก Class โดยผ่านการเรียกใช้ Interface Public Method`
2. ตัวแปร static คืออะไร<br>
`เป็นตัวแปรแบบค่าคงที่ (static) ทุกครั้งที่มีการเรียกใช้งานตัวแปรแบบค่าคงที่ จะมีการดึง memory มาใช้ และการเรียกใช้ครั้งต่อไปจะใช้ค่าเดิม จะไม่มีการเรียกใช้งาน memory หรือเรียกง่ายๆว่า เป็นตัวแปรที่เอาไว้ใช้เก็บค่าแบบคงที่`
3. ตัวแปรทั้งสอง ทำงานต่างกันอย่างไร<br>
`ตัวแปรแบบ instance จะถูกสร้างขึ้นมาเมื่อมีการสร้าง Object `<br>
`ตัวแปรแบบ static จะใช้กับ Class เท่านั้น ซึ่ง Class จะสามารถมีได้แค่ Class เดียว`
4. ตัวแปรทั้งสอง ให้ผลต่างกันอย่างไร<br>
`instance เป็นตัวแปรที่สามารถเข้าถึงได้โดยการสร้าง Object ของ Class`<br>
`static เป็นตัวแปรที่ค่าคงทีแบบตายตัว เป็นค่าที่คงที่ไม่เปลี่ยนแปลง`

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
![image](https://user-images.githubusercontent.com/50146617/163874779-fc8e2d95-956d-4f83-bf5e-7b9668fb3d54.png)
3. แก้ไข code ให้เป็นดังต่อไปนี้

```cs
using System;
class Student
{
	public int id;
	public void PrintID()
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
![image](https://user-images.githubusercontent.com/50146617/163878570-4d3b8a67-f3b8-4b7f-af36-6905e0bedacd.png)
###  คำถาม ### 
1. จงเปรียบเทียบผลที่ได้จากการรัน source code ในข้อ 1 และ ข้อ 3 ว่าเหมือนกันหรือไม่<br>
`ผลที่ได้จากการรันโปรแกรมไม่ต่างกัน ต่างกันแค่การกำหนดค่า และการสร้าง instance ของ Student ในข้อ 3`
2. เหตุใดผลการเปรียบเทียบจึงเป็นเช่นนั้น<br>
`ข้อ 1 เป็น Method แบบ Statid`<br>
`ข้อ 2 เป็น method แบบ Instance`



