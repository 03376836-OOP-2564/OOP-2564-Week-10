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

![image](https://user-images.githubusercontent.com/92081694/168818842-c847a761-d799-4f8a-97c1-9fd30d0ce7cb.png)
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
![image](https://user-images.githubusercontent.com/92081694/168819049-0d89f2e7-229b-4a92-a038-119c49e8e9f7.png)

5. เปรียบเทียบและอธิบายสิ่งที่ได้จากการรันโปรแกรมในข้อ 1 และ ข้อ 3
 ```
  ข้อ1 การประกาศตัวเเปรเเบบ static ซึ่งมีค่าคงที่ของตัวเเปร
  ข้อ3 ค่า0static ไม่สามารถปรับค่าได้ใหม่ทำให้รันโปรเเกรมไม่ได้
 ```
### คำถาม ###
1. โปรแกรมในข้อ 1 และ 3 สามารถทำงานได้ตามปกตือหรือไม่
```
 ข้อที่1 สามารถทำงานได้ปกติ
 ข้อที่3 ไม่สามารถทำงานได้
```
2. ข้อใดรันได้หรือไม่ได้
```
 ข้อที่1 สามารถทำงานได้ปกติ
 ข้อที่3 ไม่สามารถทำงานได้
```
3. ถ้าจะให้แก้ไขโปรแกรม ต้องแก้ที่จุดไหน อย่างไร
```
ต้องไม่กำหนดค่าตัวเเปรเเบบ Static
```
