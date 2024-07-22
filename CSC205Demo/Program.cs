﻿using System;
namespace ThinkSharp
{
    // version 5
    public class Program
    {
        static void Main(string[] args)
        {
            Teacher p1 = new Teacher("Tom", 55, "Computer Science");
            Student p2 = new Student("Sara", 19, 3.5);
            p1.DisplayInfo();
            p2.DisplayInfo();

        }
    }

    abstract class Person
    { // Parent class
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayNameAge()
        { System.Console.WriteLine($"Name：{name}, Age: {age}"); }
    }
    class Teacher : Person
    { // Child class
        public string subject;
        public Teacher(string name, int age, string subject) : base(name, age)
        { this.subject = subject; }
        public void DisplayInfo()
        {
            base.DisplayNameAge();
            System.Console.WriteLine($"Teaches {subject}\n");
        }
    }
    class Student : Person
    { // Child class
        public double gpa;
        public Student(string name, int age, double gpa) : base(name, age)
        { this.gpa = gpa; }
        public void DisplayInfo()
        {
            base.DisplayNameAge();
            System.Console.WriteLine($"GPA: {this.gpa}");
        }
    }
}