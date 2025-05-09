using System;

 class Student
{
    public int RollNumber;
    public string Name;
    public int Marks;

    public void PrintDetails()
    {
        Console.WriteLine($"Rollnumber : {RollNumber}");
        Console.WriteLine($"RollNumber : {Name}");
        Console.WriteLine($"Marks : {Marks}");
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

         //Inline instantiation
         Student student2 = new Student { RollNumber = 1, Name = "Swetha", Marks = 88 };
          Student student3 = new Student { RollNumber = 2, Name = "Ayat", Marks = 90 };

         student1.PrintDetails();
         student2.PrintDetails();
         student3.PrintDetails();
    }
}