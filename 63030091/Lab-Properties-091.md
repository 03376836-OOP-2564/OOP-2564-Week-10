# การทดลองเรื่อง Properties #

## การทดลอง 10.4 Read-Write properties ##

1. ให้นักศึกษาสร้าง project ชนิด Console application แล้วเขียน code ต่อไปนี้

``` cs
using System;
class Cat
{
    private float age;
    private string  color;
    public float Age 
    {
        get {return age; }
        set {age = value; } 
    }
    public string Color 
    {
        get {return color; }
        set {color = value; }
    }
}
class Program
{
    static void Main()
    {
        // Create Cat's instances named Garfield and Thomas
        Cat Garfield = new Cat();
        Cat Thomas = new Cat();
        
        // Set properties of Garfield 
        Garfield.Age = 3.2f;
        Garfield.Color = "Orange";
        Thomas.Age = 2.5f;
        Thomas.Color = "Grey";

        //Show Cats  prpoerties
        Console.WriteLine($"Garfield.Age = {Garfield.Age}");
        Console.WriteLine($"Garfield.Color = {Garfield.Color}");
        Console.WriteLine($"Thomas.Age = {Thomas.Age}");
        Console.WriteLine($"Thomas.Color = {Thomas.Color}");
    }
}

```
2. บันทึกผลจากการรันโปรแกรม

