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
        Console.WriteLine($"GrandPa.Age = {GrandPa.Age}\t ,AgeGroup = {GrandPa.AgeGroup}");
        
        Person GrandMa = new Person();
        GrandMa.Age = 125;
        //Console.WriteLine($"GrandMa.Age = {GrandMa.Age}, AgeGroup = {GrandMa.AgeGroup}");

        Person GrandSon = new Person();
        GrandSon.Age = 1;
        Console.WriteLine($"GrandSon.Age = {GrandSon.Age}\t ,AgeGroup = {GrandSon.AgeGroup}");

        Person Children = new Person();
        Children.Age = 3;
        Console.WriteLine($"GrandDaughter.Age = {Children.Age}\t ,AgeGroup = {Children.AgeGroup}");

        Person Teens = new Person();
        Teens.Age = 13;
        Console.WriteLine($"Son.Age = {Teens.Age}\t\t ,AgeGroup = {Teens.AgeGroup}");

        Person YoungAdults = new Person();
        YoungAdults.Age = 20;
        Console.WriteLine($"Daughter.Age = {YoungAdults.Age}\t ,AgeGroup = {YoungAdults.AgeGroup}");

        Person Adults = new Person();
        Adults.Age = 31;
        Console.WriteLine($"Uncle.Age = {Adults.Age}\t\t ,AgeGroup = {Adults.AgeGroup}");

        Person OldAdults = new Person();
        OldAdults.Age = 61;
        Console.WriteLine($"Aunt.Age = {OldAdults.Age}\t\t ,AgeGroup = {OldAdults.AgeGroup}");
    }
}
