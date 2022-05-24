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

![image](https://user-images.githubusercontent.com/92082350/168639043-edde7428-d6dc-4721-9ec2-8c9107528fff.png)

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
![image](https://user-images.githubusercontent.com/92082350/168639632-b9df9ef3-d02d-4ecf-9347-4cd1ac9d9e6d.png)


5. เปรียบเทียบและอธิบายสิ่งที่ได้จากการรันโปรแกรมในข้อ 1 และ ข้อ 3

  สามารถรันได้พราะไม่ได้มีการเปลี่ยนแปลงค่าคงที่ของตัวแปรที่ได้ประกาศไว้
  ไม่สามารถรันได้เพราะมีการเปลี่ยนแปลงค่าคงที่ของตัวแปรที่ได้ประกาศไว้
  
### คำถาม ###
1. โปรแกรมในข้อ 1 และ 3 สามารถทำงานได้ตามปกตือหรือไม่
 ข้อที่ 1 ทำงานได้ปกติ
 ข้อที่ 3 ทำงานไม่ได้
2. ข้อใดรันได้หรือไม่ได้
  ข้อที่ 1 ทำงานได้ปกติ
  ข้อที่ 3 ทำงานไม่ได้
3. ถ้าจะให้แก้ไขโปรแกรม ต้องแก้ที่จุดไหน อย่างไร
 โดยแก้ตอนประกาศตัวแปร public const double PI = 3.14; เป็น public double PI = 3.14; 
