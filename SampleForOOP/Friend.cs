using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleForOOP
{
    public class Friend : Person
    {
        public override void Display()
        {
            Console.WriteLine($"Friend name = {Name}");
        }
    }
}