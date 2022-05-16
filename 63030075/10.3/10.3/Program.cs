using System;

namespace _10._3
{
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
}
