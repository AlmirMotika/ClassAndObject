using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObject
{
    //class
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //methods
        public Student()
        {
            Name = "StudentN";
        }
        public Student(int studentID,string name,string address)
        {
            StudentID = studentID;
            Name = name;
            Address = address;
        }
        public Student(string name,string address)
        {
            Name = name;
            Address = address;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine("StudentID:{0},Name:{1},Address:{2}", StudentID, Name, Address);
        }
    }
    public class Example
    {
        private static int Counter;

        //private constructor
        private Example()
        {
            Counter = 10;
        }
        
        //static constructor
        static Example()
        {
            Counter = 20;
        }
        //public constructor
        public Example(int counter)
        {
            Counter = Counter + counter;

        }
        public static int GetCounter()
        {
            return ++Counter;
        }
        public class NestedExample
        {
            public void Test()
            {
                //internal instance
                Example example = new Example();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //object
            //Student student = new Student();
            //student.StudentID = 1;
            //student.Name = "Name1";
            //student.Address = "Address1";

            //Student student2 = new Student();
            //Student student3 = new Student(3,"Student3","Address3");

            //Student student4 = student3;

            //Student student5 = new Student("Student5", "Address5");
            //student.ShowDetails();
            //Console.WriteLine("\n");
            //student2.ShowDetails();
            //Console.WriteLine("\n");

            //student3.ShowDetails();
            //Console.WriteLine("\n");

            //student4.ShowDetails();
            //Console.WriteLine("\n");

            //student5.ShowDetails();

            Example objExample = new Example(10);
            
            Console.WriteLine("Counter:{0}", Example.GetCounter());
            

            Console.ReadKey();
        }
    }
}
