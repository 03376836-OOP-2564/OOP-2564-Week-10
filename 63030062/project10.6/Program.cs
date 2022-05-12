using System;
class Person
{
    private int age;       // years
    const int MaxAge = 120;
    const int MinAge = 0;
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
            if (age >= 0 && age < 3) return "Babies";
            else if (age > 2 && age < 13) return "Children";
            else if (age > 12 && age < 20) return "Teens";
            else if (age > 19 && age < 31) return "Young Adults";
            else if (age > 30 && age < 61) return "Adults";
            else if (age > 60 && age < 121) return "Old Adults";
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
        Console.WriteLine($"GrandPa.Age = {GrandPa.Age}, AgeGroup = {GrandPa.AgeGroup}");
        Person GrandMa = new Person();
        GrandMa.Age = 125;
        Console.WriteLine($"GrandMa.Age = {GrandMa.Age}, AgeGroup = {GrandMa.AgeGroup}");

        Person GrandSon = new Person();
        GrandSon.Age = 1;
        Console.WriteLine($"GrandSon.Age = {GrandSon.Age}, AgeGroup = {GrandSon.AgeGroup}");

        Person Son = new Person();
        Son.Age = 10;
        Console.WriteLine($"Son.Age = {Son.Age}, AgeGroup = {Son.AgeGroup}");
        
        Person MiddleSon = new Person();
        MiddleSon.Age = 17;
        Console.WriteLine($"MiddleSon.Age = {MiddleSon.Age}, AgeGroup = {MiddleSon.AgeGroup}");

        Person EldestSon = new Person();
        EldestSon.Age = 25;
        Console.WriteLine($"EldestSon.Age = {EldestSon.Age}, AgeGroup = {EldestSon.AgeGroup}");

        Person Father = new Person();
        Father.Age = 50;
        Console.WriteLine($"Father.Age = {Father.Age}, AgeGroup = {Father.AgeGroup}");
    }
}
