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
![image](https://user-images.githubusercontent.com/92080665/169266449-0220ee68-6bdd-4e65-9e5a-a18158fe6080.png)



### คำถาม ###
1. โปรแกรมนี้ทำงานได้หรือไม่ ถ้าไม่ได้ ต้องแก้ไขอย่างไร
```
โปรเเกรมสามารถทำงานได้
```
3. ทำไมเราต้องมี properties ทั้งๆ ที่มี fields อยู่แล้ว แค่ประกาศเป็น public ก็ใช้งานจากที่ไหนก็ได้
```
เพราะการกำหนด properties ต่าง ๆ สามารถกำหนดได้ว่าจะสามารถทำให้อ่านได้อย่างเดียว เขียนอย่างเดียว หรือทั้งเขียนและอ่านได้

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
![image](https://user-images.githubusercontent.com/92080665/169267608-58f20431-05d7-4fbb-8368-c258c2f11e6f.png)



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
![image](https://user-images.githubusercontent.com/92080665/169267725-77ec1620-ec0b-49ad-ad9a-c900f651c951.png)



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
![image](https://user-images.githubusercontent.com/92080665/169267824-027f76b5-2955-4737-af72-bb7cd7053ad7.png)



### คำถาม ###
1. โปรแกรมนี้ทำงานได้หรือไม่ ถ้าไม่ได้ เกิดจากอะไร
```
ทำงานไม่ได้เพราะ การกำหนด Property ให้อ่านได้เท่านั้นทำให้ไม่สามารถปรับเเละเเก้ไขได้
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
![image](https://user-images.githubusercontent.com/92080665/169268095-ee544e07-4652-418e-8eb7-051d8fd3f2a8.png)




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
    private int age ;       // years
    const int MaxAge = 120;
    const int MinAge = 1;
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
    public string AgeGroup 
    {
        get 
        {
            if (age > 0 && age < 3) return "Babies";
            // else if (age > 3 && age < 13) return "Children";
            // TODO: เพิ่ม if else (....) return "..." ให้ครบทุกช่วงอายุ
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
        Console.WriteLine($"GrandPa.Age = {GrandPa.Age}");
        Person GrandMa = new Person();
        GrandMa.Age = 125;
        Console.WriteLine($"GrandMa.Age = {GrandMa.Age}");

        Person GrandSon = new Person();
        GrandSon.Age = 1;
        Console.WriteLine($"GrandSon.Age = {GrandSon.Age}, AgeGroup = {GrandSon.AgeGroup}");

        // TODO: ทดสอบการแสดงผลให้ครบทุกช่วงอายุ

    }
}

```
3. รันโปรแกรม โดยจะต้องมีการแสดงผลครบทุกช่วงอายุ

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
            if (age >= 0 && age <= 2) return "Babies";
            else if (age >= 3 && age <= 12) return "Children";
            else if (age >= 13 && age <= 19) return "Teens";
            else if (age >= 20 && age <= 30) return "Young Adults";
            else if (age >= 31 && age <= 60) return "Adults";
            else if (age >= 61 && age <= 120) return "Old Adults";
            else return "";
        }
    }
}
class Program
{
    static void Main()
    {
        Person GrandPa = new Person();
        GrandPa.Age = 120;
        Console.WriteLine($"GrandPa.Age = {GrandPa.Age}, AgeGroup = {GrandPa.AgeGroup}");
        Person GrandMa = new Person();
        GrandMa.Age = 125;
        //Console.WriteLine($"GrandMa.Age = {GrandMa.Age}, AgeGroup = {GrandMa.AgeGroup}");

        Person GrandSon = new Person();
        GrandSon.Age = 1;
        Console.WriteLine($"GrandSon.Age = {GrandSon.Age}, AgeGroup = {GrandSon.AgeGroup}");

        Person Children = new Person();
        Children.Age = 3;
        Console.WriteLine($"GrandSon.Age = {Children.Age}, AgeGroup = {Children.AgeGroup}");

        Person Teen = new Person();
        Teen.Age = 15;
        Console.WriteLine($"GrandSon.Age = {Teen.Age}, AgeGroup = {Teen.AgeGroup}");

        Person Young_Adults = new Person();
        Young_Adults.Age = 26;
        Console.WriteLine($"GrandSon.Age = {Young_Adults.Age}, AgeGroup = {Young_Adults.AgeGroup}");

        Person Adults = new Person();
        Adults.Age = 59;
        Console.WriteLine($"GrandSon.Age = {Adults.Age}, AgeGroup = {Adults.AgeGroup}");

    }
}
```
![image](https://user-images.githubusercontent.com/92080665/169268614-3df3642e-c80b-4040-a31f-f1579d3108c1.png)


