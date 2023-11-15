using System;
using System.Text;

namespace Array 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // On a computer, Arrays can hold up to N items.
            // The value of N is decided by you, the programmer, at the time you create the Array.

            // integers array
            int[] numbers = new int[10];

            // string array
            string[] names = new string[7];

            // custom class array
            Student[] students = new Student[5];

            // DVD
            DVD[] dvdCollection = new DVD[15];
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
