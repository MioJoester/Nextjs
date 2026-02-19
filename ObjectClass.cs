using System;

class Student
{
    public string name;
    public int age;

    public void Display()
    {
        Console.WriteLine(name + " " + age);
    }
}


class Program
{
    static void Main()
    {
        
        Student s1 = new Student();
        s1.name = "Ali";
        s1.age = 20;
        s1.Display();

        
       


    }
}
