using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForOOP
{
    public class Colleague : Person
    {
        public override void Display()
        {
            Console.WriteLine($"Collegue name = {Name}");
        }
    }
}