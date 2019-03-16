using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpFundamentals
{
        
    class Program
    {   
        static void Main(string[] args)
        {
            Person test = new Person();

            Person chloe = new Person("Chloe", 21);
            chloe.Speak();
            Console.ReadLine();

        }
    }

    class Person
    {
        public string Name;
        public int Age;

        public Person()
        {
            Console.WriteLine("twats");
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Speak()
        {
            Console.WriteLine("my name is " + Name + " and my age is " + Age);
        }
    }
}
