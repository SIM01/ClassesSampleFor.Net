using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForOOP
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void Display()
        {
            Console.WriteLine($"Person = {Name}");
        }
    }
}