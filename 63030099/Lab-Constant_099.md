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

![image](https://user-images.githubusercontent.com/92079514/168638838-758fae35-0250-4393-9e15-6b38b3189e95.png)

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

![image](https://user-images.githubusercontent.com/92079514/168639487-93c17b57-eb8d-4594-9b20-2ccb79c8232d.png)

5. เปรียบเทียบและอธิบายสิ่งที่ได้จากการรันโปรแกรมในข้อ 1 และ ข้อ 3

 ในข้อที่1 โปปรแกรมสามารถรันได้เนื่องจากไม่ได้มีการเปลี่ยนแปลงค่าคงที่ของตัวแปรที่ได้ประกาศไว้
 ส่วนในข้อที่3 ไม่สามารถรันโปรแกรมได้เนื่องจากมีการเปลี่ยนแปลงค่าคงที่ของตัวแปรที่ได้ประกาศไว้
 
### คำถาม ###
1. โปรแกรมในข้อ 1 และ 3 สามารถทำงานได้ตามปกตือหรือไม่

 -ข้อที่1 สามารถทำงานได้
 ส่วนข้อที่3 ไม่สามารถทำงานได้
 
2. ข้อใดรันได้หรือไม่ได้

 -ข้อที่1 สามารถรันโปรแกรมได้
 ส่วนข้อที่3 ไม่สามารถรันโปรแกรมได้
 
3. ถ้าจะให้แก้ไขโปรแกรม ต้องแก้ที่จุดไหน อย่างไร

  -ไม่ทำให้ตัวแปรเป็นค่าคงที่ โดยแก้ตอนประกาศตัวแปร public const double PI = 3.14; เป็น public double PI = 3.14;
  
