using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        public int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static Complex operator +(Complex first, Complex second)
        {
            Complex third = new Complex(first.a + second.a, first.b + second.b);
            return third;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

    }

    class Program
    {
        static void Main(string[] argc)
        {
            Console.WriteLine(new Complex(1, 3) + new Complex(1, 4));
            Console.ReadKey();
        }
    }
    class Student
    {
        public string Name, Surname;
        public double gpa;
        public Student(string Name, string Surname, double gpa)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.gpa = gpa;
        }
     
         public override string ToString()
        {
            
            return this.Name + " " + Surname + " " + gpa;
        }
    }
}
    
 