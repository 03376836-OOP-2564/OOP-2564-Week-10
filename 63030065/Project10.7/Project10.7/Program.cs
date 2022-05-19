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
            if (age >= 0 && age <= 2) return "Babies";
            else if (age >= 3 && age <= 12) return "Children";
            else if (age >= 13 && age <= 19) return "Teens";
            else if (age >= 20 && age <= 30) return "Young Adults";
            else if (age >= 31 && age <= 60) return "Adults";
            else if (age >= 61 && age <= 120) return "Old Adults";
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
        //Console.WriteLine($"GrandMa.Age = {GrandMa.Age}, AgeGroup = {GrandMa.AgeGroup}");

        Person GrandSon = new Person();
        GrandSon.Age = 1;
        Console.WriteLine($"GrandSon.Age = {GrandSon.Age}, AgeGroup = {GrandSon.AgeGroup}");

        Person Children = new Person();
        Children.Age = 3;
        Console.WriteLine($"GrandSon.Age = {Children.Age}, AgeGroup = {Children.AgeGroup}");

        Person Teen = new Person();
        Teen.Age = 16;
        Console.WriteLine($"GrandSon.Age = {Teen.Age}, AgeGroup = {Teen.AgeGroup}");

        Person Young_Adults = new Person();
        Young_Adults.Age = 23;
        Console.WriteLine($"GrandSon.Age = {Young_Adults.Age}, AgeGroup = {Young_Adults.AgeGroup}");

        Person Adults = new Person();
        Adults.Age = 33;
        Console.WriteLine($"GrandSon.Age = {Adults.Age}, AgeGroup = {Adults.AgeGroup}");

    }
}