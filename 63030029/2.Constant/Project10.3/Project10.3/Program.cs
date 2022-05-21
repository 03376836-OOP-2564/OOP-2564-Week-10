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