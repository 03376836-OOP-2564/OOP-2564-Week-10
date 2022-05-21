# การทดลอง Constants #

## การทดลอง 10.3 Constants ##

1. ให้นักศึกษาสร้าง project ชนิด Console application แล้วเขียน code ต่อไปนี้

``` cs
using System;
class Circle
{
    public const double PI = 3.14;
    static public void CalculateArea(double radius)
    {
        Console.WriteLine($"Area of circle = {PI * radius * radius} square unit.");
    }
    
}
class Program
{
    static void Main()
    {
        Circle.CalculateArea(radius: 10.0);
    }
}
```

2. บันทึกผลจากการรันโปรแกรม
# การทดลอง Constants #

## การทดลอง 10.3 Constants ##

1. ให้นักศึกษาสร้าง project ชนิด Console application แล้วเขียน code ต่อไปนี้

``` cs
using System;
class Circle
{
    public const double PI = 3.14;
    static public void CalculateArea(double radius)
    {
        Console.WriteLine($"Area of circle = {PI * radius * radius} square unit.");
    }
    
}
class Program
{
    static void Main()
    {
        Circle.CalculateArea(radius: 10.0);
    }
}
```

2. บันทึกผลจากการรันโปรแกรม

![image](https://user-images.githubusercontent.com/92081884/168988372-c206e282-f1d1-4e82-a63a-9b42fccd0d8c.png)

3. ค่า PI จากตัวอย่างที่แล้ว เป็นค่าโดยประมาณที่ขาดความละเอียด จึงได้กดเครื่องคิดเลข ได้ค่า PI มาเป็นทศนิยม 10 หลัก จึงนำมาใส่ในโปรแกรมแทนที่ค่า PI เดิม ก่อนหาพื้นที่

```cs
using System;
class Circle
{
    public const double PI = 3.14;
    static public void CalculateArea(double radius)
    {
        // คำนวณจากเครื่องคิดเลข ได้ค่าที่ละเอียดกว่า จึงนำมาเปลี่ยนก่อนคำนวณพื้นที่
        PI = 3.14159265359;
        Console.WriteLine($"Area of circle = {PI * radius * radius} square unit.");
    }
    
}
class Program
{
    static void Main()
    {
        Circle.CalculateArea(radius: 10.0);
    }
}

```
4. บันทึกผลจากการรันโปรแกรม
![image](https://user-images.githubusercontent.com/92082299/169665477-4a6dbb42-6d40-4d13-a439-4132433e0872.png)

5. เปรียบเทียบและอธิบายสิ่งที่ได้จากการรันโปรแกรมในข้อ 1 และ ข้อ 3
```
    เมื่อรันโปรแกรมจะได้ว่าข้อ 1 รันได้ เนื่องจากไม่ได้ทำการเปลี่ยนแปลงค่าคงที่ของตัวแปรที่ประกาศไว้ แต่ข้อ 3 รันไม่ได้ เนื่องจากได้ทำการเปลี่ยนแปลงค่าคงที่ของตัวแปรที่ประกาศไว้
```
### คำถาม ###
1. โปรแกรมในข้อ 1 และ 3 สามารถทำงานได้ตามปกติหรือไม่
```
   โปรแกรมในข้อ 1 สามารถทำงานได้ตามปกติ แต่ข้อ 3 ไม่สามารถทำงานได้
```
2. ข้อใดรันได้หรือไม่ได้
```
   โปรแกรมในข้อ 1 สามารถรันได้ตามปกติ แต่ข้อ 3 ไม่สามารถรันได้
```
3. ถ้าจะให้แก้ไขโปรแกรม ต้องแก้ที่จุดไหน อย่างไร
```
   แก้ไขตัวเลขในตอนประกาศตัวแปรให้เป็น public const double PI = 3.14159265359; หรืออาจจะแก้ไขการประกาศตัวแปรไม่ให้เป็นแบบค่าคงที่
```
