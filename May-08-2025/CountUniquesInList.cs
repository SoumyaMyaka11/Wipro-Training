using System;
class student
{
    public int Rollnumber;
    public string Name;
    public int Marks;

    public void PrintDetails()
    {
        Console.WriteLine($"Rollnumber : {RollNumber}");
        Console.WriteLine($"RollNumber : {Name}");
        Console.WriteLine($"Marks : {Marks}";)
    }
}

class Program
{
    static void Main()
    {
        //instantiation
        Student student1 = new Student();

        student1.RollNumber = 1;
        student1.Name = "Swetha";
        student1.Marks = 88;

        student1.PrintDetails();

    }
}