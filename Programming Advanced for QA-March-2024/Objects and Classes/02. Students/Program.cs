using System;
using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

    public Student(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] studentInfo = input.Split();
            string firstName = studentInfo[0];
            string lastName = studentInfo[1];
            int age = int.Parse(studentInfo[2]);
            string homeTown = studentInfo[3];

            Student student = new Student(firstName, lastName, age, homeTown);
            students.Add(student);
        }

        string city = Console.ReadLine();

        foreach (Student student in students)
        {
            if (student.HomeTown == city)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