![image](https://user-images.githubusercontent.com/92081884/169007253-896ea5ed-e821-409e-bd77-15dd4c7d16e0.png)

### คำถาม ###
1. โปรแกรมนี้ทำงานได้หรือไม่ ถ้าไม่ได้ ต้องแก้ไขอย่างไร
```
   โปรแกรมนี้ทำงานได้
```
2. ทำไมเราต้องมี properties ทั้งๆ ที่มี fields อยู่แล้ว แค่ประกาศเป็น public ก็ใช้งานจากที่ไหนก็ได้
```
   เพราะ properties สามารถกำหนดการเข้าถึงได้ เช่น กำหนดให้อ่านได้อย่างเดียว กำหนดให้เขียนได้อย่างเดียว หรือกำหนดให้อ่านและเขียนได้
```

## การทดลอง 10.5 Read-only properties ##

1. ให้นักศึกษาสร้าง project ชนิด Console application แล้วเขียน code ต่อไปนี้

```cs
using System;
class Lamp
{
    private int voltage = 12;
    private string  color = "White";
    public int  Voltage
    {
        get {return voltage; }
    }
    public string Color 
    {
        get {return color; }
        set {color = value; }
    }
}
class Program
{
    static void Main()
    {
        Lamp TrafficAmberLight = new Lamp();
        Lamp TrafficRedLight = new Lamp();
        Lamp TrafficGreenLight = new Lamp();

        Console.WriteLine($"Traffic light #1 : color = {TrafficGreenLight.Color}, Voltage = {TrafficGreenLight.Voltage} V.");
        Console.WriteLine($"Traffic light #2 : color = {TrafficAmberLight.Color}, Voltage = {TrafficAmberLight.Voltage} V.");
        Console.WriteLine($"Traffic light #3 : color = {TrafficRedLight.Color}, Voltage = {TrafficRedLight.Voltage} V.");
    }
}

```

2. รันโปรแกรม บันทึกผล

![image](https://user-images.githubusercontent.com/92081884/169013284-3f023cef-26a4-4851-ba42-af3037176aa0.png)

จากโปรแกรมข้างบน จะเห็นว่าสีของไฟจราจรที่โปรแกรมรายงานออกมาจะยังไม่ตรงตามความเป็นจริง เพราะเมื่อเราไม่ทำการกำหนดค่าให้กับ field นั้นๆ โปรแกรมก็จะดึงค่า default ที่กำหนดในคลาสมาใช้

3. ให้แก้โปรแกรมเพื่อให้รายงานสีได้ถูกต้อง

```cs
using System;
class Lamp
{
    private int voltage = 12;
    private string  color = "White";
    public int  Voltage
    {
        get {return voltage; }
    }
    public string Color 
    {
        get {return color; }
        set {color = value; }
    }
}
class Program
{
    static void Main()
    {
        Lamp TrafficAmberLight = new Lamp();
        Lamp TrafficRedLight = new Lamp();
        Lamp TrafficGreenLight = new Lamp();

        // กำหนดชื่อสีให้หลอดไฟจราจร
        TrafficGreenLight.Color = "Green";
        TrafficAmberLight.Color = "Amber";
        TrafficRedLight.Color = "Red";

        Console.WriteLine($"Traffic light #1 : color = {TrafficGreenLight.Color}, Voltage = {TrafficGreenLight.Voltage} V.");
        Console.WriteLine($"Traffic light #2 : color = {TrafficAmberLight.Color}, Voltage = {TrafficAmberLight.Voltage} V.");
        Console.WriteLine($"Traffic light #3 : color = {TrafficRedLight.Color}, Voltage = {TrafficRedLight.Voltage} V.");
    }
}
```

4. รันโปรแกรม บันทึกผล

![image](https://user-images.githubusercontent.com/92081884/169013465-fbe678f4-6d8b-4e12-9739-192940f5106c.png)

จากโปรแกรมข้างบน จะเห็นว่าสีของไฟจราจรที่โปรแกรมรายงานออกมาตรงตามความเป็นจริงแล้ว แต่เราต้องการกำหนดให้หลอดไฟรับแรงดัน 220 volt จึงต้องแก้ไขที่ field ที่ชื่อ voltage (แต่ต้องทำผ่าน property ที่ชื่อ Lamp.Voltage)

5. แก้โปรแกรมเป็นดังต่อไปนี้

```cs
using System;
class Lamp
{
    private int voltage = 12;
    private string  color = "White";
    public int  Voltage
    {
        get {return voltage; }
    }
    public string Color 
    {
        get {return color; }
        set {color = value; }
    }
}
class Program
{
    static void Main()
    {
        Lamp TrafficAmberLight = new Lamp();
        Lamp TrafficRedLight = new Lamp();
        Lamp TrafficGreenLight = new Lamp();

        // กำหนดชื่อสีให้หลอดไฟจราจร
        TrafficGreenLight.Color = "Green";
        TrafficAmberLight.Color = "Amber";
        TrafficRedLight.Color = "Red";

        // กำหนดแรงดันให้หลอดไฟจราจร
        TrafficGreenLight.Voltage = 220;
        TrafficAmberLight.Voltage = 220;
        TrafficRedLight.Voltage = 220;

        Console.WriteLine($"Traffic light #1 : color = {TrafficGreenLight.Color}, Voltage = {TrafficGreenLight.Voltage} V.");
        Console.WriteLine($"Traffic light #2 : color = {TrafficAmberLight.Color}, Voltage = {TrafficAmberLight.Voltage} V.");
        Console.WriteLine($"Traffic light #3 : color = {TrafficRedLight.Color}, Voltage = {TrafficRedLight.Voltage} V.");
    }
}
```

6. รันโปรแกรม บันทึกผล

![image](https://user-images.githubusercontent.com/92081884/169012959-3f2e87ac-278f-4a8f-ae13-d1eb5d528a7e.png)

### คำถาม ###
1. โปรแกรมนี้ทำงานได้หรือไม่ ถ้าไม่ได้ เกิดจากอะไร
```
   โปรแกรมนี้ทำงานไม่ได้ เนื่องจากได้มีการกำหนด properties ให้เป็นแบบอ่านได้อย่างเดียว โดยที่ไม่สามารถแก้ไขค่าของ field ได้
```

## การทดลอง 10.6  properties ที่มีการทำงาน ##

1. ให้นักศึกษาสร้าง project ชนิด Console application แล้วเขียน code ต่อไปนี้

```cs
using System;
class Person
{
    private int age ;       // years
    const int MaxAge = 120;
    const int MinAge = 0;
    public int Age {
        get { return age; }
        set {
            if (value > MaxAge)
            {
                Console.WriteLine($"Error: maximum age  is {MaxAge} Years.");
            }
            else if (value < MinAge)
            {
                Console.WriteLine($"Error: minimum age  is {MinAge} Year.");
            }
            else
                age = value;
        } 
    }
}
class Program
{
    static void Main()
    {
        Person GrandPa = new Person();
        GrandPa.Age = 99;
        Console.WriteLine($"GrandPa.Age = {GrandPa.Age}");
        Person GrandMa = new Person();
        GrandMa.Age = 125;
        Console.WriteLine($"GrandMa.Age = {GrandMa.Age}");

        Person GrandSon = new Person();
        GrandSon.Age = 1;
        Console.WriteLine($"GrandSon.Age = {GrandSon.Age}");

    }
}

```

2. รันโปรแกรม บันทึกผล

![image](https://user-images.githubusercontent.com/92081884/169016781-678f1ba7-924d-43c7-97ab-adb978354c5a.png)

## การทดลอง 10.7  properties ที่มีการทำงานและเป็นชนิด read-only ##



แก้ไขคลาส person โดยให้มี  property ที่แสดงช่วงอายุ  (AgeGroup)

โดยสมมติให้ช่วงอายุต่างๆ มีค่าดังต่อไปนี้
|Age group name | Age range |
|:-------------:|:---------:|
|    Babies     |  0-2      |
|    Children   |  3-12     |
|    Teens      |  13-19    |
|  Young Adults |  20-30    |
|    Adults     |  31-60    |
|  Old Adults   |  61-120   |



1. แก้ไข source code ดังต่อไปนี้ โดย source code นี้ยังไม่มีความสมบูรณ์
2. ให้นักศึกษาแก้ไข/เพิ่มเติม souce code ตามคำอธิบายในบรรทัดที่มีป้ายกำกับ TODO

``` cs
using System;
class Person
{
    private int age;       // years
    const int MaxAge = 120;
    const int MinAge = 1;
    public int Age
    {
        get { return age; }
        set
        {
            if (value > MaxAge)
            {
                Console.WriteLine($"Error: maximum age  is {MaxAge} Years.");
            }
            else if (value < MinAge)
            {
                Console.WriteLine($"Error: minimum age  is {MinAge} Year.");
            }
            else
                age = value;
        }
    }
    public string AgeGroup
    {
        get
        {
            if (age > 0 && age < 3) return "Babies";
            else if (age > 2 && age < 13) return "Children";
            else if (age > 12 && age < 20) return "Teens";
            else if (age > 19 && age < 31) return "Young Adults";
            else if (age > 30 && age < 61) return "Adults";
            else if (age > 60 && age < 121) return "Old Adults";
            else return "";
        }
    }
}
class Program
{
    static void Main()
    {
        Person GrandPa = new Person();
        GrandPa.Age = 99;
        Console.WriteLine($"GrandPa.Age = {GrandPa.Age}\t ,AgeGroup = {GrandPa.AgeGroup}");
        
        Person GrandMa = new Person();
        GrandMa.Age = 125;
        //Console.WriteLine($"GrandMa.Age = {GrandMa.Age}, AgeGroup = {GrandMa.AgeGroup}");

        Person GrandSon = new Person();
        GrandSon.Age = 1;
        Console.WriteLine($"GrandSon.Age = {GrandSon.Age}\t ,AgeGroup = {GrandSon.AgeGroup}");

        Person Children = new Person();
        Children.Age = 3;
        Console.WriteLine($"GrandDaughter.Age = {Children.Age}\t ,AgeGroup = {Children.AgeGroup}");

        Person Teens = new Person();
        Teens.Age = 13;
        Console.WriteLine($"Son.Age = {Teens.Age}\t\t ,AgeGroup = {Teens.AgeGroup}");

        Person YoungAdults = new Person();
        YoungAdults.Age = 20;
        Console.WriteLine($"Daughter.Age = {YoungAdults.Age}\t ,AgeGroup = {YoungAdults.AgeGroup}");

        Person Adults = new Person();
        Adults.Age = 31;
        Console.WriteLine($"Uncle.Age = {Adults.Age}\t\t ,AgeGroup = {Adults.AgeGroup}");

        Person OldAdults = new Person();
        OldAdults.Age = 61;
        Console.WriteLine($"Aunt.Age = {OldAdults.Age}\t\t ,AgeGroup = {OldAdults.AgeGroup}");
    }
}

```
3. รันโปรแกรม โดยจะต้องมีการแสดงผลครบทุกช่วงอายุ

![image](https://user-images.githubusercontent.com/92081884/169026492-4f947a73-ab5f-4563-8afb-947d619b9c94.png)


