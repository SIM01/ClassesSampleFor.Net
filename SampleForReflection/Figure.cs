using System;

namespace SampleForReflection
{
    public class Figure
    {
        public string Name { get; set; }
        public int SideCount { get; set; }
        public double SideLength { get; set; }

        public void Display(string name)
        {
            Console.WriteLine($"{name}");
        }
    }
}