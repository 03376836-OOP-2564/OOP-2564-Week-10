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

![image](https://user-images.githubusercontent.com/92078775/168031518-8c960ece-92b8-4b19-807f-0fd3a38ac41f.png)

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
![image](https://user-images.githubusercontent.com/92078775/168031870-5d2fe247-376d-4141-846e-9a6cad2518af.png)

5. เปรียบเทียบและอธิบายสิ่งที่ได้จากการรันโปรแกรมในข้อ 1 และ ข้อ 3
```
 ข้อที่1 ประกาศตัวเเปรเเบบ static ซึ่งมีค่าคงที่
 ข้อที่3 ค่า static ไม่สามารถปรับค่าได้ใหม่ทำให้โปรเเกรม Error
```
### คำถาม ###
1. โปรแกรมในข้อ 1 และ 3 สามารถทำงานได้ตามปกตือหรือไม่
```
โปรเเกรมที่ 1 สามารถทำงานได้
โปรเเกรมที่ 3 ไม่สามารถทำงานได้
```
2. ข้อใดรันได้หรือไม่ได้
```
โปรเเกรมที่ 1 สามารถทำงานได้
โปรเเกรมที่ 3 ไม่สามารถทำงานได้
```
3. ถ้าจะให้แก้ไขโปรแกรม ต้องแก้ที่จุดไหน อย่างไร
```
ต้องไม่กำหนดตัวเเปรเเบบ Static เพราะว่ากำหนดค่า Pi เเบบ Static ไว้เเล้วมากำหนดอีกที่ class หนึ่งเลย Error
```
