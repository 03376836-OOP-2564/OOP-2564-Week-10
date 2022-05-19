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

