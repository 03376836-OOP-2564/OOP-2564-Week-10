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
![image](https://user-images.githubusercontent.com/88755456/169652673-9ea381b4-f576-4263-96d3-ed211df992cd.png)

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
![image](https://user-images.githubusercontent.com/88755456/169652732-ac87184a-fc54-4aab-867a-277fe784e055.png)

5. เปรียบเทียบและอธิบายสิ่งที่ได้จากการรันโปรแกรมในข้อ 1 และ ข้อ 3
`ข้อ 1 สามารถรันโปรแกรมได้ปกติ เพราะประกาศตัวแปรแบบ ค่าคงที่ และไม่ได้มีการเปลี่ยนแปลงค่าหลังจากที่สร้าง และกำหนดค่าขึ้นมา`<br>
`ข้อ 3 ไม่สามารถรันโปรแกรมได้ เพราะเนื่องจากเป็นการประกาศตัวแปรแบบค่าคงที่ การประกาศตัวแปรแบบค่าคงที่ จะไม่สามารถเปลี่ยนแปลงค่าได้ หลังจากถูกกำหนดค่าแล้ว

### คำถาม ###
1. โปรแกรมในข้อ 1 และ 3 สามารถทำงานได้ตามปกติหรือไม่<br>
`โปรแกรมในข้อ 1 สามารภทำงานได้ปกติ`<br>
`โปรแกรมในข้อ 3 ไม่สามารภทำงานได้`
2. ข้อใดรันได้หรือไม่ได้<br>
`โปรแกรมในข้อ 1 สามารภรันโปรแกรมได้ปกติ`<br>
`โปรแกรมในข้อ 3 ไม่สามารถรันโปรแกรมได้`
3. ถ้าจะให้แก้ไขโปรแกรม ต้องแก้ที่จุดไหน อย่างไร<br>
`หากอยากได้ ค่าที่ละเอียดกว่าจะต้องนำค่าไป กำหนดในตัวแปรตั้งแต่แรก เช่น public const double PI = 3.14159265359`<br>
`หรือ ไม่ใช้ตัวแปรแบบค่าคงที่ ก็จะสามารถเปลี่ยนแปลงค่าได้เช่นกัน`
